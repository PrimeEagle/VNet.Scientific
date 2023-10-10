using VNet.Mathematics.Randomization;
// ReSharper disable ParameterTypeCanBeEnumerable.Global

namespace VNet.Scientific.Noise
{
    public interface INoiseAlgorithm : IRandomizationAlgorithm
    {
        double GenerateSingleSampleRaw();
        double GenerateSingleSample();
        double GenerateSpatialSingleSample(double[] coordinates);
        void ResetCache();
        double[] GenerateRaw();
        double[] Generate();
    }
}