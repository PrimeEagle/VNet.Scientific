namespace VNet.Scientific.Interpolation;

public class HermiteInterpolation : InterpolationBase
{

    public HermiteInterpolation(IHermiteInterpolationAlgorithmArgs args) : base(args)
    {
    }

    public override int MinSupportedDimension => 1;
    public override int MaxSupportedDimension => 1;

    public override double Interpolate(double[] flatData, IInterpolationAlgorithmArgs args, int[] dimensions, int[] targetIndices)
    {
        var x = flatData[targetIndices[0]];

        // Find interval [x0, x1] that x lies in.
        var i = 0;
        while (i < ((IHermiteInterpolationAlgorithmArgs)Args).XValues.Length - 1 && x > ((IHermiteInterpolationAlgorithmArgs)Args).XValues[i + 1])
            i++;

        var x0 = ((IHermiteInterpolationAlgorithmArgs)Args).XValues[i];
        var x1 = ((IHermiteInterpolationAlgorithmArgs)Args).XValues[i + 1];
        var y0 = ((IHermiteInterpolationAlgorithmArgs)Args).YValues[i];
        var y1 = ((IHermiteInterpolationAlgorithmArgs)Args).YValues[i + 1];
        var dy0 = ((IHermiteInterpolationAlgorithmArgs)Args).Derivatives[i];
        var dy1 = ((IHermiteInterpolationAlgorithmArgs)Args).Derivatives[i + 1];

        var L0 = (x - x1) / (x0 - x1);
        var L1 = (x - x0) / (x1 - x0);

        return (1 - 2 * (x - x0) * (x1 - x0) / (x1 - x0)) * L0 * L0 * y0 +
               (1 - 2 * (x - x1) * (x0 - x1) / (x0 - x1)) * L1 * L1 * y1 +
               (x - x0) * L0 * L0 * dy0 +
               (x - x1) * L1 * L1 * dy1;
    }
}