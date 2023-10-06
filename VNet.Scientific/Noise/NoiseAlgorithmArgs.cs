using VNet.Mathematics.Randomization.Distribution;
using VNet.Scientific.Filtering;

namespace VNet.Scientific.Noise
{
    public class NoiseAlgorithmArgs : INoiseAlgorithmArgs
    {
        public int[] Dimensions { get; set; }
        public int QuantizeLevels { get; set; }
        public double Scale { get; set; }
        public bool NormalizeOutput { get; set; }
        public double DesiredMinValue { get; set; }
        public double DesiredMaxValue { get; set; }
        public IRandomDistributionAlgorithm RandomDistributionAlgorithm { get; set; }
        public IFilter? OutputFilter { get; set; }

        public NoiseAlgorithmArgs() { }

        public NoiseAlgorithmArgs(IRandomDistributionAlgorithm distributionAlgorithm)
        {
            RandomDistributionAlgorithm = distributionAlgorithm;
            QuantizeLevels = 1;
            Scale = 1.0d;
            NormalizeOutput = false;
        }

        public INoiseAlgorithmArgs Clone()
        {
            return new NoiseAlgorithmArgs(RandomDistributionAlgorithm)
            {
                Dimensions = (int[])Dimensions.Clone(),
                QuantizeLevels = QuantizeLevels,
                RandomDistributionAlgorithm = RandomDistributionAlgorithm,
                Scale = Scale,
                OutputFilter = OutputFilter,
                NormalizeOutput = NormalizeOutput,
                DesiredMinValue = DesiredMinValue,
                DesiredMaxValue = DesiredMaxValue
            };
        }
    }
}