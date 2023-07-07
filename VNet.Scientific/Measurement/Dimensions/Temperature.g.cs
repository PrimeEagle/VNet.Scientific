
    // Auto-generated for VNet on 2023-07-06 12:42:23
    using System.Numerics;
    
    
    namespace VNet.Scientific.Measurement.Dimensions
    {
        public sealed class Temperature<TVal> : DimensionBase<TemperatureUnit, TVal> where TVal : notnull, INumber<TVal>
        {
            public override string IdTag => nameof(Temperature<TVal>);
            
            public Temperature() : base()
            {
                Exponents.Length = 0;
                Exponents.Mass = 0;
                Exponents.Time = 0;
                Exponents.ElectricalCurrent = 0;
                Exponents.LuminousIntensity = 0;
                Exponents.Temperature = 1;
                Exponents.Amount = 0;
                
                DefaultUnit = TemperatureUnit.Kelvin;
                
                Symbols.Add(TemperatureUnit.Kelvin, "K");
                Symbols.Add(TemperatureUnit.DegreeCelsius, "°C");
                Symbols.Add(TemperatureUnit.MillidegreeCelsius, "m°C");
                Symbols.Add(TemperatureUnit.DegreeDelisle, "°De");
                Symbols.Add(TemperatureUnit.DegreeFahrenheit, "°F");
                Symbols.Add(TemperatureUnit.DegreeNewton, "°N");
                Symbols.Add(TemperatureUnit.DegreeRankine, "°R");
                Symbols.Add(TemperatureUnit.DegreeReaumur, "°Ré");
                Symbols.Add(TemperatureUnit.DegreeRoemer, "°Rø");
                Symbols.Add(TemperatureUnit.SolarTemperature, "T⊙");
                
                
                ConversionFunctions.Add(TemperatureUnit.Kelvin, "x");
                ConversionFunctions.Add(TemperatureUnit.DegreeCelsius, "x + 273.15");
                ConversionFunctions.Add(TemperatureUnit.MillidegreeCelsius, "x / 1000 + 273.15");
                ConversionFunctions.Add(TemperatureUnit.DegreeDelisle, "x * -2 / 3 + 373.15");
                ConversionFunctions.Add(TemperatureUnit.DegreeFahrenheit, "x * 5 / 9 + 459.67 * 5 / 9");
                ConversionFunctions.Add(TemperatureUnit.DegreeNewton, "x * 100 / 33 + 273.15");
                ConversionFunctions.Add(TemperatureUnit.DegreeRankine, "x * 5 / 9");
                ConversionFunctions.Add(TemperatureUnit.DegreeReaumur, "x * 5 / 4 + 273.15");
                ConversionFunctions.Add(TemperatureUnit.DegreeRoemer, "x * 40 / 21 + 273.15 - 7.5 * 40d / 21");
                ConversionFunctions.Add(TemperatureUnit.SolarTemperature, "x * 5778");
            }
        }
    }
