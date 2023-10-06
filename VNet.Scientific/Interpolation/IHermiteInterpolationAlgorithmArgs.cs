namespace VNet.Scientific.Interpolation;

public interface IHermiteInterpolationAlgorithmArgs : IInterpolationAlgorithmArgs
{
    public double[] XValues { get; }
    public double[] YValues { get; }
    public double[] Derivatives { get; }
}