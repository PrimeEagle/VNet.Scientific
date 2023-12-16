namespace VNet.Scientific.Smoothing
{
    public interface ITripleExponentialSmoothingAlgorithmArgs :ISmoothingAlgorithmArgs
    {
        public double Alpha { get; set; }
        public double Beta { get; set; }
        public double Gamma { get; set; }
        public int SeasonalPeriod { get; set; }
    }
}