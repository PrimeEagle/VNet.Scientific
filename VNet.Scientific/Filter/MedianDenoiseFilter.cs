using VNet.Scientific.Filter.Algorithms;
using VNet.Scientific.Filter.Arguments;

// ReSharper disable SuggestBaseTypeForParameterInConstructor

namespace VNet.Scientific.Filter
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