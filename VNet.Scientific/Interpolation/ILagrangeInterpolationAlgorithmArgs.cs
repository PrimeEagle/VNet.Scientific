namespace VNet.Scientific.Interpolation;

public interface ILagrangeInterpolationAlgorithmArgs : IInterpolationAlgorithmArgs
{
    public double[][] KnownPoints { get; }
    public double[] KnownValues { get; }
}