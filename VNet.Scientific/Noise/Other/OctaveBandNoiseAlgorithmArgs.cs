using VNet.Scientific.Filtering;

namespace VNet.Scientific.Noise.Other
{
    public class OctaveBandNoiseAlgorithmArgs : NoiseAlgorithmArgs, IOctaveBandNoiseAlgorithmArgs
    {
        public double CenterFrequency { get; set; }
        public double Bandwidth { get; set; }
        public double SamplingRate { get; set; }
        public INoiseAlgorithm BaseNoiseAlgorithm { get; set; }
        public IFilter Filter { get; set; }


        public OctaveBandNoiseAlgorithmArgs(double centerFrequency, double bandwidth, INoiseAlgorithm baseNoiseAlgorithm)
        {
            CenterFrequency = centerFrequency;
            Bandwidth = bandwidth;
            BaseNoiseAlgorithm = baseNoiseAlgorithm;
        }

        public override INoiseAlgorithmArgs Clone()
        {
            var result = base.Clone();

            ((IOctaveBandNoiseAlgorithmArgs)result).CenterFrequency = CenterFrequency;
            ((IOctaveBandNoiseAlgorithmArgs)result).Bandwidth = Bandwidth;
            ((IOctaveBandNoiseAlgorithmArgs)result).SamplingRate = SamplingRate;
            ((IOctaveBandNoiseAlgorithmArgs)result).BaseNoiseAlgorithm = BaseNoiseAlgorithm;

            return result;
        }
    }
}