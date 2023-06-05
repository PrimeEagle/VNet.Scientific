namespace VNet.Scientific.Filter.Algorithms;

public interface IFilterAlgorithm
{
    public double[] Apply(double[] input);
    public bool IsValid();
}