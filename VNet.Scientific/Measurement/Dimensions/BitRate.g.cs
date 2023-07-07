
    // Auto-generated for VNet on 2023-07-06 12:42:23
    using System.Numerics;
    
    
    namespace VNet.Scientific.Measurement.Dimensions
    {
        public sealed class BitRate<TVal> : DimensionBase<BitRateUnit, TVal> where TVal : notnull, INumber<TVal>
        {
            public override string IdTag => nameof(BitRate<TVal>);
            
            public BitRate() : base()
            {
                Exponents.Length = 0;
                Exponents.Mass = 0;
                Exponents.Time = -1;
                Exponents.ElectricalCurrent = 0;
                Exponents.LuminousIntensity = 0;
                Exponents.Temperature = 0;
                Exponents.Amount = 0;
                
                DefaultUnit = BitRateUnit.BitPerSecond;
                
                Symbols.Add(BitRateUnit.BytePerSecond, "B/s");
                Symbols.Add(BitRateUnit.Yottabitpersecond, "Ybit/s");
                Symbols.Add(BitRateUnit.Zettabitpersecond, "Zbit/s");
                Symbols.Add(BitRateUnit.Exabitpersecond, "Ebit/s");
                Symbols.Add(BitRateUnit.Petabitpersecond, "Pbit/s");
                Symbols.Add(BitRateUnit.Terabitpersecond, "Tbit/s");
                Symbols.Add(BitRateUnit.Gigabitpersecond, "Gbit/s");
                Symbols.Add(BitRateUnit.Megabitpersecond, "Mbit/s");
                Symbols.Add(BitRateUnit.Kilobitpersecond, "kbit/s");
                Symbols.Add(BitRateUnit.Hectobitpersecond, "hbit/s");
                Symbols.Add(BitRateUnit.Dekabitpersecond, "dabit/s");
                Symbols.Add(BitRateUnit.BitPerSecond, "bit/s");
                Symbols.Add(BitRateUnit.Decibitpersecond, "dbit/s");
                Symbols.Add(BitRateUnit.Centibitpersecond, "cbit/s");
                Symbols.Add(BitRateUnit.Millibitpersecond, "mbit/s");
                Symbols.Add(BitRateUnit.Microbitpersecond, "µbit/s");
                Symbols.Add(BitRateUnit.Nanobitpersecond, "nbit/s");
                Symbols.Add(BitRateUnit.Picobitpersecond, "pbit/s");
                Symbols.Add(BitRateUnit.Femtobitpersecond, "fbit/s");
                Symbols.Add(BitRateUnit.Attobitpersecond, "abit/s");
                Symbols.Add(BitRateUnit.Zeptobitpersecond, "zbit/s");
                Symbols.Add(BitRateUnit.Yoctobitpersecond, "ybit/s");
                
                PluralSymbols.Add(BitRateUnit.Yottabitpersecond, "Ybps");
                PluralSymbols.Add(BitRateUnit.Zettabitpersecond, "Zbps");
                PluralSymbols.Add(BitRateUnit.Exabitpersecond, "Ebps");
                PluralSymbols.Add(BitRateUnit.Petabitpersecond, "Pbps");
                PluralSymbols.Add(BitRateUnit.Terabitpersecond, "Tbps");
                PluralSymbols.Add(BitRateUnit.Gigabitpersecond, "Gbps");
                PluralSymbols.Add(BitRateUnit.Megabitpersecond, "Mbps");
                PluralSymbols.Add(BitRateUnit.Kilobitpersecond, "kbps");
                PluralSymbols.Add(BitRateUnit.Hectobitpersecond, "hbps");
                PluralSymbols.Add(BitRateUnit.Dekabitpersecond, "dabps");
                PluralSymbols.Add(BitRateUnit.BitPerSecond, "bps");
                PluralSymbols.Add(BitRateUnit.Decibitpersecond, "dbps");
                PluralSymbols.Add(BitRateUnit.Centibitpersecond, "cbps");
                PluralSymbols.Add(BitRateUnit.Millibitpersecond, "mbps");
                PluralSymbols.Add(BitRateUnit.Microbitpersecond, "µbps");
                PluralSymbols.Add(BitRateUnit.Nanobitpersecond, "nbps");
                PluralSymbols.Add(BitRateUnit.Picobitpersecond, "pbps");
                PluralSymbols.Add(BitRateUnit.Femtobitpersecond, "fbps");
                PluralSymbols.Add(BitRateUnit.Attobitpersecond, "abps");
                PluralSymbols.Add(BitRateUnit.Zeptobitpersecond, "zbps");
                PluralSymbols.Add(BitRateUnit.Yoctobitpersecond, "ybps");
                
                ConversionFunctions.Add(BitRateUnit.BytePerSecond, "x * 8m");
                ConversionFunctions.Add(BitRateUnit.Yottabitpersecond, "x * 1e24");
                ConversionFunctions.Add(BitRateUnit.Zettabitpersecond, "x * 1e21");
                ConversionFunctions.Add(BitRateUnit.Exabitpersecond, "x * 1e18");
                ConversionFunctions.Add(BitRateUnit.Petabitpersecond, "x * 1e15");
                ConversionFunctions.Add(BitRateUnit.Terabitpersecond, "x * 1e12");
                ConversionFunctions.Add(BitRateUnit.Gigabitpersecond, "x * 1e9");
                ConversionFunctions.Add(BitRateUnit.Megabitpersecond, "x * 1e6");
                ConversionFunctions.Add(BitRateUnit.Kilobitpersecond, "x * 1e3");
                ConversionFunctions.Add(BitRateUnit.Hectobitpersecond, "x * 1e2");
                ConversionFunctions.Add(BitRateUnit.Dekabitpersecond, "x * 1e1");
                ConversionFunctions.Add(BitRateUnit.BitPerSecond, "x * 1e0");
                ConversionFunctions.Add(BitRateUnit.Decibitpersecond, "x * 1e-1");
                ConversionFunctions.Add(BitRateUnit.Centibitpersecond, "x * 1e-2");
                ConversionFunctions.Add(BitRateUnit.Millibitpersecond, "x * 1e-3");
                ConversionFunctions.Add(BitRateUnit.Microbitpersecond, "x * 1e-6");
                ConversionFunctions.Add(BitRateUnit.Nanobitpersecond, "x * 1e-9");
                ConversionFunctions.Add(BitRateUnit.Picobitpersecond, "x * 1e-12");
                ConversionFunctions.Add(BitRateUnit.Femtobitpersecond, "x * 1e-15");
                ConversionFunctions.Add(BitRateUnit.Attobitpersecond, "x * 1e-18");
                ConversionFunctions.Add(BitRateUnit.Zeptobitpersecond, "x * 1e-21");
                ConversionFunctions.Add(BitRateUnit.Yoctobitpersecond, "x * 1e-24");
            }
        }
    }
