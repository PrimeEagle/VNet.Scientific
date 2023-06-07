namespace VNet.Scientific.Filtering.Algorithms;

public interface IFilterAlgorithm
{
    public double[] Apply(double[] input);
    public bool IsValid();
}