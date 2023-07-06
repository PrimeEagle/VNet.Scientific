
    // Auto-generated for VNet on 2023-07-05 10:35:43
    using System.Numerics;
    
    
    namespace VNet.Scientific.Measurement.Dimensions
    {
        public sealed class ElectricCurrent<TVal> : DimensionBase<ElectricCurrentUnit, TVal> where TVal : notnull, INumber<TVal>
        {
            public override string IdTag => nameof(ElectricCurrent<TVal>);
            
            public ElectricCurrent() : base()
            {
                DimensionComponent.Exponents.Length = 0;
                DimensionComponent.Exponents.Mass = 0;
                DimensionComponent.Exponents.Time = 0;
                DimensionComponent.Exponents.ElectricalCurrent = 1;
                DimensionComponent.Exponents.LuminousIntensity = 0;
                DimensionComponent.Exponents.Temperature = 0;
                DimensionComponent.Exponents.Amount = 0;
                
                DefaultUnit = ElectricCurrentUnit.Ampere;
                
                Symbols.Add(ElectricCurrentUnit.Yottaampere, "YA");
                Symbols.Add(ElectricCurrentUnit.Zettaampere, "ZA");
                Symbols.Add(ElectricCurrentUnit.Exaampere, "EA");
                Symbols.Add(ElectricCurrentUnit.Petaampere, "PA");
                Symbols.Add(ElectricCurrentUnit.Teraampere, "TA");
                Symbols.Add(ElectricCurrentUnit.Gigaampere, "GA");
                Symbols.Add(ElectricCurrentUnit.Megaampere, "MA");
                Symbols.Add(ElectricCurrentUnit.Kiloampere, "kA");
                Symbols.Add(ElectricCurrentUnit.Hectoampere, "hA");
                Symbols.Add(ElectricCurrentUnit.Dekaampere, "daA");
                Symbols.Add(ElectricCurrentUnit.Ampere, "A");
                Symbols.Add(ElectricCurrentUnit.Deciampere, "dA");
                Symbols.Add(ElectricCurrentUnit.Centiampere, "cA");
                Symbols.Add(ElectricCurrentUnit.Milliampere, "mA");
                Symbols.Add(ElectricCurrentUnit.Microampere, "µA");
                Symbols.Add(ElectricCurrentUnit.Nanoampere, "nA");
                Symbols.Add(ElectricCurrentUnit.Picoampere, "pA");
                Symbols.Add(ElectricCurrentUnit.Femtoampere, "fA");
                Symbols.Add(ElectricCurrentUnit.Attoampere, "aA");
                Symbols.Add(ElectricCurrentUnit.Zeptoampere, "zA");
                Symbols.Add(ElectricCurrentUnit.Yoctoampere, "yA");
                
                
                ConversionFunctions.Add(ElectricCurrentUnit.Yottaampere, "x * 1e24");
                ConversionFunctions.Add(ElectricCurrentUnit.Zettaampere, "x * 1e21");
                ConversionFunctions.Add(ElectricCurrentUnit.Exaampere, "x * 1e18");
                ConversionFunctions.Add(ElectricCurrentUnit.Petaampere, "x * 1e15");
                ConversionFunctions.Add(ElectricCurrentUnit.Teraampere, "x * 1e12");
                ConversionFunctions.Add(ElectricCurrentUnit.Gigaampere, "x * 1e9");
                ConversionFunctions.Add(ElectricCurrentUnit.Megaampere, "x * 1e6");
                ConversionFunctions.Add(ElectricCurrentUnit.Kiloampere, "x * 1e3");
                ConversionFunctions.Add(ElectricCurrentUnit.Hectoampere, "x * 1e2");
                ConversionFunctions.Add(ElectricCurrentUnit.Dekaampere, "x * 1e1");
                ConversionFunctions.Add(ElectricCurrentUnit.Ampere, "x * 1e0");
                ConversionFunctions.Add(ElectricCurrentUnit.Deciampere, "x * 1e-1");
                ConversionFunctions.Add(ElectricCurrentUnit.Centiampere, "x * 1e-2");
                ConversionFunctions.Add(ElectricCurrentUnit.Milliampere, "x * 1e-3");
                ConversionFunctions.Add(ElectricCurrentUnit.Microampere, "x * 1e-6");
                ConversionFunctions.Add(ElectricCurrentUnit.Nanoampere, "x * 1e-9");
                ConversionFunctions.Add(ElectricCurrentUnit.Picoampere, "x * 1e-12");
                ConversionFunctions.Add(ElectricCurrentUnit.Femtoampere, "x * 1e-15");
                ConversionFunctions.Add(ElectricCurrentUnit.Attoampere, "x * 1e-18");
                ConversionFunctions.Add(ElectricCurrentUnit.Zeptoampere, "x * 1e-21");
                ConversionFunctions.Add(ElectricCurrentUnit.Yoctoampere, "x * 1e-24");
            }
        }
    }
