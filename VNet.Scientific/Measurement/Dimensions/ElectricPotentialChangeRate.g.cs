
    // Auto-generated for VNet on 2023-07-05 10:35:43
    using System.Numerics;
    
    
    namespace VNet.Scientific.Measurement.Dimensions
    {
        public sealed class ElectricPotentialChangeRate<TVal> : DimensionBase<ElectricPotentialChangeRateUnit, TVal> where TVal : notnull, INumber<TVal>
        {
            public override string IdTag => nameof(ElectricPotentialChangeRate<TVal>);
            
            public ElectricPotentialChangeRate() : base()
            {
                DimensionComponent.Exponents.Length = 2;
                DimensionComponent.Exponents.Mass = 1;
                DimensionComponent.Exponents.Time = -4;
                DimensionComponent.Exponents.ElectricalCurrent = -1;
                DimensionComponent.Exponents.LuminousIntensity = 0;
                DimensionComponent.Exponents.Temperature = 0;
                DimensionComponent.Exponents.Amount = 0;
                
                DefaultUnit = ElectricPotentialChangeRateUnit.VoltPerSecond;
                
                Symbols.Add(ElectricPotentialChangeRateUnit.VoltPerMicrosecond, "V/μs");
                Symbols.Add(ElectricPotentialChangeRateUnit.VoltPerMinute, "V/min");
                Symbols.Add(ElectricPotentialChangeRateUnit.VoltPerHour, "V/h");
                Symbols.Add(ElectricPotentialChangeRateUnit.Yottavoltpersecond, "YV/s");
                Symbols.Add(ElectricPotentialChangeRateUnit.Zettavoltpersecond, "ZV/s");
                Symbols.Add(ElectricPotentialChangeRateUnit.Exavoltpersecond, "EV/s");
                Symbols.Add(ElectricPotentialChangeRateUnit.Petavoltpersecond, "PV/s");
                Symbols.Add(ElectricPotentialChangeRateUnit.Teravoltpersecond, "TV/s");
                Symbols.Add(ElectricPotentialChangeRateUnit.Gigavoltpersecond, "GV/s");
                Symbols.Add(ElectricPotentialChangeRateUnit.Megavoltpersecond, "MV/s");
                Symbols.Add(ElectricPotentialChangeRateUnit.Kilovoltpersecond, "kV/s");
                Symbols.Add(ElectricPotentialChangeRateUnit.Hectovoltpersecond, "hV/s");
                Symbols.Add(ElectricPotentialChangeRateUnit.Dekavoltpersecond, "daV/s");
                Symbols.Add(ElectricPotentialChangeRateUnit.VoltPerSecond, "V/s");
                Symbols.Add(ElectricPotentialChangeRateUnit.Decivoltpersecond, "dV/s");
                Symbols.Add(ElectricPotentialChangeRateUnit.Centivoltpersecond, "cV/s");
                Symbols.Add(ElectricPotentialChangeRateUnit.Millivoltpersecond, "mV/s");
                Symbols.Add(ElectricPotentialChangeRateUnit.Microvoltpersecond, "µV/s");
                Symbols.Add(ElectricPotentialChangeRateUnit.Nanovoltpersecond, "nV/s");
                Symbols.Add(ElectricPotentialChangeRateUnit.Picovoltpersecond, "pV/s");
                Symbols.Add(ElectricPotentialChangeRateUnit.Femtovoltpersecond, "fV/s");
                Symbols.Add(ElectricPotentialChangeRateUnit.Attovoltpersecond, "aV/s");
                Symbols.Add(ElectricPotentialChangeRateUnit.Zeptovoltpersecond, "zV/s");
                Symbols.Add(ElectricPotentialChangeRateUnit.Yoctovoltpersecond, "yV/s");
                
                
                ConversionFunctions.Add(ElectricPotentialChangeRateUnit.VoltPerMicrosecond, "x * 1E6");
                ConversionFunctions.Add(ElectricPotentialChangeRateUnit.VoltPerMinute, "x / 60");
                ConversionFunctions.Add(ElectricPotentialChangeRateUnit.VoltPerHour, "x / 3600");
                ConversionFunctions.Add(ElectricPotentialChangeRateUnit.Yottavoltpersecond, "x * 1e24");
                ConversionFunctions.Add(ElectricPotentialChangeRateUnit.Zettavoltpersecond, "x * 1e21");
                ConversionFunctions.Add(ElectricPotentialChangeRateUnit.Exavoltpersecond, "x * 1e18");
                ConversionFunctions.Add(ElectricPotentialChangeRateUnit.Petavoltpersecond, "x * 1e15");
                ConversionFunctions.Add(ElectricPotentialChangeRateUnit.Teravoltpersecond, "x * 1e12");
                ConversionFunctions.Add(ElectricPotentialChangeRateUnit.Gigavoltpersecond, "x * 1e9");
                ConversionFunctions.Add(ElectricPotentialChangeRateUnit.Megavoltpersecond, "x * 1e6");
                ConversionFunctions.Add(ElectricPotentialChangeRateUnit.Kilovoltpersecond, "x * 1e3");
                ConversionFunctions.Add(ElectricPotentialChangeRateUnit.Hectovoltpersecond, "x * 1e2");
                ConversionFunctions.Add(ElectricPotentialChangeRateUnit.Dekavoltpersecond, "x * 1e1");
                ConversionFunctions.Add(ElectricPotentialChangeRateUnit.VoltPerSecond, "x * 1e0");
                ConversionFunctions.Add(ElectricPotentialChangeRateUnit.Decivoltpersecond, "x * 1e-1");
                ConversionFunctions.Add(ElectricPotentialChangeRateUnit.Centivoltpersecond, "x * 1e-2");
                ConversionFunctions.Add(ElectricPotentialChangeRateUnit.Millivoltpersecond, "x * 1e-3");
                ConversionFunctions.Add(ElectricPotentialChangeRateUnit.Microvoltpersecond, "x * 1e-6");
                ConversionFunctions.Add(ElectricPotentialChangeRateUnit.Nanovoltpersecond, "x * 1e-9");
                ConversionFunctions.Add(ElectricPotentialChangeRateUnit.Picovoltpersecond, "x * 1e-12");
                ConversionFunctions.Add(ElectricPotentialChangeRateUnit.Femtovoltpersecond, "x * 1e-15");
                ConversionFunctions.Add(ElectricPotentialChangeRateUnit.Attovoltpersecond, "x * 1e-18");
                ConversionFunctions.Add(ElectricPotentialChangeRateUnit.Zeptovoltpersecond, "x * 1e-21");
                ConversionFunctions.Add(ElectricPotentialChangeRateUnit.Yoctovoltpersecond, "x * 1e-24");
            }
        }
    }
