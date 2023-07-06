
    // Auto-generated for VNet on 2023-07-05 10:35:43
    using System.Numerics;
    
    
    namespace VNet.Scientific.Measurement.Dimensions
    {
        public sealed class Duration<TVal> : DimensionBase<DurationUnit, TVal> where TVal : notnull, INumber<TVal>
        {
            public override string IdTag => nameof(Duration<TVal>);
            
            public Duration() : base()
            {
                DimensionComponent.Exponents.Length = 0;
                DimensionComponent.Exponents.Mass = 0;
                DimensionComponent.Exponents.Time = 1;
                DimensionComponent.Exponents.ElectricalCurrent = 0;
                DimensionComponent.Exponents.LuminousIntensity = 0;
                DimensionComponent.Exponents.Temperature = 0;
                DimensionComponent.Exponents.Amount = 0;
                
                DefaultUnit = DurationUnit.Second;
                
                Symbols.Add(DurationUnit.Year365, "yr");
                Symbols.Add(DurationUnit.Month30, "mo");
                Symbols.Add(DurationUnit.Week, "wk");
                Symbols.Add(DurationUnit.Day, "d");
                Symbols.Add(DurationUnit.Hour, "h");
                Symbols.Add(DurationUnit.Minute, "m");
                Symbols.Add(DurationUnit.JulianYear, "jyr");
                Symbols.Add(DurationUnit.Yottasecond, "Ys");
                Symbols.Add(DurationUnit.Zettasecond, "Zs");
                Symbols.Add(DurationUnit.Exasecond, "Es");
                Symbols.Add(DurationUnit.Petasecond, "Ps");
                Symbols.Add(DurationUnit.Terasecond, "Ts");
                Symbols.Add(DurationUnit.Gigasecond, "Gs");
                Symbols.Add(DurationUnit.Megasecond, "Ms");
                Symbols.Add(DurationUnit.Kilosecond, "ks");
                Symbols.Add(DurationUnit.Hectosecond, "hs");
                Symbols.Add(DurationUnit.Dekasecond, "das");
                Symbols.Add(DurationUnit.Second, "s");
                Symbols.Add(DurationUnit.Decisecond, "ds");
                Symbols.Add(DurationUnit.Centisecond, "cs");
                Symbols.Add(DurationUnit.Millisecond, "ms");
                Symbols.Add(DurationUnit.Microsecond, "µs");
                Symbols.Add(DurationUnit.Nanosecond, "ns");
                Symbols.Add(DurationUnit.Picosecond, "ps");
                Symbols.Add(DurationUnit.Femtosecond, "fs");
                Symbols.Add(DurationUnit.Attosecond, "as");
                Symbols.Add(DurationUnit.Zeptosecond, "zs");
                Symbols.Add(DurationUnit.Yoctosecond, "ys");
                
                PluralSymbols.Add(DurationUnit.Year365, "year");
                PluralSymbols.Add(DurationUnit.Month30, "month");
                PluralSymbols.Add(DurationUnit.Week, "week");
                PluralSymbols.Add(DurationUnit.Day, "day");
                PluralSymbols.Add(DurationUnit.Hour, "hr");
                PluralSymbols.Add(DurationUnit.Minute, "min");
                PluralSymbols.Add(DurationUnit.JulianYear, "jyear");
                PluralSymbols.Add(DurationUnit.Yottasecond, "Ysec");
                PluralSymbols.Add(DurationUnit.Zettasecond, "Zsec");
                PluralSymbols.Add(DurationUnit.Exasecond, "Esec");
                PluralSymbols.Add(DurationUnit.Petasecond, "Psec");
                PluralSymbols.Add(DurationUnit.Terasecond, "Tsec");
                PluralSymbols.Add(DurationUnit.Gigasecond, "Gsec");
                PluralSymbols.Add(DurationUnit.Megasecond, "Msec");
                PluralSymbols.Add(DurationUnit.Kilosecond, "ksec");
                PluralSymbols.Add(DurationUnit.Hectosecond, "hsec");
                PluralSymbols.Add(DurationUnit.Dekasecond, "dasec");
                PluralSymbols.Add(DurationUnit.Second, "sec");
                PluralSymbols.Add(DurationUnit.Decisecond, "dsec");
                PluralSymbols.Add(DurationUnit.Centisecond, "csec");
                PluralSymbols.Add(DurationUnit.Millisecond, "msec");
                PluralSymbols.Add(DurationUnit.Microsecond, "µsec");
                PluralSymbols.Add(DurationUnit.Nanosecond, "nsec");
                PluralSymbols.Add(DurationUnit.Picosecond, "psec");
                PluralSymbols.Add(DurationUnit.Femtosecond, "fsec");
                PluralSymbols.Add(DurationUnit.Attosecond, "asec");
                PluralSymbols.Add(DurationUnit.Zeptosecond, "zsec");
                PluralSymbols.Add(DurationUnit.Yoctosecond, "ysec");
                
                ConversionFunctions.Add(DurationUnit.Year365, "x * 365 * 24 * 3600");
                ConversionFunctions.Add(DurationUnit.Month30, "x * 30 * 24 * 3600");
                ConversionFunctions.Add(DurationUnit.Week, "x * 7 * 24 * 3600");
                ConversionFunctions.Add(DurationUnit.Day, "x * 24 * 3600");
                ConversionFunctions.Add(DurationUnit.Hour, "x * 3600");
                ConversionFunctions.Add(DurationUnit.Minute, "x * 60");
                ConversionFunctions.Add(DurationUnit.JulianYear, "x * 365.25 * 24 * 3600");
                ConversionFunctions.Add(DurationUnit.Yottasecond, "x * 1e24");
                ConversionFunctions.Add(DurationUnit.Zettasecond, "x * 1e21");
                ConversionFunctions.Add(DurationUnit.Exasecond, "x * 1e18");
                ConversionFunctions.Add(DurationUnit.Petasecond, "x * 1e15");
                ConversionFunctions.Add(DurationUnit.Terasecond, "x * 1e12");
                ConversionFunctions.Add(DurationUnit.Gigasecond, "x * 1e9");
                ConversionFunctions.Add(DurationUnit.Megasecond, "x * 1e6");
                ConversionFunctions.Add(DurationUnit.Kilosecond, "x * 1e3");
                ConversionFunctions.Add(DurationUnit.Hectosecond, "x * 1e2");
                ConversionFunctions.Add(DurationUnit.Dekasecond, "x * 1e1");
                ConversionFunctions.Add(DurationUnit.Second, "x * 1e0");
                ConversionFunctions.Add(DurationUnit.Decisecond, "x * 1e-1");
                ConversionFunctions.Add(DurationUnit.Centisecond, "x * 1e-2");
                ConversionFunctions.Add(DurationUnit.Millisecond, "x * 1e-3");
                ConversionFunctions.Add(DurationUnit.Microsecond, "x * 1e-6");
                ConversionFunctions.Add(DurationUnit.Nanosecond, "x * 1e-9");
                ConversionFunctions.Add(DurationUnit.Picosecond, "x * 1e-12");
                ConversionFunctions.Add(DurationUnit.Femtosecond, "x * 1e-15");
                ConversionFunctions.Add(DurationUnit.Attosecond, "x * 1e-18");
                ConversionFunctions.Add(DurationUnit.Zeptosecond, "x * 1e-21");
                ConversionFunctions.Add(DurationUnit.Yoctosecond, "x * 1e-24");
            }
        }
    }
