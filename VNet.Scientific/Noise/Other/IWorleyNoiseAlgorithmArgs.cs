namespace VNet.Scientific.Noise.Other
{
    public interface IWorleyNoiseAlgorithmArgs : INoiseAlgorithmArgs
    {
        public int PointCount { get; set; }
    }
}