// ReSharper disable UnusedMember.Global

using VNet.Mathematics.Randomization.Distribution;

namespace VNet.Scientific.Noise.Other;

// Cellular automaton algorithms divide space into discrete cells and update their states based on predefined rules. The resulting noise
// exhibits emergent behaviors and complex patterns. Cellular automata have applications in generating natural textures, simulating systems,
// and creating procedural content.
public class CellularAutomatonNoise : NoiseBase
{
    public CellularAutomatonNoise(ICellularAutomatonNoiseAlgorithmArgs args) : base(args)
    {
    }

    public override double[,] Generate()
    {
        var result = new double[Args.Height, Args.Width];
        var grid = new int[Args.Height, Args.Width];

        // Initialize the grid with random values
        InitializeGrid(grid, Args.RandomDistributionAlgorithm);

        // Perform the cellular automaton simulation
        for (var i = 0; i < ((ICellularAutomatonNoiseAlgorithmArgs)Args).Iterations; i++) grid = ApplyCellularAutomatonRule(grid);

        // Convert the binary grid to noise values
        ConvertGridToNoise(grid, result, Args.QuantizeLevels, Args.Scale);
        return result;
    }

    public override double GenerateSingleSampleRaw()
    {
        throw new NotImplementedException("Cellular automaton noise is generated for the entire grid, so generating a single sample is not applicable.");
    }

    private void InitializeGrid(int[,] grid, IRandomDistributionAlgorithm randomDistributionAlgorithm)
    {
        var height = grid.GetLength(0);
        var width = grid.GetLength(1);

        for (var i = 0; i < height; i++)
            for (var j = 0; j < width; j++)
                grid[i, j] = randomDistributionAlgorithm.NextDouble() < ((ICellularAutomatonNoiseAlgorithmArgs)Args).Threshold ? 1 : 0;
    }

    private static int[,] ApplyCellularAutomatonRule(int[,] grid)
    {
        var height = grid.GetLength(0);
        var width = grid.GetLength(1);

        var newGrid = new int[height, width];

        for (var i = 0; i < height; i++)
            for (var j = 0; j < width; j++)
            {
                var state = grid[i, j];
                var neighbors = CountAliveNeighbors(grid, i, j);

                newGrid[i, j] = state switch
                {
                    0 when neighbors >= 5 => 1,
                    1 when neighbors <= 3 => 0,
                    _ => state
                };
            }

        return newGrid;
    }

    private static int CountAliveNeighbors(int[,] grid, int x, int y)
    {
        var count = 0;
        var height = grid.GetLength(0);
        var width = grid.GetLength(1);

        for (var i = -1; i <= 1; i++)
            for (var j = -1; j <= 1; j++)
            {
                var neighborX = (x + i + height) % height;
                var neighborY = (y + j + width) % width;
                count += grid[neighborX, neighborY];
            }

        count -= grid[x, y];
        return count;
    }

    private static void ConvertGridToNoise(int[,] grid, double[,] noise, int quantizeLevels, double scale)
    {
        var height = grid.GetLength(0);
        var width = grid.GetLength(1);

        for (var i = 0; i < height; i++)
            for (var j = 0; j < width; j++)
            {
                var value = grid[i, j] == 1 ? 1.0 : 0.0;
                noise[i, j] = value * (quantizeLevels - 1) * scale;
            }
    }
}