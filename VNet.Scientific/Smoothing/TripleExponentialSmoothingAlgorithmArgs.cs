namespace VNet.Scientific.Smoothing
{
    public class TripleExponentialSmoothingAlgorithmArgs : ITripleExponentialSmoothingAlgorithmArgs
    {
        public double Alpha { get; set; }
        public double Beta { get; set; }
        public double Gamma { get; set; }
        public int SeasonalPeriod { get; set; }
    }
}