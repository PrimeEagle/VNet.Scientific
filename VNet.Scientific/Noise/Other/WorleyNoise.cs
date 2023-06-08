//// ReSharper disable UnusedMember.Global

//namespace VNet.Scientific.Noise.Other;
//// In addition to the standard Worley noise algorithm, there are several variants that modify the behavior or properties of cellular noise.
//// Examples include Voronoi-based noise with distance metrics like Manhattan or Chebyshev distance, or variations that introduce perturbations
//// or modifications to the cell shapes.
//public class WorleyNoise : INoiseAlgorithm
//{
//    private int _numPoints;

//    public WorleyNoise(int numPoints = 10)
//    {
//        _numPoints = numPoints;
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
//                double minDistance = double.MaxValue;

//                for (int k = 0; k < _numPoints; k++)
//                {
//                    double x = Args.RandomDistributionAlgorithm.NextDouble();
//                    double y = Args.RandomDistributionAlgorithm.NextDouble();
//                    double distance = Math.Sqrt(Math.Pow(x - i, 2) + Math.Pow(y - j, 2));

//                    if (distance < minDistance)
//                    {
//                        minDistance = distance;
//                    }
//                }

//                result[i, j] = minDistance * Args.Scale;
//            }
//        }

//        return result;
//    }

//    public double GenerateSingleSample(INoiseAlgorithmArgs args)
//    {
//        // Worley noise is generated for the entire grid, so generating a single sample is not applicable.
//        throw new NotImplementedException();
//    }
//}