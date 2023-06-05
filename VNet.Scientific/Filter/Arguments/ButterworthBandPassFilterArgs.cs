using VNet.Scientific.Filter.Algorithms;

namespace VNet.Scientific.Filter.Arguments
{
    public class ButterworthBandPassFilterArgs : IButterworthBandPassFilterArgs
    {
        public double PassBandRipple { get; set; }
        public double StopBandAttenuation { get; set; }
        public double LowPassBandFrequency { get; set; }
        public double LowStopBandFrequency { get; set; }
        public double HighPassBandFrequency { get; set; }
        public double HighStopBandFrequency { get; set; }
        public AlgorithmBandType BandType { get; set; }
    }
}