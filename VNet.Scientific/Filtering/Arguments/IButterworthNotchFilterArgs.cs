namespace VNet.Scientific.Filtering.Arguments
{
    public interface IButterworthNotchFilterArgs : IButterworthFilterArgs, INotchFilterArgs
    {
        public double CentralFrequency { get; set; }
        public double Q { get; set; }
    }
}