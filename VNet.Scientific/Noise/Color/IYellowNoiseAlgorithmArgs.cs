namespace VNet.Scientific.Noise.Color
{
    public interface IYellowNoiseAlgorithmArgs : INoiseAlgorithmArgs
    {
        public double SamplingRate { get; set; }
        public int Octaves { get; set; }
    }
}