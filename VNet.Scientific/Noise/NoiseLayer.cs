namespace VNet.Scientific.Noise;

public class NoiseLayer
{
    public List<NoiseBlendLayer> Layers { get; } = new List<NoiseBlendLayer>();

    public double[,] Generate(int width, int height)
    {
        if (!Layers.Any())
            throw new InvalidOperationException("At least one layer is required.");

        double[,] result = Layers[0].NoiseAlgorithm.Generate();

        for (int i = 1; i < Layers.Count; i++)
        {
            double[,] currentNoise = Layers[i].NoiseAlgorithm.Generate();

            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    result[x, y] = Layers[i].BlendMode.Blend(result[x, y], currentNoise[x, y]);
                }
            }
        }

        return result;
    }

    public double GenerateSingleSample()
    {
        if (!Layers.Any())
            throw new InvalidOperationException("At least one layer is required.");

        double result = Layers[0].NoiseAlgorithm.GenerateSingleSample();

        for (int i = 1; i < Layers.Count; i++)
        {
            double currentSample = Layers[i].NoiseAlgorithm.GenerateSingleSample();
            result = Layers[i].BlendMode.Blend(result, currentSample);
        }

        return result;
    }

    public void AddLayer(INoiseAlgorithm noiseAlgorithm, IBlendMode blendMode)
    {
        Layers.Add(new NoiseBlendLayer(noiseAlgorithm, blendMode));
    }
}