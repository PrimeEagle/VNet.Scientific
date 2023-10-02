namespace VNet.Scientific.Smoothing
{
    public interface IWeightedMovingAverageSmoothingAlgorithmArgs : ISmoothingAlgorithmArgs
    {
        public int WindowSize { get; set; }
        public double[] Weights { get; set; }
    }
}