// ReSharper disable MemberCanBePrivate.Global
namespace VNet.Scientific.Noise.Other
{
    public class PerlinNoiseAlgorithmArgs : NoiseAlgorithmArgs, IPerlinNoiseAlgorithmArgs
    {
        public int Octave { get; set; }

        public override INoiseAlgorithmArgs Clone()
        {
            var result = base.Clone();

            ((IPerlinNoiseAlgorithmArgs)result).Octave = Octave;

            return result;
        }
    }
}