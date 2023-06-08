//// ReSharper disable UnusedMember.Global

//namespace VNet.Scientific.Noise.Other;
//// Perlin noise is a gradient noise developed by Ken Perlin in 1983. It is a procedural texture primitive, a type of gradient noise used by visual
//// effects artists to increase the appearance of realism in computer graphics. Perlin noise is extensively used in computer graphics for
//// effects like fire, smoke and clouds. It's also frequently used to generate textures when memory is extremely limited, such as in 3D graphic development.
//public class PerlinNoise : INoiseAlgorithm
//{
//    private double[,] _grid;

//    public double[,] Generate(INoiseAlgorithmArgs args)
//    {
//        _grid = new double[Args.Height, Args.Width];

//        // Fill the grid with random values between -1 and 1.
//        for (var i = 0; i < Args.Height; i++)
//        {
//            for (var j = 0; j < Args.Width; j++)
//            {
//                _grid[i, j] = 2 * Args.RandomDistributionAlgorithm.NextDouble() - 1;
//            }
//        }

//        var result = new double[Args.Height, Args.Width];

//        // Calculate Perlin noise value for each point.
//        for (var i = 0; i < Args.Height; i++)
//        {
//            for (var j = 0; j < Args.Width; j++)
//            {
//                var sample = GenerateSingleSample(args, i / (double)Args.Height, j / (double)Args.Width);
//                result[i, j] = sample;
//            }
//        }

//        return result;
//    }

//    private double GenerateSingleSample(INoiseAlgorithmArgs args, double x, double y)
//    {
//        int x0 = (int)x;
//        int x1 = x0 + 1;
//        int y0 = (int)y;
//        int y1 = y0 + 1;

//        // Determine interpolation weights
//        double sx = x - x0;
//        double sy = y - y0;

//        // Interpolate between grid point gradients
//        double n0, n1, ix0, ix1, value;

//        n0 = DotGridGradient(x0, y0, x, y);
//        n1 = DotGridGradient(x1, y0, x, y);
//        ix0 = Interpolate(n0, n1, sx);

//        n0 = DotGridGradient(x0, y1, x, y);
//        n1 = DotGridGradient(x1, y1, x, y);
//        ix1 = Interpolate(n0, n1, sx);

//        value = Interpolate(ix0, ix1, sy);

//        return value;
//    }

//    private double DotGridGradient(int ix, int iy, double x, double y)
//    {
//        // Compute the distance vector
//        double dx = x - ix;
//        double dy = y - iy;

//        // Compute the dot-product
//        return dx * _grid[iy, ix] + dy * _grid[iy, ix];
//    }

//    private double Interpolate(double a, double b, double x)
//    {
//        // Simple linear interpolation
//        return a + x * (b - a);
//    }

//    public double GenerateSingleSample(INoiseAlgorithmArgs args)
//    {
//        // Perlin Noise is generated using a grid, so generating a single sample
//        // independently of the rest doesn't make sense.
//        throw new NotImplementedException();
//    }
//}