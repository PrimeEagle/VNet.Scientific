using VNet.Scientific.Filtering.Algorithms;

namespace VNet.Scientific.Filtering.Arguments
{
    public class IirBandStopFilterArgs : IIirBandStopFilterArgs
    {
        public double CutoffLowFrequency { get; set; }
        public double CutoffHighFrequency { get; set; }
        public double SamplingRate { get; set; }
        public AlgorithmBandType BandType { get; set; }
    }
}