﻿using VNet.Scientific.Filter.Algorithms;

namespace VNet.Scientific.Filter.Arguments
{
    public class FirBandStopFilterArgs : IFirBandStopFilterArgs
    {
        public double CutoffLowFrequency { get; set; }
        public double CutoffHighFrequency { get; set; }
        public int Order { get; set; }
        public double SamplingRate { get; set; }
        public WindowFunction WindowFunction { get; set; }
        public AlgorithmBandType BandType { get; set; }
        public double Sigma { get; set; }
    }
}