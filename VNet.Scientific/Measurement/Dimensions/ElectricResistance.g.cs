
    // Auto-generated for VNet on 2023-07-06 12:42:23
    using System.Numerics;
    
    
    namespace VNet.Scientific.Measurement.Dimensions
    {
        public sealed class ElectricResistance<TVal> : DimensionBase<ElectricResistanceUnit, TVal> where TVal : notnull, INumber<TVal>
        {
            public override string IdTag => nameof(ElectricResistance<TVal>);
            
            public ElectricResistance() : base()
            {
                Exponents.Length = 2;
                Exponents.Mass = 1;
                Exponents.Time = -3;
                Exponents.ElectricalCurrent = -2;
                Exponents.LuminousIntensity = 0;
                Exponents.Temperature = 0;
                Exponents.Amount = 0;
                
                DefaultUnit = ElectricResistanceUnit.Ohm;
                
                Symbols.Add(ElectricResistanceUnit.Yottaohm, "YΩ");
                Symbols.Add(ElectricResistanceUnit.Zettaohm, "ZΩ");
                Symbols.Add(ElectricResistanceUnit.Exaohm, "EΩ");
                Symbols.Add(ElectricResistanceUnit.Petaohm, "PΩ");
                Symbols.Add(ElectricResistanceUnit.Teraohm, "TΩ");
                Symbols.Add(ElectricResistanceUnit.Gigaohm, "GΩ");
                Symbols.Add(ElectricResistanceUnit.Megaohm, "MΩ");
                Symbols.Add(ElectricResistanceUnit.Kiloohm, "kΩ");
                Symbols.Add(ElectricResistanceUnit.Hectoohm, "hΩ");
                Symbols.Add(ElectricResistanceUnit.Dekaohm, "daΩ");
                Symbols.Add(ElectricResistanceUnit.Ohm, "Ω");
                Symbols.Add(ElectricResistanceUnit.Deciohm, "dΩ");
                Symbols.Add(ElectricResistanceUnit.Centiohm, "cΩ");
                Symbols.Add(ElectricResistanceUnit.Milliohm, "mΩ");
                Symbols.Add(ElectricResistanceUnit.Microohm, "µΩ");
                Symbols.Add(ElectricResistanceUnit.Nanoohm, "nΩ");
                Symbols.Add(ElectricResistanceUnit.Picoohm, "pΩ");
                Symbols.Add(ElectricResistanceUnit.Femtoohm, "fΩ");
                Symbols.Add(ElectricResistanceUnit.Attoohm, "aΩ");
                Symbols.Add(ElectricResistanceUnit.Zeptoohm, "zΩ");
                Symbols.Add(ElectricResistanceUnit.Yoctoohm, "yΩ");
                
                
                ConversionFunctions.Add(ElectricResistanceUnit.Yottaohm, "x * 1e24");
                ConversionFunctions.Add(ElectricResistanceUnit.Zettaohm, "x * 1e21");
                ConversionFunctions.Add(ElectricResistanceUnit.Exaohm, "x * 1e18");
                ConversionFunctions.Add(ElectricResistanceUnit.Petaohm, "x * 1e15");
                ConversionFunctions.Add(ElectricResistanceUnit.Teraohm, "x * 1e12");
                ConversionFunctions.Add(ElectricResistanceUnit.Gigaohm, "x * 1e9");
                ConversionFunctions.Add(ElectricResistanceUnit.Megaohm, "x * 1e6");
                ConversionFunctions.Add(ElectricResistanceUnit.Kiloohm, "x * 1e3");
                ConversionFunctions.Add(ElectricResistanceUnit.Hectoohm, "x * 1e2");
                ConversionFunctions.Add(ElectricResistanceUnit.Dekaohm, "x * 1e1");
                ConversionFunctions.Add(ElectricResistanceUnit.Ohm, "x * 1e0");
                ConversionFunctions.Add(ElectricResistanceUnit.Deciohm, "x * 1e-1");
                ConversionFunctions.Add(ElectricResistanceUnit.Centiohm, "x * 1e-2");
                ConversionFunctions.Add(ElectricResistanceUnit.Milliohm, "x * 1e-3");
                ConversionFunctions.Add(ElectricResistanceUnit.Microohm, "x * 1e-6");
                ConversionFunctions.Add(ElectricResistanceUnit.Nanoohm, "x * 1e-9");
                ConversionFunctions.Add(ElectricResistanceUnit.Picoohm, "x * 1e-12");
                ConversionFunctions.Add(ElectricResistanceUnit.Femtoohm, "x * 1e-15");
                ConversionFunctions.Add(ElectricResistanceUnit.Attoohm, "x * 1e-18");
                ConversionFunctions.Add(ElectricResistanceUnit.Zeptoohm, "x * 1e-21");
                ConversionFunctions.Add(ElectricResistanceUnit.Yoctoohm, "x * 1e-24");
            }
        }
    }
