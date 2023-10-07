namespace VNet.Scientific.Noise.Other
{
    public class RandomWalkNoiseAlgorithmArgs : NoiseAlgorithmArgs, IRandomWalkNoiseAlgorithmArgs
    {
        public int NumSteps { get; set; }
        public double StepSize {get; set; }


        public RandomWalkNoiseAlgorithmArgs(int numSteps = 1000, double stepSize = 0.1d)
        {
            NumSteps = numSteps;
            StepSize = stepSize;
        }

        public override INoiseAlgorithmArgs Clone()
        {
            var result = base.Clone();

            ((IRandomWalkNoiseAlgorithmArgs)result).NumSteps = NumSteps;
            ((IRandomWalkNoiseAlgorithmArgs)result).StepSize = StepSize;

            return result;
        }
    }
}