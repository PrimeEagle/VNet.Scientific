namespace VNet.Scientific.Smoothing
{
    public interface IMovingAverageSmoothingAlgorithmArgs : ISmoothingAlgorithmArgs
    {
        public int WindowSize { get; set; }
    }
}