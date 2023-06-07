namespace VNet.Scientific.Filtering.Arguments
{
    public interface IButterworthBandPassFilterArgs : IButterworthFilterArgs, IBandPassFilterArgs
    {
        public double LowPassBandFrequency { get; set; }
        public double LowStopBandFrequency { get; set; }
        public double HighPassBandFrequency { get; set; }
        public double HighStopBandFrequency { get; set; }
    }
}