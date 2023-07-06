
    // Auto-generated for VNet on 2023-07-05 10:35:43
    using System.Numerics;
    
    
    namespace VNet.Scientific.Measurement.Dimensions
    {
        public sealed class ForcePerLength<TVal> : DimensionBase<ForcePerLengthUnit, TVal> where TVal : notnull, INumber<TVal>
        {
            public override string IdTag => nameof(ForcePerLength<TVal>);
            
            public ForcePerLength() : base()
            {
                DimensionComponent.Exponents.Length = 0;
                DimensionComponent.Exponents.Mass = 1;
                DimensionComponent.Exponents.Time = -2;
                DimensionComponent.Exponents.ElectricalCurrent = 0;
                DimensionComponent.Exponents.LuminousIntensity = 0;
                DimensionComponent.Exponents.Temperature = 0;
                DimensionComponent.Exponents.Amount = 0;
                
                DefaultUnit = ForcePerLengthUnit.NewtonPerMeter;
                
                Symbols.Add(ForcePerLengthUnit.NewtonPerCentimeter, "N/cm");
                Symbols.Add(ForcePerLengthUnit.NewtonPerMillimeter, "N/mm");
                Symbols.Add(ForcePerLengthUnit.KilogramForcePerMeter, "kgf/m");
                Symbols.Add(ForcePerLengthUnit.KilogramForcePerCentimeter, "kgf/cm");
                Symbols.Add(ForcePerLengthUnit.KilogramForcePerMillimeter, "kgf/mm");
                Symbols.Add(ForcePerLengthUnit.TonneForcePerMeter, "tf/m");
                Symbols.Add(ForcePerLengthUnit.TonneForcePerCentimeter, "tf/cm");
                Symbols.Add(ForcePerLengthUnit.TonneForcePerMillimeter, "tf/mm");
                Symbols.Add(ForcePerLengthUnit.PoundForcePerFoot, "lbf/ft");
                Symbols.Add(ForcePerLengthUnit.PoundForcePerInch, "lbf/in");
                Symbols.Add(ForcePerLengthUnit.PoundForcePerYard, "lbf/yd");
                Symbols.Add(ForcePerLengthUnit.KilopoundForcePerFoot, "kipf/ft");
                Symbols.Add(ForcePerLengthUnit.KilopoundForcePerInch, "kipf/in");
                Symbols.Add(ForcePerLengthUnit.Yottanewtonpermeter, "YN/m");
                Symbols.Add(ForcePerLengthUnit.Zettanewtonpermeter, "ZN/m");
                Symbols.Add(ForcePerLengthUnit.Exanewtonpermeter, "EN/m");
                Symbols.Add(ForcePerLengthUnit.Petanewtonpermeter, "PN/m");
                Symbols.Add(ForcePerLengthUnit.Teranewtonpermeter, "TN/m");
                Symbols.Add(ForcePerLengthUnit.Giganewtonpermeter, "GN/m");
                Symbols.Add(ForcePerLengthUnit.Meganewtonpermeter, "MN/m");
                Symbols.Add(ForcePerLengthUnit.Kilonewtonpermeter, "kN/m");
                Symbols.Add(ForcePerLengthUnit.Hectonewtonpermeter, "hN/m");
                Symbols.Add(ForcePerLengthUnit.Dekanewtonpermeter, "daN/m");
                Symbols.Add(ForcePerLengthUnit.NewtonPerMeter, "N/m");
                Symbols.Add(ForcePerLengthUnit.Decinewtonpermeter, "dN/m");
                Symbols.Add(ForcePerLengthUnit.Centinewtonpermeter, "cN/m");
                Symbols.Add(ForcePerLengthUnit.Millinewtonpermeter, "mN/m");
                Symbols.Add(ForcePerLengthUnit.Micronewtonpermeter, "µN/m");
                Symbols.Add(ForcePerLengthUnit.Nanonewtonpermeter, "nN/m");
                Symbols.Add(ForcePerLengthUnit.Piconewtonpermeter, "pN/m");
                Symbols.Add(ForcePerLengthUnit.Femtonewtonpermeter, "fN/m");
                Symbols.Add(ForcePerLengthUnit.Attonewtonpermeter, "aN/m");
                Symbols.Add(ForcePerLengthUnit.Zeptonewtonpermeter, "zN/m");
                Symbols.Add(ForcePerLengthUnit.Yoctonewtonpermeter, "yN/m");
                
                PluralSymbols.Add(ForcePerLengthUnit.KilopoundForcePerFoot, "kip/ft");
                PluralSymbols.Add(ForcePerLengthUnit.KilopoundForcePerInch, "kip/in");
                
                ConversionFunctions.Add(ForcePerLengthUnit.NewtonPerCentimeter, "x * 1e2");
                ConversionFunctions.Add(ForcePerLengthUnit.NewtonPerMillimeter, "x * 1e3");
                ConversionFunctions.Add(ForcePerLengthUnit.KilogramForcePerMeter, "x * 9.80665002864");
                ConversionFunctions.Add(ForcePerLengthUnit.KilogramForcePerCentimeter, "x * 980.665002864");
                ConversionFunctions.Add(ForcePerLengthUnit.KilogramForcePerMillimeter, "x * 9.80665002864e3");
                ConversionFunctions.Add(ForcePerLengthUnit.TonneForcePerMeter, "x * 9.80665002864e3");
                ConversionFunctions.Add(ForcePerLengthUnit.TonneForcePerCentimeter, "x * 9.80665002864e5");
                ConversionFunctions.Add(ForcePerLengthUnit.TonneForcePerMillimeter, "x * 9.80665002864e6");
                ConversionFunctions.Add(ForcePerLengthUnit.PoundForcePerFoot, "x * 14.59390292");
                ConversionFunctions.Add(ForcePerLengthUnit.PoundForcePerInch, "x * 1.75126835e2");
                ConversionFunctions.Add(ForcePerLengthUnit.PoundForcePerYard, "x * 4.864634307");
                ConversionFunctions.Add(ForcePerLengthUnit.KilopoundForcePerFoot, "x * 14593.90292");
                ConversionFunctions.Add(ForcePerLengthUnit.KilopoundForcePerInch, "x * 1.75126835e5");
                ConversionFunctions.Add(ForcePerLengthUnit.Yottanewtonpermeter, "x * 1e24");
                ConversionFunctions.Add(ForcePerLengthUnit.Zettanewtonpermeter, "x * 1e21");
                ConversionFunctions.Add(ForcePerLengthUnit.Exanewtonpermeter, "x * 1e18");
                ConversionFunctions.Add(ForcePerLengthUnit.Petanewtonpermeter, "x * 1e15");
                ConversionFunctions.Add(ForcePerLengthUnit.Teranewtonpermeter, "x * 1e12");
                ConversionFunctions.Add(ForcePerLengthUnit.Giganewtonpermeter, "x * 1e9");
                ConversionFunctions.Add(ForcePerLengthUnit.Meganewtonpermeter, "x * 1e6");
                ConversionFunctions.Add(ForcePerLengthUnit.Kilonewtonpermeter, "x * 1e3");
                ConversionFunctions.Add(ForcePerLengthUnit.Hectonewtonpermeter, "x * 1e2");
                ConversionFunctions.Add(ForcePerLengthUnit.Dekanewtonpermeter, "x * 1e1");
                ConversionFunctions.Add(ForcePerLengthUnit.NewtonPerMeter, "x * 1e0");
                ConversionFunctions.Add(ForcePerLengthUnit.Decinewtonpermeter, "x * 1e-1");
                ConversionFunctions.Add(ForcePerLengthUnit.Centinewtonpermeter, "x * 1e-2");
                ConversionFunctions.Add(ForcePerLengthUnit.Millinewtonpermeter, "x * 1e-3");
                ConversionFunctions.Add(ForcePerLengthUnit.Micronewtonpermeter, "x * 1e-6");
                ConversionFunctions.Add(ForcePerLengthUnit.Nanonewtonpermeter, "x * 1e-9");
                ConversionFunctions.Add(ForcePerLengthUnit.Piconewtonpermeter, "x * 1e-12");
                ConversionFunctions.Add(ForcePerLengthUnit.Femtonewtonpermeter, "x * 1e-15");
                ConversionFunctions.Add(ForcePerLengthUnit.Attonewtonpermeter, "x * 1e-18");
                ConversionFunctions.Add(ForcePerLengthUnit.Zeptonewtonpermeter, "x * 1e-21");
                ConversionFunctions.Add(ForcePerLengthUnit.Yoctonewtonpermeter, "x * 1e-24");
            }
        }
    }
