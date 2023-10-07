//using VNet.Mathematics.Randomization.Distribution;
//using VNet.Scientific.Filtering;

//namespace VNet.Scientific.Noise.Color
//{
//    public class CyanNoiseAlgorithmArgs : ICyanNoiseAlgorithmArgs
//    {
//        public double BlueNoiseWeight { get; set; }
//        public double GreenNoiseWeight { get; set; }
//        public required int Width { get; set; }
//        public required int Height { get; set; }
//        public int QuantizeLevel { get; set; }
//        public double Scale { get; set; }
//        public required IRandomDistributionAlgorithm RandomDistributionAlgorithm { get; set; }
//        public IFilter? OutputFilter { get; set; }


//        public INoiseAlgorithmArgs Clone()
//        {
//            var result = new CyanNoiseAlgorithmArgs()
//            {
//                Width = Width,
//                Height = Height,
//                QuantizeLevel = QuantizeLevel,
//                RandomDistributionAlgorithm = RandomDistributionAlgorithm,
//                Scale = Scale,
//                OutputFilter = OutputFilter,
//                BlueNoiseWeight = BlueNoiseWeight,
//                GreenNoiseWeight = GreenNoiseWeight
//            };

//            return result;
//        }
//    }
//}