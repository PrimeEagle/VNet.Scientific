// ReSharper disable UnusedMember.Global

namespace VNet.Scientific.Noise.Other;

// Red noise, also known as Brown or Brownian noise, is similar to pink noise in that it also decreases in power as frequency increases.However,
// while pink noise decreases power by 3 dB per octave, red noise decreases power by 6 dB per octave (or 20 dB per decade). This means it's essentially
// "more pink" than pink noise. Generating red noise is typically done by integrating white noise, or in other words, each sample of red noise is
// the sum of the current white noise sample and the previous red noise sample.
public class CubicNoise : NoiseBase
{
    public CubicNoise(INoiseAlgorithmArgs args) : base(args)
    {
    }

    public override double[,] GenerateRaw()
    {
        var result = new double[Args.Height, Args.Width];

        for (var i = 0; i < Args.Height; i++)
            for (var j = 0; j < Args.Width; j++)
            {
                var x = j / (double)Args.Width;
                var y = i / (double)Args.Height;
                result[i, j] = Noise(x, y);
            }

        return result;
    }

    public override double GenerateSingleSampleRaw()
    {
        throw new NotImplementedException("Cubic noise is generated for the entire grid, so generating a single sample is not applicable.");
    }

    private double Noise(double x, double y)
    {
        var X = (int)Math.Floor(x) & 255;
        var Y = (int)Math.Floor(y) & 255;

        x -= Math.Floor(x);
        y -= Math.Floor(y);

        var u = Fade(x);
        var v = Fade(y);

        var A = p[X] + Y;
        var AA = p[A];
        var AB = p[A + 1];
        var B = p[X + 1] + Y;
        var BA = p[B];
        var BB = p[B + 1];

        var gradAA = Grad(p[AA], x, y);
        var gradAB = Grad(p[AB], x, y - 1);
        var gradBA = Grad(p[BA], x - 1, y);
        var gradBB = Grad(p[BB], x - 1, y - 1);

        var noise = Lerp(Lerp(gradAA, gradBA, u), Lerp(gradAB, gradBB, u), v);

        return (noise + 1) / 2.0; // Adjust range to [0, 1]
    }

    private static double Fade(double t)
    {
        return t * t * t * (t * (t * 6 - 15) + 10);
    }

    private static double Lerp(double a, double b, double t)
    {
        return a + t * (b - a);
    }

    private static double Grad(int hash, double x, double y)
    {
        var h = hash & 15;
        var u = h < 8 ? x : y;
        var v = h < 4 ? y : h == 12 || h == 14 ? x : 0;
        return ((h & 1) == 0 ? u : -u) + ((h & 2) == 0 ? v : -v);
    }

    private static readonly int[] p = { 151, 160, 137, 91, 90, 15, 131, 13, 201, 95, 96, 53, 194, 233, 7, 225, 140, 36, 103, 30, 69, 142, 8, 99, 37, 240, 21, 10, 23, 190, 6, 148, 247, 120, 234, 75, 0, 26, 197, 62, 94, 252, 219, 203, 117, 35, 11, 32, 57, 177, 33, 88, 237, 149, 56, 87, 174, 20, 125, 136, 171, 168, 68, 175, 74, 165, 71, 134, 139, 48, 27, 166, 77, 146, 158, 231, 83, 111, 229, 122, 60, 211, 133, 230, 220, 105, 92, 41, 55, 46, 245, 40, 244, 102, 143, 54, 65, 25, 63, 161, 1, 216, 80, 73, 209, 76, 132, 187, 208, 89, 18, 169, 200, 196, 135, 130, 116, 188, 159, 86, 164, 100, 109, 198, 173, 186, 3, 64, 52, 217, 226, 250, 124, 123, 5, 202, 38, 147, 118, 126, 255, 82, 85, 212, 207, 206, 59, 227, 47, 16, 58, 17, 182, 189, 28, 42, 223, 183, 170, 213, 119, 248, 152, 2, 44, 154, 163, 70, 221, 153, 101, 155, 167, 43, 172, 9, 129, 22, 39, 253, 19, 98, 108, 110, 79, 113, 224, 232, 178, 185, 112, 104, 218, 246, 97, 228, 251, 34, 242, 193, 238, 210, 144, 12, 191, 179, 162, 241, 81, 51, 145, 235, 249, 14, 239, 107, 49, 192, 214, 31, 181, 199, 106, 157, 184, 84, 204, 176, 115, 121, 50, 45, 127, 4, 150, 254, 138, 236, 205, 93, 222, 114, 67, 29, 24, 72, 243, 141, 128, 195, 78, 66, 215, 61, 156, 180 };
}