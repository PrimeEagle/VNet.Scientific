
    // Auto-generated for VNet on 2023-07-05 10:35:43
    using System.Numerics;
    
    
    namespace VNet.Scientific.Measurement.Dimensions
    {
        public sealed class TemperatureGradient<TVal> : DimensionBase<TemperatureGradientUnit, TVal> where TVal : notnull, INumber<TVal>
        {
            public override string IdTag => nameof(TemperatureGradient<TVal>);
            
            public TemperatureGradient() : base()
            {
                DimensionComponent.Exponents.Length = -1;
                DimensionComponent.Exponents.Mass = 0;
                DimensionComponent.Exponents.Time = 0;
                DimensionComponent.Exponents.ElectricalCurrent = 0;
                DimensionComponent.Exponents.LuminousIntensity = 0;
                DimensionComponent.Exponents.Temperature = 1;
                DimensionComponent.Exponents.Amount = 0;
                
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
