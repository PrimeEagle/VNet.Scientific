// ReSharper disable MemberCanBeMadeStatic.Local
namespace VNet.Scientific.Smoothing
{
    /*
        Simple Exponential Smoothing (SES) is a time series forecasting method for univariate data without a trend or seasonality. It requires a single parameter, α (alpha), also called the smoothing factor. This parameter controls the rate at which the influence of the observations at prior time steps decay exponentially. α ranges between 0 and 1.

        The formula for Simple Exponential Smoothing is:

            S_t = α × Y_t + (1 - α) × S_{t-1}

        Where:
        - S_t is the smoothed value at time t.
        - Y_t is the raw data value at time t.
        - S_{t-1} is the smoothed value of the previous time step.
        - α (Alpha) is the smoothing factor.

        When α is close to 1, the model pays attention mostly to the most recent observations. When α is close to 0, the model considers observations from the more distant past.

        The main advantage of SES is its simplicity and its ability to model the level of a time series, providing forecasts that average out noise. However, it doesn't account for trends or seasonality in the data.
    */
    public class ExponentialSmoothingAlgorithm : SmoothingBase
    {
        public ExponentialSmoothingAlgorithm(IExponentialSmoothingAlgorithmArgs args) : base(args)
        {
            if (((IExponentialSmoothingAlgorithmArgs)Args).Alpha is < 0 or > 1)
                throw new ArgumentOutOfRangeException("Alpha", "Alpha should be between 0 and 1.");
        }

        public override Array Smooth(Array data, params int[] smoothDimensions)
        {
            if (!AreValidDimensions(data.Rank, smoothDimensions))
            {
                throw new ArgumentException("Invalid smoothing dimension(s) for the given data rank.");
            }

            return data.Rank switch
            {
                2 => SmoothData((double[,])data, smoothDimensions),
                3 => SmoothData((double[,,])data, smoothDimensions),
                _ => throw new ArgumentException("Unsupported number of dimensions.")
            };
        }

        private double[] Smooth1D(IReadOnlyList<double> segment)
        {
            var smoothed = new double[segment.Count];
            smoothed[0] = segment[0]; // initialize the first value

            for (var i = 1; i < segment.Count; i++)
            {
                smoothed[i] = ((IExponentialSmoothingAlgorithmArgs)Args).Alpha * segment[i] + (1 - ((IExponentialSmoothingAlgorithmArgs)Args).Alpha) * smoothed[i - 1];
            }

            return smoothed;
        }

        private double[,] SmoothData(double[,] data, IEnumerable<int> smoothDimensions)
        {
            var width = data.GetLength(0);
            var height = data.GetLength(1);

            var result = (double[,])data.Clone();

            foreach (var dim in smoothDimensions)
            {
                switch (dim)
                {
                    // smoothing along the first dimension
                    case 0:
                        {
                            for (var y = 0; y < height; y++)
                            {
                                var segment = new double[width];
                                for (var x = 0; x < width; x++)
                                    segment[x] = data[x, y];

                                var smoothedSegment = Smooth1D(segment);
                                for (var x = 0; x < width; x++)
                                    result[x, y] = smoothedSegment[x];
                            }

                            break;
                        }
                    // smoothing along the second dimension
                    case 1:
                        {
                            for (var x = 0; x < width; x++)
                            {
                                var segment = new double[height];
                                for (var y = 0; y < height; y++)
                                    segment[y] = data[x, y];

                                var smoothedSegment = Smooth1D(segment);
                                for (var y = 0; y < height; y++)
                                    result[x, y] = smoothedSegment[y];
                            }

                            break;
                        }
                }
            }

            return result;
        }

        private double[,,] SmoothData(double[,,] data, IEnumerable<int> smoothDimensions)
        {
            var width = data.GetLength(0);
            var height = data.GetLength(1);
            var depth = data.GetLength(2);

            var result = (double[,,])data.Clone();

            foreach (var dim in smoothDimensions)
            {
                if (dim != 0) // smoothing along the X dimension
                {
                    if (dim != 1) // smoothing along the Y dimension
                    {
                        if (dim != 2) continue; // smoothing along the Z dimension
                        for (var x = 0; x < width; x++)
                        {
                            for (var y = 0; y < height; y++)
                            {
                                var segment = new double[depth];
                                for (var z = 0; z < depth; z++)
                                {
                                    segment[z] = data[x, y, z];
                                }

                                var smoothedSegment = Smooth1D(segment);
                                for (var z = 0; z < depth; z++)
                                {
                                    result[x, y, z] = smoothedSegment[z];
                                }
                            }
                        }
                    }
                    else
                    {
                        for (var x = 0; x < width; x++)
                        {
                            for (var z = 0; z < depth; z++)
                            {
                                var segment = new double[height];
                                for (var y = 0; y < height; y++)
                                {
                                    segment[y] = data[x, y, z];
                                }

                                var smoothedSegment = Smooth1D(segment);
                                for (var y = 0; y < height; y++)
                                {
                                    result[x, y, z] = smoothedSegment[y];
                                }
                            }
                        }
                    }
                }
                else
                {
                    for (var y = 0; y < height; y++)
                    {
                        for (var z = 0; z < depth; z++)
                        {
                            var segment = new double[width];
                            for (var x = 0; x < width; x++)
                            {
                                segment[x] = data[x, y, z];
                            }

                            var smoothedSegment = Smooth1D(segment);
                            for (var x = 0; x < width; x++)
                            {
                                result[x, y, z] = smoothedSegment[x];
                            }
                        }
                    }
                }
            }

            return result;
        }

        private bool AreValidDimensions(int rank, IEnumerable<int> smoothDimensions)
        {
            return smoothDimensions.All(dim => dim >= 0 && dim < rank);
        }
    }
}