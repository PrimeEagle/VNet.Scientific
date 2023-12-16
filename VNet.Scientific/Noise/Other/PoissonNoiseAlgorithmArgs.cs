namespace VNet.Scientific.Noise.Other
{
    public class PoissonNoiseAlgorithmArgs : NoiseAlgorithmArgs, IPoissonNoiseAlgorithmArgs
    {
        public double Mean { get; set; }


        public PoissonNoiseAlgorithmArgs(double mean = 1.0d)
        {
            Mean = mean;
        }

        public override INoiseAlgorithmArgs Clone()
        {
            var result = base.Clone();

            ((IPoissonNoiseAlgorithmArgs)result).Mean = Mean;

            return result;
        }
    }
}