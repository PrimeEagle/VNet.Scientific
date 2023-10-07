//using VNet.Mathematics.Randomization.Distribution;
//using VNet.Scientific.Filtering;

//namespace VNet.Scientific.Noise.Color
//{
//    public class LavenderNoiseAlgorithmArgs : ILavenderNoiseAlgorithmArgs
//    {
//        public double WhiteNoiseWeight { get; set; }
//        public double PinkNoiseWeight { get; set; }
//        public required int Width { get; set; }
//        public required int Height { get; set; }
//        public int QuantizeLevel { get; set; }
//        public double Scale { get; set; }
//        public required IRandomDistributionAlgorithm RandomDistributionAlgorithm { get; set; }
//        public IFilter? OutputFilter { get; set; }


//        public INoiseAlgorithmArgs Clone()
//        {
//            var result = new LavenderNoiseAlgorithmArgs()
//            {
//                Width = Width,
//                Height = Height,
//                QuantizeLevel = QuantizeLevel,
//                RandomDistributionAlgorithm = RandomDistributionAlgorithm,
//                Scale = Scale,
//                OutputFilter = OutputFilter,
//                WhiteNoiseWeight = WhiteNoiseWeight,
//                PinkNoiseWeight = PinkNoiseWeight
//            };

//            return result;
//        }
//    }
//}