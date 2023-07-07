
    // Auto-generated for VNet on 2023-07-06 12:42:23
    using System.Numerics;
    
    
    namespace VNet.Scientific.Measurement.Dimensions
    {
        public sealed class ThermalConductivity<TVal> : DimensionBase<ThermalConductivityUnit, TVal> where TVal : notnull, INumber<TVal>
        {
            public override string IdTag => nameof(ThermalConductivity<TVal>);
            
            public ThermalConductivity() : base()
            {
                Exponents.Length = 1;
                Exponents.Mass = 1;
                Exponents.Time = -3;
                Exponents.ElectricalCurrent = 0;
                Exponents.LuminousIntensity = 0;
                Exponents.Temperature = -1;
                Exponents.Amount = 0;
                
                DefaultUnit = ThermalConductivityUnit.WattPerMeterKelvin;
                
                Symbols.Add(ThermalConductivityUnit.BtuPerHourFootFahrenheit, "BTU/h·ft·°F");
                Symbols.Add(ThermalConductivityUnit.Yottawattpermeterkelvin, "YW/m·K");
                Symbols.Add(ThermalConductivityUnit.Zettawattpermeterkelvin, "ZW/m·K");
                Symbols.Add(ThermalConductivityUnit.Exawattpermeterkelvin, "EW/m·K");
                Symbols.Add(ThermalConductivityUnit.Petawattpermeterkelvin, "PW/m·K");
                Symbols.Add(ThermalConductivityUnit.Terawattpermeterkelvin, "TW/m·K");
                Symbols.Add(ThermalConductivityUnit.Gigawattpermeterkelvin, "GW/m·K");
                Symbols.Add(ThermalConductivityUnit.Megawattpermeterkelvin, "MW/m·K");
                Symbols.Add(ThermalConductivityUnit.Kilowattpermeterkelvin, "kW/m·K");
                Symbols.Add(ThermalConductivityUnit.Hectowattpermeterkelvin, "hW/m·K");
                Symbols.Add(ThermalConductivityUnit.Dekawattpermeterkelvin, "daW/m·K");
                Symbols.Add(ThermalConductivityUnit.WattPerMeterKelvin, "W/m·K");
                Symbols.Add(ThermalConductivityUnit.Deciwattpermeterkelvin, "dW/m·K");
                Symbols.Add(ThermalConductivityUnit.Centiwattpermeterkelvin, "cW/m·K");
                Symbols.Add(ThermalConductivityUnit.Milliwattpermeterkelvin, "mW/m·K");
                Symbols.Add(ThermalConductivityUnit.Microwattpermeterkelvin, "µW/m·K");
                Symbols.Add(ThermalConductivityUnit.Nanowattpermeterkelvin, "nW/m·K");
                Symbols.Add(ThermalConductivityUnit.Picowattpermeterkelvin, "pW/m·K");
                Symbols.Add(ThermalConductivityUnit.Femtowattpermeterkelvin, "fW/m·K");
                Symbols.Add(ThermalConductivityUnit.Attowattpermeterkelvin, "aW/m·K");
                Symbols.Add(ThermalConductivityUnit.Zeptowattpermeterkelvin, "zW/m·K");
                Symbols.Add(ThermalConductivityUnit.Yoctowattpermeterkelvin, "yW/m·K");
                
                
                ConversionFunctions.Add(ThermalConductivityUnit.BtuPerHourFootFahrenheit, "x * 1.73073467");
                ConversionFunctions.Add(ThermalConductivityUnit.Yottawattpermeterkelvin, "x * 1e24");
                ConversionFunctions.Add(ThermalConductivityUnit.Zettawattpermeterkelvin, "x * 1e21");
                ConversionFunctions.Add(ThermalConductivityUnit.Exawattpermeterkelvin, "x * 1e18");
                ConversionFunctions.Add(ThermalConductivityUnit.Petawattpermeterkelvin, "x * 1e15");
                ConversionFunctions.Add(ThermalConductivityUnit.Terawattpermeterkelvin, "x * 1e12");
                ConversionFunctions.Add(ThermalConductivityUnit.Gigawattpermeterkelvin, "x * 1e9");
                ConversionFunctions.Add(ThermalConductivityUnit.Megawattpermeterkelvin, "x * 1e6");
                ConversionFunctions.Add(ThermalConductivityUnit.Kilowattpermeterkelvin, "x * 1e3");
                ConversionFunctions.Add(ThermalConductivityUnit.Hectowattpermeterkelvin, "x * 1e2");
                ConversionFunctions.Add(ThermalConductivityUnit.Dekawattpermeterkelvin, "x * 1e1");
                ConversionFunctions.Add(ThermalConductivityUnit.WattPerMeterKelvin, "x * 1e0");
                ConversionFunctions.Add(ThermalConductivityUnit.Deciwattpermeterkelvin, "x * 1e-1");
                ConversionFunctions.Add(ThermalConductivityUnit.Centiwattpermeterkelvin, "x * 1e-2");
                ConversionFunctions.Add(ThermalConductivityUnit.Milliwattpermeterkelvin, "x * 1e-3");
                ConversionFunctions.Add(ThermalConductivityUnit.Microwattpermeterkelvin, "x * 1e-6");
                ConversionFunctions.Add(ThermalConductivityUnit.Nanowattpermeterkelvin, "x * 1e-9");
                ConversionFunctions.Add(ThermalConductivityUnit.Picowattpermeterkelvin, "x * 1e-12");
                ConversionFunctions.Add(ThermalConductivityUnit.Femtowattpermeterkelvin, "x * 1e-15");
                ConversionFunctions.Add(ThermalConductivityUnit.Attowattpermeterkelvin, "x * 1e-18");
                ConversionFunctions.Add(ThermalConductivityUnit.Zeptowattpermeterkelvin, "x * 1e-21");
                ConversionFunctions.Add(ThermalConductivityUnit.Yoctowattpermeterkelvin, "x * 1e-24");
            }
        }
    }
