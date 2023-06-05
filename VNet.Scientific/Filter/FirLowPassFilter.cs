using VNet.Scientific.Filter.Algorithms;
using VNet.Scientific.Filter.Arguments;

// ReSharper disable SuggestBaseTypeForParameterInConstructor

namespace VNet.Scientific.Filter
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