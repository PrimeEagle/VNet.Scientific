// ReSharper disable UnusedMember.Global
// ReSharper disable SuggestBaseTypeForParameterInConstructor

namespace VNet.Scientific.Noise.Color;
// Orange noise is sometimes used to describe noise with a power spectral density that decreases at a rate of 3 dB per octave. It lies between
// red (brown) noise and yellow (pink) noise in terms of its spectral characteristics.
public class OrangeNoise : NoiseBase
{
    public OrangeNoise(IOrangeNoiseAlgorithmArgs args) : base(args)
    {

    }

    public override double GenerateSingleSampleRaw()
    {
        var orangeNoise = 0.0;
        var frequency = ((IOrangeNoiseAlgorithmArgs)Args).SamplingRate / Args.Width;

        for (var octave = 1; octave <= ((IOrangeNoiseAlgorithmArgs)Args).Octaves; octave++)
        {
            var amplitude = 1.0 / Math.Pow(frequency, octave * ((IOrangeNoiseAlgorithmArgs)Args).Exponent);
            orangeNoise += (Args.RandomDistributionAlgorithm.NextDouble() * 2.0 - 1.0) * amplitude;
        }

        return orangeNoise;
    }
}