namespace VNet.Scientific.Interpolation;

public interface IInterpolationAlgorithm
{
    int MinSupportedDimension { get; }
    int MaxSupportedDimension { get; }

    bool IsDimensionSupported(int dimension);

    double Interpolate(double[] flatData, IInterpolationAlgorithmArgs args, int[] dimensions, int[] targetIndices);
}