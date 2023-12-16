namespace VNet.Scientific.Noise.Color
{
    public interface IRedNoiseAlgorithmArgs : INoiseAlgorithmArgs
    {
        public double SamplingRate { get; set; }
    }
}