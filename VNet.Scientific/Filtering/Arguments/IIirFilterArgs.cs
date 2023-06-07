namespace VNet.Scientific.Filtering.Arguments;

public interface IIirFilterArgs : IFilterArgs
{
    public double SamplingRate { get; set; }
}