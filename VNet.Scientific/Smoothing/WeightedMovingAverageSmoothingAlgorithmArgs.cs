namespace VNet.Scientific.Smoothing
{
    public class WeightedMovingAverageSmoothingAlgorithmArgs : IWeightedMovingAverageSmoothingAlgorithmArgs
    {
        public int WindowSize { get; set; }
        public double[] Weights { get; set; }
    }
}