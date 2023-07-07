
    // Auto-generated for VNet on 2023-07-06 12:42:23
    using System.Numerics;
    
    
    namespace VNet.Scientific.Measurement.Dimensions
    {
        public sealed class ElectricConductance<TVal> : DimensionBase<ElectricConductanceUnit, TVal> where TVal : notnull, INumber<TVal>
        {
            public override string IdTag => nameof(ElectricConductance<TVal>);
            
            public ElectricConductance() : base()
            {
                Exponents.Length = -2;
                Exponents.Mass = -1;
                Exponents.Time = 3;
                Exponents.ElectricalCurrent = 2;
                Exponents.LuminousIntensity = 0;
                Exponents.Temperature = 0;
                Exponents.Amount = 0;
                
                DefaultUnit = ElectricConductanceUnit.Siemens;
                
                Symbols.Add(ElectricConductanceUnit.Yottasiemens, "YS");
                Symbols.Add(ElectricConductanceUnit.Zettasiemens, "ZS");
                Symbols.Add(ElectricConductanceUnit.Exasiemens, "ES");
                Symbols.Add(ElectricConductanceUnit.Petasiemens, "PS");
                Symbols.Add(ElectricConductanceUnit.Terasiemens, "TS");
                Symbols.Add(ElectricConductanceUnit.Gigasiemens, "GS");
                Symbols.Add(ElectricConductanceUnit.Megasiemens, "MS");
                Symbols.Add(ElectricConductanceUnit.Kilosiemens, "kS");
                Symbols.Add(ElectricConductanceUnit.Hectosiemens, "hS");
                Symbols.Add(ElectricConductanceUnit.Dekasiemens, "daS");
                Symbols.Add(ElectricConductanceUnit.Siemens, "S");
                Symbols.Add(ElectricConductanceUnit.Decisiemens, "dS");
                Symbols.Add(ElectricConductanceUnit.Centisiemens, "cS");
                Symbols.Add(ElectricConductanceUnit.Millisiemens, "mS");
                Symbols.Add(ElectricConductanceUnit.Microsiemens, "µS");
                Symbols.Add(ElectricConductanceUnit.Nanosiemens, "nS");
                Symbols.Add(ElectricConductanceUnit.Picosiemens, "pS");
                Symbols.Add(ElectricConductanceUnit.Femtosiemens, "fS");
                Symbols.Add(ElectricConductanceUnit.Attosiemens, "aS");
                Symbols.Add(ElectricConductanceUnit.Zeptosiemens, "zS");
                Symbols.Add(ElectricConductanceUnit.Yoctosiemens, "yS");
                
                
                ConversionFunctions.Add(ElectricConductanceUnit.Yottasiemens, "x * 1e24");
                ConversionFunctions.Add(ElectricConductanceUnit.Zettasiemens, "x * 1e21");
                ConversionFunctions.Add(ElectricConductanceUnit.Exasiemens, "x * 1e18");
                ConversionFunctions.Add(ElectricConductanceUnit.Petasiemens, "x * 1e15");
                ConversionFunctions.Add(ElectricConductanceUnit.Terasiemens, "x * 1e12");
                ConversionFunctions.Add(ElectricConductanceUnit.Gigasiemens, "x * 1e9");
                ConversionFunctions.Add(ElectricConductanceUnit.Megasiemens, "x * 1e6");
                ConversionFunctions.Add(ElectricConductanceUnit.Kilosiemens, "x * 1e3");
                ConversionFunctions.Add(ElectricConductanceUnit.Hectosiemens, "x * 1e2");
                ConversionFunctions.Add(ElectricConductanceUnit.Dekasiemens, "x * 1e1");
                ConversionFunctions.Add(ElectricConductanceUnit.Siemens, "x * 1e0");
                ConversionFunctions.Add(ElectricConductanceUnit.Decisiemens, "x * 1e-1");
                ConversionFunctions.Add(ElectricConductanceUnit.Centisiemens, "x * 1e-2");
                ConversionFunctions.Add(ElectricConductanceUnit.Millisiemens, "x * 1e-3");
                ConversionFunctions.Add(ElectricConductanceUnit.Microsiemens, "x * 1e-6");
                ConversionFunctions.Add(ElectricConductanceUnit.Nanosiemens, "x * 1e-9");
                ConversionFunctions.Add(ElectricConductanceUnit.Picosiemens, "x * 1e-12");
                ConversionFunctions.Add(ElectricConductanceUnit.Femtosiemens, "x * 1e-15");
                ConversionFunctions.Add(ElectricConductanceUnit.Attosiemens, "x * 1e-18");
                ConversionFunctions.Add(ElectricConductanceUnit.Zeptosiemens, "x * 1e-21");
                ConversionFunctions.Add(ElectricConductanceUnit.Yoctosiemens, "x * 1e-24");
            }
        }
    }
