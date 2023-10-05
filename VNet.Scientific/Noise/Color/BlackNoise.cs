// ReSharper disable UnusedMember.Global

namespace VNet.Scientific.Noise.Color;

public class BlackNoise : NoiseBase
{
    private readonly INoiseAlgorithm _whiteNoise;

    public BlackNoise(INoiseAlgorithmArgs args) : base(args)
    {
        var whiteArgs = Args.Clone();
        whiteArgs.OutputFilter = null;
        whiteArgs.Scale = 1;
        whiteArgs.QuantizeLevels = 0;

        _whiteNoise = new WhiteNoise(whiteArgs);
    }

    public override double[] GenerateRaw()
    {
        var whiteNoiseData = _whiteNoise.Generate();

        var totalSize = Args.Dimensions.Aggregate(1, (acc, val) => acc * val);
        var result = new double[totalSize];

        for (var i = 0; i < totalSize; i++)
        {
            var whiteNoiseValue = whiteNoiseData[i];
            result[i] = whiteNoiseValue * Args.Scale;
        }

        return result;
    }

    public override double GenerateSingleSampleRaw()
    {
        throw new NotImplementedException("Black noise is generated for the entire grid, so generating a single sample is not applicable.");
    }
}