// ReSharper disable UnusedMember.Global
#pragma warning disable CA1822

using VNet.Mathematics.Randomization.Distribution;
// ReSharper disable SuggestBaseTypeForParameterInConstructor
// ReSharper disable MemberCanBeMadeStatic.Local
// ReSharper disable SuggestBaseTypeForParameter

namespace VNet.Scientific.Noise.Other;

// Cellular automaton algorithms divide space into discrete cells and update their states based on predefined rules. The resulting noise
// exhibits emergent behaviors and complex patterns. Cellular automata have applications in generating natural textures, simulating systems,
// and creating procedural content.
public class CellularAutomatonNoise : NoiseBase
{
    public CellularAutomatonNoise(ICellularAutomatonNoiseAlgorithmArgs args) : base(args)
    {
    }

    public override double GenerateSingleSampleRaw()
    {
        throw new NotImplementedException("Cellular automaton noise is generated for the entire grid, so generating a single sample is not applicable.");
    }

    public override double[] GenerateRaw()
    {
        var totalSize = Args.Dimensions.Aggregate(1, (acc, val) => acc * val);
        var result = new double[totalSize];
        var grid = new int[totalSize];

        // Initialize the grid with random values
        InitializeGrid(grid, Args.RandomDistributionAlgorithm);

        // Perform the cellular automaton simulation
        for (var i = 0; i < ((ICellularAutomatonNoiseAlgorithmArgs)Args).Iterations; i++) grid = ApplyCellularAutomatonRule(grid);

        // Convert the binary grid to noise values
        ConvertGridToNoise(grid, result, Args.QuantizeLevel, Args.Scale);
        return result;
    }

    private void InitializeGrid(int[] grid, IRandomDistributionAlgorithm randomDistributionAlgorithm)
    {
        for (var i = 0; i < grid.Length; i++)
            grid[i] = randomDistributionAlgorithm.NextDouble() < ((ICellularAutomatonNoiseAlgorithmArgs)Args).Threshold ? 1 : 0;
    }

    private int[] ApplyCellularAutomatonRule(int[] grid)
    {
        var newGrid = new int[grid.Length];
        for (var i = 0; i < grid.Length; i++)
        {
            var state = grid[i];
            var neighbors = CountAliveNeighbors(grid, i);

            newGrid[i] = state switch
            {
                0 when neighbors >= 5 => 1,
                1 when neighbors <= 3 => 0,
                _ => state
            };
        }
        return newGrid;
    }

    private int CountAliveNeighbors(int[] grid, int index)
    {
        var neighborsOffsets = Enumerable.Range(0, Args.Dimensions.Length).Select(_ => new[] { -1, 0, 1 }).ToArray();
        var neighborCombinations = GetCombinations(neighborsOffsets).Where(comb => comb.Any(val => val != 0)).ToList();

        var count = 0;
        foreach (var combination in neighborCombinations)
        {
            var neighborIndex = GetNeighborIndex(index, combination);
            if (neighborIndex >= 0 && neighborIndex < grid.Length && grid[neighborIndex] == 1)
            {
                count++;
            }
        }

        return count;
    }

    private int GetNeighborIndex(int index, int[] offsets)
    {
        var originalIndices = GetMultiDimensionalIndices(index, Args.Dimensions);
        var neighborIndices = new int[originalIndices.Length];

        for (var i = 0; i < originalIndices.Length; i++)
        {
            neighborIndices[i] = (originalIndices[i] + offsets[i] + Args.Dimensions[i]) % Args.Dimensions[i];
        }

        return GetFlatIndex(neighborIndices, Args.Dimensions);
    }

    private IEnumerable<int[]> GetCombinations(int[][] arrays)
    {
        var combinations = new List<int[]>();
        GenerateCombinations(arrays, 0, new int[arrays.Length], combinations);
        return combinations;
    }

    private void GenerateCombinations(int[][] arrays, int arrayIndex, int[] currentCombination, List<int[]> combinations)
    {
        if (arrayIndex == arrays.Length)
        {
            combinations.Add((int[])currentCombination.Clone());
            return;
        }

        foreach (var value in arrays[arrayIndex])
        {
            currentCombination[arrayIndex] = value;
            GenerateCombinations(arrays, arrayIndex + 1, currentCombination, combinations);
        }
    }

    private void ConvertGridToNoise(int[] grid, double[] noise, int quantizeLevels, double scale)
    {
        for (var i = 0; i < grid.Length; i++)
        {
            var value = grid[i] == 1 ? 1.0 : 0.0;
            noise[i] = value * (quantizeLevels - 1) * scale;
        }
    }
}