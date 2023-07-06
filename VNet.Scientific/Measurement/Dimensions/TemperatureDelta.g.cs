
    // Auto-generated for VNet on 2023-07-05 10:35:43
    using System.Numerics;
    
    
    namespace VNet.Scientific.Measurement.Dimensions
    {
        public sealed class TemperatureDelta<TVal> : DimensionBase<TemperatureDeltaUnit, TVal> where TVal : notnull, INumber<TVal>
        {
            public override string IdTag => nameof(TemperatureDelta<TVal>);
            
            public TemperatureDelta() : base()
            {
                DimensionComponent.Exponents.Length = 0;
                DimensionComponent.Exponents.Mass = 0;
                DimensionComponent.Exponents.Time = 0;
                DimensionComponent.Exponents.ElectricalCurrent = 0;
                DimensionComponent.Exponents.LuminousIntensity = 0;
                DimensionComponent.Exponents.Temperature = 1;
                DimensionComponent.Exponents.Amount = 0;
                
                DefaultUnit = TemperatureDeltaUnit.Kelvin;
                
                Symbols.Add(TemperatureDeltaUnit.Kelvin, "∆K");
                Symbols.Add(TemperatureDeltaUnit.DegreeCelsius, "∆°C");
                Symbols.Add(TemperatureDeltaUnit.DegreeDelisle, "∆°De");
                Symbols.Add(TemperatureDeltaUnit.DegreeFahrenheit, "∆°F");
                Symbols.Add(TemperatureDeltaUnit.DegreeNewton, "∆°N");
                Symbols.Add(TemperatureDeltaUnit.DegreeRankine, "∆°R");
                Symbols.Add(TemperatureDeltaUnit.DegreeReaumur, "∆°Ré");
                Symbols.Add(TemperatureDeltaUnit.DegreeRoemer, "∆°Rø");
                
                
                ConversionFunctions.Add(TemperatureDeltaUnit.Kelvin, "x");
                ConversionFunctions.Add(TemperatureDeltaUnit.DegreeCelsius, "x");
                ConversionFunctions.Add(TemperatureDeltaUnit.DegreeDelisle, "x * -2 / 3");
                ConversionFunctions.Add(TemperatureDeltaUnit.DegreeFahrenheit, "x * 5 / 9");
                ConversionFunctions.Add(TemperatureDeltaUnit.DegreeNewton, "x * 100 / 33");
                ConversionFunctions.Add(TemperatureDeltaUnit.DegreeRankine, "x * 5 / 9");
                ConversionFunctions.Add(TemperatureDeltaUnit.DegreeReaumur, "x * 5 / 4");
                ConversionFunctions.Add(TemperatureDeltaUnit.DegreeRoemer, "x * 40 / 21");
            }
        }
    }
