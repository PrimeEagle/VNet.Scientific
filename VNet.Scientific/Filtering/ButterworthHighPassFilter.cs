using VNet.Scientific.Filtering.Algorithms;
using VNet.Scientific.Filtering.Arguments;

// ReSharper disable SuggestBaseTypeForParameterInConstructor

namespace VNet.Scientific.Filtering
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