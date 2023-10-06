namespace VNet.Scientific.Interpolation;

public class LagrangeInterpolation : InterpolationBase
{
    public LagrangeInterpolation(ILagrangeInterpolationAlgorithmArgs args) : base(args)
    {
    }

    public override int MinSupportedDimension => 1;
    public override int MaxSupportedDimension => 3;

    public override double Interpolate(double[] flatData, IInterpolationAlgorithmArgs args, int[] dimensions, int[] targetIndices)
    {
        if (dimensions.Length < 1 || dimensions.Length > 3)
        {
            throw new NotSupportedException("Only 1-3 dimensions supported for Lagrange interpolation in this example.");
        }

        return CalculateLagrangeValue(targetIndices.Select(index => (double)index).ToArray());
    }

    private double CalculateLagrangeValue(double[] targetPoint)
    {
        var dimensions = targetPoint.Length;
        var pointCount = ((ILagrangeInterpolationAlgorithmArgs)Args).KnownPoints.Length;

        if (dimensions == 1)
        {
            return OneDimensionalInterpolation(targetPoint[0]);
        }
        else if (dimensions == 2)
        {
            var intermediateValues = new double[pointCount];
            for (var i = 0; i < pointCount; i++)
            {
                intermediateValues[i] = OneDimensionalInterpolation(targetPoint[0], ((ILagrangeInterpolationAlgorithmArgs)Args).KnownPoints.Select(p => p[0]).ToArray(), ((ILagrangeInterpolationAlgorithmArgs)Args).KnownValues);
            }
            return OneDimensionalInterpolation(targetPoint[1], ((ILagrangeInterpolationAlgorithmArgs)Args).KnownPoints.Select(p => p[1]).ToArray(), intermediateValues);
        }
        else
        {
            var intermediateValues1 = new double[pointCount];
            var intermediateValues2 = new double[pointCount];
            for (var i = 0; i < pointCount; i++)
            {
                intermediateValues1[i] = OneDimensionalInterpolation(targetPoint[0], ((ILagrangeInterpolationAlgorithmArgs)Args).KnownPoints.Select(p => p[0]).ToArray(), ((ILagrangeInterpolationAlgorithmArgs)Args).KnownValues);
            }
            for (var i = 0; i < pointCount; i++)
            {
                intermediateValues2[i] = OneDimensionalInterpolation(targetPoint[1], ((ILagrangeInterpolationAlgorithmArgs)Args).KnownPoints.Select(p => p[1]).ToArray(), intermediateValues1);
            }
            return OneDimensionalInterpolation(targetPoint[2], ((ILagrangeInterpolationAlgorithmArgs)Args).KnownPoints.Select(p => p[2]).ToArray(), intermediateValues2);
        }
    }

    private double OneDimensionalInterpolation(double x, double[] xValues = null, double[] yValues = null)
    {
        xValues = xValues ?? ((ILagrangeInterpolationAlgorithmArgs)Args).KnownPoints.Select(p => p[0]).ToArray();
        yValues = yValues ?? ((ILagrangeInterpolationAlgorithmArgs)Args).KnownValues;

        double result = 0;
        for (var j = 0; j < xValues.Length; j++)
        {
            var lj = xValues.Where((t, m) => m != j).Aggregate<double, double>(1, (current, t) => current * ((x - t) / (xValues[j] - t)));
            result += yValues[j] * lj;
        }
        return result;
    }
}