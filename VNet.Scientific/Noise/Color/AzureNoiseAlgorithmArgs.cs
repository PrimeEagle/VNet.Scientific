namespace VNet.Scientific.Noise.Color
{
    public class AzureNoiseAlgorithmArgs : NoiseAlgorithmArgs, IAzureNoiseAlgorithmArgs
    {
        public double BlueNoiseWeight { get; set; }
        public double VioletNoiseWeight { get; set; }

        public INoiseAlgorithmArgs Clone()
        {
            var result = new AzureNoiseAlgorithmArgs()
            {
                BlueNoiseWeight = BlueNoiseWeight,
                VioletNoiseWeight = VioletNoiseWeight
            };

            return result;
        }
    }
}