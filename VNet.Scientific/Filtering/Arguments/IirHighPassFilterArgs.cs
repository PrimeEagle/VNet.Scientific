using VNet.Scientific.Filtering.Algorithms;

namespace VNet.Scientific.Filtering.Arguments
{
    public class IirHighPassFilterArgs : IIirHighPassFilterArgs
    {
        public double CutoffFrequency { get; set; }
        public double Bandwidth { get; set; }
        public double SamplingRate { get; set; }
        public AlgorithmBandType BandType { get; set; }
    }
}