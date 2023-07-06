
    // Auto-generated for VNet on 2023-07-05 10:24:46
    using System.Numerics;
    
    
    namespace VNet.Scientific.Measurement.Dimensions
    {
        public sealed class TemperatureChangeRate<TVal> : DimensionBase<TemperatureChangeRateUnit, TVal> where TVal : notnull, INumber<TVal>
        {
            public override string IdTag => nameof(TemperatureChangeRate<TVal>);
            
            public TemperatureChangeRate() : base()
            {
                DimensionComponent.Exponents.Length = 0;
                DimensionComponent.Exponents.Mass = 0;
                DimensionComponent.Exponents.Time = -1;
                DimensionComponent.Exponents.ElectricalCurrent = 0;
                DimensionComponent.Exponents.LuminousIntensity = 0;
                DimensionComponent.Exponents.Temperature = 1;
                DimensionComponent.Exponents.Amount = 0;
                
                DefaultUnit = TemperatureChangeRateUnit.DegreeCelsiusPerSecond;
                
                
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
