namespace VNet.Scientific.Interpolation;

public class HermiteInterpolationArgs : IHermiteInterpolationAlgorithmArgs
{
    public double[] XValues { get; }
    public double[] YValues { get; }
    public double[] Derivatives { get; }

    public HermiteInterpolationArgs(double[] xValues, double[] yValues, double[] derivatives)
    {
        XValues = xValues;
        YValues = yValues;
        Derivatives = derivatives;
    }
}