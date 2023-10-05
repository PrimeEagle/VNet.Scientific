// ReSharper disable UnusedMember.Global
// ReSharper disable SuggestBaseTypeForParameterInConstructor
namespace VNet.Scientific.Noise.Color;

// Azure noise, also known as sky-blue noise, is a term used to describe noise with a power spectral density that increases at a
// rate higher than blue noise. It emphasizes higher frequencies more than blue noise.
public class AzureNoise : NoiseBase
{
    private readonly INoiseAlgorithm _blueNoise;
    private readonly INoiseAlgorithm _violetNoise;

    public AzureNoise(IAzureNoiseAlgorithmArgs args) : base(args)
    {
        // Copying properties from the given args to blueArgs
        var blueArgs = (IBlueNoiseAlgorithmArgs)args.Clone();
        blueArgs.OutputFilter = null;
        blueArgs.Scale = 1;
        blueArgs.QuantizeLevels = 0;
        // Additional properties specific to BlueNoise
        // blueArgs.MaxAttempts = 35;
        // blueArgs.Radius = 0.5;
        _blueNoise = new BlueNoise(blueArgs);

        var violetArgs = (INoiseAlgorithmArgs)args.Clone();
        violetArgs.OutputFilter = null;
        violetArgs.Scale = 1;
        violetArgs.QuantizeLevels = 0;
        _violetNoise = new VioletNoise(violetArgs);
    }

    public override double[] GenerateRaw()
    {
        var totalSize = Args.Dimensions.Aggregate(1, (acc, val) => acc * val);
        var result = new double[totalSize];

        var blueNoiseData = _blueNoise.Generate();
        var violetNoiseData = _violetNoise.Generate();

        for (var i = 0; i < totalSize; i++)
        {
            var blueNoiseValue = blueNoiseData[i];
            var violetNoiseValue = violetNoiseData[i];
            result[i] = ((IAzureNoiseAlgorithmArgs)Args).BlueNoiseWeight * blueNoiseValue + ((IAzureNoiseAlgorithmArgs)Args).VioletNoiseWeight * violetNoiseValue;
        }

        return result;
    }

    public override double GenerateSingleSampleRaw()
    {
        throw new NotImplementedException("Azure noise is generated for the entire grid, so generating a single sample is not applicable.");
    }
}
