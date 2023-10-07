// ReSharper disable UnusedMember.Global

// ReSharper disable SuggestBaseTypeForParameterInConstructor
namespace VNet.Scientific.Noise.Other;

// Random walk algorithms simulate a random path taken by a point in a discrete space. By accumulating the positions at each step,
// it generates a noise signal that exhibits a random, unpredictable pattern. Random walks have applications in modeling diffusion,
// financial markets, and generating irregular patterns.
public class RandomWalkNoise : NoiseBase
{
    public RandomWalkNoise(IRandomWalkNoiseAlgorithmArgs args)
        : base(args)
    {
    }

    public override double GenerateSingleSampleRaw()
    {
        return RandomWalk();
    }

    public override double[] GenerateRaw()
    {
        var totalSize = Args.Dimensions.Aggregate(1, (acc, val) => acc * val);
        var result = new double[totalSize];

        for (var i = 0; i < totalSize; i++)
        {
            result[i] = RandomWalk();
        }

        return result;
    }

    private double RandomWalk()
    {
        var numSteps = ((IRandomWalkNoiseAlgorithmArgs) Args).NumSteps;
        var stepSize = ((IRandomWalkNoiseAlgorithmArgs)Args).StepSize;

        var value = 0.0;
        for (var i = 0; i < numSteps; i++)
        {
            var randomStep = (2 * GetRandomValue() - 1) * stepSize;  // Using the GetRandomValue() method from NoiseBase
            value += randomStep;
        }
        return value / Math.Sqrt(numSteps);
    }
}