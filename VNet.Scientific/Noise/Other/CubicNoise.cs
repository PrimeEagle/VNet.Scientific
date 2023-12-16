// ReSharper disable UnusedMember.Global

namespace VNet.Scientific.Noise.Other;

// Cubic noise refers to a type of noise generation algorithm that is based on cubic interpolation between values in a grid to produce a smoother, more continuous
// appearance than simpler forms of interpolation, such as linear interpolation.
// In the context of procedural noise generation, interpolation methods are used to calculate the values between defined points (often random) on a grid.
// The choice of interpolation method affects the visual appearance of the generated noise.Cubic interpolation provides a balance between smoothness
// and computational complexity.
public class CubicNoise : NoiseBase
{
    public CubicNoise(INoiseAlgorithmArgs args) : base(args)
    {
    }

    public override double GenerateSingleSampleRaw()
    {
        throw new NotImplementedException("Cubic noise is generated for the entire grid, so generating a single sample is not applicable.");
    }

    public override double[] GenerateRaw()
    {
        var totalSize = Args.Dimensions.Aggregate(1, (acc, val) => acc * val);
        var result = new double[totalSize];

        for (var flatIndex = 0; flatIndex < totalSize; flatIndex++)
        {
            var coordinates = GetMultiDimensionalIndices(flatIndex, Args.Dimensions);
            var x = coordinates[0] / (double)Args.Dimensions[0];
            var y = coordinates.Length > 1 ? coordinates[1] / (double)Args.Dimensions[1] : 0; // Use 0 if only 1 dimension exists

            result[flatIndex] = Noise(x, y);
        }

        return result;
    }

    private double Noise(double x, double y)
    {
        var X = (int)Math.Floor(x) & 255;
        var Y = (int)Math.Floor(y) & 255;

        x -= Math.Floor(x);
        y -= Math.Floor(y);

        var u = Fade(x);
        var v = Fade(y);

        var A = p[X] + Y;
        var AA = p[A];
        var AB = p[A + 1];
        var B = p[X + 1] + Y;
        var BA = p[B];
        var BB = p[B + 1];

        var gradAA = Grad(p[AA], x, y);
        var gradAB = Grad(p[AB], x, y - 1);
        var gradBA = Grad(p[BA], x - 1, y);
        var gradBB = Grad(p[BB], x - 1, y - 1);

        var noise = Lerp(Lerp(gradAA, gradBA, u), Lerp(gradAB, gradBB, u), v);

        return (noise + 1) / 2.0; // Adjust range to [0, 1]
    }

    private static double Fade(double t)
    {
        return t * t * t * (t * (t * 6 - 15) + 10);
    }

    private static double Lerp(double a, double b, double t)
    {
        return a + t * (b - a);
    }

    private static double Grad(int hash, double x, double y)
    {
        var h = hash & 15;
        var u = h < 8 ? x : y;
        var v = h < 4 ? y : h == 12 || h == 14 ? x : 0;
        return ((h & 1) == 0 ? u : -u) + ((h & 2) == 0 ? v : -v);
    }

    private static readonly int[] p = { /* ... the same permuted array ... */ };
}
