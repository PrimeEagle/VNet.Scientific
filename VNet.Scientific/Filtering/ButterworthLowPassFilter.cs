using VNet.Scientific.Filtering.Algorithms;
using VNet.Scientific.Filtering.Arguments;

// ReSharper disable SuggestBaseTypeForParameterInConstructor

namespace VNet.Scientific.Filtering
{
    internal class ButterworthLowPassFilter : FilterBase
    {
        public ButterworthLowPassFilter(IButterworthLowPassFilterArgs args) : base(args)
        {
            Algorithm = new ButterworthFilterAlgorithm(AlgorithmBandType.LowPass, args);
        }

        public override bool IsValid()
        {
            return base.IsValid();
        }
    }
}