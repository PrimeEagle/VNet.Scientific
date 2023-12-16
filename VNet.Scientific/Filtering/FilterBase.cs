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

        public virtual Array Filter(Array input)
        {
            if (!IsValid() || !Algorithm.IsValid()) throw new ArgumentException("Parameters are not configured correctly.");

            var totalLength = input.Length;
            var flatInput = new double[totalLength];

            Buffer.BlockCopy(input, 0, flatInput, 0, totalLength * sizeof(double));

            var flatOutput = new double[totalLength];
            for (var i = 0; i < totalLength; i++)
            {
                flatOutput[i] = Algorithm.Apply(new double[] { flatInput[i] })[0];
            }

            var dimensions = new int[input.Rank];
            for (var i = 0; i < input.Rank; i++)
            {
                dimensions[i] = input.GetLength(i);
            }

            var output = Array.CreateInstance(typeof(double), dimensions);

            Buffer.BlockCopy(flatOutput, 0, output, 0, totalLength * sizeof(double));

            return output;
        }


        public virtual bool IsValid()
        {
            var valid = Algorithm.IsValid();

            return valid;
        }
    }
}