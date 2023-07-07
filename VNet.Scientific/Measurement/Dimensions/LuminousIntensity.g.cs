
    // Auto-generated for VNet on 2023-07-06 12:42:23
    using System.Numerics;
    
    
    namespace VNet.Scientific.Measurement.Dimensions
    {
        public sealed class LuminousIntensity<TVal> : DimensionBase<LuminousIntensityUnit, TVal> where TVal : notnull, INumber<TVal>
        {
            public override string IdTag => nameof(LuminousIntensity<TVal>);
            
            public LuminousIntensity() : base()
            {
                Exponents.Length = 0;
                Exponents.Mass = 0;
                Exponents.Time = 0;
                Exponents.ElectricalCurrent = 0;
                Exponents.LuminousIntensity = 1;
                Exponents.Temperature = 0;
                Exponents.Amount = 0;
                
                DefaultUnit = LuminousIntensityUnit.Candela;
                
                Symbols.Add(LuminousIntensityUnit.Yottacandela, "Ycd");
                Symbols.Add(LuminousIntensityUnit.Zettacandela, "Zcd");
                Symbols.Add(LuminousIntensityUnit.Exacandela, "Ecd");
                Symbols.Add(LuminousIntensityUnit.Petacandela, "Pcd");
                Symbols.Add(LuminousIntensityUnit.Teracandela, "Tcd");
                Symbols.Add(LuminousIntensityUnit.Gigacandela, "Gcd");
                Symbols.Add(LuminousIntensityUnit.Megacandela, "Mcd");
                Symbols.Add(LuminousIntensityUnit.Kilocandela, "kcd");
                Symbols.Add(LuminousIntensityUnit.Hectocandela, "hcd");
                Symbols.Add(LuminousIntensityUnit.Dekacandela, "dacd");
                Symbols.Add(LuminousIntensityUnit.Candela, "cd");
                Symbols.Add(LuminousIntensityUnit.Decicandela, "dcd");
                Symbols.Add(LuminousIntensityUnit.Centicandela, "ccd");
                Symbols.Add(LuminousIntensityUnit.Millicandela, "mcd");
                Symbols.Add(LuminousIntensityUnit.Microcandela, "µcd");
                Symbols.Add(LuminousIntensityUnit.Nanocandela, "ncd");
                Symbols.Add(LuminousIntensityUnit.Picocandela, "pcd");
                Symbols.Add(LuminousIntensityUnit.Femtocandela, "fcd");
                Symbols.Add(LuminousIntensityUnit.Attocandela, "acd");
                Symbols.Add(LuminousIntensityUnit.Zeptocandela, "zcd");
                Symbols.Add(LuminousIntensityUnit.Yoctocandela, "ycd");
                
                
                ConversionFunctions.Add(LuminousIntensityUnit.Yottacandela, "x * 1e24");
                ConversionFunctions.Add(LuminousIntensityUnit.Zettacandela, "x * 1e21");
                ConversionFunctions.Add(LuminousIntensityUnit.Exacandela, "x * 1e18");
                ConversionFunctions.Add(LuminousIntensityUnit.Petacandela, "x * 1e15");
                ConversionFunctions.Add(LuminousIntensityUnit.Teracandela, "x * 1e12");
                ConversionFunctions.Add(LuminousIntensityUnit.Gigacandela, "x * 1e9");
                ConversionFunctions.Add(LuminousIntensityUnit.Megacandela, "x * 1e6");
                ConversionFunctions.Add(LuminousIntensityUnit.Kilocandela, "x * 1e3");
                ConversionFunctions.Add(LuminousIntensityUnit.Hectocandela, "x * 1e2");
                ConversionFunctions.Add(LuminousIntensityUnit.Dekacandela, "x * 1e1");
                ConversionFunctions.Add(LuminousIntensityUnit.Candela, "x * 1e0");
                ConversionFunctions.Add(LuminousIntensityUnit.Decicandela, "x * 1e-1");
                ConversionFunctions.Add(LuminousIntensityUnit.Centicandela, "x * 1e-2");
                ConversionFunctions.Add(LuminousIntensityUnit.Millicandela, "x * 1e-3");
                ConversionFunctions.Add(LuminousIntensityUnit.Microcandela, "x * 1e-6");
                ConversionFunctions.Add(LuminousIntensityUnit.Nanocandela, "x * 1e-9");
                ConversionFunctions.Add(LuminousIntensityUnit.Picocandela, "x * 1e-12");
                ConversionFunctions.Add(LuminousIntensityUnit.Femtocandela, "x * 1e-15");
                ConversionFunctions.Add(LuminousIntensityUnit.Attocandela, "x * 1e-18");
                ConversionFunctions.Add(LuminousIntensityUnit.Zeptocandela, "x * 1e-21");
                ConversionFunctions.Add(LuminousIntensityUnit.Yoctocandela, "x * 1e-24");
            }
        }
    }
