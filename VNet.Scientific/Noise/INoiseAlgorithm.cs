using VNet.Mathematics.Randomization;

namespace VNet.Scientific.Noise
{
    public interface INoiseAlgorithm : IRandomizationAlgorithm
    {
        public double[,] GenerateRaw();
        public double[,] Generate();
        public double GenerateSingleSampleRaw();
        public double GenerateSingleSample();
    }
}