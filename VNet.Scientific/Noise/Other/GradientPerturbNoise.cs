//// ReSharper disable UnusedMember.Global

//namespace VNet.Scientific.Noise.Other;
//// Gradient perturb noise is a type of noise where the coordinates of each point are slightly altered (or "perturbed") using another noise function
//// before being input into the main noise function. This has the effect of distorting the output in an interesting way.
//public class GradientPerturbNoise : INoiseAlgorithm
//{
//    private SimplexNoise _perturbNoise;
//    private INoiseAlgorithm _baseNoise;

//    private double _frequency;
//    private double _amplitude;

//    public GradientPerturbNoise(INoiseAlgorithm baseNoise, double frequency = 0.1, double amplitude = 1.0)
//    {
//        _perturbNoise = new SimplexNoise();
//        _baseNoise = baseNoise;
//        _frequency = frequency;
//        _amplitude = amplitude;
//    }

//    public double[,] Generate(INoiseAlgorithmArgs args)
//    {
//        var result = new double[Args.Height, Args.Width];

//        for (int i = 0; i < Args.Height; i++)
//        {
//            for (int j = 0; j < Args.Width; j++)
//            {
//                double x = j + _amplitude * _perturbNoise.Noise(i * _frequency, j * _frequency);
//                double y = i + _amplitude * _perturbNoise.Noise(j * _frequency, i * _frequency);

//                x = Math.Max(0, Math.Min(Args.Width - 1, x));
//                y = Math.Max(0, Math.Min(Args.Height - 1, y));

//                //base noise is Simplex
//                result[i, j] = _baseNoise.GenerateSingleSample(new NoiseAlgorithmArgs
//                {
//                    Width = (int)x,
//                    Height = (int)y,
//                    QuantizeLevels = Args.QuantizeLevels,
//                    Scale = Args.Scale,
//                    RandomDistributionAlgorithm = Args.RandomDistributionAlgorithm
//                });
//            }
//        }

//        return result;
//    }

//    //...
//}
