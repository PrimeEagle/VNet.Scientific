using VNet.Scientific.Filter.Algorithms;
using VNet.Scientific.Filter.Arguments;

// ReSharper disable SuggestBaseTypeForParameterInConstructor

namespace VNet.Scientific.Filter
{
    internal class ButterworthHighPassFilter : FilterBase
    {
        public ButterworthHighPassFilter(IButterworthHighPassFilterArgs args) : base(args)
        {
            Algorithm = new ButterworthFilterAlgorithm(AlgorithmBandType.HighPass, args);
        }

        public override bool IsValid()
        {
            return base.IsValid();
        }
    }
}