namespace VNet.Scientific.Filter.Arguments
{
    public interface IFirHighPassFilterArgs : IFirFilterArgs, IHighPassFilterArgs
    {
        public double CutoffFrequency { get; set; }
    }
}