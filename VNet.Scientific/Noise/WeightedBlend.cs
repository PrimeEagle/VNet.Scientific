namespace VNet.Scientific.Noise;

public class WeightedBlend : IBlendMode
{
    private readonly double _weight;

    public WeightedBlend(double weight) => _weight = weight;

    public double Blend(double value1, double value2) => value1 * _weight + value2 * (1 - _weight);
}