
    // Auto-generated for VNet on 2023-07-05 10:35:43
    using System.Numerics;
    
    
    namespace VNet.Scientific.Measurement.Dimensions
    {
        public sealed class Velocity<TVal> : DimensionBase<VelocityUnit, TVal> where TVal : notnull, INumber<TVal>
        {
            public override string IdTag => nameof(Velocity<TVal>);
            
            public Velocity() : base()
            {
                DimensionComponent.Exponents.Length = 1;
                DimensionComponent.Exponents.Mass = 0;
                DimensionComponent.Exponents.Time = -1;
                DimensionComponent.Exponents.ElectricalCurrent = 0;
                DimensionComponent.Exponents.LuminousIntensity = 0;
                DimensionComponent.Exponents.Temperature = 0;
                DimensionComponent.Exponents.Amount = 0;
                
                DefaultUnit = VelocityUnit.MeterPerSecond;
                
                Symbols.Add(VelocityUnit.MeterPerMinute, "m/min");
                Symbols.Add(VelocityUnit.MeterPerHour, "m/h");
                Symbols.Add(VelocityUnit.FootPerSecond, "ft/s");
                Symbols.Add(VelocityUnit.FootPerMinute, "ft/min");
                Symbols.Add(VelocityUnit.FootPerHour, "ft/h");
                Symbols.Add(VelocityUnit.UsSurveyFootPerSecond, "ftUS/s");
                Symbols.Add(VelocityUnit.UsSurveyFootPerMinute, "ftUS/min");
                Symbols.Add(VelocityUnit.UsSurveyFootPerHour, "ftUS/h");
                Symbols.Add(VelocityUnit.InchPerSecond, "in/s");
                Symbols.Add(VelocityUnit.InchPerMinute, "in/min");
                Symbols.Add(VelocityUnit.InchPerHour, "in/h");
                Symbols.Add(VelocityUnit.YardPerSecond, "yd/s");
                Symbols.Add(VelocityUnit.YardPerMinute, "yd/min");
                Symbols.Add(VelocityUnit.YardPerHour, "yd/h");
                Symbols.Add(VelocityUnit.Knot, "kn");
                Symbols.Add(VelocityUnit.MilePerHour, "mph");
                Symbols.Add(VelocityUnit.Mach, "M");
                Symbols.Add(VelocityUnit.Yottameterpersecond, "Ym/s");
                Symbols.Add(VelocityUnit.Zettameterpersecond, "Zm/s");
                Symbols.Add(VelocityUnit.Exameterpersecond, "Em/s");
                Symbols.Add(VelocityUnit.Petameterpersecond, "Pm/s");
                Symbols.Add(VelocityUnit.Terameterpersecond, "Tm/s");
                Symbols.Add(VelocityUnit.Gigameterpersecond, "Gm/s");
                Symbols.Add(VelocityUnit.Megameterpersecond, "Mm/s");
                Symbols.Add(VelocityUnit.Kilometerpersecond, "km/s");
                Symbols.Add(VelocityUnit.Hectometerpersecond, "hm/s");
                Symbols.Add(VelocityUnit.Dekameterpersecond, "dam/s");
                Symbols.Add(VelocityUnit.MeterPerSecond, "m/s");
                Symbols.Add(VelocityUnit.Decimeterpersecond, "dm/s");
                Symbols.Add(VelocityUnit.Centimeterpersecond, "cm/s");
                Symbols.Add(VelocityUnit.Millimeterpersecond, "mm/s");
                Symbols.Add(VelocityUnit.Micrometerpersecond, "µm/s");
                Symbols.Add(VelocityUnit.Nanometerpersecond, "nm/s");
                Symbols.Add(VelocityUnit.Picometerpersecond, "pm/s");
                Symbols.Add(VelocityUnit.Femtometerpersecond, "fm/s");
                Symbols.Add(VelocityUnit.Attometerpersecond, "am/s");
                Symbols.Add(VelocityUnit.Zeptometerpersecond, "zm/s");
                Symbols.Add(VelocityUnit.Yoctometerpersecond, "ym/s");
                
                PluralSymbols.Add(VelocityUnit.Knot, "kt");
                PluralSymbols.Add(VelocityUnit.Mach, "Ma");
                
                ConversionFunctions.Add(VelocityUnit.MeterPerMinute, "x / 60");
                ConversionFunctions.Add(VelocityUnit.MeterPerHour, "x / 3600");
                ConversionFunctions.Add(VelocityUnit.FootPerSecond, "x * 0.3048");
                ConversionFunctions.Add(VelocityUnit.FootPerMinute, "x * 0.3048 / 60");
                ConversionFunctions.Add(VelocityUnit.FootPerHour, "x * 0.3048 / 3600");
                ConversionFunctions.Add(VelocityUnit.UsSurveyFootPerSecond, "x * 1200 / 3937");
                ConversionFunctions.Add(VelocityUnit.UsSurveyFootPerMinute, "(x * 1200 / 3937) / 60");
                ConversionFunctions.Add(VelocityUnit.UsSurveyFootPerHour, "(x * 1200 / 3937) / 3600");
                ConversionFunctions.Add(VelocityUnit.InchPerSecond, "x * 2.54e-2");
                ConversionFunctions.Add(VelocityUnit.InchPerMinute, "(x / 60) * 2.54e-2");
                ConversionFunctions.Add(VelocityUnit.InchPerHour, "(x / 3600) * 2.54e-2");
                ConversionFunctions.Add(VelocityUnit.YardPerSecond, "x * 0.9144");
                ConversionFunctions.Add(VelocityUnit.YardPerMinute, "x * 0.9144 / 60");
                ConversionFunctions.Add(VelocityUnit.YardPerHour, "x * 0.9144 / 3600");
                ConversionFunctions.Add(VelocityUnit.Knot, "x * (1852.0 / 3600.0)");
                ConversionFunctions.Add(VelocityUnit.MilePerHour, "x * 0.44704");
                ConversionFunctions.Add(VelocityUnit.Mach, "x * 340.29");
                ConversionFunctions.Add(VelocityUnit.Yottameterpersecond, "x * 1e24");
                ConversionFunctions.Add(VelocityUnit.Zettameterpersecond, "x * 1e21");
                ConversionFunctions.Add(VelocityUnit.Exameterpersecond, "x * 1e18");
                ConversionFunctions.Add(VelocityUnit.Petameterpersecond, "x * 1e15");
                ConversionFunctions.Add(VelocityUnit.Terameterpersecond, "x * 1e12");
                ConversionFunctions.Add(VelocityUnit.Gigameterpersecond, "x * 1e9");
                ConversionFunctions.Add(VelocityUnit.Megameterpersecond, "x * 1e6");
                ConversionFunctions.Add(VelocityUnit.Kilometerpersecond, "x * 1e3");
                ConversionFunctions.Add(VelocityUnit.Hectometerpersecond, "x * 1e2");
                ConversionFunctions.Add(VelocityUnit.Dekameterpersecond, "x * 1e1");
                ConversionFunctions.Add(VelocityUnit.MeterPerSecond, "x * 1e0");
                ConversionFunctions.Add(VelocityUnit.Decimeterpersecond, "x * 1e-1");
                ConversionFunctions.Add(VelocityUnit.Centimeterpersecond, "x * 1e-2");
                ConversionFunctions.Add(VelocityUnit.Millimeterpersecond, "x * 1e-3");
                ConversionFunctions.Add(VelocityUnit.Micrometerpersecond, "x * 1e-6");
                ConversionFunctions.Add(VelocityUnit.Nanometerpersecond, "x * 1e-9");
                ConversionFunctions.Add(VelocityUnit.Picometerpersecond, "x * 1e-12");
                ConversionFunctions.Add(VelocityUnit.Femtometerpersecond, "x * 1e-15");
                ConversionFunctions.Add(VelocityUnit.Attometerpersecond, "x * 1e-18");
                ConversionFunctions.Add(VelocityUnit.Zeptometerpersecond, "x * 1e-21");
                ConversionFunctions.Add(VelocityUnit.Yoctometerpersecond, "x * 1e-24");
            }
        }
    }
