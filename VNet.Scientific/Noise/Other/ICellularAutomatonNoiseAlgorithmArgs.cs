namespace VNet.Scientific.Noise.Other
{
    public interface ICellularAutomatonNoiseAlgorithmArgs : INoiseAlgorithmArgs
    {
        public int Iterations { get; set; }
        public double Threshold { get; set; }
    }
}