﻿using VNet.Mathematics.Randomization.Distribution;
using VNet.Scientific.Filtering;

namespace VNet.Scientific.Noise.Color
{
    public class GoldNoiseAlgorithmArgs : IGoldNoiseAlgorithmArgs
    {
        public int Octaves { get; set; }
        public double SamplingRate { get; set; }
        public required int Width { get; set; }
        public required int Height { get; set; }
        public int QuantizeLevel { get; set; }
        public double Scale { get; set; }
        public required IRandomDistributionAlgorithm RandomDistributionAlgorithm { get; set; }
        public IFilter? OutputFilter { get; set; }


        public INoiseAlgorithmArgs Clone()
        {
            var result = new GoldNoiseAlgorithmArgs()
            {
                Width = Width,
                Height = Height,
                QuantizeLevel = QuantizeLevel,
                RandomDistributionAlgorithm = RandomDistributionAlgorithm,
                Scale = Scale,
                OutputFilter = OutputFilter,
                Octaves = Octaves,
                SamplingRate = SamplingRate
            };

            return result;
        }
    }
}