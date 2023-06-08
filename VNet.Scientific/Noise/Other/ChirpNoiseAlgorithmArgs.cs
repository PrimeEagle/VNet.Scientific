using VNet.Mathematics.Randomization.Distribution;
using VNet.Scientific.Filtering;

namespace VNet.Scientific.Noise.Other
{
    public class ChirpNoiseAlgorithmArgs : IChirpNoiseAlgorithmArgs
    {
        public double StartFrequency { get; set; }
        public double EndFrequency { get; set; }
        public double Duration { get; set; }
        public double SamplingRate { get; set; }
        public required int Width { get; set; }
        public required int Height { get; set; }
        public int QuantizeLevels { get; set; }
        public double Scale { get; set; }
        public required IRandomDistributionAlgorithm RandomDistributionAlgorithm { get; set; }
        public IFilter? OutputFilter { get; set; }


        public INoiseAlgorithmArgs Clone()
        {
            var result = new ChirpNoiseAlgorithmArgs()
            {
                Width = Width,
                Height = Height,
                QuantizeLevels = QuantizeLevels,
                RandomDistributionAlgorithm = RandomDistributionAlgorithm,
                Scale = Scale,
                OutputFilter = OutputFilter,
                StartFrequency = StartFrequency,
                EndFrequency = EndFrequency,
                Duration = Duration,
                SamplingRate = SamplingRate
            };

            return result;
        }
    }
}