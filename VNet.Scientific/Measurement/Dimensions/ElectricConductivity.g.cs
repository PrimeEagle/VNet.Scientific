
    // Auto-generated for VNet on 2023-07-05 10:35:43
    using System.Numerics;
    
    
    namespace VNet.Scientific.Measurement.Dimensions
    {
        public sealed class ElectricConductivity<TVal> : DimensionBase<ElectricConductivityUnit, TVal> where TVal : notnull, INumber<TVal>
        {
            public override string IdTag => nameof(ElectricConductivity<TVal>);
            
            public ElectricConductivity() : base()
            {
                DimensionComponent.Exponents.Length = -3;
                DimensionComponent.Exponents.Mass = -1;
                DimensionComponent.Exponents.Time = 3;
                DimensionComponent.Exponents.ElectricalCurrent = 2;
                DimensionComponent.Exponents.LuminousIntensity = 0;
                DimensionComponent.Exponents.Temperature = 0;
                DimensionComponent.Exponents.Amount = 0;
                
                DefaultUnit = ElectricConductivityUnit.SiemensPerMeter;
                
                Symbols.Add(ElectricConductivityUnit.SiemensPerInch, "S/in");
                Symbols.Add(ElectricConductivityUnit.SiemensPerFoot, "S/ft");
                Symbols.Add(ElectricConductivityUnit.SiemensPerCentimeter, "S/cm");
                Symbols.Add(ElectricConductivityUnit.Yottasiemenspermeter, "YS/m");
                Symbols.Add(ElectricConductivityUnit.Zettasiemenspermeter, "ZS/m");
                Symbols.Add(ElectricConductivityUnit.Exasiemenspermeter, "ES/m");
                Symbols.Add(ElectricConductivityUnit.Petasiemenspermeter, "PS/m");
                Symbols.Add(ElectricConductivityUnit.Terasiemenspermeter, "TS/m");
                Symbols.Add(ElectricConductivityUnit.Gigasiemenspermeter, "GS/m");
                Symbols.Add(ElectricConductivityUnit.Megasiemenspermeter, "MS/m");
                Symbols.Add(ElectricConductivityUnit.Kilosiemenspermeter, "kS/m");
                Symbols.Add(ElectricConductivityUnit.Hectosiemenspermeter, "hS/m");
                Symbols.Add(ElectricConductivityUnit.Dekasiemenspermeter, "daS/m");
                Symbols.Add(ElectricConductivityUnit.SiemensPerMeter, "S/m");
                Symbols.Add(ElectricConductivityUnit.Decisiemenspermeter, "dS/m");
                Symbols.Add(ElectricConductivityUnit.Centisiemenspermeter, "cS/m");
                Symbols.Add(ElectricConductivityUnit.Millisiemenspermeter, "mS/m");
                Symbols.Add(ElectricConductivityUnit.Microsiemenspermeter, "µS/m");
                Symbols.Add(ElectricConductivityUnit.Nanosiemenspermeter, "nS/m");
                Symbols.Add(ElectricConductivityUnit.Picosiemenspermeter, "pS/m");
                Symbols.Add(ElectricConductivityUnit.Femtosiemenspermeter, "fS/m");
                Symbols.Add(ElectricConductivityUnit.Attosiemenspermeter, "aS/m");
                Symbols.Add(ElectricConductivityUnit.Zeptosiemenspermeter, "zS/m");
                Symbols.Add(ElectricConductivityUnit.Yoctosiemenspermeter, "yS/m");
                
                
                ConversionFunctions.Add(ElectricConductivityUnit.SiemensPerInch, "x * 3.937007874015748e1");
                ConversionFunctions.Add(ElectricConductivityUnit.SiemensPerFoot, "x * 3.2808398950131234");
                ConversionFunctions.Add(ElectricConductivityUnit.SiemensPerCentimeter, "x * 1e2");
                ConversionFunctions.Add(ElectricConductivityUnit.Yottasiemenspermeter, "x * 1e24");
                ConversionFunctions.Add(ElectricConductivityUnit.Zettasiemenspermeter, "x * 1e21");
                ConversionFunctions.Add(ElectricConductivityUnit.Exasiemenspermeter, "x * 1e18");
                ConversionFunctions.Add(ElectricConductivityUnit.Petasiemenspermeter, "x * 1e15");
                ConversionFunctions.Add(ElectricConductivityUnit.Terasiemenspermeter, "x * 1e12");
                ConversionFunctions.Add(ElectricConductivityUnit.Gigasiemenspermeter, "x * 1e9");
                ConversionFunctions.Add(ElectricConductivityUnit.Megasiemenspermeter, "x * 1e6");
                ConversionFunctions.Add(ElectricConductivityUnit.Kilosiemenspermeter, "x * 1e3");
                ConversionFunctions.Add(ElectricConductivityUnit.Hectosiemenspermeter, "x * 1e2");
                ConversionFunctions.Add(ElectricConductivityUnit.Dekasiemenspermeter, "x * 1e1");
                ConversionFunctions.Add(ElectricConductivityUnit.SiemensPerMeter, "x * 1e0");
                ConversionFunctions.Add(ElectricConductivityUnit.Decisiemenspermeter, "x * 1e-1");
                ConversionFunctions.Add(ElectricConductivityUnit.Centisiemenspermeter, "x * 1e-2");
                ConversionFunctions.Add(ElectricConductivityUnit.Millisiemenspermeter, "x * 1e-3");
                ConversionFunctions.Add(ElectricConductivityUnit.Microsiemenspermeter, "x * 1e-6");
                ConversionFunctions.Add(ElectricConductivityUnit.Nanosiemenspermeter, "x * 1e-9");
                ConversionFunctions.Add(ElectricConductivityUnit.Picosiemenspermeter, "x * 1e-12");
                ConversionFunctions.Add(ElectricConductivityUnit.Femtosiemenspermeter, "x * 1e-15");
                ConversionFunctions.Add(ElectricConductivityUnit.Attosiemenspermeter, "x * 1e-18");
                ConversionFunctions.Add(ElectricConductivityUnit.Zeptosiemenspermeter, "x * 1e-21");
                ConversionFunctions.Add(ElectricConductivityUnit.Yoctosiemenspermeter, "x * 1e-24");
            }
        }
    }
