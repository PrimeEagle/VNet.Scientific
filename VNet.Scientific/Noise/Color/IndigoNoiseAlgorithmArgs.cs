namespace VNet.Scientific.Noise.Color
{
    public class IndigoNoiseAlgorithmArgs : NoiseAlgorithmArgs, IIndigoNoiseAlgorithmArgs
    {
        public double BlueNoiseWeight { get; set; }
        public double WhiteNoiseWeight { get; set; }
        public double GrayNoiseWeight { get; set; }
        public required int Width { get; set; }
        public required int Height { get; set; }



        public INoiseAlgorithmArgs Clone()
        {
            var result = new IndigoNoiseAlgorithmArgs()
            {
                Width = Width,
                Height = Height,
                BlueNoiseWeight = BlueNoiseWeight,
                WhiteNoiseWeight = WhiteNoiseWeight,
                GrayNoiseWeight = GrayNoiseWeight
            };

            return result;
        }
    }
}