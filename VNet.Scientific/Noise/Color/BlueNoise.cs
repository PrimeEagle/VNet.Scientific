// ReSharper disable UnusedMember.Global
// ReSharper disable SuggestBaseTypeForParameterInConstructor
// ReSharper disable SuggestBaseTypeForParameter

namespace VNet.Scientific.Noise.Color;

// Blue noise, also known as azure noise, has a power spectral density that increases by 6 dB per octave as the frequency increases. It is often
// used in audio applications, such as dithering or noise shaping in digital audio, as it emphasizes high frequencies while minimizing
// low-frequency components.
public class BlueNoise : NoiseBase
{
    public BlueNoise(IBlueNoiseAlgorithmArgs args) : base(args)
    {
    }

    public override double[] GenerateRaw()
    {
        var samples = GenerateBlueNoiseSamples();
        var result = new double[Args.Dimensions.Aggregate(1, (acc, val) => acc * val)];

        for (var i = 0; i < result.Length; i++)
        {
            var samplePoint = GetMultiDimensionalIndices(i, Args.Dimensions);
            var minDistance = double.MaxValue;

            foreach (var sample in samples)
            {
                var distance = CalculateDistance(samplePoint.Select(p => (double)p).ToArray(), sample);
                minDistance = Math.Min(minDistance, distance);
            }

            result[i] = minDistance * Args.Scale;
        }

        return result;
    }

    private double CalculateDistance(double[] point1, double[] point2)
    {
        return Math.Sqrt(point1.Zip(point2, (a, b) => Math.Pow(a - b, 2)).Sum());
    }

    private List<double[]> GenerateBlueNoiseSamples()
    {
        var random = new Random();
        var dimensions = Args.Dimensions.Length;
        var totalCells = Args.Dimensions.Aggregate(1, (acc, val) => acc * val);

        var grid = new int[totalCells];
        var samples = new List<double[]>();
        var activeSamples = new List<double[]>();

        var firstSample = Enumerable.Range(0, dimensions).Select(_ => random.NextDouble()).ToArray();
        activeSamples.Add(firstSample);
        samples.Add(firstSample);
        grid[GetFlatIndex(firstSample.Select(d => (int)(d * totalCells)).ToArray(), Args.Dimensions)] = 1;

        while (activeSamples.Count > 0)
        {
            var sampleIndex = random.Next(activeSamples.Count);
            var sample = activeSamples[sampleIndex];
            var foundCandidate = false;

            for (var attempt = 0; attempt < ((IBlueNoiseAlgorithmArgs)Args).MaxAttempts; attempt++)
            {
                var candidate = sample.Zip(Enumerable.Range(0, dimensions).Select(_ => random.NextDouble() - 0.5), (s, r) => s + r).ToArray();

                if (!IsValidCandidate(candidate, samples, grid))
                    continue;

                foundCandidate = true;
                activeSamples.Add(candidate);
                samples.Add(candidate);
                grid[GetFlatIndex(candidate.Select(d => (int)(d * totalCells)).ToArray(), Args.Dimensions)] = samples.Count;
                break;
            }

            if (!foundCandidate)
                activeSamples.RemoveAt(sampleIndex);
        }

        return samples;
    }

    private bool IsValidCandidate(double[] candidate, List<double[]> samples, int[] grid)
    {
        var neighboringIndices = GetNeighboringIndices(candidate.Select(d => (int)(d * Args.Dimensions.Length)).ToArray(), Args.Dimensions);
        foreach (var neighbor in neighboringIndices)
        {
            var gridIndex = GetFlatIndex(neighbor, Args.Dimensions);
            if (grid[gridIndex] != 0)
            {
                var existingSample = samples[grid[gridIndex] - 1];
                if (CalculateDistance(candidate, existingSample) < ((IBlueNoiseAlgorithmArgs)Args).Radius)
                    return false;
            }
        }
        return true;
    }

    private List<int[]> GetNeighboringIndices(int[] point, int[] dimensions)
    {
        var neighbors = new List<int[]>();
        GetNeighboringIndicesRecursive(point, 0, new int[point.Length], neighbors, dimensions);
        return neighbors;
    }

    private void GetNeighboringIndicesRecursive(int[] point, int depth, int[] current, ICollection<int[]> neighbors, int[] dimensions)
    {
        if (depth == point.Length)
        {
            if (current.Zip(point, (a, b) => a != b).Count(diff => diff) == 1) // Only one dimension is different
                neighbors.Add(current.ToArray());
            return;
        }

        for (var i = -1; i <= 1; i++)
        {
            current[depth] = point[depth] + i;
            if (current[depth] >= 0 && current[depth] < dimensions[depth])
                GetNeighboringIndicesRecursive(point, depth + 1, current, neighbors, dimensions);
        }
    }

    public override double GenerateSingleSampleRaw()
    {
        throw new NotImplementedException("Blue noise is generated for the entire grid, so generating a single sample is not applicable.");
    }
}