
    // Auto-generated for VNet on 2023-07-06 12:42:23
    using System.Numerics;
    
    
    namespace VNet.Scientific.Measurement.Dimensions
    {
        public sealed class PressureChangeRate<TVal> : DimensionBase<PressureChangeRateUnit, TVal> where TVal : notnull, INumber<TVal>
        {
            public override string IdTag => nameof(PressureChangeRate<TVal>);
            
            public PressureChangeRate() : base()
            {
                Exponents.Length = -1;
                Exponents.Mass = 1;
                Exponents.Time = -3;
                Exponents.ElectricalCurrent = 0;
                Exponents.LuminousIntensity = 0;
                Exponents.Temperature = 0;
                Exponents.Amount = 0;
                
                DefaultUnit = PressureChangeRateUnit.PascalPerSecond;
                
                Symbols.Add(PressureChangeRateUnit.PascalPerMinute, "Pa/min");
                Symbols.Add(PressureChangeRateUnit.MillimeterOfMercuryPerSecond, "mmHg/s");
                Symbols.Add(PressureChangeRateUnit.AtmospherePerSecond, "atm/s");
                Symbols.Add(PressureChangeRateUnit.PoundForcePerSquareInchPerSecond, "psi/s");
                Symbols.Add(PressureChangeRateUnit.PoundForcePerSquareInchPerMinute, "psi/min");
                Symbols.Add(PressureChangeRateUnit.Yottapascalpersecond, "YPa/s");
                Symbols.Add(PressureChangeRateUnit.Zettapascalpersecond, "ZPa/s");
                Symbols.Add(PressureChangeRateUnit.Exapascalpersecond, "EPa/s");
                Symbols.Add(PressureChangeRateUnit.Petapascalpersecond, "PPa/s");
                Symbols.Add(PressureChangeRateUnit.Terapascalpersecond, "TPa/s");
                Symbols.Add(PressureChangeRateUnit.Gigapascalpersecond, "GPa/s");
                Symbols.Add(PressureChangeRateUnit.Megapascalpersecond, "MPa/s");
                Symbols.Add(PressureChangeRateUnit.Kilopascalpersecond, "kPa/s");
                Symbols.Add(PressureChangeRateUnit.Hectopascalpersecond, "hPa/s");
                Symbols.Add(PressureChangeRateUnit.Dekapascalpersecond, "daPa/s");
                Symbols.Add(PressureChangeRateUnit.PascalPerSecond, "Pa/s");
                Symbols.Add(PressureChangeRateUnit.Decipascalpersecond, "dPa/s");
                Symbols.Add(PressureChangeRateUnit.Centipascalpersecond, "cPa/s");
                Symbols.Add(PressureChangeRateUnit.Millipascalpersecond, "mPa/s");
                Symbols.Add(PressureChangeRateUnit.Micropascalpersecond, "µPa/s");
                Symbols.Add(PressureChangeRateUnit.Nanopascalpersecond, "nPa/s");
                Symbols.Add(PressureChangeRateUnit.Picopascalpersecond, "pPa/s");
                Symbols.Add(PressureChangeRateUnit.Femtopascalpersecond, "fPa/s");
                Symbols.Add(PressureChangeRateUnit.Attopascalpersecond, "aPa/s");
                Symbols.Add(PressureChangeRateUnit.Zeptopascalpersecond, "zPa/s");
                Symbols.Add(PressureChangeRateUnit.Yoctopascalpersecond, "yPa/s");
                
                PluralSymbols.Add(PressureChangeRateUnit.PoundForcePerSquareInchPerSecond, "lb/in²/s");
                PluralSymbols.Add(PressureChangeRateUnit.PoundForcePerSquareInchPerMinute, "lb/in²/min");
                
                ConversionFunctions.Add(PressureChangeRateUnit.PascalPerMinute, "x / 60");
                ConversionFunctions.Add(PressureChangeRateUnit.MillimeterOfMercuryPerSecond, "x * 133.322");
                ConversionFunctions.Add(PressureChangeRateUnit.AtmospherePerSecond, "x * 1.01325 * 1e5");
                ConversionFunctions.Add(PressureChangeRateUnit.PoundForcePerSquareInchPerSecond, "x * 6.894757293168361e3");
                ConversionFunctions.Add(PressureChangeRateUnit.PoundForcePerSquareInchPerMinute, "x * 6.894757293168361e3 / 60");
                ConversionFunctions.Add(PressureChangeRateUnit.Yottapascalpersecond, "x * 1e24");
                ConversionFunctions.Add(PressureChangeRateUnit.Zettapascalpersecond, "x * 1e21");
                ConversionFunctions.Add(PressureChangeRateUnit.Exapascalpersecond, "x * 1e18");
                ConversionFunctions.Add(PressureChangeRateUnit.Petapascalpersecond, "x * 1e15");
                ConversionFunctions.Add(PressureChangeRateUnit.Terapascalpersecond, "x * 1e12");
                ConversionFunctions.Add(PressureChangeRateUnit.Gigapascalpersecond, "x * 1e9");
                ConversionFunctions.Add(PressureChangeRateUnit.Megapascalpersecond, "x * 1e6");
                ConversionFunctions.Add(PressureChangeRateUnit.Kilopascalpersecond, "x * 1e3");
                ConversionFunctions.Add(PressureChangeRateUnit.Hectopascalpersecond, "x * 1e2");
                ConversionFunctions.Add(PressureChangeRateUnit.Dekapascalpersecond, "x * 1e1");
                ConversionFunctions.Add(PressureChangeRateUnit.PascalPerSecond, "x * 1e0");
                ConversionFunctions.Add(PressureChangeRateUnit.Decipascalpersecond, "x * 1e-1");
                ConversionFunctions.Add(PressureChangeRateUnit.Centipascalpersecond, "x * 1e-2");
                ConversionFunctions.Add(PressureChangeRateUnit.Millipascalpersecond, "x * 1e-3");
                ConversionFunctions.Add(PressureChangeRateUnit.Micropascalpersecond, "x * 1e-6");
                ConversionFunctions.Add(PressureChangeRateUnit.Nanopascalpersecond, "x * 1e-9");
                ConversionFunctions.Add(PressureChangeRateUnit.Picopascalpersecond, "x * 1e-12");
                ConversionFunctions.Add(PressureChangeRateUnit.Femtopascalpersecond, "x * 1e-15");
                ConversionFunctions.Add(PressureChangeRateUnit.Attopascalpersecond, "x * 1e-18");
                ConversionFunctions.Add(PressureChangeRateUnit.Zeptopascalpersecond, "x * 1e-21");
                ConversionFunctions.Add(PressureChangeRateUnit.Yoctopascalpersecond, "x * 1e-24");
            }
        }
    }
