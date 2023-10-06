using MathNet.Numerics;

namespace VNet.Scientific.Interpolation;

public class FourierInterpolation3D : InterpolationBase
{

    public FourierInterpolation3D(IFourierInterpolationAlgorithmArgs args) : base(args)
    {
    }

    public override int MinSupportedDimension => 1;
    public override int MaxSupportedDimension => 3;

    public override double Interpolate(double[] flatData, IInterpolationAlgorithmArgs args, int[] dimensions, int[] targetIndices)
    {
        if (dimensions.Length is < 1 or > 3)
        {
            throw new NotSupportedException("Only 1-3 dimensions supported for Fourier interpolation in this example.");
        }

        var x = targetIndices[0];
        var N = dimensions[0];

        if (dimensions.Length == 1)
        {
            return Interpolate1D(((IFourierInterpolationAlgorithmArgs)Args).Coefficients.Select(fc => fc[0][0]).ToArray(), x, N);
        }

        var y = targetIndices[1];
        var M = dimensions[1];
        if (dimensions.Length == 2)
        {
            var temp = new double[M];
            for (var j = 0; j < M; j++)
            {
                temp[j] = Interpolate1D(((IFourierInterpolationAlgorithmArgs)Args).Coefficients.Select(fc => fc[j][0]).ToArray(), x, N);
            }
            return Interpolate1D(DoubleArrayToComplex32Array(temp), y, M);
        }

        var z = targetIndices[2];
        var L = dimensions[2];
        var temp1 = new double[L];
        for (var k = 0; k < L; k++)
        {
            var temp2 = new double[M];
            for (var j = 0; j < M; j++)
            {
                temp2[j] = Interpolate1D(((IFourierInterpolationAlgorithmArgs)Args).Coefficients.Select(fc => fc[j][k]).ToArray(), x, N);
            }
            temp1[k] = Interpolate1D(DoubleArrayToComplex32Array(temp2), y, M);
        }
        return Interpolate1D(DoubleArrayToComplex32Array(temp1), z, L);
    }

    private double Interpolate1D(Complex32[] coefficients, int x, int N)
    {
        var sum = 0.0;
        for (var n = 0; n < N; n++)
        {
            sum += coefficients[n].Real * Math.Cos(2 * Math.PI * n * x / N)
                   - coefficients[n].Imaginary * Math.Sin(2 * Math.PI * n * x / N);
        }

        return sum / N;
    }

    public static FourierInterpolationArgs3D CreateArgsFromData(double[][][] data)
    {
        var Nx = data.Length;
        var Ny = data[0].Length;
        var Nz = data[0][0].Length;

        var coefficients = new Complex32[Nx * Ny * Nz];

        int index = 0;
        for (var i = 0; i < Nx; i++)
        {
            for (var j = 0; j < Ny; j++)
            {
                for (var k = 0; k < Nz; k++)
                {
                    coefficients[index++] = new Complex32((float)data[i][j][k], 0.0f);
                }
            }
        }

        return new FourierInterpolationArgs3D(coefficients, Nx, Ny, Nz);
    }


    private static Complex32[] DoubleArrayToComplex32Array(double[] doubleArray)
    {
        var complexArray = new Complex32[doubleArray.Length];

        for (var i = 0; i < doubleArray.Length; i++)
        {
            complexArray[i] = new Complex32((float)doubleArray[i], 0.0f);
        }

        return complexArray;
    }

    private static Complex32[][][] DoubleArrayToComplex32Array3D(double[][][] doubleArray)
    {
        var x = doubleArray.Length;
        var y = doubleArray[0].Length;
        var z = doubleArray[0][0].Length;

        var complexArray3D = new Complex32[x][][];

        for (var i = 0; i < x; i++)
        {
            complexArray3D[i] = new Complex32[y][];
            for (var j = 0; j < y; j++)
            {
                complexArray3D[i][j] = new Complex32[z];
                for (var k = 0; k < z; k++)
                {
                    complexArray3D[i][j][k] = new Complex32((float)doubleArray[i][j][k], 0.0f);
                }
            }
        }

        return complexArray3D;
    }
}