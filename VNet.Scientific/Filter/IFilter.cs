namespace VNet.Scientific.Filter;

public interface IFilter
{
    public double[] Filter(double[] input);
    public bool IsValid();
}