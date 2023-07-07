
    // Auto-generated for VNet on 2023-07-06 12:42:23
    using System.Numerics;
    
    
    namespace VNet.Scientific.Measurement.Dimensions
    {
        public sealed class SpecificWeight<TVal> : DimensionBase<SpecificWeightUnit, TVal> where TVal : notnull, INumber<TVal>
        {
            public override string IdTag => nameof(SpecificWeight<TVal>);
            
            public SpecificWeight() : base()
            {
                Exponents.Length = -2;
                Exponents.Mass = 1;
                Exponents.Time = -2;
                Exponents.ElectricalCurrent = 0;
                Exponents.LuminousIntensity = 0;
                Exponents.Temperature = 0;
                Exponents.Amount = 0;
                
                DefaultUnit = SpecificWeightUnit.NewtonPerCubicMeter;
                
                Symbols.Add(SpecificWeightUnit.NewtonPerCubicMillimeter, "N/mm³");
                Symbols.Add(SpecificWeightUnit.NewtonPerCubicCentimeter, "N/cm³");
                Symbols.Add(SpecificWeightUnit.KilogramForcePerCubicMillimeter, "kgf/mm³");
                Symbols.Add(SpecificWeightUnit.KilogramForcePerCubicCentimeter, "kgf/cm³");
                Symbols.Add(SpecificWeightUnit.KilogramForcePerCubicMeter, "kgf/m³");
                Symbols.Add(SpecificWeightUnit.PoundForcePerCubicInch, "lbf/in³");
                Symbols.Add(SpecificWeightUnit.PoundForcePerCubicFoot, "lbf/ft³");
                Symbols.Add(SpecificWeightUnit.TonneForcePerCubicMillimeter, "tf/mm³");
                Symbols.Add(SpecificWeightUnit.TonneForcePerCubicCentimeter, "tf/cm³");
                Symbols.Add(SpecificWeightUnit.TonneForcePerCubicMeter, "tf/m³");
                Symbols.Add(SpecificWeightUnit.Yottanewtonpercubicmeter, "YN/m³");
                Symbols.Add(SpecificWeightUnit.Zettanewtonpercubicmeter, "ZN/m³");
                Symbols.Add(SpecificWeightUnit.Exanewtonpercubicmeter, "EN/m³");
                Symbols.Add(SpecificWeightUnit.Petanewtonpercubicmeter, "PN/m³");
                Symbols.Add(SpecificWeightUnit.Teranewtonpercubicmeter, "TN/m³");
                Symbols.Add(SpecificWeightUnit.Giganewtonpercubicmeter, "GN/m³");
                Symbols.Add(SpecificWeightUnit.Meganewtonpercubicmeter, "MN/m³");
                Symbols.Add(SpecificWeightUnit.Kilonewtonpercubicmeter, "kN/m³");
                Symbols.Add(SpecificWeightUnit.Hectonewtonpercubicmeter, "hN/m³");
                Symbols.Add(SpecificWeightUnit.Dekanewtonpercubicmeter, "daN/m³");
                Symbols.Add(SpecificWeightUnit.NewtonPerCubicMeter, "N/m³");
                Symbols.Add(SpecificWeightUnit.Decinewtonpercubicmeter, "dN/m³");
                Symbols.Add(SpecificWeightUnit.Centinewtonpercubicmeter, "cN/m³");
                Symbols.Add(SpecificWeightUnit.Millinewtonpercubicmeter, "mN/m³");
                Symbols.Add(SpecificWeightUnit.Micronewtonpercubicmeter, "µN/m³");
                Symbols.Add(SpecificWeightUnit.Nanonewtonpercubicmeter, "nN/m³");
                Symbols.Add(SpecificWeightUnit.Piconewtonpercubicmeter, "pN/m³");
                Symbols.Add(SpecificWeightUnit.Femtonewtonpercubicmeter, "fN/m³");
                Symbols.Add(SpecificWeightUnit.Attonewtonpercubicmeter, "aN/m³");
                Symbols.Add(SpecificWeightUnit.Zeptonewtonpercubicmeter, "zN/m³");
                Symbols.Add(SpecificWeightUnit.Yoctonewtonpercubicmeter, "yN/m³");
                
                
                ConversionFunctions.Add(SpecificWeightUnit.NewtonPerCubicMillimeter, "x * 1000000000");
                ConversionFunctions.Add(SpecificWeightUnit.NewtonPerCubicCentimeter, "x * 1000000");
                ConversionFunctions.Add(SpecificWeightUnit.KilogramForcePerCubicMillimeter, "x * 9.80665e9");
                ConversionFunctions.Add(SpecificWeightUnit.KilogramForcePerCubicCentimeter, "x * 9.80665e6");
                ConversionFunctions.Add(SpecificWeightUnit.KilogramForcePerCubicMeter, "x * 9.80665");
                ConversionFunctions.Add(SpecificWeightUnit.PoundForcePerCubicInch, "x * 2.714471375263134e5");
                ConversionFunctions.Add(SpecificWeightUnit.PoundForcePerCubicFoot, "x * 1.570874638462462e2");
                ConversionFunctions.Add(SpecificWeightUnit.TonneForcePerCubicMillimeter, "x * 9.80665e12");
                ConversionFunctions.Add(SpecificWeightUnit.TonneForcePerCubicCentimeter, "x * 9.80665e9");
                ConversionFunctions.Add(SpecificWeightUnit.TonneForcePerCubicMeter, "x * 9.80665e3");
                ConversionFunctions.Add(SpecificWeightUnit.Yottanewtonpercubicmeter, "x * 1e24");
                ConversionFunctions.Add(SpecificWeightUnit.Zettanewtonpercubicmeter, "x * 1e21");
                ConversionFunctions.Add(SpecificWeightUnit.Exanewtonpercubicmeter, "x * 1e18");
                ConversionFunctions.Add(SpecificWeightUnit.Petanewtonpercubicmeter, "x * 1e15");
                ConversionFunctions.Add(SpecificWeightUnit.Teranewtonpercubicmeter, "x * 1e12");
                ConversionFunctions.Add(SpecificWeightUnit.Giganewtonpercubicmeter, "x * 1e9");
                ConversionFunctions.Add(SpecificWeightUnit.Meganewtonpercubicmeter, "x * 1e6");
                ConversionFunctions.Add(SpecificWeightUnit.Kilonewtonpercubicmeter, "x * 1e3");
                ConversionFunctions.Add(SpecificWeightUnit.Hectonewtonpercubicmeter, "x * 1e2");
                ConversionFunctions.Add(SpecificWeightUnit.Dekanewtonpercubicmeter, "x * 1e1");
                ConversionFunctions.Add(SpecificWeightUnit.NewtonPerCubicMeter, "x * 1e0");
                ConversionFunctions.Add(SpecificWeightUnit.Decinewtonpercubicmeter, "x * 1e-1");
                ConversionFunctions.Add(SpecificWeightUnit.Centinewtonpercubicmeter, "x * 1e-2");
                ConversionFunctions.Add(SpecificWeightUnit.Millinewtonpercubicmeter, "x * 1e-3");
                ConversionFunctions.Add(SpecificWeightUnit.Micronewtonpercubicmeter, "x * 1e-6");
                ConversionFunctions.Add(SpecificWeightUnit.Nanonewtonpercubicmeter, "x * 1e-9");
                ConversionFunctions.Add(SpecificWeightUnit.Piconewtonpercubicmeter, "x * 1e-12");
                ConversionFunctions.Add(SpecificWeightUnit.Femtonewtonpercubicmeter, "x * 1e-15");
                ConversionFunctions.Add(SpecificWeightUnit.Attonewtonpercubicmeter, "x * 1e-18");
                ConversionFunctions.Add(SpecificWeightUnit.Zeptonewtonpercubicmeter, "x * 1e-21");
                ConversionFunctions.Add(SpecificWeightUnit.Yoctonewtonpercubicmeter, "x * 1e-24");
            }
        }
    }
