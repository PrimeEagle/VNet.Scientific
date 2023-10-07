namespace VNet.Scientific.Noise.Other
{
    public class TurbulenceNoiseAlgorithmArgs : NoiseAlgorithmArgs, ITurbulenceNoiseAlgorithmArgs
    {
        public int Octaves { get; set; }
        public double Lacunarity { get; set; }
        public double Gain { get; set; }
        public INoiseAlgorithm BaseNoiseAlgorithm { get; set; }


        public TurbulenceNoiseAlgorithmArgs(INoiseAlgorithm baseNoiseAlgorithm, int octaves = 6, double lacunarity = 2.0, double gain = 0.5)
        {
            Octaves = octaves;
            Lacunarity = lacunarity;
            Gain = gain;
            BaseNoiseAlgorithm = baseNoiseAlgorithm;
        }

        public override INoiseAlgorithmArgs Clone()
        {
            var result = base.Clone();

            ((ITurbulenceNoiseAlgorithmArgs)result).Octaves = Octaves;
            ((ITurbulenceNoiseAlgorithmArgs)result).Lacunarity = Lacunarity;
            ((ITurbulenceNoiseAlgorithmArgs)result).Gain = Gain;
            ((ITurbulenceNoiseAlgorithmArgs)result).BaseNoiseAlgorithm = BaseNoiseAlgorithm;

            return result;
        }
    }
}