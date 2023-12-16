namespace VNet.Scientific.Smoothing
{
    public interface IDoubleExponentialSmoothingAlgorithmArgs : ISmoothingAlgorithmArgs
    {
        public double Alpha { get; set; }
        public double Beta { get; set; }
    }
}