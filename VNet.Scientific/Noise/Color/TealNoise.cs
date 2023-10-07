// ReSharper disable UnusedMember.Global
namespace VNet.Scientific.Noise.Color;

// Teal noise is a term used to describe noise with a power spectral density that increases at a rate higher than blue noise.
// It emphasizes higher frequencies more than blue noise.
public class TealNoise : NoiseBase
{
    private readonly INoiseAlgorithm _whiteNoise;

    public TealNoise(INoiseAlgorithmArgs args) : base(args)
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

        var baseNoiseData = _whiteNoise.GenerateRaw();

        for (var i = 0; i < totalSize; i++)
        {
            var baseNoiseValue = baseNoiseData[i];

            // Apply custom transformation to achieve teal-like characteristics
            var tealNoiseValue = Math.Sin(2.0 * Math.PI * baseNoiseValue);

            result[i] = tealNoiseValue;
        }

        return result;
    }

    public override double GenerateSingleSampleRaw()
    {
        throw new NotImplementedException("Teal noise is generated for the entire grid, so generating a single sample is not applicable.");
    }
}