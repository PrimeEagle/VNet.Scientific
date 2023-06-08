// ReSharper disable UnusedMember.Global
// ReSharper disable SuggestBaseTypeForParameterInConstructor
namespace VNet.Scientific.Noise.Color;

// Cyan noise is a term used to describe noise with a power spectral density that increases at a rate between blue noise and white noise.
// It lies between the two in terms of its frequency distribution
public class CyanNoise : NoiseBase
{
    private readonly INoiseAlgorithm _blueNoise;
    private readonly INoiseAlgorithm _greenNoise;
    private readonly double _blueNoiseWeight;
    private readonly double _greenNoiseWeight;

    public CyanNoise(ICyanNoiseAlgorithmArgs args) : base(args)
    {
        var blueArgs = new BlueNoiseAlgorithmArgs()
        {
            Width = Args.Width,
            Height = Args.Height,
            RandomDistributionAlgorithm = Args.RandomDistributionAlgorithm,
            OutputFilter = null,
            Scale = 1,
            QuantizeLevels = 0,
            MaxAttempts = 35,
            Radius = 0.5
        };
        _blueNoise = new BlueNoise(blueArgs);

        var greenArgs = new NoiseAlgorithmArgs()
        {
            Width = Args.Width,
            Height = Args.Height,
            RandomDistributionAlgorithm = Args.RandomDistributionAlgorithm,
            OutputFilter = null,
            Scale = 1,
            QuantizeLevels = 0,
        };
        _greenNoise = new GreenNoise(greenArgs);
        _blueNoiseWeight = ((ICyanNoiseAlgorithmArgs)Args).BlueNoiseWeight;
        _greenNoiseWeight = ((ICyanNoiseAlgorithmArgs)Args).GreenNoiseWeight;
    }

    public override double[,] GenerateRaw()
    {
        var result = new double[Args.Height, Args.Width];
        var blueNoiseData = _blueNoise.Generate();
        var greenNoiseData = _greenNoise.Generate();

        for (var i = 0; i < Args.Height; i++)
            for (var j = 0; j < Args.Width; j++)
            {
                var blueNoiseValue = blueNoiseData[i, j];
                var greenNoiseValue = greenNoiseData[i, j];
                result[i, j] = _blueNoiseWeight * blueNoiseValue + _greenNoiseWeight * greenNoiseValue;
            }

        return result;
    }

    public override double GenerateSingleSampleRaw()
    {
        throw new NotImplementedException("Cyan noise is generated for the entire grid, so generating a single sample is not applicable.");
    }
}