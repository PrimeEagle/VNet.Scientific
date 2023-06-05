namespace VNet.Scientific.Filter.Arguments;

public interface IIirFilterArgs : IFilterArgs
{
    public double SamplingRate { get; set; }
}