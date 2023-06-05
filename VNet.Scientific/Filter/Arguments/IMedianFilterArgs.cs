namespace VNet.Scientific.Filter.Arguments;

public interface IMedianFilterArgs : IFilterArgs
{
    public int Order { get; set; }
}