namespace VNet.Scientific.Noise.Other
{
    public interface ISpeckleNoiseAlgorithmArgs : INoiseAlgorithmArgs
    {
        public double Intensity { get; set; }
    }
}