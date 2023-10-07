namespace VNet.Scientific.Noise.Other
{
    public interface IPoissonNoiseAlgorithmArgs : INoiseAlgorithmArgs
    {
        public double Mean { get; set; }
    }
}