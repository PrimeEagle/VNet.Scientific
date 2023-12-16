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
        if (Args.Dimensions.Length != 2)
            throw new ArgumentException("Diamond-Square noise is inherently 2D. Please provide 2D dimensions.");
    }

    public override double[] GenerateRaw()
    {
        var width = Args.Dimensions[1];
        var height = Args.Dimensions[0];

        var gridSize = GetNextPowerOfTwo(Math.Max(width, height)) + 1;
        var grid = new double[gridSize * gridSize];

        var topLeft = GetFlatIndex(0, 0, gridSize, gridSize);
        var topRight = GetFlatIndex(gridSize - 1, 0, gridSize, gridSize);
        var bottomLeft = GetFlatIndex(0, gridSize - 1, gridSize, gridSize);
        var bottomRight = GetFlatIndex(gridSize - 1, gridSize - 1, gridSize, gridSize);

        grid[topLeft] = RandomRange(-1.0, 1.0);
        grid[topRight] = RandomRange(-1.0, 1.0);
        grid[bottomLeft] = RandomRange(-1.0, 1.0);
        grid[bottomRight] = RandomRange(-1.0, 1.0);

        DiamondSquare(grid, 0, 0, gridSize - 1, gridSize - 1, ((IDiamondSquareNoiseAlgorithmArgs)Args).Roughness);

        var result = new double[height * width];
        for (var i = 0; i < height; i++)
        {
            for (var j = 0; j < width; j++)
            {
                var x = (int)Math.Floor(j * (double)(gridSize - 1) / (width - 1));
                var y = (int)Math.Floor(i * (double)(gridSize - 1) / (height - 1));
                result[GetFlatIndex(j, i, width, height)] = grid[GetFlatIndex(x, y, gridSize, gridSize)];
            }
        }

        return result;
    }

    private int GetFlatIndex(int x, int y, int width, int height)
    {
        return y * width + x;
    }


    public override double GenerateSingleSampleRaw()
    {
        throw new NotImplementedException("Diamond-Square noise is generated for the entire grid, so generating a single sample is not applicable.");
    }

    private void DiamondSquare(double[] grid, int startX, int startY, int endX, int endY, double roughness)
    {
        var size = endX - startX;
        var halfSize = size / 2;
        var width = endX + 1; // The "+1" is to ensure it covers the full range, including the end index.

        if (halfSize < 1)
            return;

        var scale = roughness * size;

        // Diamond step
        for (var y = startY + halfSize; y < endY; y += size)
        for (var x = startX + halfSize; x < endX; x += size)
        {
            var a = grid[GetFlatIndex(x - halfSize, y - halfSize, width)];
            var b = grid[GetFlatIndex(x + halfSize, y - halfSize, width)];
            var c = grid[GetFlatIndex(x - halfSize, y + halfSize, width)];
            var d = grid[GetFlatIndex(x + halfSize, y + halfSize, width)];
            var average = (a + b + c + d) / 4.0;
            var offset = RandomRange(-scale, scale);
            grid[GetFlatIndex(x, y, width)] = average + offset;
        }

        // Square step
        for (var y = startY; y <= endY; y += halfSize)
        for (var x = startX + (y + halfSize) % size; x <= endX; x += size)
        {
            var a = grid[GetFlatIndex(x - halfSize, y, width)];
            var b = grid[GetFlatIndex(x + halfSize, y, width)];
            var c = grid[GetFlatIndex(x, y - halfSize, width)];
            var d = grid[GetFlatIndex(x, y + halfSize, width)];
            var average = (a + b + c + d) / 4.0;
            var offset = RandomRange(-scale, scale);
            grid[GetFlatIndex(x, y, width)] = average + offset;
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
    private int GetFlatIndex(int x, int y, int[] dimensions)
    {
        return y * dimensions[1] + x;
    }

    private static int GetNextPowerOfTwo(int n)
    {
        var power = 1;
        while (power < n)
            power *= 2;
        return power;
    }

    private int GetFlatIndex(int x, int y, int width)
    {
        return y * width + x;
    }
}