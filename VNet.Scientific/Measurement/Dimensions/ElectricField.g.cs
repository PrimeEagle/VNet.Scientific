
    // Auto-generated for VNet on 2023-07-05 10:35:43
    using System.Numerics;
    
    
    namespace VNet.Scientific.Measurement.Dimensions
    {
        public sealed class ElectricField<TVal> : DimensionBase<ElectricFieldUnit, TVal> where TVal : notnull, INumber<TVal>
        {
            public override string IdTag => nameof(ElectricField<TVal>);
            
            public ElectricField() : base()
            {
                DimensionComponent.Exponents.Length = 1;
                DimensionComponent.Exponents.Mass = 1;
                DimensionComponent.Exponents.Time = -3;
                DimensionComponent.Exponents.ElectricalCurrent = -1;
                DimensionComponent.Exponents.LuminousIntensity = 0;
                DimensionComponent.Exponents.Temperature = 0;
                DimensionComponent.Exponents.Amount = 0;
                
                DefaultUnit = ElectricFieldUnit.VoltPerMeter;
                
                Symbols.Add(ElectricFieldUnit.Yottavoltpermeter, "YV/m");
                Symbols.Add(ElectricFieldUnit.Zettavoltpermeter, "ZV/m");
                Symbols.Add(ElectricFieldUnit.Exavoltpermeter, "EV/m");
                Symbols.Add(ElectricFieldUnit.Petavoltpermeter, "PV/m");
                Symbols.Add(ElectricFieldUnit.Teravoltpermeter, "TV/m");
                Symbols.Add(ElectricFieldUnit.Gigavoltpermeter, "GV/m");
                Symbols.Add(ElectricFieldUnit.Megavoltpermeter, "MV/m");
                Symbols.Add(ElectricFieldUnit.Kilovoltpermeter, "kV/m");
                Symbols.Add(ElectricFieldUnit.Hectovoltpermeter, "hV/m");
                Symbols.Add(ElectricFieldUnit.Dekavoltpermeter, "daV/m");
                Symbols.Add(ElectricFieldUnit.VoltPerMeter, "V/m");
                Symbols.Add(ElectricFieldUnit.Decivoltpermeter, "dV/m");
                Symbols.Add(ElectricFieldUnit.Centivoltpermeter, "cV/m");
                Symbols.Add(ElectricFieldUnit.Millivoltpermeter, "mV/m");
                Symbols.Add(ElectricFieldUnit.Microvoltpermeter, "µV/m");
                Symbols.Add(ElectricFieldUnit.Nanovoltpermeter, "nV/m");
                Symbols.Add(ElectricFieldUnit.Picovoltpermeter, "pV/m");
                Symbols.Add(ElectricFieldUnit.Femtovoltpermeter, "fV/m");
                Symbols.Add(ElectricFieldUnit.Attovoltpermeter, "aV/m");
                Symbols.Add(ElectricFieldUnit.Zeptovoltpermeter, "zV/m");
                Symbols.Add(ElectricFieldUnit.Yoctovoltpermeter, "yV/m");
                
                
                ConversionFunctions.Add(ElectricFieldUnit.Yottavoltpermeter, "x * 1e24");
                ConversionFunctions.Add(ElectricFieldUnit.Zettavoltpermeter, "x * 1e21");
                ConversionFunctions.Add(ElectricFieldUnit.Exavoltpermeter, "x * 1e18");
                ConversionFunctions.Add(ElectricFieldUnit.Petavoltpermeter, "x * 1e15");
                ConversionFunctions.Add(ElectricFieldUnit.Teravoltpermeter, "x * 1e12");
                ConversionFunctions.Add(ElectricFieldUnit.Gigavoltpermeter, "x * 1e9");
                ConversionFunctions.Add(ElectricFieldUnit.Megavoltpermeter, "x * 1e6");
                ConversionFunctions.Add(ElectricFieldUnit.Kilovoltpermeter, "x * 1e3");
                ConversionFunctions.Add(ElectricFieldUnit.Hectovoltpermeter, "x * 1e2");
                ConversionFunctions.Add(ElectricFieldUnit.Dekavoltpermeter, "x * 1e1");
                ConversionFunctions.Add(ElectricFieldUnit.VoltPerMeter, "x * 1e0");
                ConversionFunctions.Add(ElectricFieldUnit.Decivoltpermeter, "x * 1e-1");
                ConversionFunctions.Add(ElectricFieldUnit.Centivoltpermeter, "x * 1e-2");
                ConversionFunctions.Add(ElectricFieldUnit.Millivoltpermeter, "x * 1e-3");
                ConversionFunctions.Add(ElectricFieldUnit.Microvoltpermeter, "x * 1e-6");
                ConversionFunctions.Add(ElectricFieldUnit.Nanovoltpermeter, "x * 1e-9");
                ConversionFunctions.Add(ElectricFieldUnit.Picovoltpermeter, "x * 1e-12");
                ConversionFunctions.Add(ElectricFieldUnit.Femtovoltpermeter, "x * 1e-15");
                ConversionFunctions.Add(ElectricFieldUnit.Attovoltpermeter, "x * 1e-18");
                ConversionFunctions.Add(ElectricFieldUnit.Zeptovoltpermeter, "x * 1e-21");
                ConversionFunctions.Add(ElectricFieldUnit.Yoctovoltpermeter, "x * 1e-24");
            }
        }
    }
