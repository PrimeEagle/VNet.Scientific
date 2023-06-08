//// ReSharper disable UnusedMember.Global

//namespace VNet.Scientific.Noise.Other;
//// Speckle noise is a type of noise commonly found in radar or ultrasound imaging.It appears as a granular or textured pattern,
//// similar to the noise produced by scattering of coherent waves. Speckle noise can be simulated by applying random variations to image pixels or
//// by using statistical models.
//public class SpeckleNoise : INoiseAlgorithm
//{
//    private double _intensity;

//    public SpeckleNoise(double intensity = 0.1)
//    {
//        _intensity = intensity;
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
//                double randomValue = (Args.RandomDistributionAlgorithm.NextDouble() * 2 - 1) * _intensity;
//                result[i, j] = Args.Scale * randomValue;
//            }
//        }

//        return result;
//    }

//    public double GenerateSingleSample(INoiseAlgorithmArgs args)
//    {
//        // Speckle noise is generated for the entire grid, so generating a single sample is not applicable.
//        throw new NotImplementedException();
//    }
//}