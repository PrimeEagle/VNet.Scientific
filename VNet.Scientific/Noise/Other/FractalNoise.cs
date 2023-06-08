//// ReSharper disable UnusedMember.Global

//namespace VNet.Scientific.Noise.Other;
//// Fractal noise, also known as Fractional Brownian Motion (fBm), is a way of combining multiple layers of noise to create a more complex and
//// rich output. Each layer of noise is typically called an "octave", and each octave is given a frequency and an amplitude.
//public class FractalNoise : INoiseAlgorithm
//{
//    private INoiseAlgorithm _baseNoise;
//    private int _octaves;
//    private double _lacunarity;
//    private double _gain;

//    public FractalNoise(INoiseAlgorithm baseNoise, int octaves = 8, double lacunarity = 2.0, double gain = 0.5)
//    {
//        _baseNoise = baseNoise;
//        _octaves = octaves;
//        _lacunarity = lacunarity;
//        _gain = gain;
//    }

//    public double[,] Generate(INoiseAlgorithmArgs args)
//    {
//        var result = new double[Args.Height, Args.Width];

//        for (int i = 0; i < Args.Height; i++)
//        {
//            for (int j = 0; j < Args.Width; j++)
//            {
//                double frequency = 1;
//                double amplitude = 1;
//                double total = 0;

//                for (int octave = 0; octave < _octaves; octave++)
//                {
//                    double x = j * frequency / Args.Width;
//                    double y = i * frequency / Args.Height;
//                    double noise = _baseNoise.GenerateSingleSample(new NoiseAlgorithmArgs
//                    {
//                        Width = (int)x,
//                        Height = (int)y,
//                        QuantizeLevels = Args.QuantizeLevels,
//                        Scale = Args.Scale,
//                        RandomDistributionAlgorithm = Args.RandomDistributionAlgorithm
//                    });

//                    total += noise * amplitude;
//                    frequency *= _lacunarity;
//                    amplitude *= _gain;
//                }

//                result[i, j] = total;
//            }
//        }

//        return result;
//    }

//    public double GenerateSingleSample(INoiseAlgorithmArgs args)
//    {
//        // Fractal noise is generated for the entire grid, so generating a single sample is not applicable.
//        throw new NotImplementedException();
//    }
//}