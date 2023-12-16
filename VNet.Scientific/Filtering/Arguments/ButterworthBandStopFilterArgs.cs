using VNet.Scientific.Filtering.Algorithms;

namespace VNet.Scientific.Filtering.Arguments
{
    public class ButterworthBandStopFilterArgs : IButterworthBandStopFilterArgs
    {
        public double LowPassBandFrequency { get; set; }
        public double LowStopBandFrequency { get; set; }
        public double HighPassBandFrequency { get; set; }
        public double HighStopBandFrequency { get; set; }
        public double PassBandRipple { get; set; }
        public double StopBandAttenuation { get; set; }
        public AlgorithmBandType BandType { get; set; }
    }
}