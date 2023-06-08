namespace VNet.Scientific.Noise.Color
{
    // Purple noise, also known as violet noise, is a type of noise signal that has a power spectrum that decreases by 6 dB per octave. It is named "purple"
    // or "violet" because it is considered to be at the high-frequency end of the visible light spectrum, analogous to the color purple or violet.
    // Purple noise contains equal energy per octave, which means that the power of the noise signal is evenly distributed across the frequency spectrum.
    // As a result, it has a higher power in the higher frequencies compared to lower frequencies.This characteristic gives purple noise a higher
    // emphasis on higher-frequency components, resulting in a hissing or hissing-like sound.
    public class VioletNoise : NoiseBase
    {
        public VioletNoise(INoiseAlgorithmArgs args) : base(args)
        {

        }

        public override double GenerateSingleSampleRaw()
        {
            var sample = Args.RandomDistributionAlgorithm.NextDouble() * 2.0 - 1.0;

            return sample;
        }
    }
}