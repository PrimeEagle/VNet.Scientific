
    // Auto-generated for VNet on 2023-07-06 12:42:23
    using System.Numerics;
    
    
    namespace VNet.Scientific.Measurement.Dimensions
    {
        public sealed class Force<TVal> : DimensionBase<ForceUnit, TVal> where TVal : notnull, INumber<TVal>
        {
            public override string IdTag => nameof(Force<TVal>);
            
            public Force() : base()
            {
                Exponents.Length = 1;
                Exponents.Mass = 1;
                Exponents.Time = -2;
                Exponents.ElectricalCurrent = 0;
                Exponents.LuminousIntensity = 0;
                Exponents.Temperature = 0;
                Exponents.Amount = 0;
                
                DefaultUnit = ForceUnit.Newton;
                
                Symbols.Add(ForceUnit.Dyn, "dyn");
                Symbols.Add(ForceUnit.KilogramForce, "kgf");
                Symbols.Add(ForceUnit.TonneForce, "tf");
                Symbols.Add(ForceUnit.KiloPond, "kp");
                Symbols.Add(ForceUnit.Poundal, "pdl");
                Symbols.Add(ForceUnit.PoundForce, "lbf");
                Symbols.Add(ForceUnit.OunceForce, "ozf");
                Symbols.Add(ForceUnit.ShortTonForce, "tf (short)");
                Symbols.Add(ForceUnit.Yottanewton, "YN");
                Symbols.Add(ForceUnit.Zettanewton, "ZN");
                Symbols.Add(ForceUnit.Exanewton, "EN");
                Symbols.Add(ForceUnit.Petanewton, "PN");
                Symbols.Add(ForceUnit.Teranewton, "TN");
                Symbols.Add(ForceUnit.Giganewton, "GN");
                Symbols.Add(ForceUnit.Meganewton, "MN");
                Symbols.Add(ForceUnit.Kilonewton, "kN");
                Symbols.Add(ForceUnit.Hectonewton, "hN");
                Symbols.Add(ForceUnit.Dekanewton, "daN");
                Symbols.Add(ForceUnit.Newton, "N");
                Symbols.Add(ForceUnit.Decinewton, "dN");
                Symbols.Add(ForceUnit.Centinewton, "cN");
                Symbols.Add(ForceUnit.Millinewton, "mN");
                Symbols.Add(ForceUnit.Micronewton, "µN");
                Symbols.Add(ForceUnit.Nanonewton, "nN");
                Symbols.Add(ForceUnit.Piconewton, "pN");
                Symbols.Add(ForceUnit.Femtonewton, "fN");
                Symbols.Add(ForceUnit.Attonewton, "aN");
                Symbols.Add(ForceUnit.Zeptonewton, "zN");
                Symbols.Add(ForceUnit.Yoctonewton, "yN");
                
                PluralSymbols.Add(ForceUnit.TonneForce, "Ton");
                PluralSymbols.Add(ForceUnit.ShortTonForce, "t (US)f");
                
                ConversionFunctions.Add(ForceUnit.Dyn, "x / 1e5");
                ConversionFunctions.Add(ForceUnit.KilogramForce, "x * 9.80665002864");
                ConversionFunctions.Add(ForceUnit.TonneForce, "x * 9.80665002864e3");
                ConversionFunctions.Add(ForceUnit.KiloPond, "x * 9.80665002864");
                ConversionFunctions.Add(ForceUnit.Poundal, "x * 0.13825502798973041652092282466083");
                ConversionFunctions.Add(ForceUnit.PoundForce, "x * 4.4482216152605095551842641431421");
                ConversionFunctions.Add(ForceUnit.OunceForce, "x * 2.780138509537812e-1");
                ConversionFunctions.Add(ForceUnit.ShortTonForce, "x * 8.896443230521e3");
                ConversionFunctions.Add(ForceUnit.Yottanewton, "x * 1e24");
                ConversionFunctions.Add(ForceUnit.Zettanewton, "x * 1e21");
                ConversionFunctions.Add(ForceUnit.Exanewton, "x * 1e18");
                ConversionFunctions.Add(ForceUnit.Petanewton, "x * 1e15");
                ConversionFunctions.Add(ForceUnit.Teranewton, "x * 1e12");
                ConversionFunctions.Add(ForceUnit.Giganewton, "x * 1e9");
                ConversionFunctions.Add(ForceUnit.Meganewton, "x * 1e6");
                ConversionFunctions.Add(ForceUnit.Kilonewton, "x * 1e3");
                ConversionFunctions.Add(ForceUnit.Hectonewton, "x * 1e2");
                ConversionFunctions.Add(ForceUnit.Dekanewton, "x * 1e1");
                ConversionFunctions.Add(ForceUnit.Newton, "x * 1e0");
                ConversionFunctions.Add(ForceUnit.Decinewton, "x * 1e-1");
                ConversionFunctions.Add(ForceUnit.Centinewton, "x * 1e-2");
                ConversionFunctions.Add(ForceUnit.Millinewton, "x * 1e-3");
                ConversionFunctions.Add(ForceUnit.Micronewton, "x * 1e-6");
                ConversionFunctions.Add(ForceUnit.Nanonewton, "x * 1e-9");
                ConversionFunctions.Add(ForceUnit.Piconewton, "x * 1e-12");
                ConversionFunctions.Add(ForceUnit.Femtonewton, "x * 1e-15");
                ConversionFunctions.Add(ForceUnit.Attonewton, "x * 1e-18");
                ConversionFunctions.Add(ForceUnit.Zeptonewton, "x * 1e-21");
                ConversionFunctions.Add(ForceUnit.Yoctonewton, "x * 1e-24");
            }
        }
    }
