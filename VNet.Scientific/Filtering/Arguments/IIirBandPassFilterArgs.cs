namespace VNet.Scientific.Filtering.Arguments
{
    public interface IIirBandPassFilterArgs : IIirFilterArgs, IBandPassFilterArgs
    {
        public double CutoffLowFrequency { get; set; }
        public double CutoffHighFrequency { get; set; }
    }
}