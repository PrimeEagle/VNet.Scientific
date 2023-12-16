namespace VNet.Scientific.Noise;

public class MultiplyBlend : IBlendMode
{
    public double Blend(double value1, double value2) => value1 * value2;
}