
    // Auto-generated for VNet on 2023-07-05 10:35:43
    using System.Numerics;
    
    
    namespace VNet.Scientific.Measurement.Dimensions
    {
        public sealed class LinearPowerDensity<TVal> : DimensionBase<LinearPowerDensityUnit, TVal> where TVal : notnull, INumber<TVal>
        {
            public override string IdTag => nameof(LinearPowerDensity<TVal>);
            
            public LinearPowerDensity() : base()
            {
                DimensionComponent.Exponents.Length = 1;
                DimensionComponent.Exponents.Mass = 1;
                DimensionComponent.Exponents.Time = -3;
                DimensionComponent.Exponents.ElectricalCurrent = 0;
                DimensionComponent.Exponents.LuminousIntensity = 0;
                DimensionComponent.Exponents.Temperature = 0;
                DimensionComponent.Exponents.Amount = 0;
                
                DefaultUnit = LinearPowerDensityUnit.WattPerMeter;
                
                Symbols.Add(LinearPowerDensityUnit.WattPerCentimeter, "W/cm");
                Symbols.Add(LinearPowerDensityUnit.WattPerMillimeter, "W/mm");
                Symbols.Add(LinearPowerDensityUnit.WattPerInch, "W/in");
                Symbols.Add(LinearPowerDensityUnit.WattPerFoot, "W/ft");
                Symbols.Add(LinearPowerDensityUnit.Yottawattpermeter, "YW/m");
                Symbols.Add(LinearPowerDensityUnit.Zettawattpermeter, "ZW/m");
                Symbols.Add(LinearPowerDensityUnit.Exawattpermeter, "EW/m");
                Symbols.Add(LinearPowerDensityUnit.Petawattpermeter, "PW/m");
                Symbols.Add(LinearPowerDensityUnit.Terawattpermeter, "TW/m");
                Symbols.Add(LinearPowerDensityUnit.Gigawattpermeter, "GW/m");
                Symbols.Add(LinearPowerDensityUnit.Megawattpermeter, "MW/m");
                Symbols.Add(LinearPowerDensityUnit.Kilowattpermeter, "kW/m");
                Symbols.Add(LinearPowerDensityUnit.Hectowattpermeter, "hW/m");
                Symbols.Add(LinearPowerDensityUnit.Dekawattpermeter, "daW/m");
                Symbols.Add(LinearPowerDensityUnit.WattPerMeter, "W/m");
                Symbols.Add(LinearPowerDensityUnit.Deciwattpermeter, "dW/m");
                Symbols.Add(LinearPowerDensityUnit.Centiwattpermeter, "cW/m");
                Symbols.Add(LinearPowerDensityUnit.Milliwattpermeter, "mW/m");
                Symbols.Add(LinearPowerDensityUnit.Microwattpermeter, "µW/m");
                Symbols.Add(LinearPowerDensityUnit.Nanowattpermeter, "nW/m");
                Symbols.Add(LinearPowerDensityUnit.Picowattpermeter, "pW/m");
                Symbols.Add(LinearPowerDensityUnit.Femtowattpermeter, "fW/m");
                Symbols.Add(LinearPowerDensityUnit.Attowattpermeter, "aW/m");
                Symbols.Add(LinearPowerDensityUnit.Zeptowattpermeter, "zW/m");
                Symbols.Add(LinearPowerDensityUnit.Yoctowattpermeter, "yW/m");
                
                
                ConversionFunctions.Add(LinearPowerDensityUnit.WattPerCentimeter, "x * 1e2");
                ConversionFunctions.Add(LinearPowerDensityUnit.WattPerMillimeter, "x * 1e3");
                ConversionFunctions.Add(LinearPowerDensityUnit.WattPerInch, "x * 39.37007874");
                ConversionFunctions.Add(LinearPowerDensityUnit.WattPerFoot, "x * 3.280839895");
                ConversionFunctions.Add(LinearPowerDensityUnit.Yottawattpermeter, "x * 1e24");
                ConversionFunctions.Add(LinearPowerDensityUnit.Zettawattpermeter, "x * 1e21");
                ConversionFunctions.Add(LinearPowerDensityUnit.Exawattpermeter, "x * 1e18");
                ConversionFunctions.Add(LinearPowerDensityUnit.Petawattpermeter, "x * 1e15");
                ConversionFunctions.Add(LinearPowerDensityUnit.Terawattpermeter, "x * 1e12");
                ConversionFunctions.Add(LinearPowerDensityUnit.Gigawattpermeter, "x * 1e9");
                ConversionFunctions.Add(LinearPowerDensityUnit.Megawattpermeter, "x * 1e6");
                ConversionFunctions.Add(LinearPowerDensityUnit.Kilowattpermeter, "x * 1e3");
                ConversionFunctions.Add(LinearPowerDensityUnit.Hectowattpermeter, "x * 1e2");
                ConversionFunctions.Add(LinearPowerDensityUnit.Dekawattpermeter, "x * 1e1");
                ConversionFunctions.Add(LinearPowerDensityUnit.WattPerMeter, "x * 1e0");
                ConversionFunctions.Add(LinearPowerDensityUnit.Deciwattpermeter, "x * 1e-1");
                ConversionFunctions.Add(LinearPowerDensityUnit.Centiwattpermeter, "x * 1e-2");
                ConversionFunctions.Add(LinearPowerDensityUnit.Milliwattpermeter, "x * 1e-3");
                ConversionFunctions.Add(LinearPowerDensityUnit.Microwattpermeter, "x * 1e-6");
                ConversionFunctions.Add(LinearPowerDensityUnit.Nanowattpermeter, "x * 1e-9");
                ConversionFunctions.Add(LinearPowerDensityUnit.Picowattpermeter, "x * 1e-12");
                ConversionFunctions.Add(LinearPowerDensityUnit.Femtowattpermeter, "x * 1e-15");
                ConversionFunctions.Add(LinearPowerDensityUnit.Attowattpermeter, "x * 1e-18");
                ConversionFunctions.Add(LinearPowerDensityUnit.Zeptowattpermeter, "x * 1e-21");
                ConversionFunctions.Add(LinearPowerDensityUnit.Yoctowattpermeter, "x * 1e-24");
            }
        }
    }
