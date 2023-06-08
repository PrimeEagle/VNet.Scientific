using VNet.Mathematics.Randomization.Distribution;
using VNet.Scientific.Filtering;

namespace VNet.Scientific.Noise
{
    public class NoiseAlgorithmArgs : INoiseAlgorithmArgs
    {
        public required int Width { get; set; }
        public required int Height { get; set; }
        public int QuantizeLevels { get; set; }
        public double Scale { get; set; }
        public required IRandomDistributionAlgorithm RandomDistributionAlgorithm { get; set; }
        public IFilter? OutputFilter { get; set; }


        public NoiseAlgorithmArgs()
        {

        }

        public NoiseAlgorithmArgs(IRandomDistributionAlgorithm distributionAlgorithm)
        {
            RandomDistributionAlgorithm = distributionAlgorithm;
            QuantizeLevels = 0;
            Scale = 1.0d;
        }

        public INoiseAlgorithmArgs Clone()
        {
            var result = new NoiseAlgorithmArgs(RandomDistributionAlgorithm)
            {
                Width = Width,
                Height = Height,
                QuantizeLevels = QuantizeLevels,
                RandomDistributionAlgorithm = RandomDistributionAlgorithm,
                Scale = Scale,
                OutputFilter = OutputFilter
            };

            return result;
        }
    }
}