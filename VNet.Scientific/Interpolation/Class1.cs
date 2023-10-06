using MathNet.Numerics;
using MathNet.Numerics.IntegralTransforms;
using MathNet.Numerics.Interpolation;
using MathNet.Numerics.LinearAlgebra;

namespace VNet.Scientific.Interpolation
{
    // IInterpolationAlgorithmArgs interface
    public interface IInterpolationAlgorithmArgs
    {
        // Add any properties or methods that are general enough to be applicable across all interpolation algorithms.
        // Example: We might want arguments to decide on some kind of boundary behavior for all interpolations.
        // BoundaryBehavior BoundaryBehavior { get; set; }
    }

    // IInterpolationAlgorithm interface
    public interface IInterpolationAlgorithm
    {
        int MinSupportedDimension { get; }
        int MaxSupportedDimension { get; }

        bool IsDimensionSupported(int dimension);

        double Interpolate(double[] flatData, IInterpolationAlgorithmArgs args, int[] dimensions, int[] targetIndices);
    }

    public abstract class InterpolationBase : IInterpolationAlgorithm
    {
        public abstract int MinSupportedDimension { get; }
        public abstract int MaxSupportedDimension { get; }

        public bool IsDimensionSupported(int dimension)
        {
            return dimension >= MinSupportedDimension && dimension <= MaxSupportedDimension;
        }

        public abstract double Interpolate(double[] flatData, IInterpolationAlgorithmArgs args, int[] dimensions, int[] targetIndices);

        // Assuming implementations for these exist elsewhere in your codebase
        protected int GetFlatIndex(int[] indices, int[] dimensions)
        {
            // Implementation here
            return 0; // Placeholder
        }

        protected int[] GetMultiDimensionalIndices(int flatIndex, int[] dimensions)
        {
            // Implementation here
            return new int[0]; // Placeholder
        }
    }

    // Linear Interpolation Args class
    public class LinearInterpolationArgs : IInterpolationAlgorithmArgs
    {
        // For this simple algorithm, perhaps we don't need any specific arguments.
        // However, this structure lets you add parameters in the future if necessary.
        // e.g. Boundary handling method, etc.
    }

    // Linear Interpolation implementation
    public class LinearInterpolation : InterpolationBase
    {
        private LinearInterpolationArgs _args;

        public LinearInterpolation(LinearInterpolationArgs args)
        {
            _args = args;
        }

        public override int MinSupportedDimension => 1;
        public override int MaxSupportedDimension => 1;

        public override double Interpolate(double[] flatData, IInterpolationAlgorithmArgs args, int[] dimensions, int[] targetIndices)
        {
            return OneDimensionalInterpolation(flatData, targetIndices[0]);

            throw new NotSupportedException("Dimension not supported for linear interpolation");
        }

        private double OneDimensionalInterpolation(double[] data, int targetIndex)
        {
            if (targetIndex < 0 || targetIndex >= data.Length - 1)
            {
                throw new ArgumentOutOfRangeException("Target index out of range for data provided");
            }

            double y0 = data[targetIndex];
            double y1 = data[targetIndex + 1];

            // Simple linear interpolation
            return y0 + (y1 - y0) * 0.5; // Assuming equidistant points, 0.5 is the middle
        }
    }


    public class BilinearInterpolationArgs : IInterpolationAlgorithmArgs
    {
        // For this simple algorithm, perhaps we don't need any specific arguments.
        // However, this structure lets you add parameters in the future if necessary.
        // e.g. Boundary handling method, etc.
    }

    // Linear Interpolation implementation
    public class BilinearInterpolation : InterpolationBase
    {
        private BilinearInterpolationArgs _args;

        public BilinearInterpolation(BilinearInterpolationArgs args)
        {
            _args = args;
        }

        public override int MinSupportedDimension => 1;
        public override int MaxSupportedDimension => 1;

        public override double Interpolate(double[] flatData, IInterpolationAlgorithmArgs args, int[] dimensions, int[] targetIndices)
        {
            return TwoDimensionalInterpolation(flatData, dimensions, targetIndices);

            throw new NotSupportedException("Dimension not supported for linear interpolation");
        }

        private double TwoDimensionalInterpolation(double[] flatData, int[] dimensions, int[] targetIndices)
        {
            if (targetIndices.Length != 2)
            {
                throw new ArgumentException("Expected 2 target indices for 2D interpolation");
            }

            int x = targetIndices[0];
            int y = targetIndices[1];

            // Retrieve corner values
            double q11 = flatData[GetFlatIndex(new[] { x, y }, dimensions)];
            double q12 = flatData[GetFlatIndex(new[] { x, y + 1 }, dimensions)];
            double q21 = flatData[GetFlatIndex(new[] { x + 1, y }, dimensions)];
            double q22 = flatData[GetFlatIndex(new[] { x + 1, y + 1 }, dimensions)];

            // Perform bilinear interpolation
            double r1 = q11 + (q21 - q11) * 0.5; // Interpolate in x at the bottom row
            double r2 = q12 + (q22 - q12) * 0.5; // Interpolate in x at the top row

            return r1 + (r2 - r1) * 0.5; // Interpolate in y between the two row results
        }
    }

    public class NearestNeighborInterpolation : InterpolationBase
    {
        private NearestNeighborInterpolationArgs _args;

        public NearestNeighborInterpolation(NearestNeighborInterpolationArgs args)
        {
            _args = args;
        }

        public override int MinSupportedDimension => 1;
        public override int MaxSupportedDimension => 3;  // Supporting up to 3D now

        public override double Interpolate(double[] flatData, IInterpolationAlgorithmArgs args, int[] dimensions, int[] targetIndices)
        {
            switch (dimensions.Length)
            {
                case 1:
                    return OneDimensionalInterpolation(flatData, targetIndices[0]);
                case 2:
                    return TwoDimensionalInterpolation(flatData, dimensions, targetIndices);
                case 3:
                    return ThreeDimensionalInterpolation(flatData, dimensions, targetIndices);
                default:
                    throw new NotSupportedException("Dimension not supported for nearest neighbor interpolation");
            }
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

            int x = targetIndices[0];
            int y = targetIndices[1];

            // Retrieve the nearest value
            return flatData[GetFlatIndex(new[] { x, y }, dimensions)];
        }

        private double ThreeDimensionalInterpolation(double[] flatData, int[] dimensions, int[] targetIndices)
        {
            if (targetIndices.Length != 3)
            {
                throw new ArgumentException("Expected 3 target indices for 3D interpolation");
            }

            int x = targetIndices[0];
            int y = targetIndices[1];
            int z = targetIndices[2];

            // Retrieve the nearest value
            return flatData[GetFlatIndex(new[] { x, y, z }, dimensions)];
        }
    }

    // Trilinear Interpolation Args class
    public class TrilinearInterpolationArgs : IInterpolationAlgorithmArgs
    {
        // Like before, we may not need any specific arguments for trilinear interpolation right now.
        // However, the structure lets you add parameters in the future if necessary.
    }

    public class TrilinearInterpolation : InterpolationBase
    {
        private TrilinearInterpolationArgs _args;

        public TrilinearInterpolation(TrilinearInterpolationArgs args)
        {
            _args = args;
        }

        public override int MinSupportedDimension => 3;
        public override int MaxSupportedDimension => 3;  // Trilinear is specifically for 3D

        public override double Interpolate(double[] flatData, IInterpolationAlgorithmArgs args, int[] dimensions, int[] targetIndices)
        {
            if (dimensions.Length != 3)
            {
                throw new NotSupportedException("Only 3D data supported for trilinear interpolation");
            }

            return ThreeDimensionalInterpolation(flatData, dimensions, targetIndices);
        }

        private double ThreeDimensionalInterpolation(double[] flatData, int[] dimensions, int[] targetIndices)
        {
            int x = targetIndices[0];
            int y = targetIndices[1];
            int z = targetIndices[2];

            // Get all corner values of the 3D cell
            double c000 = flatData[GetFlatIndex(new[] { x, y, z }, dimensions)];
            double c001 = flatData[GetFlatIndex(new[] { x, y, z + 1 }, dimensions)];
            double c010 = flatData[GetFlatIndex(new[] { x, y + 1, z }, dimensions)];
            double c011 = flatData[GetFlatIndex(new[] { x, y + 1, z + 1 }, dimensions)];
            double c100 = flatData[GetFlatIndex(new[] { x + 1, y, z }, dimensions)];
            double c101 = flatData[GetFlatIndex(new[] { x + 1, y, z + 1 }, dimensions)];
            double c110 = flatData[GetFlatIndex(new[] { x + 1, y + 1, z }, dimensions)];
            double c111 = flatData[GetFlatIndex(new[] { x + 1, y + 1, z + 1 }, dimensions)];

            // We'll use fractions of the target indices for interpolation
            // For simplicity, this example assumes data points are 1 unit apart.
            // These fractions represent where the target indices lie between the corners of the 3D cell.
            double fx = 0.5; // Placeholder for fraction along x
            double fy = 0.5; // Placeholder for fraction along y
            double fz = 0.5; // Placeholder for fraction along z

            // Trilinear interpolation formula
            double interpolatedValue =
                c000 * (1 - fx) * (1 - fy) * (1 - fz) +
                c100 * fx * (1 - fy) * (1 - fz) +
                c010 * (1 - fx) * fy * (1 - fz) +
                c110 * fx * fy * (1 - fz) +
                c001 * (1 - fx) * (1 - fy) * fz +
                c101 * fx * (1 - fy) * fz +
                c011 * (1 - fx) * fy * fz +
                c111 * fx * fy * fz;

            return interpolatedValue;
        }
    }



    public class BicubicInterpolation : InterpolationBase
    {
        private BicubicInterpolationArgs _args;

        public BicubicInterpolation(BicubicInterpolationArgs args)
        {
            _args = args;
        }

        public override int MinSupportedDimension => 2;
        public override int MaxSupportedDimension => 2;  // Bicubic is specifically for 2D

        public override double Interpolate(double[] flatData, IInterpolationAlgorithmArgs args, int[] dimensions, int[] targetIndices)
        {
            if (dimensions.Length != 2)
            {
                throw new NotSupportedException("Only 2D data supported for bicubic interpolation");
            }

            return TwoDimensionalInterpolation(flatData, dimensions, targetIndices);
        }

        private double TwoDimensionalInterpolation(double[] flatData, int[] dimensions, int[] targetIndices)
        {
            int x = targetIndices[0];
            int y = targetIndices[1];

            // 1. Fetch the 16 surrounding values (4x4 grid) around (x,y).
            Matrix<double> surroundingValues = Matrix<double>.Build.Dense(4, 4);
            for (int i = -1; i <= 2; i++)
            {
                for (int j = -1; j <= 2; j++)
                {
                    surroundingValues[i + 1, j + 1] = flatData[GetFlatIndex(new[] { x + i, y + j }, dimensions)];
                }
            }

            // 2. Compute the coefficients needed for the bicubic polynomial using the surrounding values.
            Vector<double> coefficients = ComputeCoefficients(surroundingValues);

            // 3. Evaluate the bicubic polynomial at the desired point using the coefficients.
            double interpolatedValue = EvaluateBicubicPolynomial(0.5, 0.5, coefficients); // for simplicity, we're evaluating at the center of the grid

            return interpolatedValue;
        }

        private Vector<double> ComputeCoefficients(Matrix<double> surroundingValues)
        {
            // Compute the matrix 'A' that contains the bicubic basis
            double[,] basisData = {
                {1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                {-3, 3, 0, 0, -2, -1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                {2, -2, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0},
                // ... Continue with the remaining basis values ...
                // This is a 16x16 matrix
            };
            var A = Matrix<double>.Build.DenseOfArray(basisData);

            // Compute the vector 'b' that contains function values and derivatives
            double[] bData = new double[16];

            bData[0] = surroundingValues[1, 1];
            bData[1] = surroundingValues[2, 1];
            bData[2] = (surroundingValues[2, 1] - surroundingValues[0, 1]) / 2.0; // df/dx at (1,1)
            bData[3] = (surroundingValues[3, 1] - surroundingValues[1, 1]) / 2.0; // df/dx at (2,1)
            // ... Continue with the remaining function values and derivatives ...
            // This is a 16x1 vector

            var b = Vector<double>.Build.Dense(bData);

            // Solve the system of equations A*x = b for x
            Vector<double> coefficients = A.Solve(b);

            return coefficients;
        }


        private double EvaluateBicubicPolynomial(double x, double y, Vector<double> coefficients)
        {
            double result = 0.0;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    result += coefficients[4 * i + j] * Math.Pow(x, i) * Math.Pow(y, j);
                }
            }
            return result;
        }
        public class CubicSplineInterpolationArgs : IInterpolationAlgorithmArgs
        {
            // We might need specific parameters like boundary conditions in the future.
            // For now, it's kept empty for simplicity.
        }

        public class CubicSplineInterpolation : InterpolationBase
        {
            private CubicSplineInterpolationArgs _args;
            private IInterpolation _interpolator;
            private double[] _xValues, _yValues;

            public CubicSplineInterpolation(double[] xValues, double[] yValues, CubicSplineInterpolationArgs args)
            {
                _args = args;
                _xValues = xValues;
                _yValues = yValues;

                _interpolator = MathNet.Numerics.Interpolation.CubicSpline.InterpolateNaturalSorted(_xValues, _yValues);
            }

            public override int MinSupportedDimension => 1;
            public override int MaxSupportedDimension => 1;  // Cubic spline is specifically for 1D

            public override double Interpolate(double[] flatData, IInterpolationAlgorithmArgs args, int[] dimensions, int[] targetIndices)
            {
                if (dimensions.Length != 1)
                {
                    throw new NotSupportedException("Only 1D data supported for cubic spline interpolation");
                }

                return _interpolator.Interpolate(targetIndices[0]);
            }
        }

        public class BezierInterpolationArgs : IInterpolationAlgorithmArgs
        {
            public double[][] ControlPoints { get; }
            public double T { get; }  // Parameter t

            public BezierInterpolationArgs(double[][] controlPoints, double t)
            {
                if (controlPoints.Length != 4)
                    throw new ArgumentException("Cubic Bezier interpolation requires 4 control points.");

                if (t < 0 || t > 1)
                    throw new ArgumentOutOfRangeException("Parameter t must be between 0 and 1.");

                ControlPoints = controlPoints;
                T = t;
            }
        }

        public class BezierInterpolation : InterpolationBase
        {
            private readonly BezierInterpolationArgs _args;

            public BezierInterpolation(BezierInterpolationArgs args)
            {
                _args = args;
            }

            public override int MinSupportedDimension => 2;
            public override int MaxSupportedDimension => 2;  // Now supporting 2D

            public override double Interpolate(double[] flatData, IInterpolationAlgorithmArgs args, int[] dimensions, int[] targetIndices)
            {
                if (dimensions.Length != 2)
                {
                    throw new NotSupportedException("Only 2D data supported for Bezier interpolation in this example.");
                }

                double xValue = CalculateBezierValue(_args.T, new double[][]
                {
            new double[] { _args.ControlPoints[0][0] },
            new double[] { _args.ControlPoints[1][0] },
            new double[] { _args.ControlPoints[2][0] },
            new double[] { _args.ControlPoints[3][0] },
                });

                double yValue = CalculateBezierValue(_args.T, new double[][]
                {
            new double[] { _args.ControlPoints[0][1] },
            new double[] { _args.ControlPoints[1][1] },
            new double[] { _args.ControlPoints[2][1] },
            new double[] { _args.ControlPoints[3][1] },
                });

                // This assumes the 2D data is stored in row-major order. Adjust accordingly if different.
                int flatIndex = targetIndices[0] * dimensions[1] + targetIndices[1];
                flatData[flatIndex] = xValue;  // Storing xValue, but could be changed based on needs
                                               // Similarly, you could use yValue, perhaps depending on the specific requirements.

                return xValue;  // This returns the x value of the Bezier curve, but it can be adapted based on specific needs.
            }

            private double CalculateBezierValue(double t, double[][] controlPoints)
            {
                double mt = 1 - t;
                return mt * mt * mt * controlPoints[0][0] +
                       3 * mt * mt * t * controlPoints[1][0] +
                       3 * mt * t * t * controlPoints[2][0] +
                       t * t * t * controlPoints[3][0];
            }
        }

        public class RBFInterpolationArgs : IInterpolationAlgorithmArgs
        {
            public double[][] KnownPoints { get; }  // Each inner array represents a point's coordinates (x, y, z)
            public double[] KnownValues { get; }    // Function values at the known points
            public Func<double, double> RadialFunction { get; }

            public RBFInterpolationArgs(double[][] knownPoints, double[] knownValues, Func<double, double> radialFunction)
            {
                KnownPoints = knownPoints;
                KnownValues = knownValues;
                RadialFunction = radialFunction;
            }
        }

        public class RBFInterpolation : InterpolationBase
        {
            private readonly RBFInterpolationArgs _args;
            private Vector<double> _weights;

            public RBFInterpolation(RBFInterpolationArgs args)
            {
                _args = args;
                ComputeWeights();
            }

            public override int MinSupportedDimension => 1;
            public override int MaxSupportedDimension => 3;

            private void ComputeWeights()
            {
                int N = _args.KnownPoints.Length;
                var matrix = Matrix<double>.Build.Dense(N, N);

                for (int i = 0; i < N; i++)
                {
                    for (int j = 0; j < N; j++)
                    {
                        double distance = EuclideanDistance(_args.KnownPoints[i], _args.KnownPoints[j]);
                        matrix[i, j] = _args.RadialFunction(distance);
                    }
                }

                var vector = Vector<double>.Build.DenseOfArray(_args.KnownValues);
                _weights = matrix.Solve(vector);
            }

            public override double Interpolate(double[] flatData, IInterpolationAlgorithmArgs args, int[] dimensions, int[] targetIndices)
            {
                if (dimensions.Length > 3)
                {
                    throw new NotSupportedException("Only up to 3D data supported for RBF interpolation in this example.");
                }

                double[] targetPoint = targetIndices.Select(index => (double)index).ToArray();
                double s = 0;

                for (int i = 0; i < _args.KnownPoints.Length; i++)
                {
                    double distance = EuclideanDistance(targetPoint, _args.KnownPoints[i]);
                    s += _weights[i] * _args.RadialFunction(distance);
                }

                return s;
            }

            private double EuclideanDistance(double[] point1, double[] point2)
            {
                double sum = 0.0;
                for (int i = 0; i < point1.Length; i++)
                {
                    sum += (point1[i] - point2[i]) * (point1[i] - point2[i]);
                }
                return Math.Sqrt(sum);
            }
        }


    }

public class LagrangeInterpolationArgs : IInterpolationAlgorithmArgs
    {
        public double[][] KnownPoints { get; }  // Inner arrays are points, e.g., [x], [x,y], or [x,y,z]
        public double[] KnownValues { get; }    // Function values at the known points

        public LagrangeInterpolationArgs(double[][] knownPoints, double[] knownValues)
        {
            KnownPoints = knownPoints;
            KnownValues = knownValues;
        }
    }

    public class LagrangeInterpolation : InterpolationBase
    {
        private readonly LagrangeInterpolationArgs _args;

        public LagrangeInterpolation(LagrangeInterpolationArgs args)
        {
            _args = args;
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
            int dimensions = targetPoint.Length;
            int pointCount = _args.KnownPoints.Length;

            if (dimensions == 1)
            {
                return OneDimensionalInterpolation(targetPoint[0]);
            }
            else if (dimensions == 2)
            {
                double[] intermediateValues = new double[pointCount];
                for (int i = 0; i < pointCount; i++)
                {
                    intermediateValues[i] = OneDimensionalInterpolation(targetPoint[0], _args.KnownPoints.Select(p => p[0]).ToArray(), _args.KnownValues);
                }
                return OneDimensionalInterpolation(targetPoint[1], _args.KnownPoints.Select(p => p[1]).ToArray(), intermediateValues);
            }
            else
            {
                double[] intermediateValues1 = new double[pointCount];
                double[] intermediateValues2 = new double[pointCount];
                for (int i = 0; i < pointCount; i++)
                {
                    intermediateValues1[i] = OneDimensionalInterpolation(targetPoint[0], _args.KnownPoints.Select(p => p[0]).ToArray(), _args.KnownValues);
                }
                for (int i = 0; i < pointCount; i++)
                {
                    intermediateValues2[i] = OneDimensionalInterpolation(targetPoint[1], _args.KnownPoints.Select(p => p[1]).ToArray(), intermediateValues1);
                }
                return OneDimensionalInterpolation(targetPoint[2], _args.KnownPoints.Select(p => p[2]).ToArray(), intermediateValues2);
            }
        }

        private double OneDimensionalInterpolation(double x, double[] xValues = null, double[] yValues = null)
        {
            xValues = xValues ?? _args.KnownPoints.Select(p => p[0]).ToArray();
            yValues = yValues ?? _args.KnownValues;

            double result = 0;
            for (int j = 0; j < xValues.Length; j++)
            {
                double lj = 1;
                for (int m = 0; m < xValues.Length; m++)
                {
                    if (m != j)
                    {
                        lj *= (x - xValues[m]) / (xValues[j] - xValues[m]);
                    }
                }
                result += yValues[j] * lj;
            }
            return result;
        }
    }

public class FourierInterpolationArgs3D : IInterpolationAlgorithmArgs
    {
        public Complex32[][][] FourierCoefficients { get; }

        public FourierInterpolationArgs3D(Complex32[][][] fourierCoefficients)
        {
            FourierCoefficients = fourierCoefficients;
        }
    }

    public class FourierInterpolation3D : InterpolationBase
    {
        private readonly FourierInterpolationArgs3D _args;

        public FourierInterpolation3D(FourierInterpolationArgs3D args)
        {
            _args = args;
        }

        public override int MinSupportedDimension => 1;
        public override int MaxSupportedDimension => 3;

        public override double Interpolate(double[] flatData, IInterpolationAlgorithmArgs args, int[] dimensions, int[] targetIndices)
        {
            if (dimensions.Length < 1 || dimensions.Length > 3)
            {
                throw new NotSupportedException("Only 1-3 dimensions supported for Fourier interpolation in this example.");
            }

            int x = targetIndices[0];
            int N = dimensions[0];

            if (dimensions.Length == 1)
            {
                return Interpolate1D(_args.FourierCoefficients.Select(fc => fc[0][0]).ToArray(), x, N);
            }

            int y = targetIndices[1];
            int M = dimensions[1];
            if (dimensions.Length == 2)
            {
                double[] temp = new double[M];
                for (int j = 0; j < M; j++)
                {
                    temp[j] = Interpolate1D(_args.FourierCoefficients.Select(fc => fc[j][0]).ToArray(), x, N);
                }
                return Interpolate1D(temp, y, M);
            }

            int z = targetIndices[2];
            int L = dimensions[2];
            double[] temp1 = new double[L];
            for (int k = 0; k < L; k++)
            {
                double[] temp2 = new double[M];
                for (int j = 0; j < M; j++)
                {
                    temp2[j] = Interpolate1D(_args.FourierCoefficients.Select(fc => fc[j][k]).ToArray(), x, N);
                }
                temp1[k] = Interpolate1D(temp2, y, M);
            }
            return Interpolate1D(temp1, z, L);
        }

        private double Interpolate1D(Complex32[] coefficients, int x, int N)
        {
            double sum = 0.0;
            for (int n = 0; n < N; n++)
            {
                sum += coefficients[n].Real * Math.Cos(2 * Math.PI * n * x / N)
                     - coefficients[n].Imaginary * Math.Sin(2 * Math.PI * n * x / N);
            }

            return sum / N;
        }

        public static FourierInterpolationArgs3D CreateArgsFromData(double[][][] data)
        {
            int Nx = data.Length;
            int Ny = data[0].Length;
            int Nz = data[0][0].Length;

            Complex32[][][] coefficients = new Complex32[Nx][][];
            for (int i = 0; i < Nx; i++)
            {
                coefficients[i] = new Complex32[Ny][];
                for (int j = 0; j < Ny; j++)
                {
                    coefficients[i][j] = new Complex32[Nz];
                    for (int k = 0; k < Nz; k++)
                    {
                        coefficients[i][j][k] = new Complex32((float)data[i][j][k], 0.0f);
                    }
                }
            }

            // Apply 3D FFT. This might need some refinement.
            MathNet.Numerics.IntegralTransforms.Fourier.Forward(coefficients, FourierOptions.NoScaling);

            return new FourierInterpolationArgs3D(coefficients);
        }
    }

    public class HermiteInterpolationArgs : IInterpolationAlgorithmArgs
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

    public class HermiteInterpolation : InterpolationBase
    {
        private readonly HermiteInterpolationArgs _args;

        public HermiteInterpolation(HermiteInterpolationArgs args)
        {
            _args = args;
        }

        public override int MinSupportedDimension => 1;
        public override int MaxSupportedDimension => 1;

        public override double Interpolate(double[] flatData, IInterpolationAlgorithmArgs args, int[] dimensions, int[] targetIndices)
        {
            double x = flatData[targetIndices[0]];

            // Find interval [x0, x1] that x lies in.
            int i = 0;
            while (i < _args.XValues.Length - 1 && x > _args.XValues[i + 1])
                i++;

            double x0 = _args.XValues[i];
            double x1 = _args.XValues[i + 1];
            double y0 = _args.YValues[i];
            double y1 = _args.YValues[i + 1];
            double dy0 = _args.Derivatives[i];
            double dy1 = _args.Derivatives[i + 1];

            double L0 = (x - x1) / (x0 - x1);
            double L1 = (x - x0) / (x1 - x0);

            return (1 - 2 * (x - x0) * (x1 - x0) / (x1 - x0)) * L0 * L0 * y0 +
                   (1 - 2 * (x - x1) * (x0 - x1) / (x0 - x1)) * L1 * L1 * y1 +
                   (x - x0) * L0 * L0 * dy0 +
                   (x - x1) * L1 * L1 * dy1;
        }
    }




}
