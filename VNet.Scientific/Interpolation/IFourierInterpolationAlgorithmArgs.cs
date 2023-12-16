using MathNet.Numerics;

namespace VNet.Scientific.Interpolation;

public interface IFourierInterpolationAlgorithmArgs : IInterpolationAlgorithmArgs
{
    public Complex32[][][] Coefficients { get; set; }
}