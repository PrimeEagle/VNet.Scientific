//// ReSharper disable UnusedMember.Global
//namespace VNet.Scientific.Noise.Color;

//// Pink noise, also known as 1/f noise, has equal energy in all octaves (or similar log bundles) of frequency. In terms of power at a constant
//// bandwidth, pink noise falls off at 3 dB per octave. Generating pink noise is more complicated than white or violet noise, as it requires more
//// advanced signal processing techniques.A common method to generate pink noise is using IIR (Infinite Impulse Response) filters, but it
//// involves quite a complex logic. Here is a simple approximation in C#, using the Stochastic Difference Equation method, often known as the
//// IIR Filter method, or the Stochastic Difference Equation.
//public class PinkNoise : NoiseBase
//{
//    private readonly WhiteNoise _whiteNoise;

//    public PinkNoise(INoiseAlgorithmArgs args):base(args)
//    {
//        var whiteArgs = Args.Clone();
//        whiteArgs.OutputFilter = null;
//        whiteArgs.Scale = 1;
//        whiteArgs.QuantizeLevel = 0;
//        _whiteNoise = new WhiteNoise(whiteArgs);
//    }

//    public override double GenerateSingleSampleRaw()
//    {
//        var pinkNoise = 0.0;
//        var frequency = ((IPinkNoiseAlgorithmArgs)Args).SamplingRate / Args.Width; // Compute frequency based on sample rate and width

//        for (var octave = 1; octave <= ((IPinkNoiseAlgorithmArgs)Args).Octaves; octave++)
//        {
//            var amplitude = 1.0 / Math.Sqrt(frequency);
//            pinkNoise += _whiteNoise.GenerateSingleSampleRaw() * 2.0 - 1.0 * amplitude;
//            frequency *= 2.0; // Double the frequency for the next octave
//        }

//        return pinkNoise;
//    }
//}