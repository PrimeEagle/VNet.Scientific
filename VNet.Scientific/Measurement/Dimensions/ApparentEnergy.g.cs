
    // Auto-generated for VNet on 2023-07-05 10:35:43
    using System.Numerics;
    
    
    namespace VNet.Scientific.Measurement.Dimensions
    {
        public sealed class ApparentEnergy<TVal> : DimensionBase<ApparentEnergyUnit, TVal> where TVal : notnull, INumber<TVal>
        {
            public override string IdTag => nameof(ApparentEnergy<TVal>);
            
            public ApparentEnergy() : base()
            {
                DimensionComponent.Exponents.Length = 2;
                DimensionComponent.Exponents.Mass = 1;
                DimensionComponent.Exponents.Time = -2;
                DimensionComponent.Exponents.ElectricalCurrent = 0;
                DimensionComponent.Exponents.LuminousIntensity = 0;
                DimensionComponent.Exponents.Temperature = 0;
                DimensionComponent.Exponents.Amount = 0;
                
                DefaultUnit = ApparentEnergyUnit.VoltampereHour;
                
                Symbols.Add(ApparentEnergyUnit.Yottavoltamperehour, "YVAh");
                Symbols.Add(ApparentEnergyUnit.Zettavoltamperehour, "ZVAh");
                Symbols.Add(ApparentEnergyUnit.Exavoltamperehour, "EVAh");
                Symbols.Add(ApparentEnergyUnit.Petavoltamperehour, "PVAh");
                Symbols.Add(ApparentEnergyUnit.Teravoltamperehour, "TVAh");
                Symbols.Add(ApparentEnergyUnit.Gigavoltamperehour, "GVAh");
                Symbols.Add(ApparentEnergyUnit.Megavoltamperehour, "MVAh");
                Symbols.Add(ApparentEnergyUnit.Kilovoltamperehour, "kVAh");
                Symbols.Add(ApparentEnergyUnit.Hectovoltamperehour, "hVAh");
                Symbols.Add(ApparentEnergyUnit.Dekavoltamperehour, "daVAh");
                Symbols.Add(ApparentEnergyUnit.VoltampereHour, "VAh");
                Symbols.Add(ApparentEnergyUnit.Decivoltamperehour, "dVAh");
                Symbols.Add(ApparentEnergyUnit.Centivoltamperehour, "cVAh");
                Symbols.Add(ApparentEnergyUnit.Millivoltamperehour, "mVAh");
                Symbols.Add(ApparentEnergyUnit.Microvoltamperehour, "µVAh");
                Symbols.Add(ApparentEnergyUnit.Nanovoltamperehour, "nVAh");
                Symbols.Add(ApparentEnergyUnit.Picovoltamperehour, "pVAh");
                Symbols.Add(ApparentEnergyUnit.Femtovoltamperehour, "fVAh");
                Symbols.Add(ApparentEnergyUnit.Attovoltamperehour, "aVAh");
                Symbols.Add(ApparentEnergyUnit.Zeptovoltamperehour, "zVAh");
                Symbols.Add(ApparentEnergyUnit.Yoctovoltamperehour, "yVAh");
                
                
                ConversionFunctions.Add(ApparentEnergyUnit.Yottavoltamperehour, "x * 1e24");
                ConversionFunctions.Add(ApparentEnergyUnit.Zettavoltamperehour, "x * 1e21");
                ConversionFunctions.Add(ApparentEnergyUnit.Exavoltamperehour, "x * 1e18");
                ConversionFunctions.Add(ApparentEnergyUnit.Petavoltamperehour, "x * 1e15");
                ConversionFunctions.Add(ApparentEnergyUnit.Teravoltamperehour, "x * 1e12");
                ConversionFunctions.Add(ApparentEnergyUnit.Gigavoltamperehour, "x * 1e9");
                ConversionFunctions.Add(ApparentEnergyUnit.Megavoltamperehour, "x * 1e6");
                ConversionFunctions.Add(ApparentEnergyUnit.Kilovoltamperehour, "x * 1e3");
                ConversionFunctions.Add(ApparentEnergyUnit.Hectovoltamperehour, "x * 1e2");
                ConversionFunctions.Add(ApparentEnergyUnit.Dekavoltamperehour, "x * 1e1");
                ConversionFunctions.Add(ApparentEnergyUnit.VoltampereHour, "x * 1e0");
                ConversionFunctions.Add(ApparentEnergyUnit.Decivoltamperehour, "x * 1e-1");
                ConversionFunctions.Add(ApparentEnergyUnit.Centivoltamperehour, "x * 1e-2");
                ConversionFunctions.Add(ApparentEnergyUnit.Millivoltamperehour, "x * 1e-3");
                ConversionFunctions.Add(ApparentEnergyUnit.Microvoltamperehour, "x * 1e-6");
                ConversionFunctions.Add(ApparentEnergyUnit.Nanovoltamperehour, "x * 1e-9");
                ConversionFunctions.Add(ApparentEnergyUnit.Picovoltamperehour, "x * 1e-12");
                ConversionFunctions.Add(ApparentEnergyUnit.Femtovoltamperehour, "x * 1e-15");
                ConversionFunctions.Add(ApparentEnergyUnit.Attovoltamperehour, "x * 1e-18");
                ConversionFunctions.Add(ApparentEnergyUnit.Zeptovoltamperehour, "x * 1e-21");
                ConversionFunctions.Add(ApparentEnergyUnit.Yoctovoltamperehour, "x * 1e-24");
            }
        }
    }
