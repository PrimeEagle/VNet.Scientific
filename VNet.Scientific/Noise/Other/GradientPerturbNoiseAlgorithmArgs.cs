namespace VNet.Scientific.Noise.Other
{
    public class GradientPerturbNoiseAlgorithmArgs : NoiseAlgorithmArgs, IGradientPerturbNoiseAlgorithmArgs
    {
        public INoiseAlgorithm BaseNoise { get; set; }
        public double Frequency { get; set; }
        public double Amplitude { get; set; }


        public override INoiseAlgorithmArgs Clone()
        {
            var result = base.Clone();

            ((IGradientPerturbNoiseAlgorithmArgs)result).BaseNoise = BaseNoise;
            ((IGradientPerturbNoiseAlgorithmArgs)result).Frequency = Frequency;
            ((IGradientPerturbNoiseAlgorithmArgs)result).Amplitude = Amplitude;

            return result;
        }
    }
}