//// ReSharper disable UnusedMember.Global
//// ReSharper disable SuggestBaseTypeForParameterInConstructor
//namespace VNet.Scientific.Noise.Color;

//// Crimson noise is a term occasionally used to describe noise with a power spectral density that increases at a rate higher than
//// red (brown) noise. It emphasizes higher frequencies more than red noise.
//public class CrimsonNoise : NoiseBase
//{
//    private readonly INoiseAlgorithm _redNoise;
//    private readonly INoiseAlgorithm _violetNoise;

//    public CrimsonNoise(ICrimsonNoiseAlgorithmArgs args) : base(args)
//    {
//        var redArgs = new RedNoiseAlgorithmArgs()
//        {
//            OutputFilter = null,
//            Scale = 1,
//            Width = Args.Width,
//            Height = Args.Height,
//            SamplingRate = 44100,
//            RandomDistributionAlgorithm = Args.RandomDistributionAlgorithm,
//            QuantizeLevel = 0
//        };
//        _redNoise = new RedNoise(redArgs);

//        var violetArgs = Args.Clone();
//        violetArgs.OutputFilter = null;
//        violetArgs.Scale = 1;
//        violetArgs.QuantizeLevel = 0;
//        _violetNoise = new VioletNoise(violetArgs);
//    }

//    public override double[,] GenerateRaw()
//    {
//        var result = new double[Args.Height, Args.Width];

//        var redNoiseData = _redNoise.Generate();
//        var purpleNoiseData = _violetNoise.Generate();

//        for (var i = 0; i < Args.Height; i++)
//            for (var j = 0; j < Args.Width; j++)
//            {
//                var redNoiseValue = redNoiseData[i, j];
//                var purpleNoiseValue = purpleNoiseData[i, j];
//                result[i, j] = ((ICrimsonNoiseAlgorithmArgs)Args).RedNoiseWeight * redNoiseValue + ((ICrimsonNoiseAlgorithmArgs)Args).VioletNoiseWeight * purpleNoiseValue;
//            }

//        return result;
//    }

//    public override double GenerateSingleSampleRaw()
//    {
//        throw new NotImplementedException("Crimson noise is generated for the entire grid, so generating a single sample is not applicable.");
//    }
//}