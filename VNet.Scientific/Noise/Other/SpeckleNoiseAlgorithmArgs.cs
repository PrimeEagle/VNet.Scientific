namespace VNet.Scientific.Noise.Other
{
    public class SpeckleNoiseAlgorithmArgs : NoiseAlgorithmArgs, ISpeckleNoiseAlgorithmArgs
    {
        public double Intensity { get; set; }


        public SpeckleNoiseAlgorithmArgs(double intensity)
        {
            Intensity = intensity;
        }

        public override INoiseAlgorithmArgs Clone()
        {
            var result = base.Clone();

            ((ISpeckleNoiseAlgorithmArgs)result).Intensity = Intensity;

            return result;
        }
    }
}