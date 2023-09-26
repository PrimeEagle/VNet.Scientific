namespace VNet.Scientific.Noise;

public class NoiseBlendLayer
{
    public INoiseAlgorithm NoiseAlgorithm { get; }
    public IBlendMode BlendMode { get; }

    public NoiseBlendLayer(INoiseAlgorithm noiseAlgorithm, IBlendMode blendMode)
    {
        NoiseAlgorithm = noiseAlgorithm;
        BlendMode = blendMode;
    }
}