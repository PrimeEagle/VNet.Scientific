//// ReSharper disable UnusedMember.Global

//using VNet.Mathematics.Randomization.Distribution;

//namespace VNet.Scientific.Noise.Other;
//// Reaction-diffusion noise algorithms simulate the behavior of chemical reactions and diffusion processes to generate complex patterns.
//// They are used to model natural phenomena like fire, smoke, or animal skin patterns. Reaction-diffusion algorithms involve the interaction
//// of multiple variables over time.
//public class ReactionDiffusionNoise : INoiseAlgorithm
//{
//    private double[,] _grid;
//    private double _diffusionRateA;
//    private double _diffusionRateB;
//    private double _feedRate;
//    private double _killRate;
//    private double _timeStep;
//    private int _iterations;

//    public ReactionDiffusionNoise(double diffusionRateA = 1.0, double diffusionRateB = 0.5, double feedRate = 0.055, double killRate = 0.062, double timeStep = 1.0, int iterations = 1000)
//    {
//        _diffusionRateA = diffusionRateA;
//        _diffusionRateB = diffusionRateB;
//        _feedRate = feedRate;
//        _killRate = killRate;
//        _timeStep = timeStep;
//        _iterations = iterations;
//    }

//    public double[,] Generate(INoiseAlgorithmArgs args)
//    {
//        int width = Args.Width;
//        int height = Args.Height;

//        _grid = new double[height, width];

//        // Initialize the grid with random values
//        InitializeGrid(Args.RandomDistributionAlgorithm);

//        // Perform the reaction-diffusion simulation
//        for (int i = 0; i < _iterations; i++)
//        {
//            SimulateReactionDiffusion();
//        }

//        Normalize(_grid, Args.QuantizeLevels, Args.Scale);
//        return _grid;
//    }

//    public double GenerateSingleSample(INoiseAlgorithmArgs args)
//    {
//        // Reaction-diffusion noise is generated for the entire grid, so generating a single sample is not applicable.
//        throw new NotImplementedException();
//    }

//    private void InitializeGrid(IRandomDistributionAlgorithm randomDistributionAlgorithm)
//    {
//        int height = _grid.GetLength(0);
//        int width = _grid.GetLength(1);

//        for (int i = 0; i < height; i++)
//        {
//            for (int j = 0; j < width; j++)
//            {
//                _grid[i, j] = randomDistributionAlgorithm.NextDouble();
//            }
//        }
//    }

//    private void SimulateReactionDiffusion()
//    {
//        int height = _grid.GetLength(0);
//        int width = _grid.GetLength(1);

//        double[,] nextGrid = new double[height, width];

//        for (int i = 0; i < height; i++)
//        {
//            for (int j = 0; j < width; j++)
//            {
//                double a = _grid[i, j];
//                double b = _grid[i, j];

//                double laplacianA = GetLaplacian(_grid, i, j, _diffusionRateA);
//                double laplacianB = GetLaplacian(_grid, i, j, _diffusionRateB);

//                double reaction = a * b * b;
//                double diffusionA = laplacianA * _diffusionRateA;
//                double diffusionB = laplacianB * _diffusionRateB;

//                nextGrid[i, j] = a + _timeStep * (diffusionA - reaction + _feedRate * (1.0 - a));
//                nextGrid[i, j] = b + _timeStep * (diffusionB + reaction - (_killRate + _feedRate) * b);
//            }
//        }

//        _grid = nextGrid;
//    }

//    private double GetLaplacian(double[,] grid, int x, int y, double diffusionRate)
//    {
//        int height = grid.GetLength(0);
//        int width = grid.GetLength(1);

//        double value = grid[x, y];
//        double laplacian = -4 * value;

//        if (x > 0)
//            laplacian += diffusionRate * grid[x - 1, y];
//        if (x < height - 1)
//            laplacian += diffusionRate * grid[x + 1, y];
//        if (y > 0)
//            laplacian += diffusionRate * grid[x, y - 1];
//        if (y < width - 1)
//            laplacian += diffusionRate * grid[x, y + 1];

//        return laplacian;
//    }

//    private void Normalize(double[,] noise, int quantizeLevels, double scale)
//    {
//        double min = double.MaxValue;
//        double max = double.MinValue;

//        int height = noise.GetLength(0);
//        int width = noise.GetLength(1);

//        for (int i = 0; i < height; i++)
//        {
//            for (int j = 0; j < width; j++)
//            {
//                double value = noise[i, j];
//                min = Math.Min(min, value);
//                max = Math.Max(max, value);
//            }
//        }

//        double range = max - min;
//        double invRange = range > 0.0 ? 1.0 / range : 0.0;

//        for (int i = 0; i < height; i++)
//        {
//            for (int j = 0; j < width; j++)
//            {
//                double value = (noise[i, j] - min) * invRange;
//                noise[i, j] = value * (quantizeLevels - 1) * scale;
//            }
//        }
//    }
//}
