
    // Auto-generated for VNet on 2023-07-05 10:35:43
    using System.Numerics;
    
    
    namespace VNet.Scientific.Measurement.Dimensions
    {
        public sealed class Ratio<TVal> : DimensionBase<RatioUnit, TVal> where TVal : notnull, INumber<TVal>
        {
            public override string IdTag => nameof(Ratio<TVal>);
            
            public Ratio() : base()
            {
                DimensionComponent.Exponents.Length = 0;
                DimensionComponent.Exponents.Mass = 0;
                DimensionComponent.Exponents.Time = 0;
                DimensionComponent.Exponents.ElectricalCurrent = 0;
                DimensionComponent.Exponents.LuminousIntensity = 0;
                DimensionComponent.Exponents.Temperature = 0;
                DimensionComponent.Exponents.Amount = 0;
                
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
