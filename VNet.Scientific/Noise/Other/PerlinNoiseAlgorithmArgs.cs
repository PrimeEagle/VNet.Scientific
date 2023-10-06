namespace VNet.Scientific.Noise.Other
{
    public class PerlinNoiseAlgorithmArgs : NoiseAlgorithmArgs
    {
        public int Octave { get; set; }

        public override INoiseAlgorithmArgs Clone()
        {
            var result = base.Clone();

            ((PerlinNoiseAlgorithmArgs)result).Octave = Octave;

            return result;
        }
    }
}