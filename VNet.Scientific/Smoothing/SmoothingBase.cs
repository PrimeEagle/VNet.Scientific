namespace VNet.Scientific.Smoothing
{
    public abstract class SmoothingBase : ISmoothingAlgorithm
    {
        protected readonly ISmoothingAlgorithmArgs Args;



        protected SmoothingBase(ISmoothingAlgorithmArgs args)
        {
            Args = args;
        }

        public abstract Array Smooth(Array data, params int[] smoothDimensions);
    }
}