using VNet.Scientific.Filter.Algorithms;
using VNet.Scientific.Filter.Arguments;

// ReSharper disable SuggestBaseTypeForParameterInConstructor

namespace VNet.Scientific.Filter
{
    internal class ButterworthNotchFilter : FilterBase
    {
        public ButterworthNotchFilter(IButterworthNotchFilterArgs args) : base(args)
        {
            Algorithm = new ButterworthFilterAlgorithm(AlgorithmBandType.LowPass, args);
        }

        public override bool IsValid()
        {
            return base.IsValid();
        }
    }
}