
    // Auto-generated for VNet on 2023-07-05 10:35:43
    using System.Numerics;
    
    
    namespace VNet.Scientific.Measurement.Dimensions
    {
        public sealed class Frequency<TVal> : DimensionBase<FrequencyUnit, TVal> where TVal : notnull, INumber<TVal>
        {
            public override string IdTag => nameof(Frequency<TVal>);
            
            public Frequency() : base()
            {
                DimensionComponent.Exponents.Length = 0;
                DimensionComponent.Exponents.Mass = 0;
                DimensionComponent.Exponents.Time = -1;
                DimensionComponent.Exponents.ElectricalCurrent = 0;
                DimensionComponent.Exponents.LuminousIntensity = 0;
                DimensionComponent.Exponents.Temperature = 0;
                DimensionComponent.Exponents.Amount = 0;
                
                DefaultUnit = FrequencyUnit.Hertz;
                
                Symbols.Add(FrequencyUnit.RadianPerSecond, "rad/s");
                Symbols.Add(FrequencyUnit.CyclePerMinute, "cpm");
                Symbols.Add(FrequencyUnit.CyclePerHour, "cph");
                Symbols.Add(FrequencyUnit.BeatPerMinute, "bpm");
                Symbols.Add(FrequencyUnit.PerSecond, "s⁻¹");
                Symbols.Add(FrequencyUnit.BUnit, "B Units");
                Symbols.Add(FrequencyUnit.Yottahertz, "YHz");
                Symbols.Add(FrequencyUnit.Zettahertz, "ZHz");
                Symbols.Add(FrequencyUnit.Exahertz, "EHz");
                Symbols.Add(FrequencyUnit.Petahertz, "PHz");
                Symbols.Add(FrequencyUnit.Terahertz, "THz");
                Symbols.Add(FrequencyUnit.Gigahertz, "GHz");
                Symbols.Add(FrequencyUnit.Megahertz, "MHz");
                Symbols.Add(FrequencyUnit.Kilohertz, "kHz");
                Symbols.Add(FrequencyUnit.Hectohertz, "hHz");
                Symbols.Add(FrequencyUnit.Dekahertz, "daHz");
                Symbols.Add(FrequencyUnit.Hertz, "Hz");
                Symbols.Add(FrequencyUnit.Decihertz, "dHz");
                Symbols.Add(FrequencyUnit.Centihertz, "cHz");
                Symbols.Add(FrequencyUnit.Millihertz, "mHz");
                Symbols.Add(FrequencyUnit.Microhertz, "µHz");
                Symbols.Add(FrequencyUnit.Nanohertz, "nHz");
                Symbols.Add(FrequencyUnit.Picohertz, "pHz");
                Symbols.Add(FrequencyUnit.Femtohertz, "fHz");
                Symbols.Add(FrequencyUnit.Attohertz, "aHz");
                Symbols.Add(FrequencyUnit.Zeptohertz, "zHz");
                Symbols.Add(FrequencyUnit.Yoctohertz, "yHz");
                
                
                ConversionFunctions.Add(FrequencyUnit.RadianPerSecond, "x / 6.2831853072");
                ConversionFunctions.Add(FrequencyUnit.CyclePerMinute, "x / 60");
                ConversionFunctions.Add(FrequencyUnit.CyclePerHour, "x / 3600");
                ConversionFunctions.Add(FrequencyUnit.BeatPerMinute, "x / 60");
                ConversionFunctions.Add(FrequencyUnit.PerSecond, "x");
                ConversionFunctions.Add(FrequencyUnit.BUnit, "Math.Sqrt(x * 1e3)");
                ConversionFunctions.Add(FrequencyUnit.Yottahertz, "x * 1e24");
                ConversionFunctions.Add(FrequencyUnit.Zettahertz, "x * 1e21");
                ConversionFunctions.Add(FrequencyUnit.Exahertz, "x * 1e18");
                ConversionFunctions.Add(FrequencyUnit.Petahertz, "x * 1e15");
                ConversionFunctions.Add(FrequencyUnit.Terahertz, "x * 1e12");
                ConversionFunctions.Add(FrequencyUnit.Gigahertz, "x * 1e9");
                ConversionFunctions.Add(FrequencyUnit.Megahertz, "x * 1e6");
                ConversionFunctions.Add(FrequencyUnit.Kilohertz, "x * 1e3");
                ConversionFunctions.Add(FrequencyUnit.Hectohertz, "x * 1e2");
                ConversionFunctions.Add(FrequencyUnit.Dekahertz, "x * 1e1");
                ConversionFunctions.Add(FrequencyUnit.Hertz, "x * 1e0");
                ConversionFunctions.Add(FrequencyUnit.Decihertz, "x * 1e-1");
                ConversionFunctions.Add(FrequencyUnit.Centihertz, "x * 1e-2");
                ConversionFunctions.Add(FrequencyUnit.Millihertz, "x * 1e-3");
                ConversionFunctions.Add(FrequencyUnit.Microhertz, "x * 1e-6");
                ConversionFunctions.Add(FrequencyUnit.Nanohertz, "x * 1e-9");
                ConversionFunctions.Add(FrequencyUnit.Picohertz, "x * 1e-12");
                ConversionFunctions.Add(FrequencyUnit.Femtohertz, "x * 1e-15");
                ConversionFunctions.Add(FrequencyUnit.Attohertz, "x * 1e-18");
                ConversionFunctions.Add(FrequencyUnit.Zeptohertz, "x * 1e-21");
                ConversionFunctions.Add(FrequencyUnit.Yoctohertz, "x * 1e-24");
            }
        }
    }
