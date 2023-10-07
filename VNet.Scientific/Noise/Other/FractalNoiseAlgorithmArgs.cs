namespace VNet.Scientific.Noise.Other
{
    public class FractalNoiseAlgorithmArgs : NoiseAlgorithmArgs, IFractalNoiseAlgorithmArgs
    {
        public int Octaves { get; set; }
        public double Lacunarity { get; set; }
        public double Gain { get; set; }
        public INoiseAlgorithm BaseNoiseAlgorithm { get; set; }


        public FractalNoiseAlgorithmArgs(INoiseAlgorithm baseNoiseAlgorithm, int octaves = 8, double lacunarity = 2.0, double gain = 0.5)
        {
            Octaves = octaves;
            Lacunarity = lacunarity;
            Gain = gain;
            BaseNoiseAlgorithm = baseNoiseAlgorithm;
        }

        public override INoiseAlgorithmArgs Clone()
        {
            var result = base.Clone();

            ((IFractalNoiseAlgorithmArgs)result).Octaves = Octaves;
            ((IFractalNoiseAlgorithmArgs)result).Lacunarity = Lacunarity;
            ((IFractalNoiseAlgorithmArgs)result).Gain = Gain;
            ((IFractalNoiseAlgorithmArgs)result).BaseNoiseAlgorithm = BaseNoiseAlgorithm;

            return result;
        }
    }
}