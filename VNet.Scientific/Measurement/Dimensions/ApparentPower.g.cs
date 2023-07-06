
    // Auto-generated for VNet on 2023-07-05 10:35:43
    using System.Numerics;
    
    
    namespace VNet.Scientific.Measurement.Dimensions
    {
        public sealed class ApparentPower<TVal> : DimensionBase<ApparentPowerUnit, TVal> where TVal : notnull, INumber<TVal>
        {
            public override string IdTag => nameof(ApparentPower<TVal>);
            
            public ApparentPower() : base()
            {
                DimensionComponent.Exponents.Length = 2;
                DimensionComponent.Exponents.Mass = 1;
                DimensionComponent.Exponents.Time = -3;
                DimensionComponent.Exponents.ElectricalCurrent = 0;
                DimensionComponent.Exponents.LuminousIntensity = 0;
                DimensionComponent.Exponents.Temperature = 0;
                DimensionComponent.Exponents.Amount = 0;
                
                DefaultUnit = ApparentPowerUnit.Voltampere;
                
                Symbols.Add(ApparentPowerUnit.Yottavoltampere, "YVA");
                Symbols.Add(ApparentPowerUnit.Zettavoltampere, "ZVA");
                Symbols.Add(ApparentPowerUnit.Exavoltampere, "EVA");
                Symbols.Add(ApparentPowerUnit.Petavoltampere, "PVA");
                Symbols.Add(ApparentPowerUnit.Teravoltampere, "TVA");
                Symbols.Add(ApparentPowerUnit.Gigavoltampere, "GVA");
                Symbols.Add(ApparentPowerUnit.Megavoltampere, "MVA");
                Symbols.Add(ApparentPowerUnit.Kilovoltampere, "kVA");
                Symbols.Add(ApparentPowerUnit.Hectovoltampere, "hVA");
                Symbols.Add(ApparentPowerUnit.Dekavoltampere, "daVA");
                Symbols.Add(ApparentPowerUnit.Voltampere, "VA");
                Symbols.Add(ApparentPowerUnit.Decivoltampere, "dVA");
                Symbols.Add(ApparentPowerUnit.Centivoltampere, "cVA");
                Symbols.Add(ApparentPowerUnit.Millivoltampere, "mVA");
                Symbols.Add(ApparentPowerUnit.Microvoltampere, "µVA");
                Symbols.Add(ApparentPowerUnit.Nanovoltampere, "nVA");
                Symbols.Add(ApparentPowerUnit.Picovoltampere, "pVA");
                Symbols.Add(ApparentPowerUnit.Femtovoltampere, "fVA");
                Symbols.Add(ApparentPowerUnit.Attovoltampere, "aVA");
                Symbols.Add(ApparentPowerUnit.Zeptovoltampere, "zVA");
                Symbols.Add(ApparentPowerUnit.Yoctovoltampere, "yVA");
                
                
                ConversionFunctions.Add(ApparentPowerUnit.Yottavoltampere, "x * 1e24");
                ConversionFunctions.Add(ApparentPowerUnit.Zettavoltampere, "x * 1e21");
                ConversionFunctions.Add(ApparentPowerUnit.Exavoltampere, "x * 1e18");
                ConversionFunctions.Add(ApparentPowerUnit.Petavoltampere, "x * 1e15");
                ConversionFunctions.Add(ApparentPowerUnit.Teravoltampere, "x * 1e12");
                ConversionFunctions.Add(ApparentPowerUnit.Gigavoltampere, "x * 1e9");
                ConversionFunctions.Add(ApparentPowerUnit.Megavoltampere, "x * 1e6");
                ConversionFunctions.Add(ApparentPowerUnit.Kilovoltampere, "x * 1e3");
                ConversionFunctions.Add(ApparentPowerUnit.Hectovoltampere, "x * 1e2");
                ConversionFunctions.Add(ApparentPowerUnit.Dekavoltampere, "x * 1e1");
                ConversionFunctions.Add(ApparentPowerUnit.Voltampere, "x * 1e0");
                ConversionFunctions.Add(ApparentPowerUnit.Decivoltampere, "x * 1e-1");
                ConversionFunctions.Add(ApparentPowerUnit.Centivoltampere, "x * 1e-2");
                ConversionFunctions.Add(ApparentPowerUnit.Millivoltampere, "x * 1e-3");
                ConversionFunctions.Add(ApparentPowerUnit.Microvoltampere, "x * 1e-6");
                ConversionFunctions.Add(ApparentPowerUnit.Nanovoltampere, "x * 1e-9");
                ConversionFunctions.Add(ApparentPowerUnit.Picovoltampere, "x * 1e-12");
                ConversionFunctions.Add(ApparentPowerUnit.Femtovoltampere, "x * 1e-15");
                ConversionFunctions.Add(ApparentPowerUnit.Attovoltampere, "x * 1e-18");
                ConversionFunctions.Add(ApparentPowerUnit.Zeptovoltampere, "x * 1e-21");
                ConversionFunctions.Add(ApparentPowerUnit.Yoctovoltampere, "x * 1e-24");
            }
        }
    }
