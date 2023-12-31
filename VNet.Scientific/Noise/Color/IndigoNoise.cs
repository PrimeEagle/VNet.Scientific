﻿// ReSharper disable UnusedMember.Global
// ReSharper disable SuggestBaseTypeForParameterInConstructor
namespace VNet.Scientific.Noise.Color;

// Indigo noise is a less common term, but it has been used to describe noise with a power spectral density that increases more steeply
// than blue noise as the frequency increases. It emphasizes higher frequencies to a greater extent than blue noise.
public class IndigoNoise : NoiseBase
{
    private readonly INoiseAlgorithm _blueNoise;
    private readonly INoiseAlgorithm _whiteNoise;
    private readonly INoiseAlgorithm _grayNoise;

    public IndigoNoise(IIndigoNoiseAlgorithmArgs args) : base(args)
    {
        var blueArgs = new BlueNoiseAlgorithmArgs()
        {
            OutputFilter = null,
            Scale = 1,
            Dimensions = Args.Dimensions,
            RandomDistributionAlgorithm = Args.RandomDistributionAlgorithm,
            QuantizeLevel = 0,
            // Additional properties specific to BlueNoise may need adjusting for n-dimensions.
            MaxAttempts = 35,
            Radius = 0.5
        };
        _blueNoise = new BlueNoise(blueArgs);

        var whiteArgs = Args.Clone();
        whiteArgs.OutputFilter = null;
        whiteArgs.Scale = 1;
        whiteArgs.QuantizeLevel = 0;
        _whiteNoise = new WhiteNoise(whiteArgs);

        var grayArgs = new GrayNoiseAlgorithmArgs()
        {
            OutputFilter = null,
            Scale = 1,
            Dimensions = Args.Dimensions,
            RandomDistributionAlgorithm = Args.RandomDistributionAlgorithm,
            QuantizeLevel = 0,
            BlueNoiseWeight = 0.5,
            WhiteNoiseWeight = 0.5
        };
        _grayNoise = new GrayNoise(grayArgs);
    }

    public override double[] GenerateRaw()
    {
        var totalSize = Args.Dimensions.Aggregate(1, (acc, val) => acc * val);
        var result = new double[totalSize];

        var blueNoiseData = _blueNoise.GenerateRaw();
        var whiteNoiseData = _whiteNoise.GenerateRaw();
        var grayNoiseData = _grayNoise.GenerateRaw();

        for (var i = 0; i < totalSize; i++)
        {
            var blueNoiseValue = blueNoiseData[i];
            var whiteNoiseValue = whiteNoiseData[i];
            var grayNoiseValue = grayNoiseData[i];

            var indigoNoiseValue = ((IIndigoNoiseAlgorithmArgs)Args).BlueNoiseWeight * blueNoiseValue + ((IIndigoNoiseAlgorithmArgs)Args).WhiteNoiseWeight * whiteNoiseValue + ((IIndigoNoiseAlgorithmArgs)Args).GrayNoiseWeight * grayNoiseValue;
            result[i] = indigoNoiseValue * Args.Scale;
        }

        return result;
    }

    public override double GenerateSingleSampleRaw()
    {
        throw new NotImplementedException("Indigo noise is generated for the entire grid, so generating a single sample is not applicable.");
    }
}