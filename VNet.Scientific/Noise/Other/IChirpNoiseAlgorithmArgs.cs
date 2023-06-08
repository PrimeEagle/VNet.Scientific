namespace VNet.Scientific.Noise.Other
{
    public interface IChirpNoiseAlgorithmArgs : INoiseAlgorithmArgs
    {
        public double StartFrequency { get; set; }
        public double EndFrequency { get; set; }
        public double Duration { get; set; }
        public double SamplingRate { get; set; }
    }
}