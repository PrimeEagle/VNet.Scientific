//// ReSharper disable UnusedMember.Global

//namespace VNet.Scientific.Noise.Other;

//// Fractional Brownian Motion (fBm) is a generalization of Brownian motion. It is a fractal-based noise algorithm that generates self-similar noise
//// patterns with a controlled amount of detail at different scales. fBm is used in terrain generation, procedural textures, and modeling natural phenomena.
//public class FractionalBrownianMotionNoise : INoiseAlgorithm
//{
//    private int _octaves;
//    private double _lacunarity;
//    private double _gain;
//    private double _frequency;
//    private double _amplitude;

//    public FractionalBrownianMotionNoise(int octaves = 6, double lacunarity = 2.0, double gain = 0.5, double frequency = 1.0, double amplitude = 1.0)
//    {
//        _octaves = octaves;
//        _lacunarity = lacunarity;
//        _gain = gain;
//        _frequency = frequency;
//        _amplitude = amplitude;
//    }

//    public double[,] Generate(INoiseAlgorithmArgs args)
//    {
//        int width = Args.Width;
//        int height = Args.Height;

//        double[,] result = new double[height, width];
//        double frequency = _frequency;
//        double amplitude = _amplitude;

//        for (int octave = 0; octave < _octaves; octave++)
//        {
//            double[,] octaveNoise = GenerateOctaveNoise(width, height, frequency);
//            for (int i = 0; i < height; i++)
//            {
//                for (int j = 0; j < width; j++)
//                {
//                    result[i, j] += octaveNoise[i, j] * amplitude;
//                }
//            }

//            frequency *= _lacunarity;
//            amplitude *= _gain;
//        }

//        Normalize(result, Args.QuantizeLevels, Args.Scale);
//        return result;
//    }

//    public double GenerateSingleSample(INoiseAlgorithmArgs args)
//    {
//        // Fractional Brownian Motion noise is generated for the entire grid, so generating a single sample is not applicable.
//        throw new NotImplementedException();
//    }

//    private double[,] GenerateOctaveNoise(int width, int height, double frequency)
//    {
//        double[,] noise = new double[height, width];

//        for (int i = 0; i < height; i++)
//        {
//            for (int j = 0; j < width; j++)
//            {
//                double x = j / (double)width * frequency;
//                double y = i / (double)height * frequency;

//                noise[i, j] = PerlinNoise.Noise(x, y);
//            }
//        }

//        return noise;
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
