// ReSharper disable UnusedMember.Global

namespace VNet.Scientific.Noise.Other;
// Fractal noise, also known as Fractional Brownian Motion (fBm), is a way of combining multiple layers of noise to create a more complex and
// rich output. Each layer of noise is typically called an "octave", and each octave is given a frequency and an amplitude.
public class FractalNoise : NoiseBase
{
    public FractalNoise(IFractalNoiseAlgorithmArgs args)
        : base(args)
    { }

    public override double GenerateSingleSampleRaw()
    {
        double frequency = 1;
        double amplitude = 1;
        double total = 0;

        for (var octave = 0; octave < ((IFractalNoiseAlgorithmArgs)Args).Octaves; octave++)
        {
            var dimensions = Args.Dimensions.Select(dim => (int)(dim * frequency)).ToArray();
            var noise = ((IFractalNoiseAlgorithmArgs)Args).BaseNoiseAlgorithm.GenerateSingleSample();

            total += noise * amplitude;
            frequency *= ((IFractalNoiseAlgorithmArgs)Args).Lacunarity;
            amplitude *= ((IFractalNoiseAlgorithmArgs)Args).Gain;
        }

        return total;
    }

    public override double[] GenerateRaw()
    {
        var totalSize = Args.Dimensions.Aggregate(1, (acc, val) => acc * val);
        var samples = new double[totalSize];

        for (var i = 0; i < totalSize; i++)
        {
            samples[i] = GenerateSingleSampleRaw();
        }

        return samples;
    }
}