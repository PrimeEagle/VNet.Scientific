namespace VNet.Scientific.Noise.Color
{
    public class NoisyWhiteNoiseAlgorithmArgs : NoiseAlgorithmArgs, INoisyWhiteNoiseAlgorithmArgs
    {
        public double NoiseScale { get; set; }
        public int NoiseIterations { get; set; }
        public required int Width { get; set; }
        public required int Height { get; set; }


        public INoiseAlgorithmArgs Clone()
        {
            var result = new NoisyWhiteNoiseAlgorithmArgs()
            {
                Width = Width,
                Height = Height,
                NoiseScale = NoiseScale,
                NoiseIterations = NoiseIterations
            };

            return result;
        }
    }
}