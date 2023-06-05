using VNet.Scientific.Filter.Algorithms;

namespace VNet.Scientific.Filter.Arguments
{
    public class ButterworthNotchFilterArgs : IButterworthNotchFilterArgs
    {
        public double CentralFrequency { get; set; }
        public double Q { get; set; }
        public double PassBandRipple { get; set; }
        public double StopBandAttenuation { get; set; }
        public AlgorithmBandType BandType { get; set; }
    }
}