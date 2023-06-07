using VNet.Scientific.Filtering.Algorithms;
using VNet.Scientific.Filtering.Arguments;

// ReSharper disable SuggestBaseTypeForParameterInConstructor

namespace VNet.Scientific.Filtering
{
    internal class FirBandPassFilter : FilterBase
    {
        public FirBandPassFilter(IFirBandPassFilterArgs args) : base(args)
        {
            Algorithm = new FirFilterAlgorithm(AlgorithmBandType.BandPass, args);
        }

        public override bool IsValid()
        {
            return base.IsValid();
        }
    }
}