using VNet.Mathematics.Randomization.Distribution;
using VNet.Scientific.Filtering;

namespace VNet.Scientific.Noise.Color
{
    public class AzureNoiseAlgorithmArgs : IAzureNoiseAlgorithmArgs
    {
        public double BlueNoiseWeight { get; set; }
        public double VioletNoiseWeight { get; set; }
        public int QuantizeLevel { get; set; }
        public double Scale { get; set; }
        public required IRandomDistributionAlgorithm RandomDistributionAlgorithm { get; set; }
        public IFilter? OutputFilter { get; set; }
        public required int[] Dimensions { get; set; }

        public INoiseAlgorithmArgs Clone()
        {
            var result = new AzureNoiseAlgorithmArgs()
            {
                Dimensions = Dimensions,
                QuantizeLevel = QuantizeLevel,
                RandomDistributionAlgorithm = RandomDistributionAlgorithm,
                Scale = Scale,
                OutputFilter = OutputFilter,
                BlueNoiseWeight = BlueNoiseWeight,
                VioletNoiseWeight = VioletNoiseWeight
            };

            return result;
        }
    }
}