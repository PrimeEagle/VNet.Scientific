// ReSharper disable UnusedMember.Global
// ReSharper disable MemberCanBeMadeStatic.Local

#pragma warning disable CA1822
using VNet.Scientific.Filter.Arguments;

namespace VNet.Scientific.Filter.Algorithms;

public class IirFilterAlgorithm : FilterAlgorithmBase
{
    public IirFilterAlgorithm(AlgorithmBandType bandType, IIirFilterArgs args) : base(bandType, args)
    {
    }

    public override double[] Apply(double[] input)
    {
        var coefficients = BandType switch
        {
            AlgorithmBandType.LowPass => MathNet.Filtering.IIR.IirCoefficients.LowPass(((IIirLowPassFilterArgs)Args).SamplingRate, ((IIirLowPassFilterArgs)Args).CutoffFrequency, ((IIirLowPassFilterArgs)Args).Bandwidth),
            AlgorithmBandType.HighPass => MathNet.Filtering.IIR.IirCoefficients.HighPass(((IIirHighPassFilterArgs)Args).SamplingRate, ((IIirHighPassFilterArgs)Args).CutoffFrequency, ((IIirLowPassFilterArgs)Args).Bandwidth),
            AlgorithmBandType.BandPass => MathNet.Filtering.IIR.IirCoefficients.BandPass(((IIirBandPassFilterArgs)Args).SamplingRate, ((IIirBandPassFilterArgs)Args).CutoffLowFrequency, ((IIirBandPassFilterArgs)Args).CutoffHighFrequency),
            AlgorithmBandType.BandStop => MathNet.Filtering.IIR.IirCoefficients.BandStop(((IIirBandStopFilterArgs)Args).SamplingRate, ((IIirBandStopFilterArgs)Args).CutoffLowFrequency, ((IIirBandStopFilterArgs)Args).CutoffHighFrequency),
            _ => throw new ArgumentException("Invalid filter type.")
        };

        // Apply the filter
        var filter = new MathNet.Filtering.IIR.OnlineIirFilter(coefficients);
        var result = filter.ProcessSamples(input);

        return result;
    }

    public override bool IsValid()
    {
        var valid = ((IIirFilterArgs)Args).SamplingRate > 0;
        if (valid && BandType == AlgorithmBandType.LowPass) valid &= ((IIirLowPassFilterArgs)Args).CutoffFrequency > 0;
        if (valid && BandType == AlgorithmBandType.HighPass) valid &= ((IIirLowPassFilterArgs)Args).CutoffFrequency > 0;
        if (valid && BandType == AlgorithmBandType.LowPass) valid &= ((IIirLowPassFilterArgs)Args).Bandwidth > 0;
        if (valid && BandType == AlgorithmBandType.HighPass) valid &= ((IIirLowPassFilterArgs)Args).Bandwidth > 0;
        if (valid && BandType == AlgorithmBandType.BandPass) valid &= ((IIirBandPassFilterArgs)Args).CutoffLowFrequency > 0;
        if (valid && BandType == AlgorithmBandType.BandPass) valid &= ((IIirBandPassFilterArgs)Args).CutoffHighFrequency > 0;
        if (valid && BandType == AlgorithmBandType.BandStop) valid &= ((IIirBandStopFilterArgs)Args).CutoffLowFrequency > 0;
        if (valid && BandType == AlgorithmBandType.BandStop) valid &= ((IIirBandStopFilterArgs)Args).CutoffHighFrequency > 0;

        return valid;
    }
}