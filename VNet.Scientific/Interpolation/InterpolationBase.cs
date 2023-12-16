namespace VNet.Scientific.Interpolation
{
    public abstract class InterpolationBase : IInterpolationAlgorithm
    {
        protected readonly IInterpolationAlgorithmArgs Args;
        public abstract int MinSupportedDimension { get; }
        public abstract int MaxSupportedDimension { get; }


        protected InterpolationBase(IInterpolationAlgorithmArgs args)
        {
            Args = args;
        }

        public bool IsDimensionSupported(int dimension)
        {
            return dimension >= MinSupportedDimension && dimension <= MaxSupportedDimension;
        }

        public abstract double Interpolate(double[] flatData, IInterpolationAlgorithmArgs args, int[] dimensions, int[] targetIndices);

        protected int GetFlatIndex(int[] indices, int[] dimensions)
        {
            // Implementation here
            return 0; // Placeholder
        }

        protected int[] GetMultiDimensionalIndices(int flatIndex, int[] dimensions)
        {
            // Implementation here
            return new int[0]; // Placeholder
        }
    }
}