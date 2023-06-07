using VNet.Scientific.Filtering.Algorithms;
using VNet.Scientific.Filtering.Arguments;

// ReSharper disable SuggestBaseTypeForParameterInConstructor

namespace VNet.Scientific.Filtering
{
    internal class MedianDenoiseFilter : FilterBase
    {
        public MedianDenoiseFilter(IMedianFilterArgs args) : base(args)
        {
            Algorithm = new MedianFilterAlgorithm(AlgorithmBandType.Denoise, args);
        }

        public override bool IsValid()
        {
            return base.IsValid();
        }
    }
}