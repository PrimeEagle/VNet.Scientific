namespace VNet.Scientific.Noise.Other
{
    public class HarmonicNoiseAlgorithmArgs : NoiseAlgorithmArgs, IHarmonicNoiseAlgorithmArgs
    {
        public double[] Frequencies { get; set; }
        public double[] Amplitudes { get; set; }
        public double SampleRate { get; set; }


        public override INoiseAlgorithmArgs Clone()
        {
            var result = base.Clone();

            ((IHarmonicNoiseAlgorithmArgs)result).Frequencies = Frequencies;
            ((IHarmonicNoiseAlgorithmArgs)result).Amplitudes = Amplitudes;
            ((IHarmonicNoiseAlgorithmArgs)result).SampleRate = SampleRate;

            return result;
        }
    }
}