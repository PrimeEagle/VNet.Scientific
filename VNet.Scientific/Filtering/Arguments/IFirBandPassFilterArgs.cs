namespace VNet.Scientific.Filtering.Arguments
{
    public interface IFirBandPassFilterArgs : IFirFilterArgs, IBandPassFilterArgs
    {
        public double CutoffLowFrequency { get; set; }
        public double CutoffHighFrequency { get; set; }
    }
}