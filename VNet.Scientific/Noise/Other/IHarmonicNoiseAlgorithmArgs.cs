namespace VNet.Scientific.Noise.Other
{
    public interface IHarmonicNoiseAlgorithmArgs : INoiseAlgorithmArgs
    {
        double[] Frequencies { get; set; }
        double[] Amplitudes { get; set; }
        double SampleRate { get; set; }
    }
}