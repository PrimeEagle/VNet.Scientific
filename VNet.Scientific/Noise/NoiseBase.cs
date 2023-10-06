// ReSharper disable SuggestBaseTypeForParameter
// ReSharper disable MemberCanBePrivate.Global
// ReSharper disable MemberCanBeMadeStatic.Global

using VNet.Mathematics.Randomization.Distribution;

#pragma warning disable CA1822
namespace VNet.Scientific.Noise
{
    public abstract class NoiseBase : INoiseAlgorithm
    {
        protected readonly INoiseAlgorithmArgs Args;

        protected double EstimatedMinValue { get; set; } = double.MaxValue;
        protected double EstimatedMaxValue { get; set; } = double.MinValue;


        protected NoiseBase(INoiseAlgorithmArgs args)
        {
            Args = args;
        }

        public abstract double GenerateSingleSampleRaw();

        public virtual double GenerateSingleSample()
        {
            var sample = GenerateSingleSampleRaw();
            return sample;
        }

        public virtual double[] GenerateRaw()
        {
            var totalSize = Args.Dimensions.Aggregate(1, (acc, val) => acc * val);
            var samples = new double[totalSize];

            var indices = new int[Args.Dimensions.Length];
            for (var flatIndex = 0; flatIndex < totalSize; flatIndex++)
            {
                samples[flatIndex] = GenerateSingleSampleRaw();
                IncrementIndices(indices, Args.Dimensions);
            }

            return samples;
        }

        protected void IncrementIndices(int[] indices, int[] dimensions)
        {
            for (var i = indices.Length - 1; i >= 0; i--)
            {
                if (indices[i] < dimensions[i] - 1)
                {
                    indices[i]++;
                    break;
                }
                else
                {
                    indices[i] = 0; // Reset and carry over
                }
            }
        }


        private void GenerateRecursive(double[] samples, int[] dimensions, int depth, int[] indices)
        {
            if (depth == dimensions.Length)
            {
                var index = GetFlatIndex(indices, dimensions);
                samples[index] = GenerateSingleSampleRaw();
                return;
            }

            for (var i = 0; i < dimensions[depth]; i++)
            {
                GenerateRecursive(samples, dimensions, depth + 1, indices.Concat(new int[] { i }).ToArray());
            }
        }

        public virtual double[] Generate()
        {
            var samples = GenerateRaw();
            var shouldNormalize = Args.NormalizeOutput;

            if (shouldNormalize) EstimateNoiseRange(samples); // Estimate before any post-processing

            for (var i = 0; i < samples.Length; i++)
            {
                samples[i] = PostProcess(samples[i]);
                if (shouldNormalize)
                {
                    samples[i] = NormalizeToRange(samples[i], EstimatedMinValue, EstimatedMaxValue);
                }
            }

            return samples;
        }

        protected void EstimateNoiseRange(double[] samples)
        {
            EstimatedMinValue = samples.Min();
            EstimatedMaxValue = samples.Max();
        }

        private double PostProcess(double sample)
        {
            // filter
            if (Args.OutputFilter is not null && Args.OutputFilter.IsValid())
            {
                var filteredSamples = Args.OutputFilter.Filter(new double[] { sample });
                if (filteredSamples.Length > 0)
                {
                    sample = filteredSamples[0];
                }
            }

            // quantize
            if (Args.QuantizeLevel != 1)
            {
                if (Args.QuantizeLevel == 0) throw new ArgumentException("QuantizeLevels cannot be zero.");
                var quantizationLevel = (int)(sample * Args.QuantizeLevel);
                sample = (double)quantizationLevel / Args.QuantizeLevel;
            }

            // scale
            if (Math.Abs(Args.Scale - 1.0d) > double.Epsilon)
            {
                sample *= Args.Scale;
            }

            // normalize
            if (Args.NormalizeOutput)
            {
                sample = NormalizeToRange(sample, EstimatedMinValue, EstimatedMaxValue);
            }

            return sample;
        }

        protected int GetFlatIndex(int[] indices, int[] dimensions)
        {
            var index = 0;
            var multiplier = 1;

            for (var i = indices.Length - 1; i >= 0; i--)
            {
                index += indices[i] * multiplier;
                multiplier *= dimensions[i];
            }

            return index;
        }

        protected int[] GetMultiDimensionalIndices(int flatIndex, int[] dimensions)
        {
            var indices = new int[dimensions.Length];
            for (var i = 0; i < dimensions.Length; i++)
            {
                indices[i] = flatIndex % dimensions[i];
                flatIndex /= dimensions[i];
            }
            return indices;
        }

        protected double NormalizeToRange(double value, double min, double max)
        {
            // Normalize to 0-1 first
            var normalized = (value - min) / (max - min);
            // Then map to DesiredMinValue to DesiredMaxValue
            return Args.DesiredMinValue + normalized * (Args.DesiredMaxValue - Args.DesiredMinValue);
        }

        protected double GetRandomValue()
        {
            return Args.RandomDistributionAlgorithm.NextDouble();
        }
    }
}