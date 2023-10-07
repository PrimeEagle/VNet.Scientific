namespace VNet.Scientific.Noise.Color
{
    public interface IOrangeNoiseAlgorithmArgs : INoiseAlgorithmArgs
    {
        public double SamplingRate { get; set; }
        public double Exponent { get; set; }
        public int Octaves { get; set; }
    }
}