using VNet.Mathematics.Randomization;

namespace VNet.Scientific.Noise
{
    public interface INoiseAlgorithm : IRandomizationAlgorithm
    {
        // Generates a single noise sample without any processing.
        double GenerateSingleSampleRaw();

        // Generates a single noise sample with any post-processing.
        double GenerateSingleSample();

        // Generates a raw noise array of n-dimensions defined in Args.
        double[] GenerateRaw();

        // Generates a processed noise array of n-dimensions.
        double[] Generate();
    }
}