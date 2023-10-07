// ReSharper disable UnusedMember.Global

// ReSharper disable MemberCanBeMadeStatic.Local
// ReSharper disable SuggestBaseTypeForParameter
#pragma warning disable CA1822
namespace VNet.Scientific.Noise.Other;
// Value noise is a type of noise commonly used in procedural texture generation, such as for terrain generation in computer graphics.
// It's created by interpolating random values on a grid. Creating value noise typically requires a grid of random values and an interpolation
// method.The interpolation can be linear, cosine, cubic, or another method depending on the desired smoothness.
public class ValueNoise : NoiseBase
{
    private double[] _grid;

    public ValueNoise(INoiseAlgorithmArgs args) : base(args) { }

    public override double[] GenerateRaw()
    {
        var totalSize = Args.Dimensions.Aggregate(1, (acc, val) => acc * val);
        _grid = new double[totalSize];

        // Fill the grid with random values.
        for (var i = 0; i < totalSize; i++)
        {
            _grid[i] = GetRandomValue();
        }

        var result = new double[totalSize];
        var indices = new int[Args.Dimensions.Length];

        for (var flatIndex = 0; flatIndex < totalSize; flatIndex++)
        {
            var fractions = indices.Select((idx, dim) => idx / (double)Args.Dimensions[dim]).ToArray();
            result[flatIndex] = InterpolateMultiDimensional(fractions, Args.Dimensions);
            IncrementIndices(indices, Args.Dimensions);
        }

        return result;
    }

    private double InterpolateMultiDimensional(double[] fractions, int[] dimensions)
    {
        if (fractions.Length == 1)
        {
            var leftIndex = (int)(fractions[0] * dimensions[0]);
            var rightIndex = Math.Min(leftIndex + 1, dimensions[0] - 1);

            return Interpolate(_grid[leftIndex], _grid[rightIndex], fractions[0] * dimensions[0] % 1);
        }

        var lowerFractions = fractions.Skip(1).ToArray();
        var lowerDimensions = dimensions.Skip(1).ToArray();

        InterpolateMultiDimensional(lowerFractions, lowerDimensions);

        var leftIndices = new int[dimensions.Length];
        leftIndices[0] = (int)(fractions[0] * dimensions[0]);
        for (var i = 1; i < dimensions.Length; i++)
        {
            leftIndices[i] = (int)(fractions[i] * dimensions[i]);
        }

        var rightIndices = leftIndices.ToArray();
        rightIndices[0] = Math.Min(rightIndices[0] + 1, dimensions[0] - 1);

        return Interpolate(
            _grid[GetFlatIndex(leftIndices, dimensions)],
            _grid[GetFlatIndex(rightIndices, dimensions)],
            fractions[0] * dimensions[0] % 1);
    }

    private double Interpolate(double a, double b, double fraction)
    {
        return a * (1 - fraction) + b * fraction;
    }

    public override double GenerateSingleSampleRaw()
    {
        throw new NotImplementedException("GenerateSingleSampleRaw method doesn't really make sense for value noise, since each value is dependent on its neighbors in the grid.");
    }
}