
    // Auto-generated for VNet on 2023-07-06 12:42:23
    using System.Numerics;
    
    
    namespace VNet.Scientific.Measurement.Dimensions
    {
        public sealed class TemperatureChangeRate<TVal> : DimensionBase<TemperatureChangeRateUnit, TVal> where TVal : notnull, INumber<TVal>
        {
            public override string IdTag => nameof(TemperatureChangeRate<TVal>);
            
            public TemperatureChangeRate() : base()
            {
                Exponents.Length = 0;
                Exponents.Mass = 0;
                Exponents.Time = -1;
                Exponents.ElectricalCurrent = 0;
                Exponents.LuminousIntensity = 0;
                Exponents.Temperature = 1;
                Exponents.Amount = 0;
                
                DefaultUnit = TemperatureChangeRateUnit.DegreeCelsiusPerSecond;
                
                Symbols.Add(TemperatureChangeRateUnit.DegreeCelsiusPerMinute, "°C/min");
                Symbols.Add(TemperatureChangeRateUnit.Yottadegreecelsiuspersecond, "Y°C/s");
                Symbols.Add(TemperatureChangeRateUnit.Zettadegreecelsiuspersecond, "Z°C/s");
                Symbols.Add(TemperatureChangeRateUnit.Exadegreecelsiuspersecond, "E°C/s");
                Symbols.Add(TemperatureChangeRateUnit.Petadegreecelsiuspersecond, "P°C/s");
                Symbols.Add(TemperatureChangeRateUnit.Teradegreecelsiuspersecond, "T°C/s");
                Symbols.Add(TemperatureChangeRateUnit.Gigadegreecelsiuspersecond, "G°C/s");
                Symbols.Add(TemperatureChangeRateUnit.Megadegreecelsiuspersecond, "M°C/s");
                Symbols.Add(TemperatureChangeRateUnit.Kilodegreecelsiuspersecond, "k°C/s");
                Symbols.Add(TemperatureChangeRateUnit.Hectodegreecelsiuspersecond, "h°C/s");
                Symbols.Add(TemperatureChangeRateUnit.Dekadegreecelsiuspersecond, "da°C/s");
                Symbols.Add(TemperatureChangeRateUnit.DegreeCelsiusPerSecond, "°C/s");
                Symbols.Add(TemperatureChangeRateUnit.Decidegreecelsiuspersecond, "d°C/s");
                Symbols.Add(TemperatureChangeRateUnit.Centidegreecelsiuspersecond, "c°C/s");
                Symbols.Add(TemperatureChangeRateUnit.Millidegreecelsiuspersecond, "m°C/s");
                Symbols.Add(TemperatureChangeRateUnit.Microdegreecelsiuspersecond, "µ°C/s");
                Symbols.Add(TemperatureChangeRateUnit.Nanodegreecelsiuspersecond, "n°C/s");
                Symbols.Add(TemperatureChangeRateUnit.Picodegreecelsiuspersecond, "p°C/s");
                Symbols.Add(TemperatureChangeRateUnit.Femtodegreecelsiuspersecond, "f°C/s");
                Symbols.Add(TemperatureChangeRateUnit.Attodegreecelsiuspersecond, "a°C/s");
                Symbols.Add(TemperatureChangeRateUnit.Zeptodegreecelsiuspersecond, "z°C/s");
                Symbols.Add(TemperatureChangeRateUnit.Yoctodegreecelsiuspersecond, "y°C/s");
                
                
                ConversionFunctions.Add(TemperatureChangeRateUnit.DegreeCelsiusPerMinute, "x / 60");
                ConversionFunctions.Add(TemperatureChangeRateUnit.Yottadegreecelsiuspersecond, "x * 1e24");
                ConversionFunctions.Add(TemperatureChangeRateUnit.Zettadegreecelsiuspersecond, "x * 1e21");
                ConversionFunctions.Add(TemperatureChangeRateUnit.Exadegreecelsiuspersecond, "x * 1e18");
                ConversionFunctions.Add(TemperatureChangeRateUnit.Petadegreecelsiuspersecond, "x * 1e15");
                ConversionFunctions.Add(TemperatureChangeRateUnit.Teradegreecelsiuspersecond, "x * 1e12");
                ConversionFunctions.Add(TemperatureChangeRateUnit.Gigadegreecelsiuspersecond, "x * 1e9");
                ConversionFunctions.Add(TemperatureChangeRateUnit.Megadegreecelsiuspersecond, "x * 1e6");
                ConversionFunctions.Add(TemperatureChangeRateUnit.Kilodegreecelsiuspersecond, "x * 1e3");
                ConversionFunctions.Add(TemperatureChangeRateUnit.Hectodegreecelsiuspersecond, "x * 1e2");
                ConversionFunctions.Add(TemperatureChangeRateUnit.Dekadegreecelsiuspersecond, "x * 1e1");
                ConversionFunctions.Add(TemperatureChangeRateUnit.DegreeCelsiusPerSecond, "x * 1e0");
                ConversionFunctions.Add(TemperatureChangeRateUnit.Decidegreecelsiuspersecond, "x * 1e-1");
                ConversionFunctions.Add(TemperatureChangeRateUnit.Centidegreecelsiuspersecond, "x * 1e-2");
                ConversionFunctions.Add(TemperatureChangeRateUnit.Millidegreecelsiuspersecond, "x * 1e-3");
                ConversionFunctions.Add(TemperatureChangeRateUnit.Microdegreecelsiuspersecond, "x * 1e-6");
                ConversionFunctions.Add(TemperatureChangeRateUnit.Nanodegreecelsiuspersecond, "x * 1e-9");
                ConversionFunctions.Add(TemperatureChangeRateUnit.Picodegreecelsiuspersecond, "x * 1e-12");
                ConversionFunctions.Add(TemperatureChangeRateUnit.Femtodegreecelsiuspersecond, "x * 1e-15");
                ConversionFunctions.Add(TemperatureChangeRateUnit.Attodegreecelsiuspersecond, "x * 1e-18");
                ConversionFunctions.Add(TemperatureChangeRateUnit.Zeptodegreecelsiuspersecond, "x * 1e-21");
                ConversionFunctions.Add(TemperatureChangeRateUnit.Yoctodegreecelsiuspersecond, "x * 1e-24");
            }
        }
    }
