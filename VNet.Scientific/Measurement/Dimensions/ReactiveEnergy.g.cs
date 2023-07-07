
    // Auto-generated for VNet on 2023-07-06 12:42:23
    using System.Numerics;
    
    
    namespace VNet.Scientific.Measurement.Dimensions
    {
        public sealed class ReactiveEnergy<TVal> : DimensionBase<ReactiveEnergyUnit, TVal> where TVal : notnull, INumber<TVal>
        {
            public override string IdTag => nameof(ReactiveEnergy<TVal>);
            
            public ReactiveEnergy() : base()
            {
                Exponents.Length = 2;
                Exponents.Mass = 1;
                Exponents.Time = -1;
                Exponents.ElectricalCurrent = 0;
                Exponents.LuminousIntensity = 0;
                Exponents.Temperature = 0;
                Exponents.Amount = 0;
                
                DefaultUnit = ReactiveEnergyUnit.VoltampereReactiveHour;
                
                Symbols.Add(ReactiveEnergyUnit.Yottavoltamperereactivehour, "Yvarh");
                Symbols.Add(ReactiveEnergyUnit.Zettavoltamperereactivehour, "Zvarh");
                Symbols.Add(ReactiveEnergyUnit.Exavoltamperereactivehour, "Evarh");
                Symbols.Add(ReactiveEnergyUnit.Petavoltamperereactivehour, "Pvarh");
                Symbols.Add(ReactiveEnergyUnit.Teravoltamperereactivehour, "Tvarh");
                Symbols.Add(ReactiveEnergyUnit.Gigavoltamperereactivehour, "Gvarh");
                Symbols.Add(ReactiveEnergyUnit.Megavoltamperereactivehour, "Mvarh");
                Symbols.Add(ReactiveEnergyUnit.Kilovoltamperereactivehour, "kvarh");
                Symbols.Add(ReactiveEnergyUnit.Hectovoltamperereactivehour, "hvarh");
                Symbols.Add(ReactiveEnergyUnit.Dekavoltamperereactivehour, "davarh");
                Symbols.Add(ReactiveEnergyUnit.VoltampereReactiveHour, "varh");
                Symbols.Add(ReactiveEnergyUnit.Decivoltamperereactivehour, "dvarh");
                Symbols.Add(ReactiveEnergyUnit.Centivoltamperereactivehour, "cvarh");
                Symbols.Add(ReactiveEnergyUnit.Millivoltamperereactivehour, "mvarh");
                Symbols.Add(ReactiveEnergyUnit.Microvoltamperereactivehour, "µvarh");
                Symbols.Add(ReactiveEnergyUnit.Nanovoltamperereactivehour, "nvarh");
                Symbols.Add(ReactiveEnergyUnit.Picovoltamperereactivehour, "pvarh");
                Symbols.Add(ReactiveEnergyUnit.Femtovoltamperereactivehour, "fvarh");
                Symbols.Add(ReactiveEnergyUnit.Attovoltamperereactivehour, "avarh");
                Symbols.Add(ReactiveEnergyUnit.Zeptovoltamperereactivehour, "zvarh");
                Symbols.Add(ReactiveEnergyUnit.Yoctovoltamperereactivehour, "yvarh");
                
                
                ConversionFunctions.Add(ReactiveEnergyUnit.Yottavoltamperereactivehour, "x * 1e24");
                ConversionFunctions.Add(ReactiveEnergyUnit.Zettavoltamperereactivehour, "x * 1e21");
                ConversionFunctions.Add(ReactiveEnergyUnit.Exavoltamperereactivehour, "x * 1e18");
                ConversionFunctions.Add(ReactiveEnergyUnit.Petavoltamperereactivehour, "x * 1e15");
                ConversionFunctions.Add(ReactiveEnergyUnit.Teravoltamperereactivehour, "x * 1e12");
                ConversionFunctions.Add(ReactiveEnergyUnit.Gigavoltamperereactivehour, "x * 1e9");
                ConversionFunctions.Add(ReactiveEnergyUnit.Megavoltamperereactivehour, "x * 1e6");
                ConversionFunctions.Add(ReactiveEnergyUnit.Kilovoltamperereactivehour, "x * 1e3");
                ConversionFunctions.Add(ReactiveEnergyUnit.Hectovoltamperereactivehour, "x * 1e2");
                ConversionFunctions.Add(ReactiveEnergyUnit.Dekavoltamperereactivehour, "x * 1e1");
                ConversionFunctions.Add(ReactiveEnergyUnit.VoltampereReactiveHour, "x * 1e0");
                ConversionFunctions.Add(ReactiveEnergyUnit.Decivoltamperereactivehour, "x * 1e-1");
                ConversionFunctions.Add(ReactiveEnergyUnit.Centivoltamperereactivehour, "x * 1e-2");
                ConversionFunctions.Add(ReactiveEnergyUnit.Millivoltamperereactivehour, "x * 1e-3");
                ConversionFunctions.Add(ReactiveEnergyUnit.Microvoltamperereactivehour, "x * 1e-6");
                ConversionFunctions.Add(ReactiveEnergyUnit.Nanovoltamperereactivehour, "x * 1e-9");
                ConversionFunctions.Add(ReactiveEnergyUnit.Picovoltamperereactivehour, "x * 1e-12");
                ConversionFunctions.Add(ReactiveEnergyUnit.Femtovoltamperereactivehour, "x * 1e-15");
                ConversionFunctions.Add(ReactiveEnergyUnit.Attovoltamperereactivehour, "x * 1e-18");
                ConversionFunctions.Add(ReactiveEnergyUnit.Zeptovoltamperereactivehour, "x * 1e-21");
                ConversionFunctions.Add(ReactiveEnergyUnit.Yoctovoltamperereactivehour, "x * 1e-24");
            }
        }
    }
