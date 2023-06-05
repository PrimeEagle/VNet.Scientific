namespace VNet.Scientific.Filter.Arguments;

public interface IButterworthFilterArgs : IFilterArgs
{
    public double PassBandRipple { get; set; }
    public double StopBandAttenuation { get; set; }
}