using VNet.Scientific.Filtering.Arguments;

namespace VNet.Scientific.Filtering.Algorithms
{
    public abstract class FilterAlgorithmBase : IFilterAlgorithm
    {
        protected readonly IFilterArgs Args;
        protected readonly AlgorithmBandType BandType;

        protected FilterAlgorithmBase(AlgorithmBandType bandType, IFilterArgs args)
        {
            Args = args;
            BandType = bandType;
        }
        public abstract double[] Apply(double[] input);
        public abstract bool IsValid();
    }
}