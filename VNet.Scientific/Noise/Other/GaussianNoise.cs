// ReSharper disable UnusedMember.Global

namespace VNet.Scientific.Noise.Other;
// Gaussian noise, also known as normal noise, is a type of noise that follows a Gaussian or normal distribution. It is characterized by random
// fluctuations with a bell-shaped distribution. Gaussian noise is commonly used in simulations, statistical modeling,
// and as a model for various noise sources.
public class GaussianNoise : NoiseBase
{
    private double _mean;
    private double _stdDev;

    public GaussianNoise(INoiseAlgorithmArgs args, double mean = 0.0, double stdDev = 1.0) : base(args)
    {
        _mean = mean;
        _stdDev = stdDev;
    }

    public override double GenerateSingleSampleRaw()
    {
        return NextGaussian(_mean, _stdDev) * Args.Scale;
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

    private double NextGaussian(double mean, double stdDev)
    {
        // Using the Box-Muller transform
        var u1 = 1.0 - GetRandomValue(); // Uniform(0,1] random doubles
        var u2 = 1.0 - GetRandomValue();

        var randStdNormal = Math.Sqrt(-2.0 * Math.Log(u1)) * Math.Sin(2.0 * Math.PI * u2); // random normal (0,1)
        var randNormal = mean + stdDev * randStdNormal; // random normal(mean, stdDev^2)

        return randNormal;
    }
}
