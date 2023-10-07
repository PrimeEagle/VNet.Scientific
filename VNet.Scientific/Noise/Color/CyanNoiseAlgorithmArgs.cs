namespace VNet.Scientific.Noise.Color
{
    public class CyanNoiseAlgorithmArgs : NoiseAlgorithmArgs, ICyanNoiseAlgorithmArgs
    {
        public double BlueNoiseWeight { get; set; }
        public double GreenNoiseWeight { get; set; }
        public required int Width { get; set; }
        public required int Height { get; set; }



        public INoiseAlgorithmArgs Clone()
        {
            var result = new CyanNoiseAlgorithmArgs()
            {
                Width = Width,
                Height = Height,
                BlueNoiseWeight = BlueNoiseWeight,
                GreenNoiseWeight = GreenNoiseWeight
            };

            return result;
        }
    }
}