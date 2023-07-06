
    // Auto-generated for VNet on 2023-07-05 10:35:43
    using System.Numerics;
    
    
    namespace VNet.Scientific.Measurement.Dimensions
    {
        public sealed class PowerDensity<TVal> : DimensionBase<PowerDensityUnit, TVal> where TVal : notnull, INumber<TVal>
        {
            public override string IdTag => nameof(PowerDensity<TVal>);
            
            public PowerDensity() : base()
            {
                DimensionComponent.Exponents.Length = -1;
                DimensionComponent.Exponents.Mass = 1;
                DimensionComponent.Exponents.Time = -3;
                DimensionComponent.Exponents.ElectricalCurrent = 0;
                DimensionComponent.Exponents.LuminousIntensity = 0;
                DimensionComponent.Exponents.Temperature = 0;
                DimensionComponent.Exponents.Amount = 0;
                
                DefaultUnit = PowerDensityUnit.WattPerCubicMeter;
                
                Symbols.Add(PowerDensityUnit.WattPerCubicInch, "W/in³");
                Symbols.Add(PowerDensityUnit.WattPerCubicFoot, "W/ft³");
                Symbols.Add(PowerDensityUnit.WattPerLiter, "W/l");
                Symbols.Add(PowerDensityUnit.Yottawattpercubicmeter, "YW/m³");
                Symbols.Add(PowerDensityUnit.Zettawattpercubicmeter, "ZW/m³");
                Symbols.Add(PowerDensityUnit.Exawattpercubicmeter, "EW/m³");
                Symbols.Add(PowerDensityUnit.Petawattpercubicmeter, "PW/m³");
                Symbols.Add(PowerDensityUnit.Terawattpercubicmeter, "TW/m³");
                Symbols.Add(PowerDensityUnit.Gigawattpercubicmeter, "GW/m³");
                Symbols.Add(PowerDensityUnit.Megawattpercubicmeter, "MW/m³");
                Symbols.Add(PowerDensityUnit.Kilowattpercubicmeter, "kW/m³");
                Symbols.Add(PowerDensityUnit.Hectowattpercubicmeter, "hW/m³");
                Symbols.Add(PowerDensityUnit.Dekawattpercubicmeter, "daW/m³");
                Symbols.Add(PowerDensityUnit.WattPerCubicMeter, "W/m³");
                Symbols.Add(PowerDensityUnit.Deciwattpercubicmeter, "dW/m³");
                Symbols.Add(PowerDensityUnit.Centiwattpercubicmeter, "cW/m³");
                Symbols.Add(PowerDensityUnit.Milliwattpercubicmeter, "mW/m³");
                Symbols.Add(PowerDensityUnit.Microwattpercubicmeter, "µW/m³");
                Symbols.Add(PowerDensityUnit.Nanowattpercubicmeter, "nW/m³");
                Symbols.Add(PowerDensityUnit.Picowattpercubicmeter, "pW/m³");
                Symbols.Add(PowerDensityUnit.Femtowattpercubicmeter, "fW/m³");
                Symbols.Add(PowerDensityUnit.Attowattpercubicmeter, "aW/m³");
                Symbols.Add(PowerDensityUnit.Zeptowattpercubicmeter, "zW/m³");
                Symbols.Add(PowerDensityUnit.Yoctowattpercubicmeter, "yW/m³");
                
                
                ConversionFunctions.Add(PowerDensityUnit.WattPerCubicInch, "x * 6.102374409473228e4");
                ConversionFunctions.Add(PowerDensityUnit.WattPerCubicFoot, "x * 3.531466672148859e1");
                ConversionFunctions.Add(PowerDensityUnit.WattPerLiter, "x * 1.0e3");
                ConversionFunctions.Add(PowerDensityUnit.Yottawattpercubicmeter, "x * 1e24");
                ConversionFunctions.Add(PowerDensityUnit.Zettawattpercubicmeter, "x * 1e21");
                ConversionFunctions.Add(PowerDensityUnit.Exawattpercubicmeter, "x * 1e18");
                ConversionFunctions.Add(PowerDensityUnit.Petawattpercubicmeter, "x * 1e15");
                ConversionFunctions.Add(PowerDensityUnit.Terawattpercubicmeter, "x * 1e12");
                ConversionFunctions.Add(PowerDensityUnit.Gigawattpercubicmeter, "x * 1e9");
                ConversionFunctions.Add(PowerDensityUnit.Megawattpercubicmeter, "x * 1e6");
                ConversionFunctions.Add(PowerDensityUnit.Kilowattpercubicmeter, "x * 1e3");
                ConversionFunctions.Add(PowerDensityUnit.Hectowattpercubicmeter, "x * 1e2");
                ConversionFunctions.Add(PowerDensityUnit.Dekawattpercubicmeter, "x * 1e1");
                ConversionFunctions.Add(PowerDensityUnit.WattPerCubicMeter, "x * 1e0");
                ConversionFunctions.Add(PowerDensityUnit.Deciwattpercubicmeter, "x * 1e-1");
                ConversionFunctions.Add(PowerDensityUnit.Centiwattpercubicmeter, "x * 1e-2");
                ConversionFunctions.Add(PowerDensityUnit.Milliwattpercubicmeter, "x * 1e-3");
                ConversionFunctions.Add(PowerDensityUnit.Microwattpercubicmeter, "x * 1e-6");
                ConversionFunctions.Add(PowerDensityUnit.Nanowattpercubicmeter, "x * 1e-9");
                ConversionFunctions.Add(PowerDensityUnit.Picowattpercubicmeter, "x * 1e-12");
                ConversionFunctions.Add(PowerDensityUnit.Femtowattpercubicmeter, "x * 1e-15");
                ConversionFunctions.Add(PowerDensityUnit.Attowattpercubicmeter, "x * 1e-18");
                ConversionFunctions.Add(PowerDensityUnit.Zeptowattpercubicmeter, "x * 1e-21");
                ConversionFunctions.Add(PowerDensityUnit.Yoctowattpercubicmeter, "x * 1e-24");
            }
        }
    }
