namespace VNet.Scientific.Noise.Other
{
    public class DiamondSquareNoiseAlgorithmArgs : NoiseAlgorithmArgs, IDiamondSquareNoiseAlgorithmArgs
    {
        public double Roughness { get; set; }
        public required int Width { get; set; }
        public required int Height { get; set; }


        public override INoiseAlgorithmArgs Clone()
        {
            var result = new DiamondSquareNoiseAlgorithmArgs()
            {
                Width = Width,
                Height = Height,
                Roughness = Roughness
            };

            return result;
        }
    }
}