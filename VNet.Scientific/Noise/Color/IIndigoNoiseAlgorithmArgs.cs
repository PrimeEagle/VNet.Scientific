namespace VNet.Scientific.Noise.Color
{
    public interface IIndigoNoiseAlgorithmArgs : INoiseAlgorithmArgs
    {
        public double BlueNoiseWeight { get; set; }
        public double WhiteNoiseWeight { get; set; }
        public double GrayNoiseWeight { get; set; }
    }
}