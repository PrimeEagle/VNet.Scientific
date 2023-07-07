
    // Auto-generated for VNet on 2023-07-06 12:42:23
    using System.Numerics;
    
    
    namespace VNet.Scientific.Measurement.Dimensions
    {
        public sealed class AbsorbedDoseOfIonizingRadiation<TVal> : DimensionBase<AbsorbedDoseOfIonizingRadiationUnit, TVal> where TVal : notnull, INumber<TVal>
        {
            public override string IdTag => nameof(AbsorbedDoseOfIonizingRadiation<TVal>);
            
            public AbsorbedDoseOfIonizingRadiation() : base()
            {
                Exponents.Length = 2;
                Exponents.Mass = 0;
                Exponents.Time = -2;
                Exponents.ElectricalCurrent = 0;
                Exponents.LuminousIntensity = 0;
                Exponents.Temperature = 0;
                Exponents.Amount = 0;
                
                DefaultUnit = AbsorbedDoseOfIonizingRadiationUnit.Gray;
                
                Symbols.Add(AbsorbedDoseOfIonizingRadiationUnit.Rad, "rad");
                Symbols.Add(AbsorbedDoseOfIonizingRadiationUnit.Yottagray, "YGy");
                Symbols.Add(AbsorbedDoseOfIonizingRadiationUnit.Zettagray, "ZGy");
                Symbols.Add(AbsorbedDoseOfIonizingRadiationUnit.Exagray, "EGy");
                Symbols.Add(AbsorbedDoseOfIonizingRadiationUnit.Petagray, "PGy");
                Symbols.Add(AbsorbedDoseOfIonizingRadiationUnit.Teragray, "TGy");
                Symbols.Add(AbsorbedDoseOfIonizingRadiationUnit.Gigagray, "GGy");
                Symbols.Add(AbsorbedDoseOfIonizingRadiationUnit.Megagray, "MGy");
                Symbols.Add(AbsorbedDoseOfIonizingRadiationUnit.Kilogray, "kGy");
                Symbols.Add(AbsorbedDoseOfIonizingRadiationUnit.Hectogray, "hGy");
                Symbols.Add(AbsorbedDoseOfIonizingRadiationUnit.Dekagray, "daGy");
                Symbols.Add(AbsorbedDoseOfIonizingRadiationUnit.Gray, "Gy");
                Symbols.Add(AbsorbedDoseOfIonizingRadiationUnit.Decigray, "dGy");
                Symbols.Add(AbsorbedDoseOfIonizingRadiationUnit.Centigray, "cGy");
                Symbols.Add(AbsorbedDoseOfIonizingRadiationUnit.Milligray, "mGy");
                Symbols.Add(AbsorbedDoseOfIonizingRadiationUnit.Microgray, "µGy");
                Symbols.Add(AbsorbedDoseOfIonizingRadiationUnit.Nanogray, "nGy");
                Symbols.Add(AbsorbedDoseOfIonizingRadiationUnit.Picogray, "pGy");
                Symbols.Add(AbsorbedDoseOfIonizingRadiationUnit.Femtogray, "fGy");
                Symbols.Add(AbsorbedDoseOfIonizingRadiationUnit.Attogray, "aGy");
                Symbols.Add(AbsorbedDoseOfIonizingRadiationUnit.Zeptogray, "zGy");
                Symbols.Add(AbsorbedDoseOfIonizingRadiationUnit.Yoctogray, "yGy");
                
                
                ConversionFunctions.Add(AbsorbedDoseOfIonizingRadiationUnit.Rad, "x / 100");
                ConversionFunctions.Add(AbsorbedDoseOfIonizingRadiationUnit.Yottagray, "x * 1e24");
                ConversionFunctions.Add(AbsorbedDoseOfIonizingRadiationUnit.Zettagray, "x * 1e21");
                ConversionFunctions.Add(AbsorbedDoseOfIonizingRadiationUnit.Exagray, "x * 1e18");
                ConversionFunctions.Add(AbsorbedDoseOfIonizingRadiationUnit.Petagray, "x * 1e15");
                ConversionFunctions.Add(AbsorbedDoseOfIonizingRadiationUnit.Teragray, "x * 1e12");
                ConversionFunctions.Add(AbsorbedDoseOfIonizingRadiationUnit.Gigagray, "x * 1e9");
                ConversionFunctions.Add(AbsorbedDoseOfIonizingRadiationUnit.Megagray, "x * 1e6");
                ConversionFunctions.Add(AbsorbedDoseOfIonizingRadiationUnit.Kilogray, "x * 1e3");
                ConversionFunctions.Add(AbsorbedDoseOfIonizingRadiationUnit.Hectogray, "x * 1e2");
                ConversionFunctions.Add(AbsorbedDoseOfIonizingRadiationUnit.Dekagray, "x * 1e1");
                ConversionFunctions.Add(AbsorbedDoseOfIonizingRadiationUnit.Gray, "x * 1e0");
                ConversionFunctions.Add(AbsorbedDoseOfIonizingRadiationUnit.Decigray, "x * 1e-1");
                ConversionFunctions.Add(AbsorbedDoseOfIonizingRadiationUnit.Centigray, "x * 1e-2");
                ConversionFunctions.Add(AbsorbedDoseOfIonizingRadiationUnit.Milligray, "x * 1e-3");
                ConversionFunctions.Add(AbsorbedDoseOfIonizingRadiationUnit.Microgray, "x * 1e-6");
                ConversionFunctions.Add(AbsorbedDoseOfIonizingRadiationUnit.Nanogray, "x * 1e-9");
                ConversionFunctions.Add(AbsorbedDoseOfIonizingRadiationUnit.Picogray, "x * 1e-12");
                ConversionFunctions.Add(AbsorbedDoseOfIonizingRadiationUnit.Femtogray, "x * 1e-15");
                ConversionFunctions.Add(AbsorbedDoseOfIonizingRadiationUnit.Attogray, "x * 1e-18");
                ConversionFunctions.Add(AbsorbedDoseOfIonizingRadiationUnit.Zeptogray, "x * 1e-21");
                ConversionFunctions.Add(AbsorbedDoseOfIonizingRadiationUnit.Yoctogray, "x * 1e-24");
            }
        }
    }
