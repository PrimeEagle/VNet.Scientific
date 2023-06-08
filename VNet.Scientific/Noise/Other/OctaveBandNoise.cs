//// ReSharper disable UnusedMember.Global

//using VNet.Scientific.Filtering;
//using VNet.Scientific.Filtering.Arguments;

//namespace VNet.Scientific.Noise.Other;
//// Octave band noise refers to noise that is divided into distinct frequency bands according to octave intervals. This allows for analysis
//// and characterization of noise energy at different frequency ranges. Octave band noise is commonly used in acoustic measurements
//// and environmental noise analysis.

//public class OctaveBandNoise : INoiseAlgorithm
//{
//    private double _centerFrequency;
//    private double _bandwidth;
//    private INoiseAlgorithm _baseNoise;

//    public OctaveBandNoise(double centerFrequency, double bandwidth, INoiseAlgorithm baseNoise)
//    {
//        _centerFrequency = centerFrequency;
//        _bandwidth = bandwidth;
//        _baseNoise = baseNoise;
//    }

//    public double[,] Generate(INoiseAlgorithmArgs args)
//    {
//        int width = Args.Width;
//        int height = Args.Height;

//        double[,] result = new double[height, width];

//        double lowerFrequency = _centerFrequency / Math.Pow(2, _bandwidth / 2.0);
//        double upperFrequency = _centerFrequency * Math.Pow(2, _bandwidth / 2.0);

//        IFilterArgs filterArgs = new BandPassFilterArgs
//        {
//            SampleRate = Args.SampleRate,
//            LowCutoffFrequency = lowerFrequency,
//            HighCutoffFrequency = upperFrequency
//        };

//        if (_baseNoise is IFilteredNoiseAlgorithm filteredNoise)
//        {
//            result = filteredNoise.GenerateFilteredNoise(args, filterArgs);
//        }
//        else
//        {
//            double[,] baseNoiseData = _baseNoise.Generate(args);
//            result = FilterNoise(baseNoiseData, Args.SampleRate, filterArgs);
//        }

//        return result;
//    }

//    public double GenerateSingleSample(INoiseAlgorithmArgs args)
//    {
//        // Octave band noise is generated for the entire grid, so generating a single sample is not applicable.
//        throw new NotImplementedException();
//    }

//    private double[,] FilterNoise(double[,] noiseData, double sampleRate, IFilterArgs filterArgs)
//    {
//        int height = noiseData.GetLength(0);
//        int width = noiseData.GetLength(1);

//        double[,] result = new double[height, width];

//        for (int i = 0; i < height; i++)
//        {
//            double[] input = new double[width];
//            for (int j = 0; j < width; j++)
//            {
//                input[j] = noiseData[i, j];
//            }

//            double[] filteredSamples = FilterSamples(input, sampleRate, filterArgs);

//            for (int j = 0; j < width; j++)
//            {
//                result[i, j] = filteredSamples[j];
//            }
//        }

//        return result;
//    }

//    private double[] FilterSamples(double[] input, double sampleRate, IFilterArgs filterArgs)
//    {
//        IFilter filter = FilterFactory.CreateFilter(filterArgs);

//        if (filter is null || !filter.IsValid(filterArgs))
//        {
//            return input;
//        }

//        return filter.Filter(input, filterArgs);
//    }
//}