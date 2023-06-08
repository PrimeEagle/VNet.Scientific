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
        var blueArgs = new BlueNoiseAlgorithmArgs()
        {
            OutputFilter = null,
            Scale = 1,
            Width = Args.Width,
            Height = Args.Height,
            RandomDistributionAlgorithm = Args.RandomDistributionAlgorithm,
            QuantizeLevels = 0,
            MaxAttempts = 35,
            Radius = 0.5
        };
        _blueNoise = new BlueNoise(blueArgs);

        var violetArgs = Args.Clone();
        violetArgs.OutputFilter = null;
        violetArgs.Scale = 1;
        violetArgs.QuantizeLevels = 0;
        _violetNoise = new VioletNoise(violetArgs);
    }

    public override double[,] GenerateRaw()
    {
        var result = new double[Args.Height, Args.Width];

        var blueNoiseData = _blueNoise.Generate();
        var violetNoiseData = _violetNoise.Generate();

        for (var i = 0; i < Args.Height; i++)
            for (var j = 0; j < Args.Width; j++)
            {
                var blueNoiseValue = blueNoiseData[i, j];
                var violetNoiseValue = violetNoiseData[i, j];
                result[i, j] = ((IAzureNoiseAlgorithmArgs)Args).BlueNoiseWeight * blueNoiseValue + ((IAzureNoiseAlgorithmArgs)Args).VioletNoiseWeight * violetNoiseValue;
            }

        return result;
    }

    public override double GenerateSingleSampleRaw()
    {
        throw new NotImplementedException("Azure noise is generated for the entire grid, so generating a single sample is not applicable.");
    }
}