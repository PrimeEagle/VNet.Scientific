namespace VNet.Scientific.Noise.Color
{
    public class BlueNoiseAlgorithmArgs : NoiseAlgorithmArgs, IBlueNoiseAlgorithmArgs
    {
        public required double Radius { get; set; }
        public required int MaxAttempts { get; set; }



        public INoiseAlgorithmArgs Clone()
        {
            return new BlueNoiseAlgorithmArgs()
            {
                Radius = Radius,
                MaxAttempts = MaxAttempts
            };
        }
    }
}