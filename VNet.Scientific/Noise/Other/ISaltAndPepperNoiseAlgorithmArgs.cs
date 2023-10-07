namespace VNet.Scientific.Noise.Other
{
    public interface ISaltAndPepperNoiseAlgorithmArgs : INoiseAlgorithmArgs
    {
        public double Density { get; set; }
        public double SaltValue { get; set; }
        public double PepperValue { get; set; }
    }
}