// ReSharper disable UnusedMember.Global

// ReSharper disable ParameterTypeCanBeEnumerable.Local
// ReSharper disable SuggestBaseTypeForParameter
// ReSharper disable MemberCanBeMadeStatic.Local
#pragma warning disable CA1822
namespace VNet.Scientific.Noise.Other;
// Gradient perturb noise is a type of noise where the coordinates of each point are slightly altered (or "perturbed") using another noise function
// before being input into the main noise function. This has the effect of distorting the output in an interesting way.
public class GradientPerturbNoise : NoiseBase
{
    private SimplexNoise _perturbNoise; // Note: SimplexNoise will need to be refactored to handle n-dimensions.
    private INoiseAlgorithm _baseNoise;

    private double _frequency;
    private double _amplitude;

    public GradientPerturbNoise(IGradientPerturbNoiseAlgorithmArgs args) : base(args)
    {
        _perturbNoise = new SimplexNoise();
        _baseNoise = args.BaseNoise;
        _frequency = args.Frequency;
        _amplitude = args.Amplitude;
    }

    public override double[] GenerateRaw()
    {
        var dimensions = Args.Dimensions;

        var result = new double[GetTotalSize(dimensions)];

        for (var i = 0; i < GetTotalSize(dimensions); i++)
        {
            var indices = ConvertIndexToNDimensional(i, dimensions);
            double perturbedValue = _perturbNoise.Noise(indices.Select(index => index * _frequency).ToArray()); // This assumes that SimplexNoise is n-dimensional.
            indices = indices.Select(index => (int)Math.Max(0, Math.Min(dimensions[Array.IndexOf(indices, index)] - 1, index + _amplitude * perturbedValue))).ToArray();

            // Use base noise's raw generation method
            if (_baseNoise is NoiseBase noiseBase)
            {
                result[i] = noiseBase.GenerateRawSample(indices);
            }
            else
            {
                // You'd need to refactor this section further to support n-dimensional input for GenerateSingleSample.
                // For now, this throws an exception.
                throw new NotImplementedException();
            }
        }

        return result;
    }

    private int GetTotalSize(int[] dimensions)
    {
        return dimensions.Aggregate(1, (a, b) => a * b);
    }

    private int[] ConvertIndexToNDimensional(int index, int[] dimensions)
    {
        var indices = new int[dimensions.Length];
        for (var i = 0; i < dimensions.Length; i++)
        {
            indices[i] = index % dimensions[i];
            index /= dimensions[i];
        }
        return indices;
    }

    public override double GenerateSingleSampleRaw()
    {
        throw new NotImplementedException("GradientPerturb noise is generated for the entire grid, so generating a single sample is not applicable.");
    }
}