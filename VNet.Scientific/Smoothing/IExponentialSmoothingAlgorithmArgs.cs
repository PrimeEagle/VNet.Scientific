namespace VNet.Scientific.Smoothing
{
    public interface IExponentialSmoothingAlgorithmArgs : ISmoothingAlgorithmArgs
    {
        public double Alpha { get; set; }
    }
}