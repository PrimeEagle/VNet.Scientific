namespace VNet.Scientific.Filtering;

public interface IFilter
{
    public double[] Filter(double[] input);
    public bool IsValid();
}