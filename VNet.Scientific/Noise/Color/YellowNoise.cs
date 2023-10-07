// ReSharper disable UnusedMember.Global
// ReSharper disable SuggestBaseTypeForParameterInConstructor
namespace VNet.Scientific.Noise.Color;

// Yellow noise, also known as "1/f^3 noise" or "squared noise," is a type of noise signal that exhibits a power spectrum that decreases by
// 6 dB per octave. It is characterized by a steeper roll-off compared to pink noise or orange noise.
public class YellowNoise : NoiseBase
{
    private readonly INoiseAlgorithm _whiteNoise;

    public YellowNoise(IYellowNoiseAlgorithmArgs args) : base(args)
    {
        var whiteArgs = Args.Clone();
        whiteArgs.OutputFilter = null;
        whiteArgs.Scale = 1;
        whiteArgs.QuantizeLevel = 0;
        _whiteNoise = new WhiteNoise(whiteArgs);
    }

    public override double[] GenerateRaw()
    {
        var totalSize = Args.Dimensions.Aggregate(1, (acc, val) => acc * val);
        var result = new double[totalSize];

        for (var i = 0; i < totalSize; i++)
        {
            result[i] = GenerateSingleSampleRaw();
        }

        return result;
    }

    public override double GenerateSingleSampleRaw()
    {
        var yellowNoise = 0.0;
        var totalSize = Args.Dimensions.Aggregate(1, (acc, val) => acc * val);
        var frequency = ((IYellowNoiseAlgorithmArgs)Args).SamplingRate / totalSize;

        for (var octave = 1; octave <= ((IYellowNoiseAlgorithmArgs)Args).Octaves; octave++)
        {
            var amplitude = 1.0 / Math.Pow(frequency, octave * 2);
            yellowNoise += (_whiteNoise.GenerateSingleSampleRaw() * 2.0 - 1.0) * amplitude;
        }

        return yellowNoise;
    }
}