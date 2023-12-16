namespace VNet.Scientific.Noise.Color
{
    public class CrimsonNoiseAlgorithmArgs : NoiseAlgorithmArgs, ICrimsonNoiseAlgorithmArgs
    {
        public double RedNoiseWeight { get; set; }
        public double VioletNoiseWeight { get; set; }
        public required int Width { get; set; }
        public required int Height { get; set; }


        public INoiseAlgorithmArgs Clone()
        {
            var result = new CrimsonNoiseAlgorithmArgs()
            {
                Width = Width,
                Height = Height,
                RedNoiseWeight = RedNoiseWeight,
                VioletNoiseWeight = VioletNoiseWeight
            };

            return result;
        }
    }
}