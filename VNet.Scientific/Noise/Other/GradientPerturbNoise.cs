// ReSharper disable UnusedMember.Global

// ReSharper disable ParameterTypeCanBeEnumerable.Local
// ReSharper disable SuggestBaseTypeForParameter
// ReSharper disable MemberCanBeMadeStatic.Local
// ReSharper disable SuggestBaseTypeForParameterInConstructor
#pragma warning disable CA1822
namespace VNet.Scientific.Noise.Other;
// Gradient perturb noise is a type of noise where the coordinates of each point are slightly altered (or "perturbed") using another noise function
// before being input into the main noise function. This has the effect of distorting the output in an interesting way.
public class GradientPerturbNoise : NoiseBase
{
    private readonly INoiseAlgorithm _perturbNoise; // Added this line

    public GradientPerturbNoise(IGradientPerturbNoiseAlgorithmArgs args)
        : base(args)
    {
        _perturbNoise = args.BaseNoise; // Initialize _perturbNoise
    }

    public override double[] GenerateRaw()
    {
        var dimensions = Args.Dimensions;

        var result = new double[GetTotalSize(dimensions)];
        var frequency = ((IGradientPerturbNoiseAlgorithmArgs)Args).Frequency;
        var amplitude = ((IGradientPerturbNoiseAlgorithmArgs)Args).Amplitude;
        var baseNoise = ((IGradientPerturbNoiseAlgorithmArgs)Args).BaseNoise;

        for (var i = 0; i < GetTotalSize(dimensions); i++)
        {
            var indices = ConvertIndexToNDimensional(i, dimensions);
            var perturbedValue = _perturbNoise.GenerateSingleSampleRaw();
            indices = indices.Select(index => (int)Math.Max(0, Math.Min(dimensions[Array.IndexOf(indices, index)] - 1, index + amplitude * perturbedValue))).ToArray();

            result[i] = baseNoise.GenerateSingleSampleRaw();
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