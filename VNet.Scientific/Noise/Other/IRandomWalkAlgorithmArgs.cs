namespace VNet.Scientific.Noise.Other
{
    public interface IRandomWalkNoiseAlgorithmArgs : INoiseAlgorithmArgs
    {
        public int NumSteps { get; set; }
        public double StepSize { get; set; }
    }
}