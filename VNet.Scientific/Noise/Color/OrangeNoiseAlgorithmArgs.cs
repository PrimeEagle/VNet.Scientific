//using VNet.Mathematics.Randomization.Distribution;
//using VNet.Scientific.Filtering;

//namespace VNet.Scientific.Noise.Color
//{
//    public class OrangeNoiseAlgorithmArgs : IOrangeNoiseAlgorithmArgs
//    {
//        public double Exponent { get; set; }
//        public double SamplingRate { get; set; }
//        public int Octaves { get; set; }
//        public required int Width { get; set; }
//        public required int Height { get; set; }
//        public int QuantizeLevel { get; set; }
//        public double Scale { get; set; }
//        public required IRandomDistributionAlgorithm RandomDistributionAlgorithm { get; set; }
//        public IFilter? OutputFilter { get; set; }


//        public INoiseAlgorithmArgs Clone()
//        {
//            var result = new OrangeNoiseAlgorithmArgs()
//            {
//                Width = Width,
//                Height = Height,
//                QuantizeLevel = QuantizeLevel,
//                RandomDistributionAlgorithm = RandomDistributionAlgorithm,
//                Scale = Scale,
//                OutputFilter = OutputFilter,
//                SamplingRate = SamplingRate,
//                Exponent = Exponent,
//                Octaves = Octaves
//            };

//            return result;
//        }
//    }
//}