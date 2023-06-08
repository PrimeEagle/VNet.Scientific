// ReSharper disable UnusedMember.Global
// ReSharper disable SuggestBaseTypeForParameterInConstructor

namespace VNet.Scientific.Noise.Other;

// The Diamond-Square algorithm is not a distinct type of noise but rather an algorithm used to generate fractal terrain or heightmaps.
// It is a method for generating terrain-like patterns with realistic variations. The algorithm starts with a square grid where each corner
// of the grid is given an initial height value.The algorithm then iteratively subdivides the squares into smaller squares and performs a
// diamond-square step.In the diamond step, the algorithm calculates the average height of the four corner points and adds a random displacement.
// In the square step, the algorithm calculates the average height of the four midpoints of the sides and adds a random displacement.
// By repeating this process for each iteration and adjusting the random displacements, the Diamond-Square algorithm generates a fractal-like
// pattern that resembles terrain.It creates a smooth, continuous, and self-similar structure with details at different scales.
public class DiamondSquareNoise : NoiseBase
{
    public DiamondSquareNoise(IDiamondSquareNoiseAlgorithmArgs args) : base(args)
    {
    }

    public override double[,] GenerateRaw()
    {
        var width = Args.Width;
        var height = Args.Height;

        // Ensure the grid size is a power of 2 plus 1
        var gridSize = GetNextPowerOfTwo(Math.Max(width, height)) + 1;

        var grid = new double[gridSize, gridSize];
        grid[0, 0] = RandomRange(-1.0, 1.0);
        grid[0, gridSize - 1] = RandomRange(-1.0, 1.0);
        grid[gridSize - 1, 0] = RandomRange(-1.0, 1.0);
        grid[gridSize - 1, gridSize - 1] = RandomRange(-1.0, 1.0);

        DiamondSquare(grid, 0, 0, gridSize - 1, gridSize - 1, ((IDiamondSquareNoiseAlgorithmArgs)Args).Roughness);

        var result = new double[height, width];
        for (var i = 0; i < height; i++)
            for (var j = 0; j < width; j++)
            {
                var x = (int)Math.Floor(j * (double)(gridSize - 1) / (width - 1));
                var y = (int)Math.Floor(i * (double)(gridSize - 1) / (height - 1));
                result[i, j] = grid[y, x];
            }

        return result;
    }

    public override double GenerateSingleSampleRaw()
    {
        throw new NotImplementedException("Diamond-Square noise is generated for the entire grid, so generating a single sample is not applicable.");
    }

    private void DiamondSquare(double[,] grid, int startX, int startY, int endX, int endY, double roughness)
    {
        var size = endX - startX;
        var halfSize = size / 2;

        if (halfSize < 1)
            return;

        var scale = roughness * size;

        // Diamond step
        for (var y = startY + halfSize; y < endY; y += size)
            for (var x = startX + halfSize; x < endX; x += size)
            {
                var a = grid[y - halfSize, x - halfSize];
                var b = grid[y - halfSize, x + halfSize];
                var c = grid[y + halfSize, x - halfSize];
                var d = grid[y + halfSize, x + halfSize];
                var average = (a + b + c + d) / 4.0;
                var offset = RandomRange(-scale, scale);
                grid[y, x] = average + offset;
            }

        // Square step
        for (var y = startY; y <= endY; y += halfSize)
            for (var x = startX + (y + halfSize) % size; x <= endX; x += size)
            {
                var a = GetGridValue(grid, x - halfSize, y);
                var b = GetGridValue(grid, x + halfSize, y);
                var c = GetGridValue(grid, x, y - halfSize);
                var d = GetGridValue(grid, x, y + halfSize);
                var average = (a + b + c + d) / 4.0;
                var offset = RandomRange(-scale, scale);
                grid[y, x] = average + offset;
            }

        DiamondSquare(grid, startX, startY, startX + halfSize, startY + halfSize, roughness);
        DiamondSquare(grid, startX + halfSize, startY, endX, startY + halfSize, roughness);
        DiamondSquare(grid, startX, startY + halfSize, startX + halfSize, endY, roughness);
        DiamondSquare(grid, startX + halfSize, startY + halfSize, endX, endY, roughness);
    }

    private static double GetGridValue(double[,] grid, int x, int y)
    {
        var gridSize = grid.GetLength(0);
        if (x < 0 || x >= gridSize || y < 0 || y >= gridSize)
            return 0.0;
        return grid[y, x];
    }

    private double RandomRange(double min, double max)
    {
        return min + (max - min) * Args.RandomDistributionAlgorithm.NextDouble();
    }

    private static int GetNextPowerOfTwo(int n)
    {
        var power = 1;
        while (power < n)
            power *= 2;
        return power;
    }
}