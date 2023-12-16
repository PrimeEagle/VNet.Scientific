namespace VNet.Scientific.Noise.Other
{
    public interface IReactionDiffusionNoiseAlgorithmArgs : INoiseAlgorithmArgs
    {
        public double DiffusionRateA { get; set; }
        public double DiffusionRateB { get; set; }
        public double FeedRate { get; set; }
        public double KillRate { get; set; }
        public double TimeStep { get; set; }
        public int Iterations { get; set; }
    }
}