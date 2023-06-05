namespace VNet.Scientific.Filter.Arguments
{
    public interface IButterworthNotchFilterArgs : IButterworthFilterArgs, INotchFilterArgs
    {
        public double CentralFrequency { get; set; }
        public double Q { get; set; }
    }
}