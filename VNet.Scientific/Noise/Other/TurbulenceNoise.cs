//// ReSharper disable UnusedMember.Global

//namespace VNet.Scientific.Noise.Other;
//// Turbulence noise algorithms combine multiple noise sources or functions to create a more dynamic and turbulent effect. It involves adding or
//// multiplying different noise layers with varying scales and amplitudes. Turbulence noise is often used in visual effects, fluid simulations, and
//// creating natural textures.
//public class TurbulenceNoise : INoiseAlgorithm
//{
//    private INoiseAlgorithm _baseNoise;
//    private int _octaves;
//    private double _lacunarity;
//    private double _gain;

//    public TurbulenceNoise(INoiseAlgorithm baseNoise, int octaves = 6, double lacunarity = 2.0, double gain = 0.5)
//    {
//        _baseNoise = baseNoise;
//        _octaves = octaves;
//        _lacunarity = lacunarity;
//        _gain = gain;
//    }

//    public double[,] Generate(INoiseAlgorithmArgs args)
//    {
//        int width = Args.Width;
//        int height = Args.Height;

//        double[,] result = new double[height, width];
//        double amplitude = 1.0;
//        double frequency = 1.0;

//        for (int octave = 0; octave < _octaves; octave++)
//        {
//            double[,] octaveNoise = _baseNoise.Generate(new NoiseAlgorithmArgs
//            {
//                Width = width,
//                Height = height,
//                QuantizeLevels = 1,
//                Scale = 1.0,
//                RandomDistributionAlgorithm = Args.RandomDistributionAlgorithm
//            });

//            for (int i = 0; i < height; i++)
//            {
//                for (int j = 0; j < width; j++)
//                {
//                    result[i, j] += octaveNoise[i, j] * amplitude;
//                }
//            }

//            amplitude *= _gain;
//            frequency *= _lacunarity;
//        }

//        Normalize(result, Args.QuantizeLevels, Args.Scale);
//        return result;
//    }

//    public double GenerateSingleSample(INoiseAlgorithmArgs args)
//    {
//        // Turbulence noise is generated for the entire grid, so generating a single sample is not applicable.
//        throw new NotImplementedException();
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