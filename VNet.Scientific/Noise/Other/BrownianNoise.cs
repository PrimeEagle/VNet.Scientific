// ReSharper disable UnusedMember.Global
// ReSharper disable SuggestBaseTypeForParameterInConstructor
namespace VNet.Scientific.Noise.Other;

// Brownian noise, also known as Brown noise or red noise, is a type of noise signal that has a power spectrum that decreases by 3 dB per
// octave. It is named "Brownian" after the random motion of particles in Brownian motion, which exhibits similar characteristics.
public class BrownianNoise : NoiseBase
{
    private readonly PerlinNoise _perlinNoise;

    public BrownianNoise(IBrownianNoiseAlgorithmArgs args)
        : base(args)
    {
        var perlinArgs = new PerlinNoiseAlgorithmArgs()
        {
            Dimensions = args.Dimensions,
            NormalizeOutput = args.NormalizeOutput,
            Scale = args.Scale,
            DesiredMinValue = args.DesiredMinValue,
            DesiredMaxValue = args.DesiredMaxValue,
            RandomDistributionAlgorithm = args.RandomDistributionAlgorithm
        };

        _perlinNoise = new PerlinNoise(perlinArgs);
    }

    public override double GenerateSingleSampleRaw()
    {
        double total = 0;
        var amplitude = ((IBrownianNoiseAlgorithmArgs)Args).Amplitude;
        var octaves = ((IBrownianNoiseAlgorithmArgs)Args).Octaves;
        var frequency = ((IBrownianNoiseAlgorithmArgs)Args).Frequency;

        for (var i = 0; i < octaves; i++)
        {
            total += _perlinNoise.GenerateSingleSampleRaw() * amplitude;
            frequency *= 2.0;  // double the frequency with each octave
            amplitude *= 0.5;  // halve the amplitude with each octave
            ((IBrownianNoiseAlgorithmArgs)Args).Scale = frequency; // Update the scale for Perlin noise to adjust for the new frequency
        }

        return total;
    }
}