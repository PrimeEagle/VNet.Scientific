// ReSharper disable UnusedMember.Global
// ReSharper disable MemberCanBeMadeStatic.Local
// ReSharper disable SuggestBaseTypeForParameterInConstructor

#pragma warning disable CA1822
using VNet.Scientific.Filter.Arguments;

namespace VNet.Scientific.Filter.Algorithms;

public class ButterworthFilterAlgorithm : FilterAlgorithmBase
{
    public ButterworthFilterAlgorithm(AlgorithmBandType bandType, IButterworthFilterArgs args) : base(bandType, args)
    {
    }

    public override double[] Apply(double[] input)
    {
        var coefficients = BandType switch
        {
            AlgorithmBandType.LowPass => MathNet.Filtering.Butterworth.IirCoefficients.LowPass(((IButterworthLowPassFilterArgs)Args).PassBandFrequency, ((IButterworthLowPassFilterArgs)Args).StopBandFrequency, ((IButterworthFilterArgs)Args).PassBandRipple, ((IButterworthFilterArgs)Args).StopBandAttenuation),
            AlgorithmBandType.HighPass => MathNet.Filtering.Butterworth.IirCoefficients.HighPass(((IButterworthLowPassFilterArgs)Args).StopBandFrequency, ((IButterworthHighPassFilterArgs)Args).PassBandFrequency, ((IButterworthFilterArgs)Args).PassBandRipple, ((IButterworthFilterArgs)Args).StopBandAttenuation),
            AlgorithmBandType.BandPass => MathNet.Filtering.Butterworth.IirCoefficients.BandPass(((IButterworthBandPassFilterArgs)Args).LowStopBandFrequency, ((IButterworthBandPassFilterArgs)Args).LowPassBandFrequency, ((IButterworthBandPassFilterArgs)Args).HighPassBandFrequency, ((IButterworthBandPassFilterArgs)Args).HighStopBandFrequency, ((IButterworthFilterArgs)Args).PassBandRipple, ((IButterworthFilterArgs)Args).StopBandAttenuation),
            AlgorithmBandType.BandStop => MathNet.Filtering.Butterworth.IirCoefficients.BandStop(((IButterworthBandStopFilterArgs)Args).LowPassBandFrequency, ((IButterworthBandStopFilterArgs)Args).LowStopBandFrequency, ((IButterworthBandStopFilterArgs)Args).HighStopBandFrequency, ((IButterworthBandStopFilterArgs)Args).HighPassBandFrequency, ((IButterworthFilterArgs)Args).PassBandRipple, ((IButterworthFilterArgs)Args).StopBandAttenuation),
            AlgorithmBandType.Notch => MathNet.Filtering.Butterworth.IirCoefficients.Notch(((IButterworthNotchFilterArgs)Args).CentralFrequency, ((IButterworthNotchFilterArgs)Args).Q, ((IButterworthFilterArgs)Args).PassBandRipple, ((IButterworthFilterArgs)Args).StopBandAttenuation),
            _ => throw new ArgumentException("Invalid filter type.")
        };

        // transform coefficients
        var coefficients2 = new double[6];
        var len = coefficients.denominator.Length;
        for (var i = 0; i < len; i++)
        {
            coefficients2[i] = coefficients.numerator[i];
            coefficients2[i + len] = coefficients.denominator[i];
        }

        // Apply the filter
        var filter = new MathNet.Filtering.IIR.OnlineIirFilter(coefficients2);
        var result = filter.ProcessSamples(input);

        return result;
    }

    public override bool IsValid()
    {
        var valid = ((IButterworthFilterArgs)Args).PassBandRipple > 0;
        if (valid && ((IButterworthFilterArgs) Args).StopBandAttenuation > 0) ;
        if (valid && BandType == AlgorithmBandType.LowPass) valid &= ((IButterworthLowPassFilterArgs)Args).PassBandFrequency > 0;
        if (valid && BandType == AlgorithmBandType.HighPass) valid &= ((IButterworthLowPassFilterArgs)Args).PassBandFrequency > 0;
        if (valid && BandType == AlgorithmBandType.LowPass) valid &= ((IButterworthLowPassFilterArgs)Args).StopBandFrequency > 0;
        if (valid && BandType == AlgorithmBandType.HighPass) valid &= ((IButterworthLowPassFilterArgs)Args).StopBandFrequency > 0;
        if (valid && BandType == AlgorithmBandType.LowPass) valid &= ((IButterworthLowPassFilterArgs)Args).PassBandRipple > 0;
        if (valid && BandType == AlgorithmBandType.HighPass) valid &= ((IButterworthLowPassFilterArgs)Args).StopBandAttenuation > 0;

        if (valid && BandType == AlgorithmBandType.BandPass) valid &= ((IButterworthBandPassFilterArgs)Args).LowPassBandFrequency > 0;
        if (valid && BandType == AlgorithmBandType.BandPass) valid &= ((IButterworthBandPassFilterArgs)Args).HighPassBandFrequency > 0;
        if (valid && BandType == AlgorithmBandType.BandPass) valid &= ((IButterworthBandPassFilterArgs)Args).LowStopBandFrequency > 0;
        if (valid && BandType == AlgorithmBandType.BandPass) valid &= ((IButterworthBandPassFilterArgs)Args).HighStopBandFrequency > 0;
        if (valid && BandType == AlgorithmBandType.BandPass) valid &= ((IButterworthBandPassFilterArgs)Args).PassBandRipple > 0;
        if (valid && BandType == AlgorithmBandType.BandPass) valid &= ((IButterworthBandPassFilterArgs)Args).StopBandAttenuation > 0;

        if (valid && BandType == AlgorithmBandType.BandStop) valid &= ((IButterworthBandPassFilterArgs)Args).LowPassBandFrequency > 0;
        if (valid && BandType == AlgorithmBandType.BandStop) valid &= ((IButterworthBandPassFilterArgs)Args).HighPassBandFrequency > 0;
        if (valid && BandType == AlgorithmBandType.BandStop) valid &= ((IButterworthBandStopFilterArgs)Args).LowStopBandFrequency > 0;
        if (valid && BandType == AlgorithmBandType.BandStop) valid &= ((IButterworthBandStopFilterArgs)Args).HighStopBandFrequency > 0;
        if (valid && BandType == AlgorithmBandType.BandStop) valid &= ((IButterworthBandStopFilterArgs)Args).PassBandRipple > 0;
        if (valid && BandType == AlgorithmBandType.BandStop) valid &= ((IButterworthBandStopFilterArgs)Args).StopBandAttenuation > 0;

        if (valid && BandType == AlgorithmBandType.Notch) valid &= ((IButterworthNotchFilterArgs)Args).CentralFrequency > 0;
        if (valid && BandType == AlgorithmBandType.Notch) valid &= ((IButterworthNotchFilterArgs)Args).Q > 0;
        if (valid && BandType == AlgorithmBandType.Notch) valid &= ((IButterworthNotchFilterArgs)Args).PassBandRipple > 0;
        if (valid && BandType == AlgorithmBandType.Notch) valid &= ((IButterworthNotchFilterArgs)Args).StopBandAttenuation > 0;

        return valid;
    }
}