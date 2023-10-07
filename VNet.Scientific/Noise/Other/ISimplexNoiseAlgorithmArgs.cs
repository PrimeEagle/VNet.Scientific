namespace VNet.Scientific.Noise.Other
{
    public interface ISimplexNoiseAlgorithmArgs : INoiseAlgorithmArgs
    {
        public int[] P { get; set; }
        public int[] Permutation { get; set; }
        public double F2 { get; set; }
        public double G2 { get; set; }
    }
}