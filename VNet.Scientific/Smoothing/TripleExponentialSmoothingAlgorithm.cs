namespace VNet.Scientific.Smoothing
{
    /*
        Triple Exponential Smoothing, often referred to as the Holt-Winters method, is an advanced technique to predict data points in a time series. It takes into consideration three components:

        1. Level (the average value in the series).
        2. Trend (the increasing or decreasing value in the series).
        3. Seasonality (the repeating short-term cycle in the series).

        The method uses three smoothing constants:
        - α (Alpha): For the level.
        - β (Beta): For the trend.
        - γ (Gamma): For the seasonality.

        Additionally, a seasonal period, m, is required. This defines the number of time units per season.

        The recursive formulas for triple exponential smoothing are:

        1. S_t = α × (Y_t - I_{t-m}) + (1 - α) × (S_{t-1} + T_{t-1})
        2. T_t = β × (S_t - S_{t-1}) + (1 - β) × T_{t-1}
        3. I_t = γ × (Y_t - S_t) + (1 - γ) × I_{t-m}
        4. F_{t+1} = S_t + T_t + I_{t+1-m}

        Where:
        - S_t is the smoothed value at time t.
        - T_t is the trend value at time t.
        - I_t is the seasonal index at time t.
        - Y_t is the raw value at time t.
        - F_{t+1} is the forecast for the next period.
        - m is the number of time units per season.

        By applying these formulas iteratively, we can predict future data points in the time series. It is particularly effective when data has clear trend and seasonality.
    */
    public class TripleExponentialSmoothingAlgorithm : SmoothingBase
    {
        public TripleExponentialSmoothingAlgorithm(ITripleExponentialSmoothingAlgorithmArgs args) : base(args)
        {
            if (((ITripleExponentialSmoothingAlgorithmArgs)Args).Alpha < 0 || ((ITripleExponentialSmoothingAlgorithmArgs)Args).Alpha > 1 ||
                ((ITripleExponentialSmoothingAlgorithmArgs)Args).Beta < 0 || ((ITripleExponentialSmoothingAlgorithmArgs)Args).Beta > 1 ||
                ((ITripleExponentialSmoothingAlgorithmArgs)Args).Gamma < 0 || ((ITripleExponentialSmoothingAlgorithmArgs)Args).Gamma > 1)
                throw new ArgumentOutOfRangeException("Alpha, Beta, and Gamma should be between 0 and 1.");
        }

        public override Array Smooth(Array data, params int[] smoothDimensions)
        {
            if (!AreValidDimensions(data.Rank, smoothDimensions))
            {
                throw new ArgumentException("Invalid smoothing dimension(s) for the given data rank.");
            }

            return data.Rank switch
            {
                2 => SmoothData((double[,]) data, smoothDimensions),
                3 => SmoothData((double[,,]) data, smoothDimensions),
                _ => throw new ArgumentException("Unsupported number of dimensions.")
            };
        }

        private double[] Smooth1D(IReadOnlyList<double> segment)
        {
            var smoothed = new double[segment.Count];
            var trend = new double[segment.Count];
            var seasonal = new double[segment.Count];

            smoothed[0] = segment[0];
            trend[0] = segment[1] - segment[0];

            for (var i = 0; i < ((ITripleExponentialSmoothingAlgorithmArgs)Args).SeasonalPeriod; i++)
            {
                seasonal[i] = segment[i];
            }

            for (var i = 1; i < segment.Count; i++)
            {
                var prevSmoothed = smoothed[i - 1];
                var seasonIndex = (i - ((ITripleExponentialSmoothingAlgorithmArgs)Args).SeasonalPeriod) >= 0 ? seasonal[i - ((ITripleExponentialSmoothingAlgorithmArgs)Args).SeasonalPeriod] : 1;
                if (i >= ((ITripleExponentialSmoothingAlgorithmArgs)Args).SeasonalPeriod)
                {
                    smoothed[i] = ((ITripleExponentialSmoothingAlgorithmArgs)Args).Alpha * (segment[i] - seasonIndex) + (1 - ((ITripleExponentialSmoothingAlgorithmArgs)Args).Alpha) * (prevSmoothed + trend[i - 1]);
                    trend[i] = ((ITripleExponentialSmoothingAlgorithmArgs)Args).Beta * (smoothed[i] - prevSmoothed) + (1 - ((ITripleExponentialSmoothingAlgorithmArgs)Args).Beta) * trend[i - 1];
                    seasonal[i] = ((ITripleExponentialSmoothingAlgorithmArgs)Args).Gamma * (segment[i] - smoothed[i]) + (1 - ((ITripleExponentialSmoothingAlgorithmArgs)Args).Gamma) * seasonIndex;
                }
                else
                {
                    smoothed[i] = segment[i];
                    trend[i] = trend[0];
                }
            }

            for (var i = 0; i < segment.Count; i++)
            {
                smoothed[i] += trend[i] + (i >= ((ITripleExponentialSmoothingAlgorithmArgs)Args).SeasonalPeriod ? seasonal[i - ((ITripleExponentialSmoothingAlgorithmArgs)Args).SeasonalPeriod] : seasonal[i]);
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
                switch (dim)
                {
                    // smoothing along the X dimension
                    case 0:
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

                        break;
                    }
                    // smoothing along the Y dimension
                    case 1:
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

                        break;
                    }
                    // smoothing along the Z dimension
                    case 2:
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

                        break;
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