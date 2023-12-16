namespace VNet.Scientific.Noise.Color
{
    public class YellowNoiseAlgorithmArgs : NoiseAlgorithmArgs, IYellowNoiseAlgorithmArgs
    {
        public double SamplingRate { get; set; }
        public int Octaves { get; set; }
        public required int Width { get; set; }
        public required int Height { get; set; }


        public INoiseAlgorithmArgs Clone()
        {
            var result = new YellowNoiseAlgorithmArgs()
            {
                Width = Width,
                Height = Height,
                SamplingRate = SamplingRate,
                Octaves = Octaves
            };

            return result;
        }
    }
}