namespace VNet.Scientific.Noise.Other
{
    public interface IGradientPerturbNoiseAlgorithmArgs : INoiseAlgorithmArgs
    {
        INoiseAlgorithm BaseNoise { get; set; }
        double Frequency { get; set; }
        double Amplitude { get; set; }
    }
}