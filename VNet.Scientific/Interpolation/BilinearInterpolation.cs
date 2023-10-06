namespace VNet.Scientific.Interpolation;

public class BilinearInterpolation : InterpolationBase
{
    public BilinearInterpolation(IInterpolationAlgorithmArgs args) : base(args)
    {
    }

    public override int MinSupportedDimension => 1;
    public override int MaxSupportedDimension => 1;

    public override double Interpolate(double[] flatData, IInterpolationAlgorithmArgs args, int[] dimensions, int[] targetIndices)
    {
        return TwoDimensionalInterpolation(flatData, dimensions, targetIndices);

        throw new NotSupportedException("Dimension not supported for linear interpolation");
    }

    private double TwoDimensionalInterpolation(double[] flatData, int[] dimensions, int[] targetIndices)
    {
        if (targetIndices.Length != 2)
        {
            throw new ArgumentException("Expected 2 target indices for 2D interpolation");
        }

        var x = targetIndices[0];
        var y = targetIndices[1];

        // Retrieve corner values
        var q11 = flatData[GetFlatIndex(new[] { x, y }, dimensions)];
        var q12 = flatData[GetFlatIndex(new[] { x, y + 1 }, dimensions)];
        var q21 = flatData[GetFlatIndex(new[] { x + 1, y }, dimensions)];
        var q22 = flatData[GetFlatIndex(new[] { x + 1, y + 1 }, dimensions)];

        // Perform bilinear interpolation
        var r1 = q11 + (q21 - q11) * 0.5; // Interpolate in x at the bottom row
        var r2 = q12 + (q22 - q12) * 0.5; // Interpolate in x at the top row

        return r1 + (r2 - r1) * 0.5; // Interpolate in y between the two row results
    }
}