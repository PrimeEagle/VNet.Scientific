namespace VNet.Scientific.Filter.Arguments
{
    public interface IButterworthBandStopFilterArgs : IButterworthFilterArgs, IBandStopFilterArgs
    {
        public double LowPassBandFrequency { get; set; }
        public double LowStopBandFrequency { get; set; }
        public double HighPassBandFrequency { get; set; }
        public double HighStopBandFrequency { get; set; }
    }
}