
    // Auto-generated for VNet on 2023-07-05 10:35:43
    using System.Numerics;
    
    
    namespace VNet.Scientific.Measurement.Dimensions
    {
        public sealed class RotationalSpeed<TVal> : DimensionBase<RotationalSpeedUnit, TVal> where TVal : notnull, INumber<TVal>
        {
            public override string IdTag => nameof(RotationalSpeed<TVal>);
            
            public RotationalSpeed() : base()
            {
                DimensionComponent.Exponents.Length = 0;
                DimensionComponent.Exponents.Mass = 0;
                DimensionComponent.Exponents.Time = -1;
                DimensionComponent.Exponents.ElectricalCurrent = 0;
                DimensionComponent.Exponents.LuminousIntensity = 0;
                DimensionComponent.Exponents.Temperature = 0;
                DimensionComponent.Exponents.Amount = 0;
                
                DefaultUnit = RotationalSpeedUnit.RadianPerSecond;
                
                Symbols.Add(RotationalSpeedUnit.DegreePerSecond, "°/s");
                Symbols.Add(RotationalSpeedUnit.DegreePerMinute, "°/min");
                Symbols.Add(RotationalSpeedUnit.RevolutionPerSecond, "r/s");
                Symbols.Add(RotationalSpeedUnit.RevolutionPerMinute, "rpm");
                Symbols.Add(RotationalSpeedUnit.Yottaradianpersecond, "Yrad/s");
                Symbols.Add(RotationalSpeedUnit.Zettaradianpersecond, "Zrad/s");
                Symbols.Add(RotationalSpeedUnit.Exaradianpersecond, "Erad/s");
                Symbols.Add(RotationalSpeedUnit.Petaradianpersecond, "Prad/s");
                Symbols.Add(RotationalSpeedUnit.Teraradianpersecond, "Trad/s");
                Symbols.Add(RotationalSpeedUnit.Gigaradianpersecond, "Grad/s");
                Symbols.Add(RotationalSpeedUnit.Megaradianpersecond, "Mrad/s");
                Symbols.Add(RotationalSpeedUnit.Kiloradianpersecond, "krad/s");
                Symbols.Add(RotationalSpeedUnit.Hectoradianpersecond, "hrad/s");
                Symbols.Add(RotationalSpeedUnit.Dekaradianpersecond, "darad/s");
                Symbols.Add(RotationalSpeedUnit.RadianPerSecond, "rad/s");
                Symbols.Add(RotationalSpeedUnit.Deciradianpersecond, "drad/s");
                Symbols.Add(RotationalSpeedUnit.Centiradianpersecond, "crad/s");
                Symbols.Add(RotationalSpeedUnit.Milliradianpersecond, "mrad/s");
                Symbols.Add(RotationalSpeedUnit.Microradianpersecond, "µrad/s");
                Symbols.Add(RotationalSpeedUnit.Nanoradianpersecond, "nrad/s");
                Symbols.Add(RotationalSpeedUnit.Picoradianpersecond, "prad/s");
                Symbols.Add(RotationalSpeedUnit.Femtoradianpersecond, "frad/s");
                Symbols.Add(RotationalSpeedUnit.Attoradianpersecond, "arad/s");
                Symbols.Add(RotationalSpeedUnit.Zeptoradianpersecond, "zrad/s");
                Symbols.Add(RotationalSpeedUnit.Yoctoradianpersecond, "yrad/s");
                
                PluralSymbols.Add(RotationalSpeedUnit.DegreePerSecond, "deg/s");
                PluralSymbols.Add(RotationalSpeedUnit.DegreePerMinute, "deg/min");
                PluralSymbols.Add(RotationalSpeedUnit.RevolutionPerMinute, "r/min");
                
                ConversionFunctions.Add(RotationalSpeedUnit.DegreePerSecond, "(Math.PI / 180) * x");
                ConversionFunctions.Add(RotationalSpeedUnit.DegreePerMinute, "(Math.PI / (180 * 60)) * x");
                ConversionFunctions.Add(RotationalSpeedUnit.RevolutionPerSecond, "x * 6.2831853072");
                ConversionFunctions.Add(RotationalSpeedUnit.RevolutionPerMinute, "(x * 6.2831853072) / 60");
                ConversionFunctions.Add(RotationalSpeedUnit.Yottaradianpersecond, "x * 1e24");
                ConversionFunctions.Add(RotationalSpeedUnit.Zettaradianpersecond, "x * 1e21");
                ConversionFunctions.Add(RotationalSpeedUnit.Exaradianpersecond, "x * 1e18");
                ConversionFunctions.Add(RotationalSpeedUnit.Petaradianpersecond, "x * 1e15");
                ConversionFunctions.Add(RotationalSpeedUnit.Teraradianpersecond, "x * 1e12");
                ConversionFunctions.Add(RotationalSpeedUnit.Gigaradianpersecond, "x * 1e9");
                ConversionFunctions.Add(RotationalSpeedUnit.Megaradianpersecond, "x * 1e6");
                ConversionFunctions.Add(RotationalSpeedUnit.Kiloradianpersecond, "x * 1e3");
                ConversionFunctions.Add(RotationalSpeedUnit.Hectoradianpersecond, "x * 1e2");
                ConversionFunctions.Add(RotationalSpeedUnit.Dekaradianpersecond, "x * 1e1");
                ConversionFunctions.Add(RotationalSpeedUnit.RadianPerSecond, "x * 1e0");
                ConversionFunctions.Add(RotationalSpeedUnit.Deciradianpersecond, "x * 1e-1");
                ConversionFunctions.Add(RotationalSpeedUnit.Centiradianpersecond, "x * 1e-2");
                ConversionFunctions.Add(RotationalSpeedUnit.Milliradianpersecond, "x * 1e-3");
                ConversionFunctions.Add(RotationalSpeedUnit.Microradianpersecond, "x * 1e-6");
                ConversionFunctions.Add(RotationalSpeedUnit.Nanoradianpersecond, "x * 1e-9");
                ConversionFunctions.Add(RotationalSpeedUnit.Picoradianpersecond, "x * 1e-12");
                ConversionFunctions.Add(RotationalSpeedUnit.Femtoradianpersecond, "x * 1e-15");
                ConversionFunctions.Add(RotationalSpeedUnit.Attoradianpersecond, "x * 1e-18");
                ConversionFunctions.Add(RotationalSpeedUnit.Zeptoradianpersecond, "x * 1e-21");
                ConversionFunctions.Add(RotationalSpeedUnit.Yoctoradianpersecond, "x * 1e-24");
            }
        }
    }
