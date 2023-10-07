// ReSharper disable UnusedMember.Global

using VNet.Scientific.Filtering;
using VNet.Scientific.Filtering.Arguments;
// ReSharper disable MemberCanBeMadeStatic.Local
// ReSharper disable SuggestBaseTypeForParameter
// ReSharper disable SuggestBaseTypeForParameterInConstructor
#pragma warning disable CA1822

namespace VNet.Scientific.Noise.Other;
// Octave band noise refers to noise that is divided into distinct frequency bands according to octave intervals. This allows for analysis
// and characterization of noise energy at different frequency ranges. Octave band noise is commonly used in acoustic measurements
// and environmental noise analysis.

public class OctaveBandNoise : NoiseBase
{
    public OctaveBandNoise(IOctaveBandNoiseAlgorithmArgs args)
        : base(args)
    {
    }

    public override double GenerateSingleSampleRaw()
    {
        // Octave band noise is generated for the entire grid, so generating a single sample is not applicable.
        throw new NotImplementedException();
    }

    public override double[] GenerateRaw()
    {
        var totalSize = Args.Dimensions.Aggregate(1, (acc, val) => acc * val);
        var result = new double[totalSize];

        var lowerFrequency = ((IOctaveBandNoiseAlgorithmArgs)Args).CenterFrequency / Math.Pow(2, ((IOctaveBandNoiseAlgorithmArgs)Args).Bandwidth / 2.0);
        var upperFrequency = ((IOctaveBandNoiseAlgorithmArgs)Args).CenterFrequency * Math.Pow(2, ((IOctaveBandNoiseAlgorithmArgs)Args).Bandwidth / 2.0);

        IFilterArgs filterArgs = new FirBandPassFilterArgs
        {
            CutoffHighFrequency = upperFrequency,
            CutoffLowFrequency = lowerFrequency,
            SamplingRate = ((IOctaveBandNoiseAlgorithmArgs)Args).SamplingRate
        };

        var filter = ((IOctaveBandNoiseAlgorithmArgs) Args).Filter;
        var baseNoiseData = Convert1DTo2D(((IOctaveBandNoiseAlgorithmArgs)Args).BaseNoiseAlgorithm.Generate());
        var filteredNoiseData = baseNoiseData;

        if (filter.IsValid())
        {
            filteredNoiseData = (double[,])filter.Filter(baseNoiseData);
        }
        
        result = Convert2DTo1D(filteredNoiseData);
        
        return result;
    }

    // Utility functions to convert between 1D and 2D arrays.
    private double[] Convert2DTo1D(double[,] input)
    {
        var height = input.GetLength(0);
        var width = input.GetLength(1);
        var output = new double[width * height];

        for (var i = 0; i < height; i++)
            for (var j = 0; j < width; j++)
                output[i * width + j] = input[i, j];

        return output;
    }

    private double[,] Convert1DTo2D(double[] input)
    {
        var height = Args.Dimensions[0];
        var width = Args.Dimensions[1];
        var output = new double[height, width];

        for (var i = 0; i < height; i++)
            for (var j = 0; j < width; j++)
                output[i, j] = input[i * width + j];

        return output;
    }
}