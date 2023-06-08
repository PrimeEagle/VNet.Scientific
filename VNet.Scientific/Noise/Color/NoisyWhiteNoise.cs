namespace VNet.Scientific.Noise.Color;

// "Noisy white" noise, also known as "noisy white" or "white noise with added noise," refers to white noise that has additional noise components
// mixed in. The additional noise can introduce variations, irregularities, or fluctuations to the white noise signal.
public class NoisyWhiteNoise : NoiseBase
{
    private readonly INoiseAlgorithm _whiteNoise;

    public NoisyWhiteNoise(INoiseAlgorithmArgs args) : base(args)
    {
        var whiteArgs = Args.Clone();
        whiteArgs.OutputFilter = null;
        whiteArgs.Scale = 1;
        whiteArgs.QuantizeLevels = 0;
        _whiteNoise = new WhiteNoise(whiteArgs);
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