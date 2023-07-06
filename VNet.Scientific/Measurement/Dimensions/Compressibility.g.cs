
    // Auto-generated for VNet on 2023-07-05 10:35:43
    using System.Numerics;
    
    
    namespace VNet.Scientific.Measurement.Dimensions
    {
        public sealed class Compressibility<TVal> : DimensionBase<CompressibilityUnit, TVal> where TVal : notnull, INumber<TVal>
        {
            public override string IdTag => nameof(Compressibility<TVal>);
            
            public Compressibility() : base()
            {
                DimensionComponent.Exponents.Length = 1;
                DimensionComponent.Exponents.Mass = -1;
                DimensionComponent.Exponents.Time = 2;
                DimensionComponent.Exponents.ElectricalCurrent = 0;
                DimensionComponent.Exponents.LuminousIntensity = 0;
                DimensionComponent.Exponents.Temperature = 0;
                DimensionComponent.Exponents.Amount = 0;
                
                DefaultUnit = CompressibilityUnit.InversePascal;
                
                Symbols.Add(CompressibilityUnit.InverseAtmosphere, "atm⁻¹");
                Symbols.Add(CompressibilityUnit.InverseMillibar, "mbar⁻¹");
                Symbols.Add(CompressibilityUnit.InverseBar, "bar⁻¹");
                Symbols.Add(CompressibilityUnit.InversePoundForcePerSquareInch, "psi⁻¹");
                Symbols.Add(CompressibilityUnit.InverseYottapascal, "YPa⁻¹");
                Symbols.Add(CompressibilityUnit.InverseZettapascal, "ZPa⁻¹");
                Symbols.Add(CompressibilityUnit.InverseExapascal, "EPa⁻¹");
                Symbols.Add(CompressibilityUnit.InversePetapascal, "PPa⁻¹");
                Symbols.Add(CompressibilityUnit.InverseTerapascal, "TPa⁻¹");
                Symbols.Add(CompressibilityUnit.InverseGigapascal, "GPa⁻¹");
                Symbols.Add(CompressibilityUnit.InverseMegapascal, "MPa⁻¹");
                Symbols.Add(CompressibilityUnit.InverseKilopascal, "kPa⁻¹");
                Symbols.Add(CompressibilityUnit.InverseHectopascal, "hPa⁻¹");
                Symbols.Add(CompressibilityUnit.InverseDekapascal, "daPa⁻¹");
                Symbols.Add(CompressibilityUnit.InversePascal, "Pa⁻¹");
                Symbols.Add(CompressibilityUnit.InverseDecipascal, "dPa⁻¹");
                Symbols.Add(CompressibilityUnit.InverseCentipascal, "cPa⁻¹");
                Symbols.Add(CompressibilityUnit.InverseMillipascal, "mPa⁻¹");
                Symbols.Add(CompressibilityUnit.InverseMicropascal, "µPa⁻¹");
                Symbols.Add(CompressibilityUnit.InverseNanopascal, "nPa⁻¹");
                Symbols.Add(CompressibilityUnit.InversePicopascal, "pPa⁻¹");
                Symbols.Add(CompressibilityUnit.InverseFemtopascal, "fPa⁻¹");
                Symbols.Add(CompressibilityUnit.InverseAttopascal, "aPa⁻¹");
                Symbols.Add(CompressibilityUnit.InverseZeptopascal, "zPa⁻¹");
                Symbols.Add(CompressibilityUnit.InverseYoctopascal, "yPa⁻¹");
                
                PluralSymbols.Add(CompressibilityUnit.InverseAtmosphere, "1/atm");
                PluralSymbols.Add(CompressibilityUnit.InverseMillibar, "1/mbar");
                PluralSymbols.Add(CompressibilityUnit.InverseBar, "1/bar");
                PluralSymbols.Add(CompressibilityUnit.InversePoundForcePerSquareInch, "1/psi");
                PluralSymbols.Add(CompressibilityUnit.InverseYottapascal, "Y1/Pa");
                PluralSymbols.Add(CompressibilityUnit.InverseZettapascal, "Z1/Pa");
                PluralSymbols.Add(CompressibilityUnit.InverseExapascal, "E1/Pa");
                PluralSymbols.Add(CompressibilityUnit.InversePetapascal, "P1/Pa");
                PluralSymbols.Add(CompressibilityUnit.InverseTerapascal, "T1/Pa");
                PluralSymbols.Add(CompressibilityUnit.InverseGigapascal, "G1/Pa");
                PluralSymbols.Add(CompressibilityUnit.InverseMegapascal, "M1/Pa");
                PluralSymbols.Add(CompressibilityUnit.InverseKilopascal, "k1/Pa");
                PluralSymbols.Add(CompressibilityUnit.InverseHectopascal, "h1/Pa");
                PluralSymbols.Add(CompressibilityUnit.InverseDekapascal, "da1/Pa");
                PluralSymbols.Add(CompressibilityUnit.InversePascal, "1/Pa");
                PluralSymbols.Add(CompressibilityUnit.InverseDecipascal, "d1/Pa");
                PluralSymbols.Add(CompressibilityUnit.InverseCentipascal, "c1/Pa");
                PluralSymbols.Add(CompressibilityUnit.InverseMillipascal, "m1/Pa");
                PluralSymbols.Add(CompressibilityUnit.InverseMicropascal, "µ1/Pa");
                PluralSymbols.Add(CompressibilityUnit.InverseNanopascal, "n1/Pa");
                PluralSymbols.Add(CompressibilityUnit.InversePicopascal, "p1/Pa");
                PluralSymbols.Add(CompressibilityUnit.InverseFemtopascal, "f1/Pa");
                PluralSymbols.Add(CompressibilityUnit.InverseAttopascal, "a1/Pa");
                PluralSymbols.Add(CompressibilityUnit.InverseZeptopascal, "z1/Pa");
                PluralSymbols.Add(CompressibilityUnit.InverseYoctopascal, "y1/Pa");
                
                ConversionFunctions.Add(CompressibilityUnit.InverseAtmosphere, "x * 101325");
                ConversionFunctions.Add(CompressibilityUnit.InverseMillibar, "x * 100");
                ConversionFunctions.Add(CompressibilityUnit.InverseBar, "x * 1e5");
                ConversionFunctions.Add(CompressibilityUnit.InversePoundForcePerSquareInch, "x * 6.894757293168361e3");
                ConversionFunctions.Add(CompressibilityUnit.InverseYottapascal, "x / 1e24");
                ConversionFunctions.Add(CompressibilityUnit.InverseZettapascal, "x / 1e21");
                ConversionFunctions.Add(CompressibilityUnit.InverseExapascal, "x / 1e18");
                ConversionFunctions.Add(CompressibilityUnit.InversePetapascal, "x / 1e15");
                ConversionFunctions.Add(CompressibilityUnit.InverseTerapascal, "x / 1e12");
                ConversionFunctions.Add(CompressibilityUnit.InverseGigapascal, "x / 1e9");
                ConversionFunctions.Add(CompressibilityUnit.InverseMegapascal, "x / 1e6");
                ConversionFunctions.Add(CompressibilityUnit.InverseKilopascal, "x / 1e3");
                ConversionFunctions.Add(CompressibilityUnit.InverseHectopascal, "x / 1e2");
                ConversionFunctions.Add(CompressibilityUnit.InverseDekapascal, "x / 1e1");
                ConversionFunctions.Add(CompressibilityUnit.InversePascal, "x / 1e0");
                ConversionFunctions.Add(CompressibilityUnit.InverseDecipascal, "x / 1e-1");
                ConversionFunctions.Add(CompressibilityUnit.InverseCentipascal, "x / 1e-2");
                ConversionFunctions.Add(CompressibilityUnit.InverseMillipascal, "x / 1e-3");
                ConversionFunctions.Add(CompressibilityUnit.InverseMicropascal, "x / 1e-6");
                ConversionFunctions.Add(CompressibilityUnit.InverseNanopascal, "x / 1e-9");
                ConversionFunctions.Add(CompressibilityUnit.InversePicopascal, "x / 1e-12");
                ConversionFunctions.Add(CompressibilityUnit.InverseFemtopascal, "x / 1e-15");
                ConversionFunctions.Add(CompressibilityUnit.InverseAttopascal, "x / 1e-18");
                ConversionFunctions.Add(CompressibilityUnit.InverseZeptopascal, "x / 1e-21");
                ConversionFunctions.Add(CompressibilityUnit.InverseYoctopascal, "x / 1e-24");
            }
        }
    }
