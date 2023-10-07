// ReSharper disable UnusedMember.Global

namespace VNet.Scientific.Noise.Other;
// Simplex noise is an improvement over Perlin noise, developed by Ken Perlin himself to address some of the limitations of the Perlin noise algorithm.
// Simplex noise has a lower computational complexity and does not have visible directional artifacts. Implementing Simplex noise in C# is quite
// complex, involving the computation of gradients in simplex space, the mapping of points from the input space to simplex space, and the addition
// of the contributions of each corner of the simplex.
public class SimplexNoise : NoiseBase
{
    private readonly int[][] grad3 = new int[][]
    {
        new int[] {1, 1, 0}, new int[] {-1, 1, 0}, new int[] {1, -1, 0}, new int[] {-1, -1, 0}, new int[] {1, 0, 1}, new int[] {-1, 0, 1},
        new int[] {1, 0, -1}, new int[] {-1, 0, -1}, new int[] {0, 1, 1}, new int[] {0, -1, 1}, new int[] {0, 1, -1}, new int[] {0, -1, -1}
    };

    public SimplexNoise(ISimplexNoiseAlgorithmArgs args) : base(args)
    {
        var p = ((ISimplexNoiseAlgorithmArgs) Args).P;
        var permutation = ((ISimplexNoiseAlgorithmArgs)Args).Permutation;

        for (var i = 0; i < 256; i++)
            p[256 + i] = p[i] = permutation[i];
    }

    public override double GenerateSingleSampleRaw()
    {
        // This uses only the 2D noise generation, but can be adapted for higher dimensions if needed.
        return Noise(GetRandomValue(), GetRandomValue());
    }

    public override double[] GenerateRaw()
    {
        var totalSize = Args.Dimensions.Aggregate(1, (acc, val) => acc * val);
        var samples = new double[totalSize];

        for (var idx = 0; idx < totalSize; idx++)
        {
            var coords = GetMultiDimensionalIndices(idx, Args.Dimensions);
            var x = coords[0] / (double)Args.Dimensions[0];
            var y = coords[1] / (double)Args.Dimensions[1];
            samples[idx] = Noise(x, y);
        }

        return samples;
    }

    private double Noise(double xin, double yin)
    {
        double n0, n1, n2;
        var s = (xin + yin) * ((ISimplexNoiseAlgorithmArgs)Args).F2;
        var i = FastFloor(xin + s);
        var j = FastFloor(yin + s);
        var t = (i + j) * ((ISimplexNoiseAlgorithmArgs)Args).G2;
        var X0 = i - t;
        var Y0 = j - t;
        var x0 = xin - X0;
        var y0 = yin - Y0;

        int i1, j1;
        if (x0 > y0) { i1 = 1; j1 = 0; }
        else { i1 = 0; j1 = 1; }

        var x1 = x0 - i1 + ((ISimplexNoiseAlgorithmArgs)Args).G2;
        var y1 = y0 - j1 + ((ISimplexNoiseAlgorithmArgs)Args).G2;
        var x2 = x0 - 1.0 + 2.0 * ((ISimplexNoiseAlgorithmArgs)Args).G2;
        var y2 = y0 - 1.0 + 2.0 * ((ISimplexNoiseAlgorithmArgs)Args).G2;

        var p = ((ISimplexNoiseAlgorithmArgs)Args).P;
        var ii = i & 255;
        var jj = j & 255;
        var gi0 = p[ii + p[jj]] % 12;
        var gi1 = p[ii + i1 + p[jj + j1]] % 12;
        var gi2 = p[ii + 1 + p[jj + 1]] % 12;

        var t0 = 0.5 - x0 * x0 - y0 * y0;
        if (t0 < 0) n0 = 0.0;
        else
        {
            t0 *= t0;
            n0 = t0 * t0 * Dot(grad3[gi0], x0, y0);
        }

        var t1 = 0.5 - x1 * x1 - y1 * y1;
        if (t1 < 0) n1 = 0.0;
        else
        {
            t1 *= t1;
            n1 = t1 * t1 * Dot(grad3[gi1], x1, y1);
        }

        var t2 = 0.5 - x2 * x2 - y2 * y2;
        if (t2 < 0) n2 = 0.0;
        else
        {
            t2 *= t2;
            n2 = t2 * t2 * Dot(grad3[gi2], x2, y2);
        }

        return 70.0 * (n0 + n1 + n2);
    }

    private static int FastFloor(double x)
    {
        return x > 0 ? (int)x : (int)x - 1;
    }

    private static double Dot(int[] g, double x, double y)
    {
        return g[0] * x + g[1] * y;
    }
}