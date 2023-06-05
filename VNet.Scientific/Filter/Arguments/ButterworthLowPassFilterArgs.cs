using VNet.Scientific.Filter.Algorithms;

namespace VNet.Scientific.Filter.Arguments
{
    public class ButterworthLowPassFilterArgs : IButterworthLowPassFilterArgs
    {
        public double PassBandFrequency { get; set; }
        public double StopBandFrequency { get; set; }
        public double PassBandRipple { get; set; }
        public double StopBandAttenuation { get; set; }
        public AlgorithmBandType BandType { get; set; }
    }
}