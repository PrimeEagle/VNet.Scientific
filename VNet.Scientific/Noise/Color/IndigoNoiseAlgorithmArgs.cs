//using VNet.Mathematics.Randomization.Distribution;
//using VNet.Scientific.Filtering;

//namespace VNet.Scientific.Noise.Color
//{
//    public class IndigoNoiseAlgorithmArgs : IIndigoNoiseAlgorithmArgs
//    {
//        public double BlueNoiseWeight { get; set; }
//        public double WhiteNoiseWeight { get; set; }
//        public double GrayNoiseWeight { get; set; }
//        public required int Width { get; set; }
//        public required int Height { get; set; }
//        public int QuantizeLevel { get; set; }
//        public double Scale { get; set; }
//        public required IRandomDistributionAlgorithm RandomDistributionAlgorithm { get; set; }
//        public IFilter? OutputFilter { get; set; }


//        public INoiseAlgorithmArgs Clone()
//        {
//            var result = new IndigoNoiseAlgorithmArgs()
//            {
//                Width = Width,
//                Height = Height,
//                QuantizeLevel = QuantizeLevel,
//                RandomDistributionAlgorithm = RandomDistributionAlgorithm,
//                Scale = Scale,
//                OutputFilter = OutputFilter,
//                BlueNoiseWeight = BlueNoiseWeight,
//                WhiteNoiseWeight = WhiteNoiseWeight,
//                GrayNoiseWeight = GrayNoiseWeight
//            };

//            return result;
//        }
//    }
//}