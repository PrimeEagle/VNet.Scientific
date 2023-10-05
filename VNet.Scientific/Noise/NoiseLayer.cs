namespace VNet.Scientific.Noise;

public class NoiseLayer
{
    public List<NoiseBlendLayer> Layers { get; } = new List<NoiseBlendLayer>();
    private double[] cachedResult = null; // for caching

    public double[] Generate()
    {
        if (cachedResult != null)
            return cachedResult;

        if (!Layers.Any())
            throw new InvalidOperationException("At least one layer is required.");

        var result = Layers[0].NoiseAlgorithm.Generate();
        var totalSize = result.Length;

        for (var i = 1; i < Layers.Count; i++)
        {
            var currentNoise = Layers[i].NoiseAlgorithm.Generate();

            for (var j = 0; j < totalSize; j++)
            {
                result[j] = Layers[i].ApplyBlends(result[j], currentNoise[j]);
            }
        }

        cachedResult = result;
        return result;
    }

    public double GenerateSingleSample()
    {
        if (!Layers.Any())
            throw new InvalidOperationException("At least one layer is required.");

        var result = Layers[0].NoiseAlgorithm.GenerateSingleSample();

        for (var i = 1; i < Layers.Count; i++)
        {
            var currentSample = Layers[i].NoiseAlgorithm.GenerateSingleSample();
            result = Layers[i].BlendMode.Blend(result, currentSample);
        }

        return result;
    }

    public void AddLayer(INoiseAlgorithm noiseAlgorithm, IBlendMode blendMode, double opacity = 1.0)
    {
        InvalidateCache();
        Layers.Add(new NoiseBlendLayer(noiseAlgorithm, blendMode, opacity));
    }

    public void RemoveLayerAt(int index)
    {
        InvalidateCache();
        Layers.RemoveAt(index);
    }

    public void MoveLayer(int oldIndex, int newIndex)
    {
        InvalidateCache();
        var item = Layers[oldIndex];
        Layers.RemoveAt(oldIndex);
        Layers.Insert(newIndex, item);
    }

    public void ClearLayers()
    {
        InvalidateCache();
        Layers.Clear();
    }

    private void InvalidateCache()
    {
        cachedResult = null;
    }
}