namespace VNet.Scientific.Noise.Color
{
    public class PinkyNoiseAlgorithmArgs : NoiseAlgorithmArgs, IPinkyNoiseAlgorithmArgs
    {
        public double StepSize { get; set; }
        public int NumSteps { get; set; }
        public required int Width { get; set; }
        public required int Height { get; set; }


        public INoiseAlgorithmArgs Clone()
        {
            var result = new PinkyNoiseAlgorithmArgs()
            {
                Width = Width,
                Height = Height,
                StepSize = StepSize,
                NumSteps = NumSteps
            };

            return result;
        }
    }
}