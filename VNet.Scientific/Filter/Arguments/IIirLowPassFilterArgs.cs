namespace VNet.Scientific.Filter.Arguments
{
    public interface IIirLowPassFilterArgs : IIirFilterArgs, ILowPassFilterArgs
    {
        public double CutoffFrequency { get; set; }
        public double Bandwidth { get; set; }
    }
}