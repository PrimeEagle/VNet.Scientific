namespace VNet.Scientific.Filtering.Arguments;

public interface IButterworthFilterArgs : IFilterArgs
{
    public double PassBandRipple { get; set; }
    public double StopBandAttenuation { get; set; }
}