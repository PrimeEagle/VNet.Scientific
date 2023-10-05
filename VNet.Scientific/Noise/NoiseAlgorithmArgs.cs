using VNet.Mathematics.Randomization.Distribution;
using VNet.Scientific.Filtering;

namespace VNet.Scientific.Noise
{
    public class NoiseAlgorithmArgs : INoiseAlgorithmArgs
    {
        public int[] Dimensions { get; set; }
        public int QuantizeLevels { get; set; }
        public double Scale { get; set; }
        public IRandomDistributionAlgorithm RandomDistributionAlgorithm { get; set; }
        public IFilter? OutputFilter { get; set; }

        public NoiseAlgorithmArgs() { }

        public NoiseAlgorithmArgs(IRandomDistributionAlgorithm distributionAlgorithm)
        {
            RandomDistributionAlgorithm = distributionAlgorithm;
            QuantizeLevels = 0;
            Scale = 1.0d;
        }

        public INoiseAlgorithmArgs Clone()
        {
            return new NoiseAlgorithmArgs(RandomDistributionAlgorithm)
            {
                Dimensions = (int[])Dimensions.Clone(),
                QuantizeLevels = QuantizeLevels,
                RandomDistributionAlgorithm = RandomDistributionAlgorithm,
                Scale = Scale,
                OutputFilter = OutputFilter
            };
        }
    }
}