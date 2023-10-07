// ReSharper disable UnusedMember.Global
// ReSharper disable SuggestBaseTypeForParameterInConstructor
namespace VNet.Scientific.Noise.Color;

// Gold noise, also known as "golden noise" or "golden ratio noise," is a type of noise signal that exhibits a power spectrum with a unique
// property related to the golden ratio.
public class GoldNoise : NoiseBase
{
    private readonly double _phi = (1 + Math.Sqrt(5)) / 2; // Golden ratio
    private readonly INoiseAlgorithm _whiteNoise;

    public GoldNoise(IGoldNoiseAlgorithmArgs args):base(args)
    {
        var whiteArgs = Args.Clone();
        whiteArgs.OutputFilter = null;
        whiteArgs.Scale = 1;
        whiteArgs.QuantizeLevel = 0;
        _whiteNoise = new WhiteNoise(whiteArgs);
    }

    public override double GenerateSingleSampleRaw()
    {
        var goldNoise = 0.0;

        for (var octave = 1; octave <= ((IGoldNoiseAlgorithmArgs)Args).Octaves; octave++)
        {
            var frequency = ((IGoldNoiseAlgorithmArgs)Args).SamplingRate / Args.Width * Math.Pow(_phi, octave);
            var amplitude = 1.0 / Math.Sqrt(frequency);
            goldNoise += (_whiteNoise.GenerateSingleSampleRaw() * 2.0 - 1.0) * amplitude;
        }

        return goldNoise;
    }
}