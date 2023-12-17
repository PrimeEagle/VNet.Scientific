namespace VNet.Scientific.Noise.Other
{
    public interface IDeltaNoiseAlgorithmArgs : INoiseAlgorithmArgs
    {
        public int DeltaIndex { get; set; }
        public double DeltaValue { get; set; }
    }
}