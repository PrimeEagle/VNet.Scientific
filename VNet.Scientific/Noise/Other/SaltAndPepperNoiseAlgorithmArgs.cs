namespace VNet.Scientific.Noise.Other
{
    public class SaltAndPepperNoiseAlgorithmArgs : NoiseAlgorithmArgs, ISaltAndPepperNoiseAlgorithmArgs
    {
        public double Density { get; set; }
        public double SaltValue { get; set; }
        public double PepperValue { get; set; }


        public SaltAndPepperNoiseAlgorithmArgs(double density = 0.05d, double saltValue = 1.0d, double pepperValue = 0)
        {
            Density = density;
            SaltValue = saltValue;
            PepperValue = pepperValue;
        }

        public override INoiseAlgorithmArgs Clone()
        {
            var result = base.Clone();

            ((ISaltAndPepperNoiseAlgorithmArgs)result).Density = Density;
            ((ISaltAndPepperNoiseAlgorithmArgs)result).SaltValue = SaltValue;
            ((ISaltAndPepperNoiseAlgorithmArgs)result).PepperValue = PepperValue;

            return result;
        }
    }
}