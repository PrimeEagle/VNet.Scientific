
    // Auto-generated for VNet on 2023-07-06 12:42:23
    using System.Numerics;
    
    
    namespace VNet.Scientific.Measurement.Dimensions
    {
        public sealed class LeakRate<TVal> : DimensionBase<LeakRateUnit, TVal> where TVal : notnull, INumber<TVal>
        {
            public override string IdTag => nameof(LeakRate<TVal>);
            
            public LeakRate() : base()
            {
                Exponents.Length = 2;
                Exponents.Mass = 1;
                Exponents.Time = -3;
                Exponents.ElectricalCurrent = 0;
                Exponents.LuminousIntensity = 0;
                Exponents.Temperature = 0;
                Exponents.Amount = 0;
                
                DefaultUnit = LeakRateUnit.PascalCubicMeterPerSecond;
                
                Symbols.Add(LeakRateUnit.MillibarLiterPerSecond, "mbar·l/s");
                Symbols.Add(LeakRateUnit.TorrLiterPerSecond, "Torr·l/s");
                Symbols.Add(LeakRateUnit.Yottapascalcubicmeterpersecond, "YPa·m³/s");
                Symbols.Add(LeakRateUnit.Zettapascalcubicmeterpersecond, "ZPa·m³/s");
                Symbols.Add(LeakRateUnit.Exapascalcubicmeterpersecond, "EPa·m³/s");
                Symbols.Add(LeakRateUnit.Petapascalcubicmeterpersecond, "PPa·m³/s");
                Symbols.Add(LeakRateUnit.Terapascalcubicmeterpersecond, "TPa·m³/s");
                Symbols.Add(LeakRateUnit.Gigapascalcubicmeterpersecond, "GPa·m³/s");
                Symbols.Add(LeakRateUnit.Megapascalcubicmeterpersecond, "MPa·m³/s");
                Symbols.Add(LeakRateUnit.Kilopascalcubicmeterpersecond, "kPa·m³/s");
                Symbols.Add(LeakRateUnit.Hectopascalcubicmeterpersecond, "hPa·m³/s");
                Symbols.Add(LeakRateUnit.Dekapascalcubicmeterpersecond, "daPa·m³/s");
                Symbols.Add(LeakRateUnit.PascalCubicMeterPerSecond, "Pa·m³/s");
                Symbols.Add(LeakRateUnit.Decipascalcubicmeterpersecond, "dPa·m³/s");
                Symbols.Add(LeakRateUnit.Centipascalcubicmeterpersecond, "cPa·m³/s");
                Symbols.Add(LeakRateUnit.Millipascalcubicmeterpersecond, "mPa·m³/s");
                Symbols.Add(LeakRateUnit.Micropascalcubicmeterpersecond, "µPa·m³/s");
                Symbols.Add(LeakRateUnit.Nanopascalcubicmeterpersecond, "nPa·m³/s");
                Symbols.Add(LeakRateUnit.Picopascalcubicmeterpersecond, "pPa·m³/s");
                Symbols.Add(LeakRateUnit.Femtopascalcubicmeterpersecond, "fPa·m³/s");
                Symbols.Add(LeakRateUnit.Attopascalcubicmeterpersecond, "aPa·m³/s");
                Symbols.Add(LeakRateUnit.Zeptopascalcubicmeterpersecond, "zPa·m³/s");
                Symbols.Add(LeakRateUnit.Yoctopascalcubicmeterpersecond, "yPa·m³/s");
                
                
                ConversionFunctions.Add(LeakRateUnit.MillibarLiterPerSecond, "x / 10");
                ConversionFunctions.Add(LeakRateUnit.TorrLiterPerSecond, "x / 7.5");
                ConversionFunctions.Add(LeakRateUnit.Yottapascalcubicmeterpersecond, "x * 1e24");
                ConversionFunctions.Add(LeakRateUnit.Zettapascalcubicmeterpersecond, "x * 1e21");
                ConversionFunctions.Add(LeakRateUnit.Exapascalcubicmeterpersecond, "x * 1e18");
                ConversionFunctions.Add(LeakRateUnit.Petapascalcubicmeterpersecond, "x * 1e15");
                ConversionFunctions.Add(LeakRateUnit.Terapascalcubicmeterpersecond, "x * 1e12");
                ConversionFunctions.Add(LeakRateUnit.Gigapascalcubicmeterpersecond, "x * 1e9");
                ConversionFunctions.Add(LeakRateUnit.Megapascalcubicmeterpersecond, "x * 1e6");
                ConversionFunctions.Add(LeakRateUnit.Kilopascalcubicmeterpersecond, "x * 1e3");
                ConversionFunctions.Add(LeakRateUnit.Hectopascalcubicmeterpersecond, "x * 1e2");
                ConversionFunctions.Add(LeakRateUnit.Dekapascalcubicmeterpersecond, "x * 1e1");
                ConversionFunctions.Add(LeakRateUnit.PascalCubicMeterPerSecond, "x * 1e0");
                ConversionFunctions.Add(LeakRateUnit.Decipascalcubicmeterpersecond, "x * 1e-1");
                ConversionFunctions.Add(LeakRateUnit.Centipascalcubicmeterpersecond, "x * 1e-2");
                ConversionFunctions.Add(LeakRateUnit.Millipascalcubicmeterpersecond, "x * 1e-3");
                ConversionFunctions.Add(LeakRateUnit.Micropascalcubicmeterpersecond, "x * 1e-6");
                ConversionFunctions.Add(LeakRateUnit.Nanopascalcubicmeterpersecond, "x * 1e-9");
                ConversionFunctions.Add(LeakRateUnit.Picopascalcubicmeterpersecond, "x * 1e-12");
                ConversionFunctions.Add(LeakRateUnit.Femtopascalcubicmeterpersecond, "x * 1e-15");
                ConversionFunctions.Add(LeakRateUnit.Attopascalcubicmeterpersecond, "x * 1e-18");
                ConversionFunctions.Add(LeakRateUnit.Zeptopascalcubicmeterpersecond, "x * 1e-21");
                ConversionFunctions.Add(LeakRateUnit.Yoctopascalcubicmeterpersecond, "x * 1e-24");
            }
        }
    }
