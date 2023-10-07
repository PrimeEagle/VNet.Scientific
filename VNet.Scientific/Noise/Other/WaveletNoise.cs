// ReSharper disable UnusedMember.Global

// ReSharper disable MemberCanBeMadeStatic.Local
// ReSharper disable SuggestBaseTypeForParameter
// ReSharper disable SuggestBaseTypeForParameterInConstructor
#pragma warning disable CA1822
namespace VNet.Scientific.Noise.Other;

// Wavelet noise algorithms utilize wavelet transforms to generate noise signals with frequency characteristics that vary across scales.
// By modifying the properties of the wavelet basis functions, it is possible to create noise with specific spectral distributions or features.
// Wavelet noise finds applications in image and texture synthesis.
public class WaveletNoise : NoiseBase
{
    public WaveletNoise(IWaveletNoiseAlgorithmArgs args)
        : base(args)
    {
    }

    public override double[] GenerateRaw()
    {
        var totalSize = Args.Dimensions.Aggregate(1, (acc, val) => acc * val);
        var result = new double[totalSize];
        var frequency = ((IWaveletNoiseAlgorithmArgs)Args).Frequency;
        var amplitude = ((IWaveletNoiseAlgorithmArgs)Args).Amplitude;

        var indices = new int[Args.Dimensions.Length];

        for (var octave = 0; octave < ((IWaveletNoiseAlgorithmArgs)Args).Octaves; octave++)
        {
            var coordinates = new double[Args.Dimensions.Length];

            for (var flatIndex = 0; flatIndex < totalSize; flatIndex++)
            {
                for (var dim = 0; dim < Args.Dimensions.Length; dim++)
                {
                    coordinates[dim] = indices[dim] / (double)Args.Dimensions[dim] * frequency;
                }

                result[flatIndex] += WaveletNoiseFunction(coordinates) * amplitude;

                IncrementIndices(indices, Args.Dimensions);
            }

            frequency *= ((IWaveletNoiseAlgorithmArgs)Args).Lacunarity;
            amplitude *= ((IWaveletNoiseAlgorithmArgs)Args).Gain;
        }

        return result;
    }

    private double WaveletNoiseFunction(double[] coords)
    {
        var result = 0.0;

        var perlinArgs = new PerlinNoiseAlgorithmArgs
        {
            Dimensions = Args.Dimensions,
            Scale = Args.Scale,
            RandomDistributionAlgorithm = Args.RandomDistributionAlgorithm,
        };

        var perlinNoise = new PerlinNoise(perlinArgs);

        for (var i = 0; i < 4; i++)
        {
            var scale = Math.Pow(2, i);
            var scaledCoords = coords.Select(c => c / scale).ToArray();

            var noiseValue = perlinNoise.GenerateSingleSampleRaw();

            result += noiseValue / scale;
        }

        return result;
    }

    public override double GenerateSingleSampleRaw()
    {
        throw new NotImplementedException("GenerateSingleSampleRaw method doesn't really make sense for Wavelet noise, since each value is dependent on its neighbors in the grid.");
    }
}