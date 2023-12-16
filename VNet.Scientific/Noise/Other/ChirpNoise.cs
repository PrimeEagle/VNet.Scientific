// ReSharper disable UnusedMember.Global
// ReSharper disable SuggestBaseTypeForParameterInConstructor
using VNet.Scientific.Noise.Color;

namespace VNet.Scientific.Noise.Other;

// Chirp noise is a type of noise signal that exhibits a frequency sweep over time. It starts at a low frequency and gradually increases or
// decreases in frequency. Chirp noise is used in various applications, including audio testing, sonar systems, and signal processing experiments.
public class ChirpNoise : NoiseBase
{
    private readonly INoiseAlgorithm _whiteNoise;

    public ChirpNoise(IChirpNoiseAlgorithmArgs args) : base(args)
    {
        var whiteArgs = Args.Clone();
        whiteArgs.OutputFilter = null;
        whiteArgs.Scale = 1;
        whiteArgs.QuantizeLevel = 0;
        _whiteNoise = new WhiteNoise(whiteArgs);
    }

    public override double GenerateSingleSampleRaw()
    {
        throw new NotImplementedException("Chirp noise is generated for the entire grid, so generating a single sample is not applicable.");
    }

    public override double[] GenerateRaw()
    {
        var totalSize = Args.Dimensions.Aggregate(1, (acc, val) => acc * val);
        var result = new double[totalSize];
        var sampleRate = ((IChirpNoiseAlgorithmArgs)Args).SamplingRate;
        var timeStep = 1.0 / sampleRate;

        for (var flatIndex = 0; flatIndex < totalSize; flatIndex++)
        {
            var coordinates = GetMultiDimensionalIndices(flatIndex, Args.Dimensions);
            var time = timeStep * coordinates[0]; // using the first dimension as the time dimension
            var frequency = GetChirpFrequency(time);
            var noiseValue = _whiteNoise.GenerateSingleSampleRaw();
            result[flatIndex] = noiseValue * Math.Sin(2 * Math.PI * frequency * time);
        }

        return result;
    }

    private double GetChirpFrequency(double time)
    {
        var t = time / ((IChirpNoiseAlgorithmArgs)Args).Duration;
        return ((IChirpNoiseAlgorithmArgs)Args).StartFrequency + (((IChirpNoiseAlgorithmArgs)Args).EndFrequency - ((IChirpNoiseAlgorithmArgs)Args).StartFrequency) * t;
    }
}
