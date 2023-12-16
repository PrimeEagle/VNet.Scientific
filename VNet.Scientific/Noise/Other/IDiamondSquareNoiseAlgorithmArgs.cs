namespace VNet.Scientific.Noise.Other
{
    public interface IDiamondSquareNoiseAlgorithmArgs : INoiseAlgorithmArgs
    {
        public double Roughness { get; set; }
    }
}