// ReSharper disable MemberCanBeMadeStatic.Local
// ReSharper disable SuggestBaseTypeForParameter
#pragma warning disable CA1822
namespace VNet.Scientific.Interpolation;

public class LinearInterpolation : InterpolationBase
{
    public LinearInterpolation(IInterpolationAlgorithmArgs args) : base(args)
    {
    }

    public override int MinSupportedDimension => 1;
    public override int MaxSupportedDimension => 1;

    public override double Interpolate(double[] flatData, IInterpolationAlgorithmArgs args, int[] dimensions, int[] targetIndices)
    {
        return OneDimensionalInterpolation(flatData, targetIndices[0]);

        throw new NotSupportedException("Dimension not supported for linear interpolation");
    }

    private double OneDimensionalInterpolation(double[] data, int targetIndex)
    {
        if (targetIndex < 0 || targetIndex >= data.Length - 1)
        {
            throw new ArgumentOutOfRangeException("Target index out of range for data provided");
        }

        var y0 = data[targetIndex];
        var y1 = data[targetIndex + 1];

        return y0 + (y1 - y0) * 0.5;
    }
}