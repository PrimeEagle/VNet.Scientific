namespace VNet.Scientific.Noise.Other
{
    public interface ILSystemsNoiseAlgorithmArgs : INoiseAlgorithmArgs
    {
        public Dictionary<char, string> Rules { get; set; }
        public int Iterations { get; set; }
    }
}