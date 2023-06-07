// ReSharper disable UnusedMember.Global
// ReSharper disable MemberCanBeMadeStatic.Local
// ReSharper disable SuggestBaseTypeForParameterInConstructor

#pragma warning disable CA1822
using VNet.Scientific.Filtering.Arguments;

namespace VNet.Scientific.Filtering.Algorithms;

public class MedianFilterAlgorithm : FilterAlgorithmBase
{
    public MedianFilterAlgorithm(AlgorithmBandType bandType, IMedianFilterArgs args) : base(bandType, args)
    {
    }

    public override double[] Apply(double[] input)
    {
        if (BandType != AlgorithmBandType.Denoise) throw new ArgumentException("Invalid filter type.");

        // Apply the filter
        var filter = MathNet.Filtering.OnlineFilter.CreateDenoise(((IMedianFilterArgs)Args).Order);
        var result = filter.ProcessSamples(input);

        return result;
    }

    public override bool IsValid()
    {
        var valid = ((IMedianFilterArgs)Args).Order > 0;
        
        return valid;
    }
}