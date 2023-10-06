using MathNet.Numerics;

namespace VNet.Scientific.Interpolation;

public class FourierInterpolationArgs3D : IFourierInterpolationAlgorithmArgs
{
    public Complex32[][][] Coefficients { get; set; }

    public FourierInterpolationArgs3D(Complex32[] flattenedCoefficients, int Nx, int Ny, int Nz)
    {
        Coefficients = new Complex32[Nx][][];
        int index = 0;
        for (var i = 0; i < Nx; i++)
        {
            Coefficients[i] = new Complex32[Ny][];
            for (var j = 0; j < Ny; j++)
            {
                Coefficients[i][j] = new Complex32[Nz];
                for (var k = 0; k < Nz; k++)
                {
                    Coefficients[i][j][k] = flattenedCoefficients[index++];
                }
            }
        }
    }
}