using VNet.Mathematics.Randomization.Distribution;
using VNet.Scientific.Filtering;

namespace VNet.Scientific.Noise
{
    public class NoiseAlgorithmArgs : INoiseAlgorithmArgs
    {
        private int _quantizeLevel = 1;


        public int[] Dimensions { get; set; }
        public int QuantizeLevel
        {
            get => _quantizeLevel;
            set
            {
                if (value <= 0) throw new ArgumentException("QuantizeLevel must be greater than zero.");
                _quantizeLevel = value;
            }
        }
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
            QuantizeLevel = 1;
            Scale = 1.0d;
            NormalizeOutput = false;
        }

        public virtual INoiseAlgorithmArgs Clone()
        {
            return new NoiseAlgorithmArgs(RandomDistributionAlgorithm)
            {
                Dimensions = (int[])Dimensions.Clone(),
                QuantizeLevel = QuantizeLevel,
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