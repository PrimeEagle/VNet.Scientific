// ReSharper disable UnusedMember.Global
// ReSharper disable SuggestBaseTypeForParameterInConstructor

namespace VNet.Scientific.Noise.Other;

// Delta noise, also known as Dirac noise or impulse noise, represents an instantaneous, infinitely short noise burst. It is
// often used to simulate or model abrupt or transient events in a signal.
public class DeltaNoise : NoiseBase
{
    public DeltaNoise(IDeltaNoiseAlgorithmArgs args) : base(args)
    {
    }

    public override double[] GenerateRaw()
    {
        var totalSize = Args.Dimensions.Aggregate(1, (acc, val) => acc * val);
        var result = new double[totalSize];

        int[] deltaIndices = { ((IDeltaNoiseAlgorithmArgs)Args).DeltaIndex, ((IDeltaNoiseAlgorithmArgs)Args).DeltaIndex };
        var deltaFlatIndex = GetFlatIndex(deltaIndices, Args.Dimensions);

        for (var i = 0; i < totalSize; i++)
        {
            if (i == deltaFlatIndex)
            {
                result[i] = ((IDeltaNoiseAlgorithmArgs)Args).DeltaValue * Args.Scale;
            }
        }

        return result;
    }

    public override double GenerateSingleSampleRaw()
    {
        throw new NotImplementedException("Delta noise is generated for the entire grid, so generating a single sample is not applicable.");
    }
}
