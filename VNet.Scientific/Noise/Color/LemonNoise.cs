// ReSharper disable UnusedMember.Global

namespace VNet.Scientific.Noise.Color;

// Lemon noise is a term used to describe noise with a power spectral density that increases at a rate higher than white noise.
// It emphasizes higher frequencies more than white noise.
public class LemonNoise : NoiseBase
{
    private readonly WhiteNoise _whiteNoise;

    public LemonNoise(INoiseAlgorithmArgs args) : base(args)
    {
        var whiteArgs = Args.Clone();
        whiteArgs.OutputFilter = null;
        whiteArgs.Scale = 1;
        whiteArgs.QuantizeLevel = 0;
        _whiteNoise = new WhiteNoise(whiteArgs);
    }

    public override double[] GenerateRaw()
    {
        var totalSize = GetTotalSize(Args.Dimensions);
        var result = new double[totalSize];
        var whiteNoiseData = _whiteNoise.GenerateRaw();

        for (var i = 0; i < totalSize; i++)
        {
            var baseNoiseValue = whiteNoiseData[i];
            var lemonNoiseValue = Math.Abs(baseNoiseValue) < 0.5 ? baseNoiseValue * 2.0 : 1.0 - (baseNoiseValue - 0.5) * 2.0;

            result[i] = lemonNoiseValue;
        }

        return result;
    }

    private int GetTotalSize(int[] dimensions)
    {
        return dimensions.Aggregate(1, (a, b) => a * b);
    }

    public override double GenerateSingleSampleRaw()
    {
        throw new NotImplementedException("Lemon noise is generated for the entire grid, so generating a single sample is not applicable.");
    }
}