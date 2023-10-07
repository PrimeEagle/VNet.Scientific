// ReSharper disable MemberCanBePrivate.Global
namespace VNet.Scientific.Noise.Other
{
    public class WaveletNoiseAlgorithmArgs : NoiseAlgorithmArgs, IWaveletNoiseAlgorithmArgs
    {
        public int Octaves { get; set; }
        public double Lacunarity { get; set; }
        public double Gain { get; set; }
        public double Frequency { get; set; }
        public double Amplitude { get; set; }


        public WaveletNoiseAlgorithmArgs(int octaves = 6, double lacunarity = 2.0, double gain = 0.5, double frequency = 1.0, double amplitude = 1.0)
        {
            Octaves = octaves;
            Lacunarity = lacunarity;
            Gain = gain;
            Frequency = frequency;
            Amplitude = amplitude;
        }

        public override INoiseAlgorithmArgs Clone()
        {
            var result = base.Clone();

            ((WaveletNoiseAlgorithmArgs)result).Octaves = Octaves;
            ((WaveletNoiseAlgorithmArgs)result).Lacunarity = Lacunarity;
            ((WaveletNoiseAlgorithmArgs)result).Gain = Gain;
            ((WaveletNoiseAlgorithmArgs)result).Frequency = Frequency;
            ((WaveletNoiseAlgorithmArgs)result).Amplitude = Amplitude;

            return result;
        }
    }
}