using VNet.Scientific.Filtering.Algorithms;
using VNet.Scientific.Filtering.Arguments;

// ReSharper disable SuggestBaseTypeForParameterInConstructor

namespace VNet.Scientific.Filtering
{
    internal class FirHighPassFilter : FilterBase
    {
        public FirHighPassFilter(IFirHighPassFilterArgs args) : base(args)
        {
            Algorithm = new FirFilterAlgorithm(AlgorithmBandType.HighPass, args);
        }

        public override bool IsValid()
        {
            return base.IsValid();
        }
    }
}