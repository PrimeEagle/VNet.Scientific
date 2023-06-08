//// ReSharper disable UnusedMember.Global

//using System.Text;

//namespace VNet.Scientific.Noise.Other;

//// L-systems, or Lindenmayer systems, are used to generate noise-like patterns in a recursive manner. They consist of a set of rules that define how
//// symbols or characters are replaced in each iteration. L-systems have applications in procedural generation of plant structures, fractals, and visual patterns.
//public class LSystemsNoise : INoiseAlgorithm
//{
//    private Dictionary<char, string> _rules;
//    private int _iterations;

//    public LSystemsNoise(Dictionary<char, string> rules, int iterations = 5)
//    {
//        _rules = rules;
//        _iterations = iterations;
//    }

//    public double[,] Generate(INoiseAlgorithmArgs args)
//    {
//        int width = Args.Width;
//        int height = Args.Height;

//        string noiseString = "F";
//        StringBuilder noiseBuilder = new StringBuilder(noiseString);

//        for (int i = 0; i < _iterations; i++)
//        {
//            for (int j = 0; j < noiseBuilder.Length; j++)
//            {
//                char currentChar = noiseBuilder[j];

//                if (_rules.ContainsKey(currentChar))
//                {
//                    string replacement = _rules[currentChar];
//                    noiseBuilder.Replace(currentChar.ToString(), replacement, j, 1);
//                    j += replacement.Length - 1;
//                }
//            }
//        }

//        noiseString = noiseBuilder.ToString();

//        double[,] result = new double[height, width];
//        int x = width / 2;
//        int y = height / 2;
//        double angle = 0.0;

//        for (int i = 0; i < noiseString.Length; i++)
//        {
//            char currentChar = noiseString[i];

//            if (currentChar == 'F')
//            {
//                double dx = Math.Cos(angle);
//                double dy = Math.Sin(angle);

//                x = (int)MathUtils.Clamp(x + dx, 0, width - 1);
//                y = (int)MathUtils.Clamp(y + dy, 0, height - 1);

//                result[y, x] = 1.0;
//            }
//            else if (currentChar == '+')
//            {
//                angle += Math.PI / 4.0;
//            }
//            else if (currentChar == '-')
//            {
//                angle -= Math.PI / 4.0;
//            }
//        }

//        Normalize(result, Args.QuantizeLevels, Args.Scale);
//        return result;
//    }

//    public double GenerateSingleSample(INoiseAlgorithmArgs args)
//    {
//        // L-systems noise is generated for the entire grid, so generating a single sample is not applicable.
//        throw new NotImplementedException();
//    }

//    private void Normalize(double[,] noise, int quantizeLevels, double scale)
//    {
//        double min = double.MaxValue;
//        double max = double.MinValue;

//        int height = noise.GetLength(0);
//        int width = noise.GetLength(1);

//        for (int i = 0; i < height; i++)
//        {
//            for (int j = 0; j < width; j++)
//            {
//                double value = noise[i, j];
//                min = Math.Min(min, value);
//                max = Math.Max(max, value);
//            }
//        }

//        double range = max - min;
//        double invRange = range > 0.0 ? 1.0 / range : 0.0;

//        for (int i = 0; i < height; i++)
//        {
//            for (int j = 0; j < width; j++)
//            {
//                double value = (noise[i, j] - min) * invRange;
//                noise[i, j] = value * (quantizeLevels - 1) * scale;
//            }
//        }
//    }
//}