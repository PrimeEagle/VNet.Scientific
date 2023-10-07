namespace VNet.Scientific.Noise.Other
{
    public class LSystemsNoiseAlgorithmArgs : NoiseAlgorithmArgs, ILSystemsNoiseAlgorithmArgs
    {
        public Dictionary<char, string> Rules { get; set; }
        public int Iterations { get; set; }


        public LSystemsNoiseAlgorithmArgs(Dictionary<char, string> rules, int iterations = 5)
        {
            Rules = rules;
            Iterations = iterations;
        }

        public override INoiseAlgorithmArgs Clone()
        {
            var result = base.Clone();

            ((ILSystemsNoiseAlgorithmArgs)result).Rules = Rules;
            ((ILSystemsNoiseAlgorithmArgs)result).Iterations = Iterations;

            return result;
        }
    }
}