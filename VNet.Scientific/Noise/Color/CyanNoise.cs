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
        var totalSize = Args.Dimensions.Aggregate(1, (acc, val) => acc * val);

        var blueArgs = new BlueNoiseAlgorithmArgs()
        {
            Dimensions = Args.Dimensions,
            RandomDistributionAlgorithm = Args.RandomDistributionAlgorithm,
            OutputFilter = null,
            Scale = 1,
            QuantizeLevel = 0,
            MaxAttempts = 35,
            Radius = 0.5
        };
        _blueNoise = new BlueNoise(blueArgs);

        var greenArgs = new NoiseAlgorithmArgs()
        {
            Dimensions = Args.Dimensions,
            RandomDistributionAlgorithm = Args.RandomDistributionAlgorithm,
            OutputFilter = null,
            Scale = 1,
            QuantizeLevel = 0,
        };
        _greenNoise = new GreenNoise(greenArgs);
        _blueNoiseWeight = ((ICyanNoiseAlgorithmArgs)Args).BlueNoiseWeight;
        _greenNoiseWeight = ((ICyanNoiseAlgorithmArgs)Args).GreenNoiseWeight;
    }

    public override double[] GenerateRaw()
    {
        var totalSize = Args.Dimensions.Aggregate(1, (acc, val) => acc * val);
        var result = new double[totalSize];

        var blueNoiseData = _blueNoise.Generate();
        var greenNoiseData = _greenNoise.Generate();

        for (var i = 0; i < totalSize; i++)
        {
            var blueNoiseValue = blueNoiseData[i];
            var greenNoiseValue = greenNoiseData[i];
            result[i] = _blueNoiseWeight * blueNoiseValue + _greenNoiseWeight * greenNoiseValue;
        }

        return result;
    }

    public override double GenerateSingleSampleRaw()
    {
        throw new NotImplementedException("Cyan noise is generated for the entire grid, so generating a single sample is not applicable.");
    }
}