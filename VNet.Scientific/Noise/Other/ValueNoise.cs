//// ReSharper disable UnusedMember.Global

//namespace VNet.Scientific.Noise.Other;
//// Value noise is a type of noise commonly used in procedural texture generation, such as for terrain generation in computer graphics.
//// It's created by interpolating random values on a grid. Creating value noise typically requires a grid of random values and an interpolation
//// method.The interpolation can be linear, cosine, cubic, or another method depending on the desired smoothness.
//public class ValueNoise : INoiseAlgorithm
//{
//    private double[,] _grid;

//    public double[,] Generate(INoiseAlgorithmArgs args)
//    {
//        _grid = new double[Args.Height, Args.Width];
//        var random = new Random();

//        // Fill the grid with random values.
//        for (var i = 0; i < Args.Height; i++)
//        {
//            for (var j = 0; j < Args.Width; j++)
//            {
//                _grid[i, j] = Args.RandomDistributionAlgorithm.NextDouble();
//            }
//        }

//        var result = new double[Args.Height, Args.Width];

//        // Interpolate between the grid values.
//        for (var i = 0; i < Args.Height; i++)
//        {
//            for (var j = 0; j < Args.Width; j++)
//            {
//                var yFraction = i / (double)Args.Height;
//                var xFraction = j / (double)Args.Width;

//                var top = Interpolate(_grid[(int)(yFraction * (Args.Height - 1)), (int)(xFraction * (Args.Width - 1))],
//                    _grid[(int)(yFraction * (Args.Height - 1)), (int)Math.Min(xFraction * Args.Width, Args.Width - 1)],
//                    xFraction * Args.Width % 1);

//                var bottom = Interpolate(_grid[(int)Math.Min(yFraction * Args.Height, Args.Height - 1), (int)(xFraction * (Args.Width - 1))],
//                    _grid[(int)Math.Min(yFraction * Args.Height, Args.Height - 1), (int)Math.Min(xFraction * Args.Width, Args.Width - 1)],
//                    xFraction * Args.Width % 1);

//                result[i, j] = Interpolate(top, bottom, yFraction * Args.Height % 1);
//            }
//        }

//        return result;
//    }

//    private double Interpolate(double a, double b, double fraction)
//    {
//        // This is a simple linear interpolation.
//        return a * (1 - fraction) + b * fraction;
//    }

//    public double GenerateSingleSample(INoiseAlgorithmArgs args)
//    {
//        // The GenerateSingleSample method doesn't really make sense for value noise,
//        // since each value is dependent on its neighbors in the grid.
//        throw new NotImplementedException();
//    }
//}