// ReSharper disable UnusedMember.Global
// ReSharper disable SuggestBaseTypeForParameterInConstructor
namespace VNet.Scientific.Noise.Color;

// Lavender noise is a term used to describe noise with a power spectral density that increases at a rate of 3 dB per octave. It lies between
// pink noise and white noise in terms of its frequency distribution.
public class LavenderNoise : NoiseBase
{
    private readonly WhiteNoise _whiteNoise;
    private readonly PinkNoise _pinkNoise;

    public LavenderNoise(ILavenderNoiseAlgorithmArgs args) : base(args)
    {
        var whiteArgs = Args.Clone();
        whiteArgs.OutputFilter = null;
        whiteArgs.Scale = 1;
        whiteArgs.QuantizeLevel = 0;
        _whiteNoise = new WhiteNoise(whiteArgs);

        var pinkArgs = Args.Clone();
        pinkArgs.OutputFilter = null;
        pinkArgs.Scale = 1;
        pinkArgs.QuantizeLevel = 0;
        _pinkNoise = new PinkNoise(pinkArgs);
    }

    public override double[] GenerateRaw()
    {
        var totalSize = GetTotalSize(Args.Dimensions);
        var result = new double[totalSize];

        var whiteNoiseData = _whiteNoise.GenerateRaw();
        var pinkNoiseData = _pinkNoise.GenerateRaw();

        for (var i = 0; i < totalSize; i++)
        {
            var whiteNoiseValue = whiteNoiseData[i];
            var pinkNoiseValue = pinkNoiseData[i];
            result[i] = ((ILavenderNoiseAlgorithmArgs)Args).WhiteNoiseWeight * whiteNoiseValue + ((ILavenderNoiseAlgorithmArgs)Args).PinkNoiseWeight * pinkNoiseValue;
        }

        return result;
    }

    private int GetTotalSize(int[] dimensions)
    {
        return dimensions.Aggregate(1, (a, b) => a * b);
    }

    public override double GenerateSingleSampleRaw()
    {
        throw new NotImplementedException("Lavender noise is generated for the entire grid, so generating a single sample is not applicable.");
    }
}