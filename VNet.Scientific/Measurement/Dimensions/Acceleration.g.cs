
    // Auto-generated for VNet on 2023-07-05 10:35:43
    using System.Numerics;
    
    
    namespace VNet.Scientific.Measurement.Dimensions
    {
        public sealed class Acceleration<TVal> : DimensionBase<AccelerationUnit, TVal> where TVal : notnull, INumber<TVal>
        {
            public override string IdTag => nameof(Acceleration<TVal>);
            
            public Acceleration() : base()
            {
                DimensionComponent.Exponents.Length = 1;
                DimensionComponent.Exponents.Mass = 0;
                DimensionComponent.Exponents.Time = -2;
                DimensionComponent.Exponents.ElectricalCurrent = 0;
                DimensionComponent.Exponents.LuminousIntensity = 0;
                DimensionComponent.Exponents.Temperature = 0;
                DimensionComponent.Exponents.Amount = 0;
                
                DefaultUnit = AccelerationUnit.MeterPerSecondSquared;
                
                Symbols.Add(AccelerationUnit.InchPerSecondSquared, "in/s²");
                Symbols.Add(AccelerationUnit.FootPerSecondSquared, "ft/s²");
                Symbols.Add(AccelerationUnit.KnotPerSecond, "kn/s");
                Symbols.Add(AccelerationUnit.KnotPerMinute, "kn/min");
                Symbols.Add(AccelerationUnit.KnotPerHour, "kn/h");
                Symbols.Add(AccelerationUnit.StandardGravity, "g");
                Symbols.Add(AccelerationUnit.Yottameterpersecondsquared, "Ym/s²");
                Symbols.Add(AccelerationUnit.Zettameterpersecondsquared, "Zm/s²");
                Symbols.Add(AccelerationUnit.Exameterpersecondsquared, "Em/s²");
                Symbols.Add(AccelerationUnit.Petameterpersecondsquared, "Pm/s²");
                Symbols.Add(AccelerationUnit.Terameterpersecondsquared, "Tm/s²");
                Symbols.Add(AccelerationUnit.Gigameterpersecondsquared, "Gm/s²");
                Symbols.Add(AccelerationUnit.Megameterpersecondsquared, "Mm/s²");
                Symbols.Add(AccelerationUnit.Kilometerpersecondsquared, "km/s²");
                Symbols.Add(AccelerationUnit.Hectometerpersecondsquared, "hm/s²");
                Symbols.Add(AccelerationUnit.Dekameterpersecondsquared, "dam/s²");
                Symbols.Add(AccelerationUnit.MeterPerSecondSquared, "m/s²");
                Symbols.Add(AccelerationUnit.Decimeterpersecondsquared, "dm/s²");
                Symbols.Add(AccelerationUnit.Centimeterpersecondsquared, "cm/s²");
                Symbols.Add(AccelerationUnit.Millimeterpersecondsquared, "mm/s²");
                Symbols.Add(AccelerationUnit.Micrometerpersecondsquared, "µm/s²");
                Symbols.Add(AccelerationUnit.Nanometerpersecondsquared, "nm/s²");
                Symbols.Add(AccelerationUnit.Picometerpersecondsquared, "pm/s²");
                Symbols.Add(AccelerationUnit.Femtometerpersecondsquared, "fm/s²");
                Symbols.Add(AccelerationUnit.Attometerpersecondsquared, "am/s²");
                Symbols.Add(AccelerationUnit.Zeptometerpersecondsquared, "zm/s²");
                Symbols.Add(AccelerationUnit.Yoctometerpersecondsquared, "ym/s²");
                
                
                ConversionFunctions.Add(AccelerationUnit.InchPerSecondSquared, "x * 0.0254");
                ConversionFunctions.Add(AccelerationUnit.FootPerSecondSquared, "x * 0.304800");
                ConversionFunctions.Add(AccelerationUnit.KnotPerSecond, "x * 0.5144444444444");
                ConversionFunctions.Add(AccelerationUnit.KnotPerMinute, "x * 0.5144444444444 / 60");
                ConversionFunctions.Add(AccelerationUnit.KnotPerHour, "x * 0.5144444444444 / 3600");
                ConversionFunctions.Add(AccelerationUnit.StandardGravity, "x * 9.80665");
                ConversionFunctions.Add(AccelerationUnit.Yottameterpersecondsquared, "x * 1e24");
                ConversionFunctions.Add(AccelerationUnit.Zettameterpersecondsquared, "x * 1e21");
                ConversionFunctions.Add(AccelerationUnit.Exameterpersecondsquared, "x * 1e18");
                ConversionFunctions.Add(AccelerationUnit.Petameterpersecondsquared, "x * 1e15");
                ConversionFunctions.Add(AccelerationUnit.Terameterpersecondsquared, "x * 1e12");
                ConversionFunctions.Add(AccelerationUnit.Gigameterpersecondsquared, "x * 1e9");
                ConversionFunctions.Add(AccelerationUnit.Megameterpersecondsquared, "x * 1e6");
                ConversionFunctions.Add(AccelerationUnit.Kilometerpersecondsquared, "x * 1e3");
                ConversionFunctions.Add(AccelerationUnit.Hectometerpersecondsquared, "x * 1e2");
                ConversionFunctions.Add(AccelerationUnit.Dekameterpersecondsquared, "x * 1e1");
                ConversionFunctions.Add(AccelerationUnit.MeterPerSecondSquared, "x * 1e0");
                ConversionFunctions.Add(AccelerationUnit.Decimeterpersecondsquared, "x * 1e-1");
                ConversionFunctions.Add(AccelerationUnit.Centimeterpersecondsquared, "x * 1e-2");
                ConversionFunctions.Add(AccelerationUnit.Millimeterpersecondsquared, "x * 1e-3");
                ConversionFunctions.Add(AccelerationUnit.Micrometerpersecondsquared, "x * 1e-6");
                ConversionFunctions.Add(AccelerationUnit.Nanometerpersecondsquared, "x * 1e-9");
                ConversionFunctions.Add(AccelerationUnit.Picometerpersecondsquared, "x * 1e-12");
                ConversionFunctions.Add(AccelerationUnit.Femtometerpersecondsquared, "x * 1e-15");
                ConversionFunctions.Add(AccelerationUnit.Attometerpersecondsquared, "x * 1e-18");
                ConversionFunctions.Add(AccelerationUnit.Zeptometerpersecondsquared, "x * 1e-21");
                ConversionFunctions.Add(AccelerationUnit.Yoctometerpersecondsquared, "x * 1e-24");
            }
        }
    }
