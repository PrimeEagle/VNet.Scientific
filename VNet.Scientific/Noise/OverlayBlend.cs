namespace VNet.Scientific.Noise;

public class OverlayBlend : IBlendMode
{
    public double Blend(double baseValue, double blendValue)
    {
        if (baseValue < 0.5)
        {
            return 2 * baseValue * blendValue;
        }
        else
        {
            return 1 - 2 * (1 - baseValue) * (1 - blendValue);
        }
    }
}