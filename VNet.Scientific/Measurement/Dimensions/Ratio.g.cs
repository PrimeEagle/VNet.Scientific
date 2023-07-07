
    // Auto-generated for VNet on 2023-07-06 12:42:23
    using System.Numerics;
    
    
    namespace VNet.Scientific.Measurement.Dimensions
    {
        public sealed class Ratio<TVal> : DimensionBase<RatioUnit, TVal> where TVal : notnull, INumber<TVal>
        {
            public override string IdTag => nameof(Ratio<TVal>);
            
            public Ratio() : base()
            {
                Exponents.Length = 0;
                Exponents.Mass = 0;
                Exponents.Time = 0;
                Exponents.ElectricalCurrent = 0;
                Exponents.LuminousIntensity = 0;
                Exponents.Temperature = 0;
                Exponents.Amount = 0;
                
                DefaultUnit = RatioUnit.DecimalFraction;
                
                Symbols.Add(RatioUnit.Percent, "%");
                Symbols.Add(RatioUnit.PartPerThousand, "‰");
                Symbols.Add(RatioUnit.PartPerMillion, "ppm");
                Symbols.Add(RatioUnit.PartPerBillion, "ppb");
                Symbols.Add(RatioUnit.PartPerTrillion, "ppt");
                
                
                ConversionFunctions.Add(RatioUnit.DecimalFraction, "x");
                ConversionFunctions.Add(RatioUnit.Percent, "x / 1e2");
                ConversionFunctions.Add(RatioUnit.PartPerThousand, "x / 1e3");
                ConversionFunctions.Add(RatioUnit.PartPerMillion, "x / 1e6");
                ConversionFunctions.Add(RatioUnit.PartPerBillion, "x / 1e9");
                ConversionFunctions.Add(RatioUnit.PartPerTrillion, "x / 1e12");
            }
        }
    }
