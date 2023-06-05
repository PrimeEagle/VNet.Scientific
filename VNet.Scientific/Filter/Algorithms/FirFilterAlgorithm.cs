// ReSharper disable UnusedMember.Global
// ReSharper disable MemberCanBeMadeStatic.Local

#pragma warning disable CA1822
using VNet.Scientific.Filter.Arguments;

namespace VNet.Scientific.Filter.Algorithms;

public class FirFilterAlgorithm : FilterAlgorithmBase
{
    public FirFilterAlgorithm(AlgorithmBandType bandType, IFirFilterArgs args) : base(bandType, args)
    {
    }

    public override double[] Apply(double[] input)
    {
        var coefficients = BandType switch
        {
            AlgorithmBandType.LowPass => MathNet.Filtering.FIR.FirCoefficients.LowPass(((IFirLowPassFilterArgs)Args).SamplingRate, ((IFirLowPassFilterArgs)Args).CutoffFrequency),
            AlgorithmBandType.HighPass => MathNet.Filtering.FIR.FirCoefficients.HighPass(((IFirHighPassFilterArgs)Args).SamplingRate, ((IFirHighPassFilterArgs)Args).CutoffFrequency),
            AlgorithmBandType.BandPass => MathNet.Filtering.FIR.FirCoefficients.BandPass(((IFirBandPassFilterArgs)Args).SamplingRate, ((IFirBandPassFilterArgs)Args).CutoffLowFrequency, ((IFirBandPassFilterArgs)Args).CutoffHighFrequency),
            AlgorithmBandType.BandStop => MathNet.Filtering.FIR.FirCoefficients.BandStop(((IFirBandStopFilterArgs)Args).SamplingRate, ((IFirBandStopFilterArgs)Args).CutoffLowFrequency, ((IFirBandStopFilterArgs)Args).CutoffHighFrequency),
            _ => throw new ArgumentException("Invalid filter type.")
        };

        // Apply the filter
        ApplyWindowFunction(coefficients);
        var filter = new MathNet.Filtering.FIR.OnlineFirFilter(coefficients);
        var result = filter.ProcessSamples(input);

        return result;
    }

    public override bool IsValid()
    {
        var valid = ((IFirFilterArgs)Args).SamplingRate > 0;
        if (valid && BandType == AlgorithmBandType.LowPass) valid &= ((IFirLowPassFilterArgs)Args).CutoffFrequency > 0;
        if (valid && BandType == AlgorithmBandType.HighPass) valid &= ((IFirLowPassFilterArgs)Args).CutoffFrequency > 0;
        if (valid && BandType == AlgorithmBandType.BandPass) valid &= ((IFirBandPassFilterArgs)Args).CutoffLowFrequency > 0;
        if (valid && BandType == AlgorithmBandType.BandPass) valid &= ((IFirBandPassFilterArgs)Args).CutoffHighFrequency > 0;
        if (valid && BandType == AlgorithmBandType.BandStop) valid &= ((IFirBandStopFilterArgs)Args).CutoffLowFrequency > 0;
        if (valid && BandType == AlgorithmBandType.BandStop) valid &= ((IFirBandStopFilterArgs)Args).CutoffHighFrequency > 0;

        return valid;
    }

    private void ApplyWindowFunction(IList<double> coefficients)
    {
        MathNet.Filtering.Windowing.Window window;

        switch (((IFirFilterArgs)Args).WindowFunction)
        {
            case WindowFunction.BartlettHann:
                window = new MathNet.Filtering.Windowing.BartlettHannWindow();
                break;
            case WindowFunction.Bartlett:
                window = new MathNet.Filtering.Windowing.BartlettWindow();
                break;
            case WindowFunction.BlackmanHarris:
                window = new MathNet.Filtering.Windowing.BlackmanHarrisWindow();
                break;
            case WindowFunction.BlackmanNuttall:
                window = new MathNet.Filtering.Windowing.BlackmanNuttallWindow();
                break;
            case WindowFunction.Blackman:
                window = new MathNet.Filtering.Windowing.BlackmanWindow();
                break;
            case WindowFunction.Cosine:
                window = new MathNet.Filtering.Windowing.CosineWindow();
                break;
            case WindowFunction.FlatTop:
                window = new MathNet.Filtering.Windowing.FlatTopWindow();
                break;
            case WindowFunction.Gauss:
                window = new MathNet.Filtering.Windowing.GaussWindow(((IFirFilterArgs)Args).Sigma);
                break;
            case WindowFunction.Hamming:
                window = new MathNet.Filtering.Windowing.HammingWindow();
                break;
            case WindowFunction.Hann:
                window = new MathNet.Filtering.Windowing.HannWindow();
                break;
            case WindowFunction.Lanczos:
                window = new MathNet.Filtering.Windowing.LanczosWindow();
                break;
            case WindowFunction.Nuttall:
                window = new MathNet.Filtering.Windowing.NuttallWindow();
                break;
            case WindowFunction.Rectangular:
                window = new MathNet.Filtering.Windowing.RectangularWindow();
                break;
            case WindowFunction.Triangular:
                window = new MathNet.Filtering.Windowing.TriangularWindow();
                break;
            case WindowFunction.None:
            default:
                return;
        }

        window.Width = coefficients.Count;
        var windowArr = window.CopyToArray();

        for (var i = 0; i < coefficients.Count; i++)
            coefficients[i] *= windowArr[i];
    }
}