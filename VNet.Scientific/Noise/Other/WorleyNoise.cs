// ReSharper disable UnusedMember.Global

// ReSharper disable SuggestBaseTypeForParameterInConstructor
namespace VNet.Scientific.Noise.Other;
// In addition to the standard Worley noise algorithm, there are several variants that modify the behavior or properties of cellular noise.
// Examples include Voronoi-based noise with distance metrics like Manhattan or Chebyshev distance, or variations that introduce perturbations
// or modifications to the cell shapes.
public class WorleyNoise : NoiseBase
{
    public WorleyNoise(IWorleyNoiseAlgorithmArgs args) : base(args)
    {
    }

    public override double[] GenerateRaw()
    {
        var totalSize = Args.Dimensions.Aggregate(1, (acc, val) => acc * val);
        var result = new double[totalSize];

        var indices = new int[Args.Dimensions.Length];

        for (var flatIndex = 0; flatIndex < totalSize; flatIndex++)
        {
            var minDistance = double.MaxValue;

            for (var k = 0; k < ((IWorleyNoiseAlgorithmArgs)Args).PointCount; k++)
            {
                double distanceSquared = Args.Dimensions.Select(t => Args.RandomDistributionAlgorithm.NextDouble() * t).Select((randomPoint, dim) => Math.Pow(randomPoint - indices[dim], 2)).Sum();

                var distance = Math.Sqrt(distanceSquared);
                minDistance = Math.Min(minDistance, distance);
            }

            result[flatIndex] = minDistance * Args.Scale;

            IncrementIndices(indices, Args.Dimensions);
        }

        return result;
    }

    public override double GenerateSingleSampleRaw()
    {
        throw new NotImplementedException("GenerateSingleSampleRaw method doesn't really make sense for Worley noise, since each value is dependent on its neighbors in the grid.");
    }
}
