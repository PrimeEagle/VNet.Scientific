using VNet.Scientific.Filtering.Algorithms;

namespace VNet.Scientific.Filtering.Arguments
{
    public class ButterworthHighPassFilterArgs : IButterworthHighPassFilterArgs
    {
        public double PassBandFrequency { get; set; }
        public double StopBandFrequency { get; set; }
        public double PassBandRipple { get; set; }
        public double StopBandAttenuation { get; set; }
        public AlgorithmBandType BandType { get; set; }
    }
}