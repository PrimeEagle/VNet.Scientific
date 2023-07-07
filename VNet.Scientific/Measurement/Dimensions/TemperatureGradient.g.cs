
    // Auto-generated for VNet on 2023-07-06 12:42:23
    using System.Numerics;
    
    
    namespace VNet.Scientific.Measurement.Dimensions
    {
        public sealed class TemperatureGradient<TVal> : DimensionBase<TemperatureGradientUnit, TVal> where TVal : notnull, INumber<TVal>
        {
            public override string IdTag => nameof(TemperatureGradient<TVal>);
            
            public TemperatureGradient() : base()
            {
                Exponents.Length = -1;
                Exponents.Mass = 0;
                Exponents.Time = 0;
                Exponents.ElectricalCurrent = 0;
                Exponents.LuminousIntensity = 0;
                Exponents.Temperature = 1;
                Exponents.Amount = 0;
                
                DefaultUnit = TemperatureGradientUnit.KelvinPerMeter;
                
                Symbols.Add(TemperatureGradientUnit.KelvinPerMeter, "∆°K/m");
                Symbols.Add(TemperatureGradientUnit.DegreeCelsiusPerMeter, "∆°C/m");
                Symbols.Add(TemperatureGradientUnit.DegreeFahrenheitPerFoot, "∆°F/ft");
                Symbols.Add(TemperatureGradientUnit.DegreeCelsiusPerKilometer, "∆°C/km");
                
                
                ConversionFunctions.Add(TemperatureGradientUnit.KelvinPerMeter, "x");
                ConversionFunctions.Add(TemperatureGradientUnit.DegreeCelsiusPerMeter, "x");
                ConversionFunctions.Add(TemperatureGradientUnit.DegreeFahrenheitPerFoot, "(x / 0.3048) * 5 / 9");
                ConversionFunctions.Add(TemperatureGradientUnit.DegreeCelsiusPerKilometer, "x / 1e3");
            }
        }
    }
