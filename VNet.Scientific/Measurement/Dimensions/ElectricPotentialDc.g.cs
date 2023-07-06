
    // Auto-generated for VNet on 2023-07-05 10:35:43
    using System.Numerics;
    
    
    namespace VNet.Scientific.Measurement.Dimensions
    {
        public sealed class ElectricPotentialDc<TVal> : DimensionBase<ElectricPotentialDcUnit, TVal> where TVal : notnull, INumber<TVal>
        {
            public override string IdTag => nameof(ElectricPotentialDc<TVal>);
            
            public ElectricPotentialDc() : base()
            {
                DimensionComponent.Exponents.Length = 0;
                DimensionComponent.Exponents.Mass = 0;
                DimensionComponent.Exponents.Time = 0;
                DimensionComponent.Exponents.ElectricalCurrent = 0;
                DimensionComponent.Exponents.LuminousIntensity = 0;
                DimensionComponent.Exponents.Temperature = 0;
                DimensionComponent.Exponents.Amount = 0;
                
                DefaultUnit = ElectricPotentialDcUnit.VoltDc;
                
                Symbols.Add(ElectricPotentialDcUnit.Yottavoltdc, "YVdc");
                Symbols.Add(ElectricPotentialDcUnit.Zettavoltdc, "ZVdc");
                Symbols.Add(ElectricPotentialDcUnit.Exavoltdc, "EVdc");
                Symbols.Add(ElectricPotentialDcUnit.Petavoltdc, "PVdc");
                Symbols.Add(ElectricPotentialDcUnit.Teravoltdc, "TVdc");
                Symbols.Add(ElectricPotentialDcUnit.Gigavoltdc, "GVdc");
                Symbols.Add(ElectricPotentialDcUnit.Megavoltdc, "MVdc");
                Symbols.Add(ElectricPotentialDcUnit.Kilovoltdc, "kVdc");
                Symbols.Add(ElectricPotentialDcUnit.Hectovoltdc, "hVdc");
                Symbols.Add(ElectricPotentialDcUnit.Dekavoltdc, "daVdc");
                Symbols.Add(ElectricPotentialDcUnit.VoltDc, "Vdc");
                Symbols.Add(ElectricPotentialDcUnit.Decivoltdc, "dVdc");
                Symbols.Add(ElectricPotentialDcUnit.Centivoltdc, "cVdc");
                Symbols.Add(ElectricPotentialDcUnit.Millivoltdc, "mVdc");
                Symbols.Add(ElectricPotentialDcUnit.Microvoltdc, "µVdc");
                Symbols.Add(ElectricPotentialDcUnit.Nanovoltdc, "nVdc");
                Symbols.Add(ElectricPotentialDcUnit.Picovoltdc, "pVdc");
                Symbols.Add(ElectricPotentialDcUnit.Femtovoltdc, "fVdc");
                Symbols.Add(ElectricPotentialDcUnit.Attovoltdc, "aVdc");
                Symbols.Add(ElectricPotentialDcUnit.Zeptovoltdc, "zVdc");
                Symbols.Add(ElectricPotentialDcUnit.Yoctovoltdc, "yVdc");
                
                
                ConversionFunctions.Add(ElectricPotentialDcUnit.Yottavoltdc, "x * 1e24");
                ConversionFunctions.Add(ElectricPotentialDcUnit.Zettavoltdc, "x * 1e21");
                ConversionFunctions.Add(ElectricPotentialDcUnit.Exavoltdc, "x * 1e18");
                ConversionFunctions.Add(ElectricPotentialDcUnit.Petavoltdc, "x * 1e15");
                ConversionFunctions.Add(ElectricPotentialDcUnit.Teravoltdc, "x * 1e12");
                ConversionFunctions.Add(ElectricPotentialDcUnit.Gigavoltdc, "x * 1e9");
                ConversionFunctions.Add(ElectricPotentialDcUnit.Megavoltdc, "x * 1e6");
                ConversionFunctions.Add(ElectricPotentialDcUnit.Kilovoltdc, "x * 1e3");
                ConversionFunctions.Add(ElectricPotentialDcUnit.Hectovoltdc, "x * 1e2");
                ConversionFunctions.Add(ElectricPotentialDcUnit.Dekavoltdc, "x * 1e1");
                ConversionFunctions.Add(ElectricPotentialDcUnit.VoltDc, "x * 1e0");
                ConversionFunctions.Add(ElectricPotentialDcUnit.Decivoltdc, "x * 1e-1");
                ConversionFunctions.Add(ElectricPotentialDcUnit.Centivoltdc, "x * 1e-2");
                ConversionFunctions.Add(ElectricPotentialDcUnit.Millivoltdc, "x * 1e-3");
                ConversionFunctions.Add(ElectricPotentialDcUnit.Microvoltdc, "x * 1e-6");
                ConversionFunctions.Add(ElectricPotentialDcUnit.Nanovoltdc, "x * 1e-9");
                ConversionFunctions.Add(ElectricPotentialDcUnit.Picovoltdc, "x * 1e-12");
                ConversionFunctions.Add(ElectricPotentialDcUnit.Femtovoltdc, "x * 1e-15");
                ConversionFunctions.Add(ElectricPotentialDcUnit.Attovoltdc, "x * 1e-18");
                ConversionFunctions.Add(ElectricPotentialDcUnit.Zeptovoltdc, "x * 1e-21");
                ConversionFunctions.Add(ElectricPotentialDcUnit.Yoctovoltdc, "x * 1e-24");
            }
        }
    }
