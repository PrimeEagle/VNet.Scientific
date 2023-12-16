namespace VNet.Scientific.Filtering;

public interface IFilter
{
    Array Filter(Array input);
    bool IsValid();
}