using VNet.Scientific.Filtering.Algorithms;

namespace VNet.Scientific.Filtering.Arguments
{
    public class IirBandPassFilterArgs : IIirBandPassFilterArgs
    {
        public double CutoffLowFrequency { get; set; }
        public double CutoffHighFrequency { get; set; }
        public double SamplingRate { get; set; }
        public AlgorithmBandType BandType { get; set; }
    }
}