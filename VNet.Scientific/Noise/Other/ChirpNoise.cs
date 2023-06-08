// ReSharper disable UnusedMember.Global
// ReSharper disable SuggestBaseTypeForParameterInConstructor

using VNet.Scientific.Noise.Color;

namespace VNet.Scientific.Noise.Other;

// Chirp noise is a type of noise signal that exhibits a frequency sweep over time. It starts at a low frequency and gradually increases or
// decreases in frequency. Chirp noise is used in various applications, including audio testing, sonar systems, and signal processing experiments.
public class ChirpNoise : NoiseBase
{
    private readonly INoiseAlgorithm _whiteNoise;

    public ChirpNoise(IChirpNoiseAlgorithmArgs args):base(args)
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
        var sampleRate = ((IChirpNoiseAlgorithmArgs)Args).SamplingRate;

        var result = new double[height, width];
        var timeStep = 1.0 / sampleRate;

        for (var i = 0; i < height; i++)
        {
            var time = 0.0;
            var frequency = ((IChirpNoiseAlgorithmArgs)Args).StartFrequency;

            for (var j = 0; j < width; j++)
            {
                var noiseValue = _whiteNoise.GenerateSingleSampleRaw();
                result[i, j] = noiseValue * Math.Sin(2 * Math.PI * frequency * time);
                time += timeStep;
                frequency = GetChirpFrequency(time);
            }
        }

        return result;
    }

    public override double GenerateSingleSampleRaw()
    {
        throw new NotImplementedException("Chirp noise is generated for the entire grid, so generating a single sample is not applicable.");
    }

    private double GetChirpFrequency(double time)
    {
        var t = time / ((IChirpNoiseAlgorithmArgs)Args).Duration;

        return ((IChirpNoiseAlgorithmArgs)Args).StartFrequency + (((IChirpNoiseAlgorithmArgs)Args).EndFrequency - ((IChirpNoiseAlgorithmArgs)Args).StartFrequency) * t;
    }
}