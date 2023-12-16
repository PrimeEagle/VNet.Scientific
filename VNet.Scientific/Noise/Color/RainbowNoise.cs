// ReSharper disable UnusedMember.Global

// ReSharper disable SuggestBaseTypeForParameterInConstructor
namespace VNet.Scientific.Noise.Color;

// Rainbow noise is a term that has been used to describe noise signals that contain a wide range of frequencies and power distributions,
// similar to the colors of a rainbow. It implies a complex and diverse spectrum rather than adhering to a specific power-law distribution.
public class RainbowNoise : NoiseBase
{
    private readonly INoiseAlgorithm _whiteNoise;

    public RainbowNoise(IRainbowNoiseAlgorithmArgs args) : base(args)
    {
        var whiteArgs = Args.Clone();
        whiteArgs.OutputFilter = null;
        whiteArgs.Scale = 1;
        whiteArgs.QuantizeLevel = 0;
        _whiteNoise = new WhiteNoise(whiteArgs);
    }

    public override double GenerateSingleSampleRaw()
    {
        var rainbowNoise = 0.0;
        var primaryFrequency = ((IRainbowNoiseAlgorithmArgs)Args).SamplingRate; // Assuming this value makes sense in n-dimensions

        for (var octave = 1; octave <= ((IRainbowNoiseAlgorithmArgs)Args).Octaves; octave++)
        {
            var frequency = primaryFrequency * octave; // Adjust the frequency computation according to n-dimensional interpretation
            var amplitude = 1.0 / Math.Sqrt(frequency);
            rainbowNoise += (_whiteNoise.GenerateSingleSampleRaw() * 2.0 - 1.0) * amplitude;
        }

        return rainbowNoise;
    }
}