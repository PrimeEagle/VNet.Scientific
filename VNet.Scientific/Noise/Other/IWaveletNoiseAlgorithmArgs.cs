namespace VNet.Scientific.Noise.Other
{
    public interface IWaveletNoiseAlgorithmArgs : INoiseAlgorithmArgs
    {
        public int Octaves { get; set; }
        public double Lacunarity { get; set; }
        public double Gain { get; set; }
        public double Frequency { get; set; }
        public double Amplitude { get; set; }
    }
}