// ReSharper disable UnusedMember.Global
using System.Text;

namespace VNet.Scientific.Noise.Other;

// L-systems, or Lindenmayer systems, are used to generate noise-like patterns in a recursive manner. They consist of a set of rules that define how
// symbols or characters are replaced in each iteration. L-systems have applications in procedural generation of plant structures, fractals, and visual patterns.
public class LSystemsNoise : NoiseBase
{
    public LSystemsNoise(INoiseAlgorithmArgs args)
        : base(args)
    {
    }

    public override double GenerateSingleSampleRaw()
    {
        // L-systems noise is generated for the entire grid, so generating a single sample is not applicable.
        throw new NotImplementedException();
    }

    public override double[] GenerateRaw()
    {
        var totalSize = Args.Dimensions.Aggregate(1, (acc, val) => acc * val);
        var result = new double[totalSize];

        var noiseString = BuildLSystemString();
        PopulateNoiseArray(result, noiseString);

        return result;
    }

    private string BuildLSystemString()
    {
        var noiseString = "F";
        var noiseBuilder = new StringBuilder(noiseString);

        for (var i = 0; i < ((ILSystemsNoiseAlgorithmArgs)Args).Iterations; i++)
        {
            for (var j = 0; j < noiseBuilder.Length; j++)
            {
                var currentChar = noiseBuilder[j];

                if (!((ILSystemsNoiseAlgorithmArgs)Args).Rules.ContainsKey(currentChar)) continue;
                var replacement = ((ILSystemsNoiseAlgorithmArgs)Args).Rules[currentChar];
                noiseBuilder.Replace(currentChar.ToString(), replacement, j, 1);
                j += replacement.Length - 1;
            }
        }

        return noiseBuilder.ToString();
    }

    private void PopulateNoiseArray(double[] noise, string noiseString)
    {
        var currentDimensionIndex = 0;
        var angle = 0.0;

        for (var i = 0; i < noiseString.Length && currentDimensionIndex < noise.Length; i++)
        {
            var currentChar = noiseString[i];

            switch (currentChar)
            {
                case 'F':
                    noise[currentDimensionIndex++] = 1.0;
                    break;
                case '+':
                    angle += Math.PI / 4.0;
                    break;
                case '-':
                    angle -= Math.PI / 4.0;
                    break;
            }
        }
    }
}