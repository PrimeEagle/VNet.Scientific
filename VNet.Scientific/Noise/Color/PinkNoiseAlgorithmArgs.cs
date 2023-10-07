using VNet.Mathematics.Randomization.Distribution;
using VNet.Scientific.Filtering;

namespace VNet.Scientific.Noise.Color
{
    public class PinkNoiseAlgorithmArgs : IPinkNoiseAlgorithmArgs
    {
        public double SamplingRate { get; set; }
        public int Octaves { get; set; }
        public required int Width { get; set; }
        public required int Height { get; set; }
        public int QuantizeLevel { get; set; }
        public double Scale { get; set; }
        public required IRandomDistributionAlgorithm RandomDistributionAlgorithm { get; set; }
        public IFilter? OutputFilter { get; set; }


        public INoiseAlgorithmArgs Clone()
        {
            var result = new PinkNoiseAlgorithmArgs()
            {
                Width = Width,
                Height = Height,
                QuantizeLevel = QuantizeLevel,
                RandomDistributionAlgorithm = RandomDistributionAlgorithm,
                Scale = Scale,
                OutputFilter = OutputFilter,
                SamplingRate = SamplingRate,
                Octaves = Octaves
            };

            return result;
        }
    }
}