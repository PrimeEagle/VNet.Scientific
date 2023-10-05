// ReSharper disable SuggestBaseTypeForParameter
namespace VNet.Scientific.Noise
{
    public abstract class NoiseBase : INoiseAlgorithm
    {
        protected readonly INoiseAlgorithmArgs Args;

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

            GenerateRecursive(samples, Args.Dimensions, 0, Array.Empty<int>());

            return samples;
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
            for (var i = 0; i < samples.Length; i++)
            {
                samples[i] = PostProcess(samples[i]);
            }

            return samples;
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
            var quantizationLevel = (int)(sample * Args.QuantizeLevels);
            sample = (double)quantizationLevel / Args.QuantizeLevels;

            // scale
            sample *= Args.Scale;

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
    }
}