// ReSharper disable MemberCanBePrivate.Global

using VNet.Scientific.Filtering.Algorithms;
using VNet.Scientific.Filtering.Arguments;

namespace VNet.Scientific.Filtering
{
    public abstract class FilterBase : IFilter
    {
        protected readonly IFilterArgs Args;
        protected IFilterAlgorithm Algorithm;


        protected FilterBase(IFilterArgs args)
        {
            Args = args;
        }

        public virtual double[] Filter(double[] input)
        {
            if (!IsValid() || !Algorithm.IsValid()) throw new ArgumentException("Parameters are not configured correctly.");
            return Algorithm.Apply(input);
        }

        public virtual bool IsValid()
        {
            var valid = Algorithm.IsValid();

            return valid;
        }
    }
}