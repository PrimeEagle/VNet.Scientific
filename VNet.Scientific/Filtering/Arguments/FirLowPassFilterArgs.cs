using VNet.Scientific.Filtering.Algorithms;

namespace VNet.Scientific.Filtering.Arguments
{
    public class FirLowPassFilterArgs : IFirLowPassFilterArgs
    {
        public double CutoffFrequency { get; set; }
        public double DcGain { get; set; }
        public int Order { get; set; }
        public double SamplingRate { get; set; }
        public WindowFunction WindowFunction { get; set; }
        public AlgorithmBandType BandType { get; set; }
        public double Sigma { get; set; }
    }
}