// ReSharper disable UnusedMember.Global
// ReSharper disable SuggestBaseTypeForParameter
// ReSharper disable SuggestBaseTypeForParameterInConstructor
// ReSharper disable ParameterTypeCanBeEnumerable.Local
// ReSharper disable MemberCanBeMadeStatic.Local
#pragma warning disable CA1822

namespace VNet.Scientific.Noise.Other;
// Perlin noise is a gradient noise developed by Ken Perlin in 1983. It is a procedural texture primitive, a type of gradient noise used by visual
// effects artists to increase the appearance of realism in computer graphics. Perlin noise is extensively used in computer graphics for
// effects like fire, smoke and clouds. It's also frequently used to generate textures when memory is extremely limited, such as in 3D graphic development.
public class PerlinNoise : NoiseBase
{
    public PerlinNoise(IPerlinNoiseAlgorithmArgs args) : base(args) { }

    public override double GenerateSingleSampleRaw()
    {
        var point = GetMultiDimensionalIndices((int)GetRandomValue(), Args.Dimensions);
        return Noise(point.Select(p => (double)p).ToArray());
    }

    private double Noise(double[] point)
    {
        for (var i = 0; i < point.Length; i++)
        {
            point[i] *= Args.Scale; // Assuming Scale here represents the Octave
        }

        var cell = point.Select(p => (int)Math.Floor(p)).ToArray();
        var value = 0.0;

        foreach (var corner in GetCorners(cell))
        {
            var gradient = GenerateRandomGradient(corner); // On-the-fly gradient generation
            var distance = point.Zip(corner, (p, c) => p - c).ToArray();
            value += DotProduct(gradient, distance) * Fade(distance);
        }

        return value;
    }

    private double[] GenerateRandomGradient(int[] forPoint)
    {
        // Use a hash function of 'forPoint' to seed a local random generator
        var hash = ComputeHash(forPoint);
        var gradient = Enumerable.Range(0, Args.Dimensions.Length)
            .Select(_ => GetRandomValue() * 2 - 1)
            .ToArray();

        return Normalize(gradient);
    }

    private static IEnumerable<int[]> GetCorners(int[] cell)
    {
        var dimensions = cell.Length;
        for (var i = 0; i < (1 << dimensions); i++)
        {
            yield return cell.Select((c, j) => c + ((i >> j) & 1)).ToArray();
        }
    }

    private static double DotProduct(double[] gradient, double[] distance)
    {
        return gradient.Zip(distance, (g, d) => g * d).Sum();
    }

    private double[] Normalize(double[] vector)
    {
        var magnitude = Math.Sqrt(vector.Sum(component => component * component));
        return vector.Select(component => component / magnitude).ToArray();
    }

    private static double Fade(double[] distance)
    {
        return distance.Select(d => d * d * d * (d * (d * 6 - 15) + 10)).Aggregate((acc, val) => acc * val);
    }

    private static int ComputeHash(int[] data)
    {
        const uint c1 = 0xcc9e2d51;
        const uint c2 = 0x1b873593;
        const int r1 = 15;
        const int r2 = 13;
        const uint m = 5;
        const uint n = 0xe6546b64;

        uint hash = 17; // Seed value
        foreach (var item in data)
        {
            var k = (uint)item;
            k *= c1;
            k = (k << r1) | (k >> (32 - r1));
            k *= c2;

            hash ^= k;
            hash = ((hash << r2) | (hash >> (32 - r2)));
            hash = hash * m + n;
        }

        hash ^= (uint)data.Length;
        hash ^= (hash >> 16);
        hash *= 0x85ebca6b;
        hash ^= (hash >> 13);
        hash *= 0xc2b2ae35;
        hash ^= (hash >> 16);

        return (int)hash; // Casting uint to int for the return value
    }
}