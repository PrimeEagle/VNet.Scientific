namespace VNet.Scientific.Noise.Color
{
    public interface IGoldNoiseAlgorithmArgs : INoiseAlgorithmArgs
    {
        public int Octaves { get; set; }
        public double SamplingRate { get; set; }
    }
}