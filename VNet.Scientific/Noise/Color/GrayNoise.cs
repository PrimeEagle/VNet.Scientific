// ReSharper disable UnusedMember.Global
// ReSharper disable SuggestBaseTypeForParameterInConstructor
namespace VNet.Scientific.Noise.Color;

// Gray noise is a variation of pink noise with a more balanced power spectral density distribution across the frequency spectrum.It is designed to have an equal
// amount of energy in each octave, resulting in a pleasing and natural sound.
public class GrayNoise : NoiseBase
{
    private readonly INoiseAlgorithm _blueNoise;
    private readonly INoiseAlgorithm _whiteNoise;

    public GrayNoise(IGrayNoiseAlgorithmArgs args):base(args)
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

        var whiteArgs = Args.Clone();
        whiteArgs.OutputFilter = null;
        whiteArgs.Scale = 1;
        whiteArgs.QuantizeLevels = 0;
        _whiteNoise = new WhiteNoise(whiteArgs);
    }

    public override double[,] GenerateRaw()
    {
        var blueNoiseData = _blueNoise.Generate();
        var whiteNoiseData = _whiteNoise.Generate();

        var result = new double[Args.Height, Args.Width];
        for (var i = 0; i < Args.Height; i++)
            for (var j = 0; j < Args.Width; j++)
            {
                var blueNoiseValue = blueNoiseData[i, j];
                var whiteNoiseValue = whiteNoiseData[i, j];

                var grayNoiseValue = ((IGrayNoiseAlgorithmArgs)Args).BlueNoiseWeight * blueNoiseValue + ((IGrayNoiseAlgorithmArgs)Args).WhiteNoiseWeight * whiteNoiseValue;
                result[i, j] = grayNoiseValue;
            }

        return result;
    }

    public override double GenerateSingleSampleRaw()
    {
        throw new NotImplementedException("Gray noise is generated for the entire grid, so generating a single sample is not applicable.");
    }
}