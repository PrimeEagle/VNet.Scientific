// ReSharper disable UnusedMember.Global
// ReSharper disable SuggestBaseTypeForParameterInConstructor

using System.Numerics;

namespace VNet.Scientific.Noise.Color;

// Blue noise, also known as azure noise, has a power spectral density that increases by 6 dB per octave as the frequency increases. It is often
// used in audio applications, such as dithering or noise shaping in digital audio, as it emphasizes high frequencies while minimizing
// low-frequency components.
public class BlueNoise : NoiseBase
{
    public BlueNoise(IBlueNoiseAlgorithmArgs args) : base(args)
    {
    }

    public override double[,] GenerateRaw()
    {
        var samples = GenerateBlueNoiseSamples();

        var result = new double[Args.Height, Args.Width];
        for (var i = 0; i < Args.Height; i++)
            for (var j = 0; j < Args.Width; j++)
            {
                var samplePoint = new Vector2((float)j / Args.Width, (float)i / Args.Height);
                var minDistance = double.MaxValue;

                foreach (var sample in samples)
                {
                    double distance = Vector2.Distance(samplePoint, sample);
                    minDistance = Math.Min(minDistance, distance);
                }

                result[i, j] = minDistance * Args.Scale;
            }

        return result;
    }

    public override double GenerateSingleSampleRaw()
    {
        throw new NotImplementedException("Blue noise is generated for the entire grid, so generating a single sample is not applicable.");
    }

    private List<Vector2> GenerateBlueNoiseSamples()
    {
        var cellSize = ((IBlueNoiseAlgorithmArgs)Args).Radius / Math.Sqrt(2);
        var gridWidth = (int)Math.Ceiling(Args.Width / cellSize);
        var gridHeight = (int)Math.Ceiling(Args.Height / cellSize);

        var grid = new int[gridHeight, gridWidth];
        var samples = new List<Vector2>();
        var activeSamples = new List<Vector2>();

        var random = new Random();
        var firstSample = new Vector2((float)random.NextDouble(), (float)random.NextDouble());
        activeSamples.Add(firstSample);
        samples.Add(firstSample);
        var gridX = (int)(firstSample.X * gridWidth);
        var gridY = (int)(firstSample.Y * gridHeight);
        grid[gridY, gridX] = 1;

        while (activeSamples.Count > 0)
        {
            var index = random.Next(activeSamples.Count);
            var sample = activeSamples[index];
            var foundCandidate = false;

            for (var attempt = 0; attempt < ((IBlueNoiseAlgorithmArgs)Args).MaxAttempts; attempt++)
            {
                var angle = 2 * Math.PI * random.NextDouble();
                var distance = ((IBlueNoiseAlgorithmArgs)Args).Radius * (1 + random.NextDouble());
                var candidate = sample + new Vector2((float)(distance * Math.Cos(angle)), (float)(distance * Math.Sin(angle)));

                if (candidate.X is < 0 or >= 1 || candidate.Y is < 0 or >= 1 || !IsCandidateValid(candidate, samples, grid, cellSize, gridWidth, gridHeight)) continue;

                activeSamples.Add(candidate);
                samples.Add(candidate);
                gridX = (int)(candidate.X * gridWidth);
                gridY = (int)(candidate.Y * gridHeight);
                grid[gridY, gridX] = 1;
                foundCandidate = true;
                break;
            }

            if (!foundCandidate) activeSamples.RemoveAt(index);
        }

        return samples;
    }

    private static bool IsCandidateValid(Vector2 candidate, IReadOnlyList<Vector2> samples, int[,] grid, double cellSize, int gridWidth, int gridHeight)
    {
        var cellX = (int)(candidate.X * gridWidth);
        var cellY = (int)(candidate.Y * gridHeight);

        var startX = Math.Max(0, cellX - 2);
        var startY = Math.Max(0, cellY - 2);
        var endX = Math.Min(gridWidth - 1, cellX + 2);
        var endY = Math.Min(gridHeight - 1, cellY + 2);

        for (var y = startY; y <= endY; y++)
            for (var x = startX; x <= endX; x++)
                if (grid[y, x] == 1)
                {
                    var existingSample = samples[grid[y, x] - 1];
                    double distance = Vector2.Distance(candidate, existingSample);

                    if (distance < cellSize) return false;
                }

        return true;
    }
}