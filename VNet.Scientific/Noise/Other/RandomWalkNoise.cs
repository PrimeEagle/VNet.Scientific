//// ReSharper disable UnusedMember.Global

//namespace VNet.Scientific.Noise.Other;

//// Random walk algorithms simulate a random path taken by a point in a discrete space. By accumulating the positions at each step,
//// it generates a noise signal that exhibits a random, unpredictable pattern. Random walks have applications in modeling diffusion,
//// financial markets, and generating irregular patterns.
//public class RandomWalkNoise : INoiseAlgorithm
//{
//    private int _numSteps;
//    private double _stepSize;

//    public RandomWalkNoise(int numSteps = 1000, double stepSize = 0.1)
//    {
//        _numSteps = numSteps;
//        _stepSize = stepSize;
//    }

//    public double[,] Generate(INoiseAlgorithmArgs args)
//    {
//        int width = Args.Width;
//        int height = Args.Height;

//        double[,] result = new double[height, width];
//        for (int i = 0; i < height; i++)
//        {
//            for (int j = 0; j < width; j++)
//            {
//                double noiseValue = RandomWalk(_numSteps, _stepSize);
//                result[i, j] = noiseValue * Args.Scale;
//            }
//        }

//        return result;
//    }

//    public double GenerateSingleSample(INoiseAlgorithmArgs args)
//    {
//        // Random Walk noise is generated for the entire grid, so generating a single sample is not applicable.
//        throw new NotImplementedException();
//    }

//    private double RandomWalk(int numSteps, double stepSize)
//    {
//        double value = 0.0;
//        for (int i = 0; i < numSteps; i++)
//        {
//            double randomStep = (2 * RandomProvider.NextDouble() - 1) * stepSize;
//            value += randomStep;
//        }
//        return value / Math.Sqrt(numSteps);
//    }
//}