//namespace VNet.Scientific.Noise.Color;

//// White noise is characterized as having equal intensity at different frequencies, giving it a flat spectral density.
//// In the context of random numbers, white noise is typically represented as a sequence of numbers that are statistically
//// independent and identically distributed.
//public class WhiteNoise : NoiseBase
//{
//    public WhiteNoise(INoiseAlgorithmArgs args) : base(args)
//    {
//    }

//    public override double GenerateSingleSampleRaw()
//    {
//        var sample = Args.RandomDistributionAlgorithm.NextDouble();
        
//        return sample;
//    }
//}