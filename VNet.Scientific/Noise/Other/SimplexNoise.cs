﻿//// ReSharper disable UnusedMember.Global

//namespace VNet.Scientific.Noise.Other;
//// Simplex noise is an improvement over Perlin noise, developed by Ken Perlin himself to address some of the limitations of the Perlin noise algorithm.
//// Simplex noise has a lower computational complexity and does not have visible directional artifacts. Implementing Simplex noise in C# is quite
//// complex, involving the computation of gradients in simplex space, the mapping of points from the input space to simplex space, and the addition
//// of the contributions of each corner of the simplex.
//public class SimplexNoise : INoiseAlgorithm
//{
//    private static readonly int[] p = new int[256];
//    private static readonly int[] permutation = { 151,160,137,91,90,15,
//        131,13,201,95,96,53,194,233,7,225,140,36,103,30,69,142,8,99,37,240,21,10,23,
//        190, 6,148,247,120,234,75,0,26,197,62,94,252,219,203,117,35,11,32,57,177,33,
//        88,237,149,56,87,174,20,125,136,171,168, 68,175,74,165,71,134,139,48,27,166,
//        77,146,158,231,83,111,229,122,60,211,133,230,220,105,92,41,55,46,245,40,244,
//        102,143,54, 65,25,63,161, 1,216,80,73,209,76,132,187,208, 89,18,169,200,196,
//        135,130,116,188,159,86,164,100,109,198,173,186, 3,64,52,217,226,250,124,123,
//        5,202,38,147,118,126,255,82,85,212,207,206,59,227,47,16,58,17,182,189,28,42,
//        223,183,170,213,119,248,152, 2,44,154,163, 70,221,153,101,155,167, 43,172,9,
//        129,22,39,253, 19,98,108,110,79,113,224,232,178,185, 112,104,218,246,97,228,
//        251,34,242,193,238,210,144,12,191,179,162,241, 81,51,145,235,249,14,239,107,
//        49,192,214, 31,181,199,106,157,184, 84,204,176,115,121,50,45,127, 4,150,254,
//        138,236,205,93,222,114,67,29,24,72,243,141,128,195,78,66,215,61,156,180
//    };

//    private static readonly double F2 = 0.5 * (Math.Sqrt(3.0) - 1.0);
//    private static readonly double G2 = (3.0 - Math.Sqrt(3.0)) / 6.0;

//    public SimplexNoise()
//    {
//        for (int i = 0; i < 256; i++)
//            p[256 + i] = p[i] = permutation[i];
//    }

//    public double[,] Generate(INoiseAlgorithmArgs args)
//    {
//        var result = new double[Args.Height, Args.Width];

//        for (int i = 0; i < Args.Height; i++)
//        {
//            for (int j = 0; j < Args.Width; j++)
//            {
//                double x = j / (double)Args.Width;
//                double y = i / (double)Args.Height;
//                result[i, j] = Noise(x, y) * Args.Scale;
//            }
//        }

//        return result;
//    }

//    private double Noise(double xin, double yin)
//    {
//        double n0, n1, n2;
//        double s = (xin + yin) * F2;
//        int i = FastFloor(xin + s);
//        int j = FastFloor(yin + s);
//        double t = (i + j) * G2;
//        double X0 = i - t;
//        double Y0 = j - t;
//        double x0 = xin - X0;
//        double y0 = yin - Y0;

//        int i1, j1;
//        if (x0 > y0) { i1 = 1; j1 = 0; }
//        else { i1 = 0; j1 = 1; }

//        double x1 = x0 - i1 + G2;
//        double y1 = y0 - j1 + G2;
//        double x2 = x0 - 1.0 + 2.0 * G2;
//        double y2 = y0 - 1.0 + 2.0 * G2;

//        int ii = i & 255;
//        int jj = j & 255;
//        int gi0 = p[ii + p[jj]] % 12;
//        int gi1 = p[ii + i1 + p[jj + j1]] % 12;
//        int gi2 = p[ii + 1 + p[jj + 1]] % 12;

//        double t0 = 0.5 - x0 * x0 - y0 * y0;
//        if (t0 < 0) n0 = 0.0;
//        else
//        {
//            t0 *= t0;
//            n0 = t0 * t0 * Dot(grad3[gi0], x0, y0);
//        }

//        double t1 = 0.5 - x1 * x1 - y1 * y1;
//        if (t1 < 0) n1 = 0.0;
//        else
//        {
//            t1 *= t1;
//            n1 = t1 * t1 * Dot(grad3[gi1], x1, y1);
//        }

//        double t2 = 0.5 - x2 * x2 - y2 * y2;
//        if (t2 < 0) n2 = 0.0;
//        else
//        {
//            t2 *= t2;
//            n2 = t2 * t2 * Dot(grad3[gi2], x2, y2);
//        }

//        return 70.0 * (n0 + n1 + n2);
//    }

//    private static int FastFloor(double x)
//    {
//        return x > 0 ? (int)x : (int)x - 1;
//    }

//    private static double Dot(int[] g, double x, double y)
//    {
//        return g[0] * x + g[1] * y;
//    }

//    private static readonly int[][] grad3 = { { 1, 1, 0 }, { -1, 1, 0 }, { 1, -1, 0 }, { -1, -1, 0 }, { 1, 0, 1 }, { -1, 0, 1 }, { 1, 0, -1 }, { -1, 0, -1 }, { 0, 1, 1 }, { 0, -1, 1 }, { 0, 1, -1 }, { 0, -1, -1 } };
//}