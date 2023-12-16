// ReSharper disable UnusedMember.Global
// ReSharper disable SuggestBaseTypeForParameterInConstructor
namespace VNet.Scientific.Noise.Color;

// Gray noise is a variation of pink noise with a more balanced power spectral density distribution across the frequency spectrum.It is designed to have an equal
// amount of energy in each octave, resulting in a pleasing and natural sound.
public class GrayNoise : NoiseBase
{
    private readonly INoiseAlgorithm _blueNoise;
    private readonly INoiseAlgorithm _whiteNoise;

    public GrayNoise(IGrayNoiseAlgorithmArgs args) : base(args)
    {
        var blueArgs = new BlueNoiseAlgorithmArgs()
        {
            OutputFilter = null,
            Scale = 1,
            Dimensions = Args.Dimensions,
            RandomDistributionAlgorithm = Args.RandomDistributionAlgorithm,
            QuantizeLevel = 0,
            // Assuming MaxAttempts and Radius are constants for the BlueNoise in any dimensions
            MaxAttempts = 35,
            Radius = 0.5
        };
        _blueNoise = new BlueNoise(blueArgs);

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

        var blueNoiseData = _blueNoise.GenerateRaw();
        var whiteNoiseData = _whiteNoise.GenerateRaw();

        for (var i = 0; i < totalSize; i++)
        {
            var blueNoiseValue = blueNoiseData[i];
            var whiteNoiseValue = whiteNoiseData[i];

            var grayNoiseValue = ((IGrayNoiseAlgorithmArgs)Args).BlueNoiseWeight * blueNoiseValue + ((IGrayNoiseAlgorithmArgs)Args).WhiteNoiseWeight * whiteNoiseValue;
            result[i] = grayNoiseValue;
        }

        return result;
    }

    private int GetTotalSize(int[] dimensions)
    {
        return dimensions.Aggregate(1, (a, b) => a * b);
    }

    public override double GenerateSingleSampleRaw()
    {
        throw new NotImplementedException("Gray noise is generated for the entire grid, so generating a single sample is not applicable.");
    }
}