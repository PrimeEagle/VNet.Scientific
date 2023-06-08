// ReSharper disable UnusedMember.Global

namespace VNet.Scientific.Noise.Other;

// Digital noise refers to noise that is introduced during digital signal processing or data acquisition. It can occur due to quantization errors,
// sampling limitations, or processing artifacts. Digital noise can manifest as random fluctuations, quantization noise, or other distortions in digital signals.
public class DigitalNoise : NoiseBase
{
    public DigitalNoise(INoiseAlgorithmArgs args) : base(args)
    {
    }

    public override double[,] GenerateRaw()
    {
        var width = Args.Width;
        var height = Args.Height;

        var result = new double[height, width];

        for (var i = 0; i < height; i++)
            for (var j = 0; j < width; j++)
            {
                var randomValue = Args.RandomDistributionAlgorithm.NextDouble();
                var quantizedValue = (int)(randomValue * Args.QuantizeLevels);
                var scaledValue = quantizedValue / (double)(Args.QuantizeLevels - 1);
                result[i, j] = scaledValue * Args.Scale;
            }

        return result;
    }

    public override double GenerateSingleSampleRaw()
    {
        throw new NotImplementedException("Digital noise is generated for the entire grid, so generating a single sample is not applicable.");
    }
}