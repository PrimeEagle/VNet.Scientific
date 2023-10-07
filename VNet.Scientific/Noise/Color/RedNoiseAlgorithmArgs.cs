namespace VNet.Scientific.Noise.Color
{
    public class RedNoiseAlgorithmArgs : NoiseAlgorithmArgs, IRedNoiseAlgorithmArgs
    {
        public double SamplingRate { get; set; }



        public INoiseAlgorithmArgs Clone()
        {
            var result = new RedNoiseAlgorithmArgs()
            {
                SamplingRate = SamplingRate
            };

            return result;
        }
    }
}