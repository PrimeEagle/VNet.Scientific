namespace VNet.Scientific.Interpolation;

public class LagrangeInterpolationAlgorithmArgs : ILagrangeInterpolationAlgorithmArgs
{
    public double[][] KnownPoints { get; }  // Inner arrays are points, e.g., [x], [x,y], or [x,y,z]
    public double[] KnownValues { get; }    // Function values at the known points

    public LagrangeInterpolationAlgorithmArgs(double[][] knownPoints, double[] knownValues)
    {
        KnownPoints = knownPoints;
        KnownValues = knownValues;
    }
}