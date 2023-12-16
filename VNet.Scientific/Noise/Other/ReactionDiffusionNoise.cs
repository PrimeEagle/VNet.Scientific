// ReSharper disable UnusedMember.Global
// ReSharper disable SuggestBaseTypeForParameterInConstructor

namespace VNet.Scientific.Noise.Other;
// Reaction-diffusion noise algorithms simulate the behavior of chemical reactions and diffusion processes to generate complex patterns.
// They are used to model natural phenomena like fire, smoke, or animal skin patterns. Reaction-diffusion algorithms involve the interaction
// of multiple variables over time.
public class ReactionDiffusionNoise : NoiseBase
{
    private double[] _grid;

    public ReactionDiffusionNoise(IReactionDiffusionNoiseAlgorithmArgs args)
        : base(args)
    {
    }

    public override double GenerateSingleSampleRaw()
    {
        // For reaction-diffusion, a single sample might not make much sense in isolation. 
        // We can return a random value for simplicity, but it won't be representative of the noise.
        return GetRandomValue();
    }

    public override double[] GenerateRaw()
    {
        var totalSize = Args.Dimensions.Aggregate(1, (acc, val) => acc * val);
        _grid = new double[totalSize];

        // Initialize the grid with random values
        InitializeGrid();

        // Perform the reaction-diffusion simulation
        for (var i = 0; i < ((IReactionDiffusionNoiseAlgorithmArgs)Args).Iterations; i++)
        {
            SimulateReactionDiffusion();
        }

        return _grid;
    }

    private void InitializeGrid()
    {
        for (var i = 0; i < _grid.Length; i++)
        {
            _grid[i] = GetRandomValue();
        }
    }

    private void SimulateReactionDiffusion()
    {
        var nextGrid = new double[_grid.Length];

        for (var i = 0; i < _grid.Length; i++)
        {
            GetMultiDimensionalIndices(i, Args.Dimensions);
            var value = _grid[i];

            // Here, we'll need a generalization of the Laplacian operation 
            // for n-dimensions. For simplicity, we're using the current value 
            // (this part would require more research to be meaningful in n-dimensions)

            var reaction = value * value * value;
            var diffusionA = value * ((IReactionDiffusionNoiseAlgorithmArgs)Args).DiffusionRateA;
            var diffusionB = value * ((IReactionDiffusionNoiseAlgorithmArgs)Args).DiffusionRateB;

            var timeStep = ((IReactionDiffusionNoiseAlgorithmArgs) Args).TimeStep;
            var feedRate = ((IReactionDiffusionNoiseAlgorithmArgs)Args).FeedRate;
            var killRate = ((IReactionDiffusionNoiseAlgorithmArgs) Args).KillRate;

            nextGrid[i] = value + timeStep * (diffusionA - reaction + feedRate * (1.0 - value));
            nextGrid[i] = value + timeStep * (diffusionB + reaction - (killRate + feedRate) * value);
        }

        _grid = nextGrid;
    }
}