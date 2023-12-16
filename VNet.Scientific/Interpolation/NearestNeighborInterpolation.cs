namespace VNet.Scientific.Interpolation;

public class NearestNeighborInterpolation : InterpolationBase
{
    public NearestNeighborInterpolation(IInterpolationAlgorithmArgs args) : base(args)
    {
    }

    public override int MinSupportedDimension => 1;
    public override int MaxSupportedDimension => 3;  // Supporting up to 3D now

    public override double Interpolate(double[] flatData, IInterpolationAlgorithmArgs args, int[] dimensions, int[] targetIndices)
    {
        return dimensions.Length switch
        {
            1 => OneDimensionalInterpolation(flatData, targetIndices[0]),
            2 => TwoDimensionalInterpolation(flatData, dimensions, targetIndices),
            3 => ThreeDimensionalInterpolation(flatData, dimensions, targetIndices),
            _ => throw new NotSupportedException("Dimension not supported for nearest neighbor interpolation")
        };
    }

    private double OneDimensionalInterpolation(double[] data, int targetIndex)
    {
        if (targetIndex < 0 || targetIndex >= data.Length)
        {
            throw new ArgumentOutOfRangeException("Target index out of range for data provided");
        }

        return data[targetIndex];
    }

    private double TwoDimensionalInterpolation(double[] flatData, int[] dimensions, int[] targetIndices)
    {
        if (targetIndices.Length != 2)
        {
            throw new ArgumentException("Expected 2 target indices for 2D interpolation");
        }

        var x = targetIndices[0];
        var y = targetIndices[1];

        // Retrieve the nearest value
        return flatData[GetFlatIndex(new[] { x, y }, dimensions)];
    }

    private double ThreeDimensionalInterpolation(double[] flatData, int[] dimensions, int[] targetIndices)
    {
        if (targetIndices.Length != 3)
        {
            throw new ArgumentException("Expected 3 target indices for 3D interpolation");
        }

        var x = targetIndices[0];
        var y = targetIndices[1];
        var z = targetIndices[2];

        // Retrieve the nearest value
        return flatData[GetFlatIndex(new[] { x, y, z }, dimensions)];
    }
}