namespace VNet.Scientific.Noise.Other
{
    public interface ITurbulenceNoiseAlgorithmArgs : INoiseAlgorithmArgs
    {
        public int Octaves { get; set; }
        public double Lacunarity { get; set; }
        public double Gain { get; set; }
        public INoiseAlgorithm BaseNoiseAlgorithm { get; set; }
    }
}