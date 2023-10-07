// ReSharper disable UnusedMember.Global

namespace VNet.Scientific.Noise.Other;

// Digital noise refers to noise that is introduced during digital signal processing or data acquisition. It can occur due to quantization errors,
// sampling limitations, or processing artifacts. Digital noise can manifest as random fluctuations, quantization noise, or other distortions in digital signals.
public class DigitalNoise : NoiseBase
{
    public DigitalNoise(INoiseAlgorithmArgs args) : base(args)
    {
    }

    public override double GenerateSingleSampleRaw()
    {
        var randomValue = Args.RandomDistributionAlgorithm.NextDouble();
        var quantizedValue = (int)(randomValue * Args.QuantizeLevel);
        var scaledValue = quantizedValue / (double)(Args.QuantizeLevel - 1);
        return scaledValue * Args.Scale;
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