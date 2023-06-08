// ReSharper disable UnusedMember.Global

namespace VNet.Scientific.Noise.Other;

// Brownian noise, also known as Brown noise or red noise, is a type of noise signal that has a power spectrum that decreases by 3 dB per
// octave. It is named "Brownian" after the random motion of particles in Brownian motion, which exhibits similar characteristics.
public class BrownianNoise : NoiseBase
{
    private double _previousSample;


    public BrownianNoise(INoiseAlgorithmArgs args) : base(args)
    {
        _previousSample = 0d;
    }

    public override double GenerateSingleSampleRaw()
    {
        var sample = _previousSample + (Args.RandomDistributionAlgorithm.NextDouble() * 2.0 - 1.0);
        _previousSample = sample;

        return sample;
    }
}