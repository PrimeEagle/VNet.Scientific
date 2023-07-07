
    // Auto-generated for VNet on 2023-07-06 12:42:23
    using System.Numerics;
    
    
    namespace VNet.Scientific.Measurement.Dimensions
    {
        public sealed class LuminousFlux<TVal> : DimensionBase<LuminousFluxUnit, TVal> where TVal : notnull, INumber<TVal>
        {
            public override string IdTag => nameof(LuminousFlux<TVal>);
            
            public LuminousFlux() : base()
            {
                Exponents.Length = 0;
                Exponents.Mass = 0;
                Exponents.Time = 0;
                Exponents.ElectricalCurrent = 0;
                Exponents.LuminousIntensity = 1;
                Exponents.Temperature = 0;
                Exponents.Amount = 0;
                
                DefaultUnit = LuminousFluxUnit.Lumen;
                
                Symbols.Add(LuminousFluxUnit.Yottalumen, "Ylm");
                Symbols.Add(LuminousFluxUnit.Zettalumen, "Zlm");
                Symbols.Add(LuminousFluxUnit.Exalumen, "Elm");
                Symbols.Add(LuminousFluxUnit.Petalumen, "Plm");
                Symbols.Add(LuminousFluxUnit.Teralumen, "Tlm");
                Symbols.Add(LuminousFluxUnit.Gigalumen, "Glm");
                Symbols.Add(LuminousFluxUnit.Megalumen, "Mlm");
                Symbols.Add(LuminousFluxUnit.Kilolumen, "klm");
                Symbols.Add(LuminousFluxUnit.Hectolumen, "hlm");
                Symbols.Add(LuminousFluxUnit.Dekalumen, "dalm");
                Symbols.Add(LuminousFluxUnit.Lumen, "lm");
                Symbols.Add(LuminousFluxUnit.Decilumen, "dlm");
                Symbols.Add(LuminousFluxUnit.Centilumen, "clm");
                Symbols.Add(LuminousFluxUnit.Millilumen, "mlm");
                Symbols.Add(LuminousFluxUnit.Microlumen, "µlm");
                Symbols.Add(LuminousFluxUnit.Nanolumen, "nlm");
                Symbols.Add(LuminousFluxUnit.Picolumen, "plm");
                Symbols.Add(LuminousFluxUnit.Femtolumen, "flm");
                Symbols.Add(LuminousFluxUnit.Attolumen, "alm");
                Symbols.Add(LuminousFluxUnit.Zeptolumen, "zlm");
                Symbols.Add(LuminousFluxUnit.Yoctolumen, "ylm");
                
                
                ConversionFunctions.Add(LuminousFluxUnit.Yottalumen, "x * 1e24");
                ConversionFunctions.Add(LuminousFluxUnit.Zettalumen, "x * 1e21");
                ConversionFunctions.Add(LuminousFluxUnit.Exalumen, "x * 1e18");
                ConversionFunctions.Add(LuminousFluxUnit.Petalumen, "x * 1e15");
                ConversionFunctions.Add(LuminousFluxUnit.Teralumen, "x * 1e12");
                ConversionFunctions.Add(LuminousFluxUnit.Gigalumen, "x * 1e9");
                ConversionFunctions.Add(LuminousFluxUnit.Megalumen, "x * 1e6");
                ConversionFunctions.Add(LuminousFluxUnit.Kilolumen, "x * 1e3");
                ConversionFunctions.Add(LuminousFluxUnit.Hectolumen, "x * 1e2");
                ConversionFunctions.Add(LuminousFluxUnit.Dekalumen, "x * 1e1");
                ConversionFunctions.Add(LuminousFluxUnit.Lumen, "x * 1e0");
                ConversionFunctions.Add(LuminousFluxUnit.Decilumen, "x * 1e-1");
                ConversionFunctions.Add(LuminousFluxUnit.Centilumen, "x * 1e-2");
                ConversionFunctions.Add(LuminousFluxUnit.Millilumen, "x * 1e-3");
                ConversionFunctions.Add(LuminousFluxUnit.Microlumen, "x * 1e-6");
                ConversionFunctions.Add(LuminousFluxUnit.Nanolumen, "x * 1e-9");
                ConversionFunctions.Add(LuminousFluxUnit.Picolumen, "x * 1e-12");
                ConversionFunctions.Add(LuminousFluxUnit.Femtolumen, "x * 1e-15");
                ConversionFunctions.Add(LuminousFluxUnit.Attolumen, "x * 1e-18");
                ConversionFunctions.Add(LuminousFluxUnit.Zeptolumen, "x * 1e-21");
                ConversionFunctions.Add(LuminousFluxUnit.Yoctolumen, "x * 1e-24");
            }
        }
    }
