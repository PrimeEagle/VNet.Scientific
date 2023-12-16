namespace VNet.Scientific.Noise.Other
{
    public interface IVoronoiNoiseAlgorithmArgs : INoiseAlgorithmArgs
    {
        public int PointCount { get; set; }
    }
}