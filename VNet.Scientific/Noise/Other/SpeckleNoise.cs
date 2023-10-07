// ReSharper disable UnusedMember.Global

namespace VNet.Scientific.Noise.Other;
// Speckle noise is a type of noise commonly found in radar or ultrasound imaging.It appears as a granular or textured pattern,
// similar to the noise produced by scattering of coherent waves. Speckle noise can be simulated by applying random variations to image pixels or
// by using statistical models.
public class SpeckleNoise : NoiseBase
{
    public SpeckleNoise(ISpeckleNoiseAlgorithmArgs args) : base(args)
    {
    }

    public override double GenerateSingleSampleRaw()
    {
        return (GetRandomValue() * 2 - 1) * ((ISpeckleNoiseAlgorithmArgs)Args).Intensity;
    }

    public override double[] GenerateRaw()
    {
        var totalSize = Args.Dimensions.Aggregate(1, (acc, val) => acc * val);
        var samples = new double[totalSize];

        for (var idx = 0; idx < totalSize; idx++)
        {
            samples[idx] = GenerateSingleSampleRaw();
        }

        return samples;
    }
}