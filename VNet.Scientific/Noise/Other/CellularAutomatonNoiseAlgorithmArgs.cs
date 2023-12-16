namespace VNet.Scientific.Noise.Other
{
    public class CellularAutomatonNoiseAlgorithmArgs : NoiseAlgorithmArgs, ICellularAutomatonNoiseAlgorithmArgs
    {
        public int Iterations { get; set; }
        public double Threshold { get; set; }


        public override INoiseAlgorithmArgs Clone()
        {
            var result = new CellularAutomatonNoiseAlgorithmArgs()
            {
                Iterations = Iterations,
                Threshold = Threshold
            };

            return result;
        }
    }
}