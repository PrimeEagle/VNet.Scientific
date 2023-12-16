using VNet.Scientific.Filtering.Algorithms;
using VNet.Scientific.Filtering.Arguments;

// ReSharper disable SuggestBaseTypeForParameterInConstructor

namespace VNet.Scientific.Filtering
{
    internal class ButterworthBandStopFilter : FilterBase
    {
        public ButterworthBandStopFilter(IButterworthBandStopFilterArgs args) : base(args)
        {
            Algorithm = new ButterworthFilterAlgorithm(AlgorithmBandType.BandStop, args);
        }

        public override bool IsValid()
        {
            return base.IsValid();
        }
    }
}