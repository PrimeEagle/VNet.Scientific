namespace VNet.Scientific.Noise.Other
{
    public interface IPerlinNoiseAlgorithmArgs : INoiseAlgorithmArgs
    {
        public int Octave { get; set; }
    }
}