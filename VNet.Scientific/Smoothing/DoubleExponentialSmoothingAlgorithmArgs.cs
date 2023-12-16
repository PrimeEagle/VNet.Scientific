namespace VNet.Scientific.Smoothing
{
    public class DoubleExponentialSmoothingAlgorithmArgs : IDoubleExponentialSmoothingAlgorithmArgs
    {
        public double Alpha { get; set; }
        public double Beta { get; set; }
    }
}