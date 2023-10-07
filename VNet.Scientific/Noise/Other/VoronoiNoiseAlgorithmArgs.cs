// ReSharper disable MemberCanBePrivate.Global
namespace VNet.Scientific.Noise.Other
{
    public class VoronoiNoiseAlgorithmArgs : NoiseAlgorithmArgs, IVoronoiNoiseAlgorithmArgs
    {
        public int PointCount { get; set; }


        public VoronoiNoiseAlgorithmArgs(int pointCount = 10)
        {
            PointCount = pointCount;
        }

        public override INoiseAlgorithmArgs Clone()
        {
            var result = base.Clone();

            ((IVoronoiNoiseAlgorithmArgs)result).PointCount = PointCount;

            return result;
        }
    }
}