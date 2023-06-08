//// ReSharper disable UnusedMember.Global

//namespace VNet.Scientific.Noise.Other;
//// Gaussian noise, also known as normal noise, is a type of noise that follows a Gaussian or normal distribution. It is characterized by random
//// fluctuations with a bell-shaped distribution. Gaussian noise is commonly used in simulations, statistical modeling,
//// and as a model for various noise sources.
//public class GaussianNoise : INoiseAlgorithm
//{
//    private double _mean;
//    private double _stdDev;

//    public GaussianNoise(double mean = 0.0, double stdDev = 1.0)
//    {
//        _mean = mean;
//        _stdDev = stdDev;
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
//                double randomValue = Args.RandomDistributionAlgorithm.NextGaussian(_mean, _stdDev);
//                result[i, j] = randomValue * Args.Scale;
//            }
//        }

//        return result;
//    }

//    public double GenerateSingleSample(INoiseAlgorithmArgs args)
//    {
//        // Gaussian noise is generated for the entire grid, so generating a single sample is not applicable.
//        throw new NotImplementedException();
//    }
//}