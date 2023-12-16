using VNet.Scientific.Filtering.Algorithms;
using VNet.Scientific.Filtering.Arguments;

// ReSharper disable SuggestBaseTypeForParameterInConstructor

namespace VNet.Scientific.Filtering
{
    internal class FirLowPassFilter : FilterBase
    {
        public FirLowPassFilter(IFirLowPassFilterArgs args) : base(args)
        {
            Algorithm = new FirFilterAlgorithm(AlgorithmBandType.LowPass, args);
        }

        public override bool IsValid()
        {
            return base.IsValid();
        }
    }
}