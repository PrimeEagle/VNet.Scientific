using VNet.Scientific.Filtering.Algorithms;
using VNet.Scientific.Filtering.Arguments;

// ReSharper disable SuggestBaseTypeForParameterInConstructor

namespace VNet.Scientific.Filtering
{
    internal class IirBandStopFilter : FilterBase
    {
        public IirBandStopFilter(IIirBandStopFilterArgs args) : base(args)
        {
            Algorithm = new IirFilterAlgorithm(AlgorithmBandType.BandStop, args);
        }

        public override bool IsValid()
        {
            return base.IsValid();
        }
    }
}