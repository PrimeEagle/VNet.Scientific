
    // Auto-generated for VNet on 2023-07-05 10:24:46
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
