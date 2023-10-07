// ReSharper disable UnusedMember.Global

using VNet.Mathematics.Randomization.Distribution;

namespace VNet.Scientific.Noise.Other;
// Exponential noise is a type of noise that follows an exponential distribution. It is characterized by a rapid initial decay and a
// long tail. Exponential noise can be used to model phenomena with decay or exponential growth processes.
public class ExponentialNoise : NoiseBase
{
    private double _lambda;

    public ExponentialNoise(double lambda, INoiseAlgorithmArgs args) : base(args)
    {
        _lambda = lambda;
    }

    public override double GenerateSingleSampleRaw()
    {
        return GenerateExponentialRandomValue(_lambda);
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

    private double GenerateExponentialRandomValue(double lambda)
    {
        var uniformRandomValue = Args.RandomDistributionAlgorithm.NextDouble();
        return -Math.Log(1 - uniformRandomValue) / lambda;
    }
}