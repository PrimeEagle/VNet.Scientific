namespace VNet.Scientific.Smoothing
{
    public interface ISmoothingAlgorithm
    {
        Array Smooth(Array data, params int[] smoothDimensions);
    }
}