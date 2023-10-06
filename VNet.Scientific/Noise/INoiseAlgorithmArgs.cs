using VNet.Mathematics.Randomization;
using VNet.Mathematics.Randomization.Distribution;
using VNet.Scientific.Filtering;

namespace VNet.Scientific.Noise
{
    public interface INoiseAlgorithmArgs : IRandomizationAlgorithmArgs
    {
        int[] Dimensions { get; set; }
        int QuantizeLevels { get; set; }
        double Scale { get; set; }
        bool NormalizeOutput { get; set; }
        double DesiredMinValue { get; set; }
        double DesiredMaxValue { get; set; }
        IRandomDistributionAlgorithm RandomDistributionAlgorithm { get; set; }
        IFilter? OutputFilter { get; set; }

        INoiseAlgorithmArgs Clone();
    }
}