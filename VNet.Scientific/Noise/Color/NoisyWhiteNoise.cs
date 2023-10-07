namespace VNet.Scientific.Noise.Color;

// "Noisy white" noise, also known as "noisy white" or "white noise with added noise," refers to white noise that has additional noise components
// mixed in. The additional noise can introduce variations, irregularities, or fluctuations to the white noise signal.
public class NoisyWhiteNoise : NoiseBase
{
    private readonly WhiteNoise _whiteNoise;

    public NoisyWhiteNoise(INoiseAlgorithmArgs args) : base(args)
    {
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

        for (var flatIndex = 0; flatIndex < totalSize; flatIndex++)
        {
            var whiteNoise = _whiteNoise.GenerateSingleSampleRaw();
            var noisyWhiteNoise = whiteNoise;

            for (var i = 0; i < ((INoisyWhiteNoiseAlgorithmArgs)Args).NoiseIterations; i++)
            {
                var noise = _whiteNoise.GenerateSingleSampleRaw() * 2.0 - 1.0;
                noisyWhiteNoise += noise * ((INoisyWhiteNoiseAlgorithmArgs)Args).NoiseScale;
            }

            result[flatIndex] = noisyWhiteNoise;
        }

        return result;
    }

    private int GetTotalSize(int[] dimensions)
    {
        return dimensions.Aggregate(1, (a, b) => a * b);
    }

    public override double GenerateSingleSampleRaw()
    {
        var whiteNoise = _whiteNoise.GenerateSingleSampleRaw();
        var noisyWhiteNoise = whiteNoise;

        for (var i = 0; i < ((INoisyWhiteNoiseAlgorithmArgs)Args).NoiseIterations; i++)
        {
            var noise = _whiteNoise.GenerateSingleSampleRaw() * 2.0 - 1.0;
            noisyWhiteNoise += noise * ((INoisyWhiteNoiseAlgorithmArgs)Args).NoiseScale;
        }

        return noisyWhiteNoise;
    }
}