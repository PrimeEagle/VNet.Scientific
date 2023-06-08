// ReSharper disable UnusedMember.Global
// ReSharper disable SuggestBaseTypeForParameterInConstructor

namespace VNet.Scientific.Noise.Other;

// Delta noise, also known as Dirac noise or impulse noise, represents an instantaneous, infinitely short noise burst. It is
// often used to simulate or model abrupt or transient events in a signal.
public class DeltaNoise : NoiseBase
{
    public DeltaNoise(IDeltaNoiseAlgorithmArgs args):base(args)
    {
    }

    public override double[,] Generate()
    {
        var width = Args.Width;
        var height = Args.Height;

        var result = new double[height, width];

        for (var i = 0; i < height; i++)
            for (var j = 0; j < width; j++)
                result[i, j] = i == ((IDeltaNoiseAlgorithmArgs)Args).DeltaIndex && j == ((IDeltaNoiseAlgorithmArgs)Args).DeltaIndex ? ((IDeltaNoiseAlgorithmArgs)Args).DeltaValue * Args.Scale : 0.0;

        return result;
    }

    public override double GenerateSingleSampleRaw()
    {
        throw new NotImplementedException("Delta noise is generated for the entire grid, so generating a single sample is not applicable.");
    }
}