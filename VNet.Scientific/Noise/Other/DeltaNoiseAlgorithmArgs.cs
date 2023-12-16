namespace VNet.Scientific.Noise.Other
{
    public class DeltaNoiseAlgorithmArgs : NoiseAlgorithmArgs, IDeltaNoiseAlgorithmArgs

    {
        public int DeltaIndex { get; set; }
        public double DeltaValue { get; set; }


        public override INoiseAlgorithmArgs Clone()
        {
            var result = base.Clone();

            ((IDeltaNoiseAlgorithmArgs)result).DeltaIndex = DeltaIndex;
            ((IDeltaNoiseAlgorithmArgs)result).DeltaValue = DeltaValue;

            return result;
        }
    }
}