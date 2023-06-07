namespace VNet.Scientific.Filtering.Arguments;

public interface IMedianFilterArgs : IFilterArgs
{
    public int Order { get; set; }
}