namespace VNet.Scientific.Noise.Other;

public interface IBrownianNoiseAlgorithmArgs : INoiseAlgorithmArgs
{
    int Octaves { get; set; }
    double Frequency { get; set; }
    double Amplitude { get; set; }
}