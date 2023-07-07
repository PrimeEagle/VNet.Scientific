
    // Auto-generated for VNet on 2023-07-06 12:42:23
    using System.Numerics;
    
    
    namespace VNet.Scientific.Measurement.Dimensions
    {
        public sealed class ForceChangeRate<TVal> : DimensionBase<ForceChangeRateUnit, TVal> where TVal : notnull, INumber<TVal>
        {
            public override string IdTag => nameof(ForceChangeRate<TVal>);
            
            public ForceChangeRate() : base()
            {
                Exponents.Length = 1;
                Exponents.Mass = 1;
                Exponents.Time = -3;
                Exponents.ElectricalCurrent = 0;
                Exponents.LuminousIntensity = 0;
                Exponents.Temperature = 0;
                Exponents.Amount = 0;
                
                DefaultUnit = ForceChangeRateUnit.NewtonPerSecond;
                
                Symbols.Add(ForceChangeRateUnit.NewtonPerMinute, "N/min");
                Symbols.Add(ForceChangeRateUnit.PoundForcePerMinute, "lbf/min");
                Symbols.Add(ForceChangeRateUnit.PoundForcePerSecond, "lbf/s");
                Symbols.Add(ForceChangeRateUnit.Yottanewtonpersecond, "YN/s");
                Symbols.Add(ForceChangeRateUnit.Zettanewtonpersecond, "ZN/s");
                Symbols.Add(ForceChangeRateUnit.Exanewtonpersecond, "EN/s");
                Symbols.Add(ForceChangeRateUnit.Petanewtonpersecond, "PN/s");
                Symbols.Add(ForceChangeRateUnit.Teranewtonpersecond, "TN/s");
                Symbols.Add(ForceChangeRateUnit.Giganewtonpersecond, "GN/s");
                Symbols.Add(ForceChangeRateUnit.Meganewtonpersecond, "MN/s");
                Symbols.Add(ForceChangeRateUnit.Kilonewtonpersecond, "kN/s");
                Symbols.Add(ForceChangeRateUnit.Hectonewtonpersecond, "hN/s");
                Symbols.Add(ForceChangeRateUnit.Dekanewtonpersecond, "daN/s");
                Symbols.Add(ForceChangeRateUnit.NewtonPerSecond, "N/s");
                Symbols.Add(ForceChangeRateUnit.Decinewtonpersecond, "dN/s");
                Symbols.Add(ForceChangeRateUnit.Centinewtonpersecond, "cN/s");
                Symbols.Add(ForceChangeRateUnit.Millinewtonpersecond, "mN/s");
                Symbols.Add(ForceChangeRateUnit.Micronewtonpersecond, "µN/s");
                Symbols.Add(ForceChangeRateUnit.Nanonewtonpersecond, "nN/s");
                Symbols.Add(ForceChangeRateUnit.Piconewtonpersecond, "pN/s");
                Symbols.Add(ForceChangeRateUnit.Femtonewtonpersecond, "fN/s");
                Symbols.Add(ForceChangeRateUnit.Attonewtonpersecond, "aN/s");
                Symbols.Add(ForceChangeRateUnit.Zeptonewtonpersecond, "zN/s");
                Symbols.Add(ForceChangeRateUnit.Yoctonewtonpersecond, "yN/s");
                
                
                ConversionFunctions.Add(ForceChangeRateUnit.NewtonPerMinute, "x / 60");
                ConversionFunctions.Add(ForceChangeRateUnit.PoundForcePerMinute, "x * 4.4482216152605095551842641431421 / 60");
                ConversionFunctions.Add(ForceChangeRateUnit.PoundForcePerSecond, "x * 4.4482216152605095551842641431421");
                ConversionFunctions.Add(ForceChangeRateUnit.Yottanewtonpersecond, "x * 1e24");
                ConversionFunctions.Add(ForceChangeRateUnit.Zettanewtonpersecond, "x * 1e21");
                ConversionFunctions.Add(ForceChangeRateUnit.Exanewtonpersecond, "x * 1e18");
                ConversionFunctions.Add(ForceChangeRateUnit.Petanewtonpersecond, "x * 1e15");
                ConversionFunctions.Add(ForceChangeRateUnit.Teranewtonpersecond, "x * 1e12");
                ConversionFunctions.Add(ForceChangeRateUnit.Giganewtonpersecond, "x * 1e9");
                ConversionFunctions.Add(ForceChangeRateUnit.Meganewtonpersecond, "x * 1e6");
                ConversionFunctions.Add(ForceChangeRateUnit.Kilonewtonpersecond, "x * 1e3");
                ConversionFunctions.Add(ForceChangeRateUnit.Hectonewtonpersecond, "x * 1e2");
                ConversionFunctions.Add(ForceChangeRateUnit.Dekanewtonpersecond, "x * 1e1");
                ConversionFunctions.Add(ForceChangeRateUnit.NewtonPerSecond, "x * 1e0");
                ConversionFunctions.Add(ForceChangeRateUnit.Decinewtonpersecond, "x * 1e-1");
                ConversionFunctions.Add(ForceChangeRateUnit.Centinewtonpersecond, "x * 1e-2");
                ConversionFunctions.Add(ForceChangeRateUnit.Millinewtonpersecond, "x * 1e-3");
                ConversionFunctions.Add(ForceChangeRateUnit.Micronewtonpersecond, "x * 1e-6");
                ConversionFunctions.Add(ForceChangeRateUnit.Nanonewtonpersecond, "x * 1e-9");
                ConversionFunctions.Add(ForceChangeRateUnit.Piconewtonpersecond, "x * 1e-12");
                ConversionFunctions.Add(ForceChangeRateUnit.Femtonewtonpersecond, "x * 1e-15");
                ConversionFunctions.Add(ForceChangeRateUnit.Attonewtonpersecond, "x * 1e-18");
                ConversionFunctions.Add(ForceChangeRateUnit.Zeptonewtonpersecond, "x * 1e-21");
                ConversionFunctions.Add(ForceChangeRateUnit.Yoctonewtonpersecond, "x * 1e-24");
            }
        }
    }
