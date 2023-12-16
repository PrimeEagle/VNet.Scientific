namespace VNet.Scientific.Smoothing
{
    /*
        Double Exponential Smoothing, also known as Holt's linear exponential smoothing, is used for forecasting time series data that has a trend, but no significant seasonality.

        This method involves two smoothing equations - one for the level and one for the trend:

        1. Level: Captures the current value or average of the series.
        2. Trend: Captures the general direction in which the series is moving.

        The method uses two smoothing constants:
        - α (Alpha): For the level.
        - β (Beta): For the trend.

        The recursive formulas for double exponential smoothing are:

        1. S_t = α × Y_t + (1 - α) × (S_{t-1} + T_{t-1})
        2. T_t = β × (S_t - S_{t-1}) + (1 - β) × T_{t-1}
        3. F_{t+1} = S_t + T_t

        Where:
        - S_t is the smoothed value at time t.
        - T_t is the trend value at time t.
        - Y_t is the raw value at time t.
        - F_{t+1} is the forecast for the next period.

        Double Exponential Smoothing can effectively predict the future values in a time series that has a trend, whether upward or downward.
    */
    public class DoubleExponentialSmoothingAlgorithm : SmoothingBase
    {

        public DoubleExponentialSmoothingAlgorithm(IDoubleExponentialSmoothingAlgorithmArgs args) : base(args)
        {
            if (((IDoubleExponentialSmoothingAlgorithmArgs)Args).Alpha < 0 || ((IDoubleExponentialSmoothingAlgorithmArgs)Args).Alpha > 1 || 
                ((IDoubleExponentialSmoothingAlgorithmArgs)Args).Beta < 0 || ((IDoubleExponentialSmoothingAlgorithmArgs)Args).Beta > 1)
                throw new ArgumentOutOfRangeException("Alpha and Beta should be between 0 and 1.");
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
            var trend = new double[segment.Count];

            smoothed[0] = segment[0]; // initialize the first value
            trend[0] = segment[1] - segment[0]; // initialize the first trend value

            for (var i = 1; i < segment.Count; i++)
            {
                var prevSmoothed = smoothed[i - 1];
                smoothed[i] = ((IDoubleExponentialSmoothingAlgorithmArgs)Args).Alpha * segment[i] + (1 - ((IDoubleExponentialSmoothingAlgorithmArgs)Args).Alpha) * (prevSmoothed + trend[i - 1]);
                trend[i] = ((IDoubleExponentialSmoothingAlgorithmArgs)Args).Beta * (smoothed[i] - prevSmoothed) + (1 - ((IDoubleExponentialSmoothingAlgorithmArgs)Args).Beta) * trend[i - 1];
            }

            for (var i = 0; i < segment.Count; i++)
            {
                smoothed[i] += trend[i]; // adding trend component for forecast
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
                if (dim == 0)  // smoothing along the X dimension
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
                else if (dim == 1)  // smoothing along the Y dimension
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
                else if (dim == 2)  // smoothing along the Z dimension
                {
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
            }

            return result;
        }

        private bool AreValidDimensions(int rank, IEnumerable<int> smoothDimensions)
        {
            return smoothDimensions.All(dim => dim >= 0 && dim < rank);
        }
    }
}