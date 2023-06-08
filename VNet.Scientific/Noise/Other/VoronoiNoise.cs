//// ReSharper disable UnusedMember.Global

//namespace VNet.Scientific.Noise.Other;
//// Voronoi noise, also known as Worley noise or cellular noise, is a type of coherent noise that can be used to generate procedural textures.
//// The simplest way of implementing Voronoi noise is by using a Voronoi tessellation algorithm which involves creating a grid of random feature
//// points and assigning every point in the space to the nearest feature point.
//public class VoronoiNoise : INoiseAlgorithm
//{
//    private const int pointCount = 30;

//    public double[,] Generate(INoiseAlgorithmArgs args)a
//    {
//        var result = new double[Args.Height, Args.Width];
//        var featurePoints = new List<(int X, int Y)>();

//        for (int i = 0; i < pointCount; i++)
//        {
//            var x = Args.RandomDistributionAlgorithm.Next(0, Args.Width);
//            var y = Args.RandomDistributionAlgorithm.Next(0, Args.Height);
//            featurePoints.Add((X: x, Y: y));
//        }

//        for (int i = 0; i < Args.Height; i++)
//        {
//            for (int j = 0; j < Args.Width; j++)
//            {
//                double minDistance = double.MaxValue;
//                foreach (var featurePoint in featurePoints)
//                {
//                    var dx = featurePoint.X - j;
//                    var dy = featurePoint.Y - i;
//                    var distance = Math.Sqrt(dx * dx + dy * dy);
//                    minDistance = Math.Min(minDistance, distance);
//                }

//                result[i, j] = minDistance / Math.Sqrt(Args.Width * Args.Width + Args.Height * Args.Height) * Args.Scale;
//            }
//        }

//        return result;
//    }
//}
