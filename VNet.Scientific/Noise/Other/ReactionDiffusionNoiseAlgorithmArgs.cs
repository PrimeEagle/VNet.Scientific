namespace VNet.Scientific.Noise.Other
{
    public class ReactionDiffusionNoiseAlgorithmArgs : NoiseAlgorithmArgs, IReactionDiffusionNoiseAlgorithmArgs
    {
        public double DiffusionRateA { get; set; }
        public double DiffusionRateB { get; set; }
        public double FeedRate { get; set; }
        public double KillRate { get; set; }
        public double TimeStep { get; set; }
        public int Iterations { get; set; }


        public ReactionDiffusionNoiseAlgorithmArgs(double diffusionRateA, double diffusionRateB, double feedRate, double killRate, double timeStep, int iterations)
        {
            DiffusionRateA = diffusionRateA;
            DiffusionRateB = diffusionRateB;
            FeedRate = feedRate;
            KillRate = killRate;
            TimeStep = timeStep;
            Iterations = iterations;
        }

        public override INoiseAlgorithmArgs Clone()
        {
            var result = base.Clone();

            ((IReactionDiffusionNoiseAlgorithmArgs)result).DiffusionRateA = DiffusionRateA;
            ((IReactionDiffusionNoiseAlgorithmArgs)result).DiffusionRateB = DiffusionRateB;
            ((IReactionDiffusionNoiseAlgorithmArgs)result).FeedRate = FeedRate;
            ((IReactionDiffusionNoiseAlgorithmArgs)result).KillRate = KillRate;
            ((IReactionDiffusionNoiseAlgorithmArgs)result).TimeStep = TimeStep;
            ((IReactionDiffusionNoiseAlgorithmArgs)result).Iterations = Iterations;

            return result;
        }
    }
}