﻿// ReSharper disable UnusedMember.Global
// ReSharper disable SuggestBaseTypeForParameterInConstructor
namespace VNet.Scientific.Noise.Color;

// Red noise is also known as "1/f^2 noise" or "flicker noise". It is a type of noise signal with a power spectrum that decreases by 6 dB per octave,
// following a 1/f^2 frequency dependence.
public class RedNoise : NoiseBase
{
    public RedNoise(IRedNoiseAlgorithmArgs args) : base(args)
    {
    }

    public override double GenerateSingleSampleRaw()
    {
        var sample = Args.RandomDistributionAlgorithm.NextDouble() * 2.0 - 1.0;

        // Calculate total size across all dimensions
        var totalSize = Args.Dimensions.Aggregate(1, (acc, val) => acc * val);

        var frequency = ((IRedNoiseAlgorithmArgs)Args).SamplingRate / totalSize;
        sample /= Math.Sqrt(frequency);

        return sample;
    }
}