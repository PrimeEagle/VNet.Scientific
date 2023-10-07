namespace VNet.Scientific.Noise.Color
{
    public interface IAzureNoiseAlgorithmArgs : INoiseAlgorithmArgs
    {
        public double BlueNoiseWeight { get; set; }
        public double VioletNoiseWeight { get; set; }
    }
}