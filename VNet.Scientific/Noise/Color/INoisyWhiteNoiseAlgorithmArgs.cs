namespace VNet.Scientific.Noise.Color
{
    public interface INoisyWhiteNoiseAlgorithmArgs : INoiseAlgorithmArgs
    {
        public double NoiseScale { get; set; }
        public int NoiseIterations { get; set; }
    }
}