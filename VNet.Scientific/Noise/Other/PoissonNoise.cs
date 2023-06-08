//// ReSharper disable UnusedMember.Global

//namespace VNet.Scientific.Noise.Other;
//// Poisson noise is a type of noise that arises from the statistical nature of photon or particle arrival events in imaging or sensing
//// applications. It is characterized by random fluctuations that follow a Poisson distribution. Poisson noise can be simulated by modeling
//// the arrival of discrete events according to the Poisson process.
//public class PoissonNoise : INoiseAlgorithm
//{
//    private double _mean;

//    public PoissonNoise(double mean = 1.0)
//    {
//        _mean = mean;
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
//                double randomValue = GeneratePoissonRandomValue(_mean, Args.RandomDistributionAlgorithm);
//                result[i, j] = randomValue * Args.Scale;
//            }
//        }

//        return result;
//    }

//    public double GenerateSingleSample(INoiseAlgorithmArgs args)
//    {
//        // Poisson noise is generated for the entire grid, so generating a single sample is not applicable.
//        throw new NotImplementedException();
//    }

//    private double GeneratePoissonRandomValue(double mean, IRandomDistributionAlgorithm randomDistributionAlgorithm)
//    {
//        double L = Math.Exp(-mean);
//        double p = 1.0;
//        int k = 0;
//        double randomValue = randomDistributionAlgorithm.NextDouble();

//        while (p > randomValue)
//        {
//            k++;
//            p *= randomDistributionAlgorithm.NextDouble();
//        }

//        return k - 1;
//    }
//}