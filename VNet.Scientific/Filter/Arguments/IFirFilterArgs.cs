namespace VNet.Scientific.Filter.Arguments;

public interface IFirFilterArgs : IFilterArgs
{
    public int Order { get; set; }
    public double SamplingRate { get; set; }
    public double Sigma { get; set; }
    public WindowFunction WindowFunction { get; set; }
}