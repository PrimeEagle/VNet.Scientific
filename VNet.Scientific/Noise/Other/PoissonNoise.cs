// ReSharper disable UnusedMember.Global

namespace VNet.Scientific.Noise.Other;
// Poisson noise is a type of noise that arises from the statistical nature of photon or particle arrival events in imaging or sensing
// applications. It is characterized by random fluctuations that follow a Poisson distribution. Poisson noise can be simulated by modeling
// the arrival of discrete events according to the Poisson process.
public class PoissonNoise : NoiseBase
{
    public PoissonNoise(IPoissonNoiseAlgorithmArgs args)
        : base(args)
    {
    }

    public override double GenerateSingleSampleRaw()
    {
        // Since PoissonNoise generates values for the entire grid, a single raw sample is just one instance of Poisson noise.
        return GeneratePoissonRandomValue();
    }

    public override double[] GenerateRaw()
    {
        var totalSize = Args.Dimensions.Aggregate(1, (acc, val) => acc * val);
        var result = new double[totalSize];

        for (var i = 0; i < totalSize; i++)
        {
            var randomValue = GeneratePoissonRandomValue();
            result[i] = randomValue;
        }

        return result;
    }

    private double GeneratePoissonRandomValue()
    {
        var L = Math.Exp(-((IPoissonNoiseAlgorithmArgs)Args).Mean);
        var p = 1.0;
        var k = 0;

        do
        {
            k++;
            p *= GetRandomValue();
        } while (p > L);

        return k - 1;
    }
}