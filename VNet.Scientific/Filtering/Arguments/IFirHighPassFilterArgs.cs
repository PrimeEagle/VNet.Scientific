namespace VNet.Scientific.Filtering.Arguments
{
    public interface IFirHighPassFilterArgs : IFirFilterArgs, IHighPassFilterArgs
    {
        public double CutoffFrequency { get; set; }
    }
}