using VNet.Mathematics.Randomization;
using VNet.Mathematics.Randomization.Distribution;
using VNet.Scientific.Filtering;

namespace VNet.Scientific.Noise
{
    public interface INoiseAlgorithmArgs : IRandomizationAlgorithmArgs
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public int QuantizeLevels { get; set; }
        public double Scale { get; set; }
        public IRandomDistributionAlgorithm RandomDistributionAlgorithm { get; set; }
        public IFilter? OutputFilter { get; set; }
        
        
        public INoiseAlgorithmArgs Clone();
    }
}