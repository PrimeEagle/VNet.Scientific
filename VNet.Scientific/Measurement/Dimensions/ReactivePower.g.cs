
    // Auto-generated for VNet on 2023-07-06 12:42:23
    using System.Numerics;
    
    
    namespace VNet.Scientific.Measurement.Dimensions
    {
        public sealed class ReactivePower<TVal> : DimensionBase<ReactivePowerUnit, TVal> where TVal : notnull, INumber<TVal>
        {
            public override string IdTag => nameof(ReactivePower<TVal>);
            
            public ReactivePower() : base()
            {
                Exponents.Length = 2;
                Exponents.Mass = 1;
                Exponents.Time = -3;
                Exponents.ElectricalCurrent = 0;
                Exponents.LuminousIntensity = 0;
                Exponents.Temperature = 0;
                Exponents.Amount = 0;
                
                DefaultUnit = ReactivePowerUnit.VoltampereReactive;
                
                Symbols.Add(ReactivePowerUnit.Yottavoltamperereactive, "Yvar");
                Symbols.Add(ReactivePowerUnit.Zettavoltamperereactive, "Zvar");
                Symbols.Add(ReactivePowerUnit.Exavoltamperereactive, "Evar");
                Symbols.Add(ReactivePowerUnit.Petavoltamperereactive, "Pvar");
                Symbols.Add(ReactivePowerUnit.Teravoltamperereactive, "Tvar");
                Symbols.Add(ReactivePowerUnit.Gigavoltamperereactive, "Gvar");
                Symbols.Add(ReactivePowerUnit.Megavoltamperereactive, "Mvar");
                Symbols.Add(ReactivePowerUnit.Kilovoltamperereactive, "kvar");
                Symbols.Add(ReactivePowerUnit.Hectovoltamperereactive, "hvar");
                Symbols.Add(ReactivePowerUnit.Dekavoltamperereactive, "davar");
                Symbols.Add(ReactivePowerUnit.VoltampereReactive, "var");
                Symbols.Add(ReactivePowerUnit.Decivoltamperereactive, "dvar");
                Symbols.Add(ReactivePowerUnit.Centivoltamperereactive, "cvar");
                Symbols.Add(ReactivePowerUnit.Millivoltamperereactive, "mvar");
                Symbols.Add(ReactivePowerUnit.Microvoltamperereactive, "µvar");
                Symbols.Add(ReactivePowerUnit.Nanovoltamperereactive, "nvar");
                Symbols.Add(ReactivePowerUnit.Picovoltamperereactive, "pvar");
                Symbols.Add(ReactivePowerUnit.Femtovoltamperereactive, "fvar");
                Symbols.Add(ReactivePowerUnit.Attovoltamperereactive, "avar");
                Symbols.Add(ReactivePowerUnit.Zeptovoltamperereactive, "zvar");
                Symbols.Add(ReactivePowerUnit.Yoctovoltamperereactive, "yvar");
                
                
                ConversionFunctions.Add(ReactivePowerUnit.Yottavoltamperereactive, "x * 1e24");
                ConversionFunctions.Add(ReactivePowerUnit.Zettavoltamperereactive, "x * 1e21");
                ConversionFunctions.Add(ReactivePowerUnit.Exavoltamperereactive, "x * 1e18");
                ConversionFunctions.Add(ReactivePowerUnit.Petavoltamperereactive, "x * 1e15");
                ConversionFunctions.Add(ReactivePowerUnit.Teravoltamperereactive, "x * 1e12");
                ConversionFunctions.Add(ReactivePowerUnit.Gigavoltamperereactive, "x * 1e9");
                ConversionFunctions.Add(ReactivePowerUnit.Megavoltamperereactive, "x * 1e6");
                ConversionFunctions.Add(ReactivePowerUnit.Kilovoltamperereactive, "x * 1e3");
                ConversionFunctions.Add(ReactivePowerUnit.Hectovoltamperereactive, "x * 1e2");
                ConversionFunctions.Add(ReactivePowerUnit.Dekavoltamperereactive, "x * 1e1");
                ConversionFunctions.Add(ReactivePowerUnit.VoltampereReactive, "x * 1e0");
                ConversionFunctions.Add(ReactivePowerUnit.Decivoltamperereactive, "x * 1e-1");
                ConversionFunctions.Add(ReactivePowerUnit.Centivoltamperereactive, "x * 1e-2");
                ConversionFunctions.Add(ReactivePowerUnit.Millivoltamperereactive, "x * 1e-3");
                ConversionFunctions.Add(ReactivePowerUnit.Microvoltamperereactive, "x * 1e-6");
                ConversionFunctions.Add(ReactivePowerUnit.Nanovoltamperereactive, "x * 1e-9");
                ConversionFunctions.Add(ReactivePowerUnit.Picovoltamperereactive, "x * 1e-12");
                ConversionFunctions.Add(ReactivePowerUnit.Femtovoltamperereactive, "x * 1e-15");
                ConversionFunctions.Add(ReactivePowerUnit.Attovoltamperereactive, "x * 1e-18");
                ConversionFunctions.Add(ReactivePowerUnit.Zeptovoltamperereactive, "x * 1e-21");
                ConversionFunctions.Add(ReactivePowerUnit.Yoctovoltamperereactive, "x * 1e-24");
            }
        }
    }
