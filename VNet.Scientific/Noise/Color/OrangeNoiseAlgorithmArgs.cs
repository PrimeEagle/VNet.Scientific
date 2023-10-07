namespace VNet.Scientific.Noise.Color
{
    public class OrangeNoiseAlgorithmArgs : NoiseAlgorithmArgs, IOrangeNoiseAlgorithmArgs
    {
        public double Exponent { get; set; }
        public double SamplingRate { get; set; }
        public int Octaves { get; set; }
        public required int Width { get; set; }
        public required int Height { get; set; }



        public INoiseAlgorithmArgs Clone()
        {
            var result = new OrangeNoiseAlgorithmArgs()
            {
                Width = Width,
                Height = Height,
                SamplingRate = SamplingRate,
                Exponent = Exponent,
                Octaves = Octaves
            };

            return result;
        }
    }
}