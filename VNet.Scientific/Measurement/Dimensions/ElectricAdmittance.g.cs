
    // Auto-generated for VNet on 2023-07-05 10:35:43
    using System.Numerics;
    
    
    namespace VNet.Scientific.Measurement.Dimensions
    {
        public sealed class ElectricAdmittance<TVal> : DimensionBase<ElectricAdmittanceUnit, TVal> where TVal : notnull, INumber<TVal>
        {
            public override string IdTag => nameof(ElectricAdmittance<TVal>);
            
            public ElectricAdmittance() : base()
            {
                DimensionComponent.Exponents.Length = -2;
                DimensionComponent.Exponents.Mass = -1;
                DimensionComponent.Exponents.Time = 3;
                DimensionComponent.Exponents.ElectricalCurrent = 2;
                DimensionComponent.Exponents.LuminousIntensity = 0;
                DimensionComponent.Exponents.Temperature = 0;
                DimensionComponent.Exponents.Amount = 0;
                
                DefaultUnit = ElectricAdmittanceUnit.Siemens;
                
                Symbols.Add(ElectricAdmittanceUnit.Yottasiemens, "YS");
                Symbols.Add(ElectricAdmittanceUnit.Zettasiemens, "ZS");
                Symbols.Add(ElectricAdmittanceUnit.Exasiemens, "ES");
                Symbols.Add(ElectricAdmittanceUnit.Petasiemens, "PS");
                Symbols.Add(ElectricAdmittanceUnit.Terasiemens, "TS");
                Symbols.Add(ElectricAdmittanceUnit.Gigasiemens, "GS");
                Symbols.Add(ElectricAdmittanceUnit.Megasiemens, "MS");
                Symbols.Add(ElectricAdmittanceUnit.Kilosiemens, "kS");
                Symbols.Add(ElectricAdmittanceUnit.Hectosiemens, "hS");
                Symbols.Add(ElectricAdmittanceUnit.Dekasiemens, "daS");
                Symbols.Add(ElectricAdmittanceUnit.Siemens, "S");
                Symbols.Add(ElectricAdmittanceUnit.Decisiemens, "dS");
                Symbols.Add(ElectricAdmittanceUnit.Centisiemens, "cS");
                Symbols.Add(ElectricAdmittanceUnit.Millisiemens, "mS");
                Symbols.Add(ElectricAdmittanceUnit.Microsiemens, "µS");
                Symbols.Add(ElectricAdmittanceUnit.Nanosiemens, "nS");
                Symbols.Add(ElectricAdmittanceUnit.Picosiemens, "pS");
                Symbols.Add(ElectricAdmittanceUnit.Femtosiemens, "fS");
                Symbols.Add(ElectricAdmittanceUnit.Attosiemens, "aS");
                Symbols.Add(ElectricAdmittanceUnit.Zeptosiemens, "zS");
                Symbols.Add(ElectricAdmittanceUnit.Yoctosiemens, "yS");
                
                
                ConversionFunctions.Add(ElectricAdmittanceUnit.Yottasiemens, "x * 1e24");
                ConversionFunctions.Add(ElectricAdmittanceUnit.Zettasiemens, "x * 1e21");
                ConversionFunctions.Add(ElectricAdmittanceUnit.Exasiemens, "x * 1e18");
                ConversionFunctions.Add(ElectricAdmittanceUnit.Petasiemens, "x * 1e15");
                ConversionFunctions.Add(ElectricAdmittanceUnit.Terasiemens, "x * 1e12");
                ConversionFunctions.Add(ElectricAdmittanceUnit.Gigasiemens, "x * 1e9");
                ConversionFunctions.Add(ElectricAdmittanceUnit.Megasiemens, "x * 1e6");
                ConversionFunctions.Add(ElectricAdmittanceUnit.Kilosiemens, "x * 1e3");
                ConversionFunctions.Add(ElectricAdmittanceUnit.Hectosiemens, "x * 1e2");
                ConversionFunctions.Add(ElectricAdmittanceUnit.Dekasiemens, "x * 1e1");
                ConversionFunctions.Add(ElectricAdmittanceUnit.Siemens, "x * 1e0");
                ConversionFunctions.Add(ElectricAdmittanceUnit.Decisiemens, "x * 1e-1");
                ConversionFunctions.Add(ElectricAdmittanceUnit.Centisiemens, "x * 1e-2");
                ConversionFunctions.Add(ElectricAdmittanceUnit.Millisiemens, "x * 1e-3");
                ConversionFunctions.Add(ElectricAdmittanceUnit.Microsiemens, "x * 1e-6");
                ConversionFunctions.Add(ElectricAdmittanceUnit.Nanosiemens, "x * 1e-9");
                ConversionFunctions.Add(ElectricAdmittanceUnit.Picosiemens, "x * 1e-12");
                ConversionFunctions.Add(ElectricAdmittanceUnit.Femtosiemens, "x * 1e-15");
                ConversionFunctions.Add(ElectricAdmittanceUnit.Attosiemens, "x * 1e-18");
                ConversionFunctions.Add(ElectricAdmittanceUnit.Zeptosiemens, "x * 1e-21");
                ConversionFunctions.Add(ElectricAdmittanceUnit.Yoctosiemens, "x * 1e-24");
            }
        }
    }
