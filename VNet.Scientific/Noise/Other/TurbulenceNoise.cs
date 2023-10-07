// ReSharper disable UnusedMember.Global

// ReSharper disable SuggestBaseTypeForParameterInConstructor
namespace VNet.Scientific.Noise.Other;
// Turbulence noise algorithms combine multiple noise sources or functions to create a more dynamic and turbulent effect. It involves adding or
// multiplying different noise layers with varying scales and amplitudes. Turbulence noise is often used in visual effects, fluid simulations, and
// creating natural textures.
public class TurbulenceNoise : NoiseBase
{
    public TurbulenceNoise(ITurbulenceNoiseAlgorithmArgs args) : base(args)
    {
    }

    public override double GenerateSingleSampleRaw()
    {
        throw new NotImplementedException("Turbulence noise is generated for the entire grid, so generating a single sample is not applicable.");
    }

    public override double[] GenerateRaw()
    {
        var totalSize = Args.Dimensions.Aggregate(1, (acc, val) => acc * val);
        var samples = new double[totalSize];
        var amplitude = 1.0;
        var frequency = 1.0;

        for (var octave = 0; octave < ((ITurbulenceNoiseAlgorithmArgs)Args).Octaves; octave++)
        {
            var argsClone = Args.Clone();
            argsClone.Scale = 1.0;
            argsClone.QuantizeLevel = 1;
            var octaveNoise = ((ITurbulenceNoiseAlgorithmArgs)Args).BaseNoiseAlgorithm.Generate();

            for (var idx = 0; idx < totalSize; idx++)
            {
                samples[idx] += octaveNoise[idx] * amplitude;
            }

            amplitude *= ((ITurbulenceNoiseAlgorithmArgs)Args).Gain;
            frequency *= ((ITurbulenceNoiseAlgorithmArgs)Args).Lacunarity;
        }

        EstimatedMinValue = samples.Min();
        EstimatedMaxValue = samples.Max();

        return samples;
    }
}