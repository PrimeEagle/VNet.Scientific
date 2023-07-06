
    // Auto-generated for VNet on 2023-07-05 10:35:43
    using System.Numerics;
    
    
    namespace VNet.Scientific.Measurement.Dimensions
    {
        public sealed class MassFraction<TVal> : DimensionBase<MassFractionUnit, TVal> where TVal : notnull, INumber<TVal>
        {
            public override string IdTag => nameof(MassFraction<TVal>);
            
            public MassFraction() : base()
            {
                DimensionComponent.Exponents.Length = 0;
                DimensionComponent.Exponents.Mass = 0;
                DimensionComponent.Exponents.Time = 0;
                DimensionComponent.Exponents.ElectricalCurrent = 0;
                DimensionComponent.Exponents.LuminousIntensity = 0;
                DimensionComponent.Exponents.Temperature = 0;
                DimensionComponent.Exponents.Amount = 0;
                
                DefaultUnit = MassFractionUnit.DecimalFraction;
                
                Symbols.Add(MassFractionUnit.GramPerGram, "g/g");
                Symbols.Add(MassFractionUnit.GramPerKilogram, "g/kg");
                Symbols.Add(MassFractionUnit.Percent, "%");
                Symbols.Add(MassFractionUnit.PartPerThousand, "‰");
                Symbols.Add(MassFractionUnit.PartPerMillion, "ppm");
                Symbols.Add(MassFractionUnit.PartPerBillion, "ppb");
                Symbols.Add(MassFractionUnit.PartPerTrillion, "ppt");
                
                PluralSymbols.Add(MassFractionUnit.Percent, "% (w/w)");
                
                ConversionFunctions.Add(MassFractionUnit.DecimalFraction, "x");
                ConversionFunctions.Add(MassFractionUnit.GramPerGram, "x");
                ConversionFunctions.Add(MassFractionUnit.GramPerKilogram, "x / 1e3");
                ConversionFunctions.Add(MassFractionUnit.Percent, "x / 1e2");
                ConversionFunctions.Add(MassFractionUnit.PartPerThousand, "x / 1e3");
                ConversionFunctions.Add(MassFractionUnit.PartPerMillion, "x / 1e6");
                ConversionFunctions.Add(MassFractionUnit.PartPerBillion, "x / 1e9");
                ConversionFunctions.Add(MassFractionUnit.PartPerTrillion, "x / 1e12");
            }
        }
    }
