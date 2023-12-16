namespace VNet.Scientific.Filtering.Arguments
{
    public interface IFirBandStopFilterArgs : IFirFilterArgs, IBandStopFilterArgs
    {
        public double CutoffLowFrequency { get; set; }
        public double CutoffHighFrequency { get; set; }
    }
}