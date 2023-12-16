namespace VNet.Scientific.Noise;

public class NoiseBlendLayer
{
    public INoiseAlgorithm NoiseAlgorithm { get; }
    public List<IBlendMode> BlendModes { get; }  // Now a list of blend modes
    public double Opacity { get; set; } = 1.0; // default to full opacity

    public NoiseBlendLayer(INoiseAlgorithm noiseAlgorithm, List<IBlendMode> blendModes, double opacity = 1.0)
    {
        NoiseAlgorithm = noiseAlgorithm;
        BlendModes = blendModes ?? new List<IBlendMode>();
        Opacity = opacity;
    }

    public double ApplyBlends(double baseValue, double layerValue)
    {
        return BlendModes.Aggregate(baseValue, (current, blendMode) => blendMode.Blend(current, layerValue * Opacity));
    }
}
