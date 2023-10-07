// ReSharper disable MemberCanBePrivate.Global
namespace VNet.Scientific.Noise.Other
{
    public class WorleyNoiseAlgorithmArgs : NoiseAlgorithmArgs, IWorleyNoiseAlgorithmArgs
    {
        public int PointCount { get; set; }


        public WorleyNoiseAlgorithmArgs(int pointCount = 30)
        {
            PointCount = pointCount;
        }

        public override INoiseAlgorithmArgs Clone()
        {
            var result = base.Clone();

            ((IWorleyNoiseAlgorithmArgs)result).PointCount = PointCount;

            return result;
        }
    }
}