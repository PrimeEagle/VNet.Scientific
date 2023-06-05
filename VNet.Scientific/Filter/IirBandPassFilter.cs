using VNet.Scientific.Filter.Algorithms;
using VNet.Scientific.Filter.Arguments;

// ReSharper disable SuggestBaseTypeForParameterInConstructor

namespace VNet.Scientific.Filter
{
    internal class IirBandPassFilter : FilterBase
    {
        public IirBandPassFilter(IIirBandPassFilterArgs args) : base(args)
        {
            Algorithm = new IirFilterAlgorithm(AlgorithmBandType.BandPass, args);
        }

        public override bool IsValid()
        {
            return base.IsValid();
        }
    }
}