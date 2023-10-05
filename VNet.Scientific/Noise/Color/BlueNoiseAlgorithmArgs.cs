using VNet.Mathematics.Randomization.Distribution;
using VNet.Scientific.Filtering;

namespace VNet.Scientific.Noise.Color
{
    public class BlueNoiseAlgorithmArgs : IBlueNoiseAlgorithmArgs
    {
        public required double Radius { get; set; }
        public required int MaxAttempts { get; set; }
        public required int Width { get; set; }
        public required int Height { get; set; }

        public int[] Dimensions
        {
            get { return new[] { Width, Height }; }
            set
            {
                if (value.Length != 2) throw new ArgumentException("BlueNoise is 2D, so dimensions array should have 2 elements.");
                Width = value[0];
                Height = value[1];
            }
        }

        public int QuantizeLevels { get; set; }
        public double Scale { get; set; }
        public required IRandomDistributionAlgorithm RandomDistributionAlgorithm { get; set; }
        public IFilter? OutputFilter { get; set; }

        public INoiseAlgorithmArgs Clone()
        {
            return new BlueNoiseAlgorithmArgs()
            {
                Width = Width,
                Height = Height,
                QuantizeLevels = QuantizeLevels,
                RandomDistributionAlgorithm = RandomDistributionAlgorithm,
                Scale = Scale,
                OutputFilter = OutputFilter,
                Radius = Radius,
                MaxAttempts = MaxAttempts
            };
        }
    }
}