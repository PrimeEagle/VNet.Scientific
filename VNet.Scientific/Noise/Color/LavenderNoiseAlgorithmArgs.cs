namespace VNet.Scientific.Noise.Color
{
    public class LavenderNoiseAlgorithmArgs : NoiseAlgorithmArgs, ILavenderNoiseAlgorithmArgs
    {
        public double WhiteNoiseWeight { get; set; }
        public double PinkNoiseWeight { get; set; }
        public required int Width { get; set; }
        public required int Height { get; set; }



        public INoiseAlgorithmArgs Clone()
        {
            var result = new LavenderNoiseAlgorithmArgs()
            {
                Width = Width,
                Height = Height,
                WhiteNoiseWeight = WhiteNoiseWeight,
                PinkNoiseWeight = PinkNoiseWeight
            };

            return result;
        }
    }
}