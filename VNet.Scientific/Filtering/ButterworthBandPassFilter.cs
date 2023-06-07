using VNet.Scientific.Filtering.Algorithms;
using VNet.Scientific.Filtering.Arguments;

// ReSharper disable SuggestBaseTypeForParameterInConstructor

namespace VNet.Scientific.Filtering
{
    internal class ButterworthBandPassFilter : FilterBase
    {
        public ButterworthBandPassFilter(IButterworthBandPassFilterArgs args) : base(args)
        {
            Algorithm = new ButterworthFilterAlgorithm(AlgorithmBandType.BandPass, args);
        }

        public override bool IsValid()
        {
            return base.IsValid();
        }
    }
}