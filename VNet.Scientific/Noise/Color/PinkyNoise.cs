// ReSharper disable UnusedMember.Global

// ReSharper disable SuggestBaseTypeForParameterInConstructor

namespace VNet.Scientific.Noise.Color;

// Pinky noise is a variation of pink noise that exhibits a more natural, organic texture. It is generated using a combination of fractal
// algorithms, filtering techniques, or a combination of other noise types. Pinky noise is used in audio synthesis, sound design, and
// generating natural soundscapes.
public class PinkyNoise : NoiseBase
{
    private readonly INoiseAlgorithm _whiteNoise;

    public PinkyNoise(IPinkyNoiseAlgorithmArgs args) : base(args)
    {
        var whiteArgs = Args.Clone();
        whiteArgs.OutputFilter = null;
        whiteArgs.Scale = 1;
        whiteArgs.QuantizeLevels = 0;
        _whiteNoise = new WhiteNoise(whiteArgs);
    }

    public override double[,] GenerateRaw()
    {
        var width = Args.Width;
        var height = Args.Height;

        var result = new double[height, width];
        var whiteNoise = _whiteNoise.GenerateRaw();

        for (var i = 0; i < height; i++)
            for (var j = 0; j < width; j++)
            {
                var sample = whiteNoise[i, j];

                for (var k = 1; k <= ((IPinkyNoiseAlgorithmArgs)Args).NumSteps; k++)
                {
                    var randomStep = (2 * Args.RandomDistributionAlgorithm.NextDouble() - 1) * ((IPinkyNoiseAlgorithmArgs)Args).StepSize;
                    sample += randomStep / (k * k);
                }

                result[i, j] = sample * Args.Scale;
            }

        return result;
    }

    public override double GenerateSingleSampleRaw()
    {
        throw new NotImplementedException("Pinky noise is generated for the entire grid, so generating a single sample is not applicable.");
    }
}