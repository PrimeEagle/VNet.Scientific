namespace VNet.Scientific.Smoothing
{
    /*
        Moving Average (MA) is a simple technique used to smooth out short-term fluctuations and highlight long-term trends in data. Unlike other methods which forecast based on the data points themselves, moving averages use the average of data points to forecast.

        There are several types of moving averages, but the most common one is the Simple Moving Average (SMA).

        The formula for a Simple Moving Average is:

            SMA_t = (Y_{t-n+1} + Y_{t-n+2} + ... + Y_t) / n

        Where:
        - SMA_t is the simple moving average at time t.
        - Y_t, Y_{t-1}, etc. are the raw data values.
        - n is the window size (number of periods).

        For a given window size n:
        - For the first value of SMA, we average the first n data points.
        - For the second value, we move one time step ahead and average the next n data points.
        - This process continues until we've averaged all possible contiguous groups of n data points.

        The main advantage of the moving average is its simplicity and its ability to remove noise from the dataset, allowing clearer identification of the underlying trend. However, since it's a lagging indicator, it may not be responsive enough for forecasting fast-changing data.

        Note: There are also other variations of moving averages like Weighted Moving Average (WMA), and Exponential Moving Average (EMA) that give different weights to different observations.
    */
    public class MovingAverageSmoothingAlgorithm : SmoothingBase
    {
        public MovingAverageSmoothingAlgorithm(IMovingAverageSmoothingAlgorithmArgs args) : base(args)
        {
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
            for (var i = 0; i < segment.Count; i++)
            {
                var count = 0;
                double sum = 0;
                for (var j = i - ((IMovingAverageSmoothingAlgorithmArgs)Args).WindowSize; j <= i + ((IMovingAverageSmoothingAlgorithmArgs)Args).WindowSize; j++)
                {
                    if (j < 0 || j >= segment.Count) continue;

                    sum += segment[j];
                    count++;
                }

                smoothed[i] = sum / count;
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