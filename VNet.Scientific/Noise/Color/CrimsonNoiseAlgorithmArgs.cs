//using VNet.Mathematics.Randomization.Distribution;
//using VNet.Scientific.Filtering;

//namespace VNet.Scientific.Noise.Color
//{
//    public class CrimsonNoiseAlgorithmArgs : ICrimsonNoiseAlgorithmArgs
//    {
//        public double RedNoiseWeight { get; set; }
//        public double VioletNoiseWeight { get; set; }
//        public required int Width { get; set; }
//        public required int Height { get; set; }
//        public int QuantizeLevel { get; set; }
//        public double Scale { get; set; }
//        public required IRandomDistributionAlgorithm RandomDistributionAlgorithm { get; set; }
//        public IFilter? OutputFilter { get; set; }


//        public INoiseAlgorithmArgs Clone()
//        {
//            var result = new CrimsonNoiseAlgorithmArgs()
//            {
//                Width = Width,
//                Height = Height,
//                QuantizeLevel = QuantizeLevel,
//                RandomDistributionAlgorithm = RandomDistributionAlgorithm,
//                Scale = Scale,
//                OutputFilter = OutputFilter,
//                RedNoiseWeight = RedNoiseWeight,
//                VioletNoiseWeight = VioletNoiseWeight
//            };

//            return result;
//        }
//    }
//}