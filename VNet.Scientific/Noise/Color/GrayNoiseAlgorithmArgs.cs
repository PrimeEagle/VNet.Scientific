namespace VNet.Scientific.Noise.Color
{
    public class GrayNoiseAlgorithmArgs : NoiseAlgorithmArgs, IGrayNoiseAlgorithmArgs
    {
        public double BlueNoiseWeight { get; set; }
        public double WhiteNoiseWeight { get; set; }



        public INoiseAlgorithmArgs Clone()
        {
            var result = new GrayNoiseAlgorithmArgs()
            {
                BlueNoiseWeight = BlueNoiseWeight,
                WhiteNoiseWeight = WhiteNoiseWeight
            };

            return result;
        }
    }
}