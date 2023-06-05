namespace VNet.Scientific.Filter.Arguments
{
    public interface IButterworthHighPassFilterArgs : IButterworthFilterArgs, IHighPassFilterArgs
    {
        public double PassBandFrequency { get; set; }
        public double StopBandFrequency { get; set; }
    }
}