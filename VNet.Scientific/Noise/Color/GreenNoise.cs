// ReSharper disable UnusedMember.Global

namespace VNet.Scientific.Noise.Color;

// Green noise, also known as mid-frequency noise, is a specific type of noise used in halftone dithering for image processing.
// It refers to a noise signal that emphasizes the mid-frequency range while reducing the low and high frequencies. This type of noise
// helps create smooth transitions and gradients in images.
public class GreenNoise : NoiseBase
{
    private readonly WhiteNoise _whiteNoise;

    public GreenNoise(INoiseAlgorithmArgs args) : base(args)
    {
        var whiteArgs = Args.Clone();
        whiteArgs.OutputFilter = null;
        whiteArgs.Scale = 1;
        whiteArgs.QuantizeLevel = 0;
        _whiteNoise = new WhiteNoise(whiteArgs);
    }

    public override double GenerateSingleSampleRaw()
    {
        var whiteNoise = _whiteNoise.GenerateSingleSampleRaw();

        // Assuming we take the product of all dimensions for the green noise calculation
        var productOfDimensions = Args.Dimensions.Aggregate(1, (acc, dim) => acc * dim);

        var greenNoise = whiteNoise * (1 - Math.Abs(Math.Sin(productOfDimensions * 2 * Math.PI)));
        return greenNoise;
    }
}