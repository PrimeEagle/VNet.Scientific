namespace VNet.Scientific.Smoothing
{
    /*
         Weighted Moving Average (WMA) is a variant of the simple moving average (SMA) that assigns varying weights to different data points in the window, typically giving more weight to the recent data points. This means that more recent data has a greater influence on the average, making the WMA more responsive to recent changes compared to the SMA.

         The formula for a Weighted Moving Average is:

             WMA_t = (w_1 * Y_{t-n+1} + w_2 * Y_{t-n+2} + ... + w_n * Y_t) / (w_1 + w_2 + ... + w_n)

         Where:
         - WMA_t is the weighted moving average at time t.
         - Y_t, Y_{t-1}, etc. are the raw data values.
         - w_1, w_2, ... w_n are the weights for each data point in the window.
         - n is the window size (number of periods).

         For example, given a window size of 3, you might weight the most recent value three times, the next most recent value two times, and the earliest value once. Therefore, if you have the weights [1, 2, 3], the most recent data point would have the largest influence on the WMA.

         The main advantage of WMA is that it's more responsive to recent data changes, offering a better representation of the data's trend compared to the SMA.

         It's important to note that the choice of weights can significantly influence the output of the WMA. For instance, if all weights are the same, the WMA becomes equivalent to the SMA.
    */
    public class WeightedMovingAverageSmoothingAlgorithm : SmoothingBase
    {


        public WeightedMovingAverageSmoothingAlgorithm(IWeightedMovingAverageSmoothingAlgorithmArgs args) : base(args)
        {
            ((IWeightedMovingAverageSmoothingAlgorithmArgs)Args).Weights = ((IWeightedMovingAverageSmoothingAlgorithmArgs)Args).Weights ?? Enumerable.Range(1, ((IWeightedMovingAverageSmoothingAlgorithmArgs)Args).WindowSize).Select(i => (double)i).ToArray();

            if (((IWeightedMovingAverageSmoothingAlgorithmArgs)Args).Weights.Length != ((IWeightedMovingAverageSmoothingAlgorithmArgs)Args).WindowSize)
                throw new ArgumentException("The provided weights array must have the same length as the window size.");
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
            var totalWeights = ((IWeightedMovingAverageSmoothingAlgorithmArgs)Args).Weights.Sum();

            for (var i = 0; i < segment.Count; i++)
            {
                double sum = 0;

                for (var j = 0; j < ((IWeightedMovingAverageSmoothingAlgorithmArgs)Args).WindowSize; j++)
                {
                    var index = i - ((IWeightedMovingAverageSmoothingAlgorithmArgs)Args).WindowSize + 1 + j;
                    if (index < 0 || index >= segment.Count) continue;

                    sum += segment[index] * ((IWeightedMovingAverageSmoothingAlgorithmArgs)Args).Weights[j];
                }

                smoothed[i] = sum / totalWeights;
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