// ReSharper disable UnusedMember.Global

// ReSharper disable SuggestBaseTypeForParameterInConstructor
// ReSharper disable SuggestBaseTypeForParameter
// ReSharper disable MemberCanBeMadeStatic.Local
// ReSharper disable ParameterTypeCanBeEnumerable.Local
#pragma warning disable CA1822
namespace VNet.Scientific.Noise.Other;
// Voronoi noise, also known as Worley noise or cellular noise, is a type of coherent noise that can be used to generate procedural textures.
// The simplest way of implementing Voronoi noise is by using a Voronoi tessellation algorithm which involves creating a grid of random feature
// points and assigning every point in the space to the nearest feature point.
public class VoronoiNoise : NoiseBase
{
    public VoronoiNoise(IVoronoiNoiseAlgorithmArgs args) : base(args) { }

    public override double[] GenerateRaw()
    {
        var totalSize = Args.Dimensions.Aggregate(1, (acc, val) => acc * val);
        var result = new double[totalSize];

        var featurePoints = new List<int[]>();

        for (var i = 0; i < ((IVoronoiNoiseAlgorithmArgs)Args).PointCount; i++)
        {
            var point = new int[Args.Dimensions.Length];
            for (var dim = 0; dim < Args.Dimensions.Length; dim++)
            {
                point[dim] = (int)(Args.RandomDistributionAlgorithm.NextDouble() * Args.Dimensions[dim]);
            }
            featurePoints.Add(point);
        }

        var indices = new int[Args.Dimensions.Length];

        for (var flatIndex = 0; flatIndex < totalSize; flatIndex++)
        {
            var minDistance = featurePoints.Select(featurePoint => CalculateEuclideanDistance(indices, featurePoint)).Prepend(double.MaxValue).Min();

            var maxPossibleDistance = Math.Sqrt(Args.Dimensions.Select(d => d * d).Sum());
            result[flatIndex] = minDistance / maxPossibleDistance * Args.Scale;

            IncrementIndices(indices, Args.Dimensions);
        }

        return result;
    }

    private double CalculateEuclideanDistance(int[] point1, int[] point2)
    {
        var sum = 0.0;

        for (var i = 0; i < point1.Length; i++)
        {
            var distance = point1[i] - point2[i];
            sum += distance * distance;
        }

        return Math.Sqrt(sum);
    }

    public override double GenerateSingleSampleRaw()
    {
        throw new NotImplementedException("GenerateSingleSampleRaw method doesn't really make sense for Voronoi noise, since each value is dependent on its neighbors in the grid.");
    }
}