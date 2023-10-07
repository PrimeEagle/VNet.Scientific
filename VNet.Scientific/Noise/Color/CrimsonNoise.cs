// ReSharper disable UnusedMember.Global
// ReSharper disable SuggestBaseTypeForParameterInConstructor
namespace VNet.Scientific.Noise.Color;

// Crimson noise is a term occasionally used to describe noise with a power spectral density that increases at a rate higher than
// red (brown) noise. It emphasizes higher frequencies more than red noise.
public class CrimsonNoise : NoiseBase
{
    private readonly INoiseAlgorithm _redNoise;
    private readonly INoiseAlgorithm _violetNoise;

    public CrimsonNoise(ICrimsonNoiseAlgorithmArgs args) : base(args)
    {
        var totalSize = Args.Dimensions.Aggregate(1, (acc, val) => acc * val);

        var redArgs = new RedNoiseAlgorithmArgs()
        {
            Dimensions = Args.Dimensions,
            OutputFilter = null,
            Scale = 1,
            SamplingRate = 44100,
            RandomDistributionAlgorithm = Args.RandomDistributionAlgorithm,
            QuantizeLevel = 0
        };
        _redNoise = new RedNoise(redArgs);

        var violetArgs = new NoiseAlgorithmArgs()
        {
            Dimensions = Args.Dimensions,
            OutputFilter = null,
            Scale = 1,
            QuantizeLevel = 0,
            RandomDistributionAlgorithm = Args.RandomDistributionAlgorithm,
        };
        _violetNoise = new VioletNoise(violetArgs);
    }

    public override double[] GenerateRaw()
    {
        var totalSize = Args.Dimensions.Aggregate(1, (acc, val) => acc * val);
        var result = new double[totalSize];

        var redNoiseData = _redNoise.Generate();
        var violetNoiseData = _violetNoise.Generate();

        for (var i = 0; i < totalSize; i++)
        {
            var redNoiseValue = redNoiseData[i];
            var violetNoiseValue = violetNoiseData[i];
            result[i] = ((ICrimsonNoiseAlgorithmArgs)Args).RedNoiseWeight * redNoiseValue + ((ICrimsonNoiseAlgorithmArgs)Args).VioletNoiseWeight * violetNoiseValue;
        }

        return result;
    }

    public override double GenerateSingleSampleRaw()
    {
        throw new NotImplementedException("Crimson noise is generated for the entire grid, so generating a single sample is not applicable.");
    }
}