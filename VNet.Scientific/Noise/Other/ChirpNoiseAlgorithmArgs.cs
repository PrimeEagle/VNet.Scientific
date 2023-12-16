namespace VNet.Scientific.Noise.Other
{
    public class ChirpNoiseAlgorithmArgs : NoiseAlgorithmArgs, IChirpNoiseAlgorithmArgs
    {
        public double StartFrequency { get; set; }
        public double EndFrequency { get; set; }
        public double Duration { get; set; }
        public double SamplingRate { get; set; }


        public override INoiseAlgorithmArgs Clone()
        {
            var result = base.Clone();

            ((IChirpNoiseAlgorithmArgs)result).StartFrequency = StartFrequency;
            ((IChirpNoiseAlgorithmArgs)result).EndFrequency = EndFrequency;
            ((IChirpNoiseAlgorithmArgs)result).Duration = Duration;
            ((IChirpNoiseAlgorithmArgs)result).SamplingRate = SamplingRate;

            return result;
        }
    }
}