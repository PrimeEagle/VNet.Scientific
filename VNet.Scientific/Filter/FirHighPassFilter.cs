using VNet.Scientific.Filter.Algorithms;
using VNet.Scientific.Filter.Arguments;

// ReSharper disable SuggestBaseTypeForParameterInConstructor

namespace VNet.Scientific.Filter
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