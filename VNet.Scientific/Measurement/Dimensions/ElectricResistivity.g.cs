
    // Auto-generated for VNet on 2023-07-05 10:35:43
    using System.Numerics;
    
    
    namespace VNet.Scientific.Measurement.Dimensions
    {
        public sealed class ElectricResistivity<TVal> : DimensionBase<ElectricResistivityUnit, TVal> where TVal : notnull, INumber<TVal>
        {
            public override string IdTag => nameof(ElectricResistivity<TVal>);
            
            public ElectricResistivity() : base()
            {
                DimensionComponent.Exponents.Length = 3;
                DimensionComponent.Exponents.Mass = 1;
                DimensionComponent.Exponents.Time = -3;
                DimensionComponent.Exponents.ElectricalCurrent = -2;
                DimensionComponent.Exponents.LuminousIntensity = 0;
                DimensionComponent.Exponents.Temperature = 0;
                DimensionComponent.Exponents.Amount = 0;
                
                DefaultUnit = ElectricResistivityUnit.OhmMeter;
                
                Symbols.Add(ElectricResistivityUnit.OhmCentimeter, "Ω·cm");
                Symbols.Add(ElectricResistivityUnit.Yottaohmmeter, "YΩ·m");
                Symbols.Add(ElectricResistivityUnit.Zettaohmmeter, "ZΩ·m");
                Symbols.Add(ElectricResistivityUnit.Exaohmmeter, "EΩ·m");
                Symbols.Add(ElectricResistivityUnit.Petaohmmeter, "PΩ·m");
                Symbols.Add(ElectricResistivityUnit.Teraohmmeter, "TΩ·m");
                Symbols.Add(ElectricResistivityUnit.Gigaohmmeter, "GΩ·m");
                Symbols.Add(ElectricResistivityUnit.Megaohmmeter, "MΩ·m");
                Symbols.Add(ElectricResistivityUnit.Kiloohmmeter, "kΩ·m");
                Symbols.Add(ElectricResistivityUnit.Hectoohmmeter, "hΩ·m");
                Symbols.Add(ElectricResistivityUnit.Dekaohmmeter, "daΩ·m");
                Symbols.Add(ElectricResistivityUnit.OhmMeter, "Ω·m");
                Symbols.Add(ElectricResistivityUnit.Deciohmmeter, "dΩ·m");
                Symbols.Add(ElectricResistivityUnit.Centiohmmeter, "cΩ·m");
                Symbols.Add(ElectricResistivityUnit.Milliohmmeter, "mΩ·m");
                Symbols.Add(ElectricResistivityUnit.Microohmmeter, "µΩ·m");
                Symbols.Add(ElectricResistivityUnit.Nanoohmmeter, "nΩ·m");
                Symbols.Add(ElectricResistivityUnit.Picoohmmeter, "pΩ·m");
                Symbols.Add(ElectricResistivityUnit.Femtoohmmeter, "fΩ·m");
                Symbols.Add(ElectricResistivityUnit.Attoohmmeter, "aΩ·m");
                Symbols.Add(ElectricResistivityUnit.Zeptoohmmeter, "zΩ·m");
                Symbols.Add(ElectricResistivityUnit.Yoctoohmmeter, "yΩ·m");
                
                
                ConversionFunctions.Add(ElectricResistivityUnit.OhmCentimeter, "x / 100");
                ConversionFunctions.Add(ElectricResistivityUnit.Yottaohmmeter, "x * 1e24");
                ConversionFunctions.Add(ElectricResistivityUnit.Zettaohmmeter, "x * 1e21");
                ConversionFunctions.Add(ElectricResistivityUnit.Exaohmmeter, "x * 1e18");
                ConversionFunctions.Add(ElectricResistivityUnit.Petaohmmeter, "x * 1e15");
                ConversionFunctions.Add(ElectricResistivityUnit.Teraohmmeter, "x * 1e12");
                ConversionFunctions.Add(ElectricResistivityUnit.Gigaohmmeter, "x * 1e9");
                ConversionFunctions.Add(ElectricResistivityUnit.Megaohmmeter, "x * 1e6");
                ConversionFunctions.Add(ElectricResistivityUnit.Kiloohmmeter, "x * 1e3");
                ConversionFunctions.Add(ElectricResistivityUnit.Hectoohmmeter, "x * 1e2");
                ConversionFunctions.Add(ElectricResistivityUnit.Dekaohmmeter, "x * 1e1");
                ConversionFunctions.Add(ElectricResistivityUnit.OhmMeter, "x * 1e0");
                ConversionFunctions.Add(ElectricResistivityUnit.Deciohmmeter, "x * 1e-1");
                ConversionFunctions.Add(ElectricResistivityUnit.Centiohmmeter, "x * 1e-2");
                ConversionFunctions.Add(ElectricResistivityUnit.Milliohmmeter, "x * 1e-3");
                ConversionFunctions.Add(ElectricResistivityUnit.Microohmmeter, "x * 1e-6");
                ConversionFunctions.Add(ElectricResistivityUnit.Nanoohmmeter, "x * 1e-9");
                ConversionFunctions.Add(ElectricResistivityUnit.Picoohmmeter, "x * 1e-12");
                ConversionFunctions.Add(ElectricResistivityUnit.Femtoohmmeter, "x * 1e-15");
                ConversionFunctions.Add(ElectricResistivityUnit.Attoohmmeter, "x * 1e-18");
                ConversionFunctions.Add(ElectricResistivityUnit.Zeptoohmmeter, "x * 1e-21");
                ConversionFunctions.Add(ElectricResistivityUnit.Yoctoohmmeter, "x * 1e-24");
            }
        }
    }
