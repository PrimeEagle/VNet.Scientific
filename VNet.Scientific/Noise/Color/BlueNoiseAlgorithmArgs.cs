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
        public int QuantizeLevels { get; set; }
        public double Scale { get; set; }
        public required IRandomDistributionAlgorithm RandomDistributionAlgorithm { get; set; }
        public IFilter? OutputFilter { get; set; }


        public INoiseAlgorithmArgs Clone()
        {
            var result = new BlueNoiseAlgorithmArgs()
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

            return result;
        }
    }
}