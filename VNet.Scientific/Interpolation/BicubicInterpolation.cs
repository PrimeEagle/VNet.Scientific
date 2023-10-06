using MathNet.Numerics.Interpolation;
using MathNet.Numerics.LinearAlgebra;

namespace VNet.Scientific.Interpolation;

public class BicubicInterpolation : InterpolationBase
{
    public BicubicInterpolation(IInterpolationAlgorithmArgs args) : base(args)
    {
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
        var x = targetIndices[0];
        var y = targetIndices[1];

        // 1. Fetch the 16 surrounding values (4x4 grid) around (x,y).
        var surroundingValues = Matrix<double>.Build.Dense(4, 4);
        for (var i = -1; i <= 2; i++)
        {
            for (var j = -1; j <= 2; j++)
            {
                surroundingValues[i + 1, j + 1] = flatData[GetFlatIndex(new[] { x + i, y + j }, dimensions)];
            }
        }

        // 2. Compute the coefficients needed for the bicubic polynomial using the surrounding values.
        var coefficients = ComputeCoefficients(surroundingValues);

        // 3. Evaluate the bicubic polynomial at the desired point using the coefficients.
        var interpolatedValue = EvaluateBicubicPolynomial(0.5, 0.5, coefficients); // for simplicity, we're evaluating at the center of the grid

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
        var bData = new double[16];

        bData[0] = surroundingValues[1, 1];
        bData[1] = surroundingValues[2, 1];
        bData[2] = (surroundingValues[2, 1] - surroundingValues[0, 1]) / 2.0; // df/dx at (1,1)
        bData[3] = (surroundingValues[3, 1] - surroundingValues[1, 1]) / 2.0; // df/dx at (2,1)
        // ... Continue with the remaining function values and derivatives ...
        // This is a 16x1 vector

        var b = Vector<double>.Build.Dense(bData);

        // Solve the system of equations A*x = b for x
        var coefficients = A.Solve(b);

        return coefficients;
    }


    private double EvaluateBicubicPolynomial(double x, double y, Vector<double> coefficients)
    {
        var result = 0.0;
        for (var i = 0; i < 4; i++)
        {
            for (var j = 0; j < 4; j++)
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

    public interface ICubicSplineInterpolationAlgorithmArgs : IInterpolationAlgorithmArgs
    {
        public double[] xValues { get; set; }
        public double[] yValues { get; set; }
    }

    public class CubicSplineInterpolationAlgorithmArgs : ICubicSplineInterpolationAlgorithmArgs
    {
        public double[] xValues { get; set; }
        public double[] yValues { get; set; }

        public CubicSplineInterpolationAlgorithmArgs(double[] xVals, double[] yVals)
        {
            xValues = xVals;
            yValues = yVals;
        }
    }

    public class CubicSplineInterpolation : InterpolationBase
    {
        private IInterpolation _interpolator;

        public CubicSplineInterpolation(ICubicSplineInterpolationAlgorithmArgs args) : base(args)
        {
            _interpolator = MathNet.Numerics.Interpolation.CubicSpline.InterpolateNaturalSorted(((ICubicSplineInterpolationAlgorithmArgs)Args).xValues, ((ICubicSplineInterpolationAlgorithmArgs)Args).yValues);
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

    public interface IBezierInterpolationAlgorithmArgs : IInterpolationAlgorithmArgs
    {
        public double[][] ControlPoints { get; set; }
        public double T { get; set; }
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
        public BezierInterpolation(BezierInterpolationArgs args) : base(args)
        {
        }

        public override int MinSupportedDimension => 2;
        public override int MaxSupportedDimension => 2;  // Now supporting 2D

        public override double Interpolate(double[] flatData, IInterpolationAlgorithmArgs args, int[] dimensions, int[] targetIndices)
        {
            if (dimensions.Length != 2)
            {
                throw new NotSupportedException("Only 2D data supported for Bezier interpolation in this example.");
            }

            var xValue = CalculateBezierValue(((IBezierInterpolationAlgorithmArgs)Args).T, new double[][]
            {
                new double[] { ((IBezierInterpolationAlgorithmArgs)Args).ControlPoints[0][0] },
                new double[] { ((IBezierInterpolationAlgorithmArgs)Args).ControlPoints[1][0] },
                new double[] { ((IBezierInterpolationAlgorithmArgs)Args).ControlPoints[2][0] },
                new double[] { ((IBezierInterpolationAlgorithmArgs)Args).ControlPoints[3][0] },
            });

            var yValue = CalculateBezierValue(((IBezierInterpolationAlgorithmArgs)Args).T, new double[][]
            {
                new double[] { ((IBezierInterpolationAlgorithmArgs)Args).ControlPoints[0][1] },
                new double[] { ((IBezierInterpolationAlgorithmArgs)Args).ControlPoints[1][1] },
                new double[] { ((IBezierInterpolationAlgorithmArgs)Args).ControlPoints[2][1] },
                new double[] { ((IBezierInterpolationAlgorithmArgs)Args).ControlPoints[3][1] },
            });

            // This assumes the 2D data is stored in row-major order. Adjust accordingly if different.
            var flatIndex = targetIndices[0] * dimensions[1] + targetIndices[1];
            flatData[flatIndex] = xValue;  // Storing xValue, but could be changed based on needs
            // Similarly, you could use yValue, perhaps depending on the specific requirements.

            return xValue;  // This returns the x value of the Bezier curve, but it can be adapted based on specific needs.
        }

        private double CalculateBezierValue(double t, double[][] controlPoints)
        {
            var mt = 1 - t;
            return mt * mt * mt * controlPoints[0][0] +
                   3 * mt * mt * t * controlPoints[1][0] +
                   3 * mt * t * t * controlPoints[2][0] +
                   t * t * t * controlPoints[3][0];
        }
    }

    public interface IRbfInterpolationAlgorithmArgs : IInterpolationAlgorithmArgs
    {
        public double[][] KnownPoints { get; set; }
        public double[] KnownValues { get; set; }
        public Func<double, double> RadialFunction { get; set; }
    }

    public class RbfInterpolationArgs : IInterpolationAlgorithmArgs
    {
        public double[][] KnownPoints { get; }  // Each inner array represents a point's coordinates (x, y, z)
        public double[] KnownValues { get; }    // Function values at the known points
        public Func<double, double> RadialFunction { get; }

        public RbfInterpolationArgs(double[][] knownPoints, double[] knownValues, Func<double, double> radialFunction)
        {
            KnownPoints = knownPoints;
            KnownValues = knownValues;
            RadialFunction = radialFunction;
        }
    }

    public class RbfInterpolation : InterpolationBase
    {
        private Vector<double> _weights;

        public RbfInterpolation(IRbfInterpolationAlgorithmArgs args) : base(args)
        {
            ComputeWeights();
        }

        public override int MinSupportedDimension => 1;
        public override int MaxSupportedDimension => 3;

        private void ComputeWeights()
        {
            var N = ((IRbfInterpolationAlgorithmArgs)Args).KnownPoints.Length;
            var matrix = Matrix<double>.Build.Dense(N, N);

            for (var i = 0; i < N; i++)
            {
                for (var j = 0; j < N; j++)
                {
                    var distance = EuclideanDistance(((IRbfInterpolationAlgorithmArgs)Args).KnownPoints[i], ((IRbfInterpolationAlgorithmArgs)Args).KnownPoints[j]);
                    matrix[i, j] = ((IRbfInterpolationAlgorithmArgs)Args).RadialFunction(distance);
                }
            }

            var vector = Vector<double>.Build.DenseOfArray(((IRbfInterpolationAlgorithmArgs)Args).KnownValues);
            _weights = matrix.Solve(vector);
        }

        public override double Interpolate(double[] flatData, IInterpolationAlgorithmArgs args, int[] dimensions, int[] targetIndices)
        {
            if (dimensions.Length > 3)
            {
                throw new NotSupportedException("Only up to 3D data supported for RBF interpolation in this example.");
            }

            var targetPoint = targetIndices.Select(index => (double)index).ToArray();
            double s = 0;

            for (var i = 0; i < ((IRbfInterpolationAlgorithmArgs)Args).KnownPoints.Length; i++)
            {
                var distance = EuclideanDistance(targetPoint, ((IRbfInterpolationAlgorithmArgs)Args).KnownPoints[i]);
                s += _weights[i] * ((IRbfInterpolationAlgorithmArgs)Args).RadialFunction(distance);
            }

            return s;
        }

        private double EuclideanDistance(double[] point1, double[] point2)
        {
            var sum = 0.0;
            for (var i = 0; i < point1.Length; i++)
            {
                sum += (point1[i] - point2[i]) * (point1[i] - point2[i]);
            }
            return Math.Sqrt(sum);
        }
    }


}