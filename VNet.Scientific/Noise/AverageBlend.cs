namespace VNet.Scientific.Noise
{
    public class AverageBlend : IBlendMode
    {
        public double Blend(double value1, double value2) => (value1 + value2) / 2.0;
    }
}