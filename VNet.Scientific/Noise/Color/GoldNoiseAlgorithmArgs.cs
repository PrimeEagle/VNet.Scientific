namespace VNet.Scientific.Noise.Color
{
    public class GoldNoiseAlgorithmArgs : NoiseAlgorithmArgs, IGoldNoiseAlgorithmArgs
    {
        public int Octaves { get; set; }
        public double SamplingRate { get; set; }
        public required int Width { get; set; }
        public required int Height { get; set; }



        public INoiseAlgorithmArgs Clone()
        {
            var result = new GoldNoiseAlgorithmArgs()
            {
                Width = Width,
                Height = Height,
                Octaves = Octaves,
                SamplingRate = SamplingRate
            };

            return result;
        }
    }
}