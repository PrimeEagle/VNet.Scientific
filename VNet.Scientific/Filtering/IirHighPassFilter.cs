using VNet.Scientific.Filtering.Algorithms;
using VNet.Scientific.Filtering.Arguments;

// ReSharper disable SuggestBaseTypeForParameterInConstructor

namespace VNet.Scientific.Filtering
{
    internal class IirHighPassFilter : FilterBase
    {
        public IirHighPassFilter(IIirHighPassFilterArgs args) : base(args)
        {
            Algorithm = new IirFilterAlgorithm(AlgorithmBandType.HighPass, args);
        }

        public override bool IsValid()
        {
            return base.IsValid();
        }
    }
}