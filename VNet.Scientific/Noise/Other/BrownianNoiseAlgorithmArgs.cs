namespace VNet.Scientific.Noise.Other;

public class BrownianNoiseAlgorithmArgs : NoiseAlgorithmArgs, IBrownianNoiseAlgorithmArgs
{
    public int Octaves { get; set; }
    public double Frequency { get; set; }
    public double Amplitude { get; set; }

    public override INoiseAlgorithmArgs Clone()
    {
        var result = base.Clone();

        ((BrownianNoiseAlgorithmArgs)result).Octaves = Octaves;
        ((BrownianNoiseAlgorithmArgs)result).Frequency = Frequency;
        ((BrownianNoiseAlgorithmArgs)result).Amplitude = Amplitude;

        return result;
    }
}