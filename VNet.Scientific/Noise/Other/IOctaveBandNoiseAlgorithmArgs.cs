using VNet.Scientific.Filtering;

namespace VNet.Scientific.Noise.Other
{
    public interface IOctaveBandNoiseAlgorithmArgs : INoiseAlgorithmArgs
    {
        public double CenterFrequency { get; set; }
        public double Bandwidth { get; set; }
        public double SamplingRate { get; set; }
        public INoiseAlgorithm BaseNoiseAlgorithm { get; set; }
        public IFilter Filter { get; set; }
    }
}