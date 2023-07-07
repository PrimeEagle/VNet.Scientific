
    // Auto-generated for VNet on 2023-07-06 12:42:23
    using System.Numerics;
    
    
    namespace VNet.Scientific.Measurement.Dimensions
    {
        public sealed class HeatTransferCoefficient<TVal> : DimensionBase<HeatTransferCoefficientUnit, TVal> where TVal : notnull, INumber<TVal>
        {
            public override string IdTag => nameof(HeatTransferCoefficient<TVal>);
            
            public HeatTransferCoefficient() : base()
            {
                Exponents.Length = 0;
                Exponents.Mass = 1;
                Exponents.Time = -3;
                Exponents.ElectricalCurrent = 0;
                Exponents.LuminousIntensity = 0;
                Exponents.Temperature = -1;
                Exponents.Amount = 0;
                
                DefaultUnit = HeatTransferCoefficientUnit.WattPerSquareMeterKelvin;
                
                Symbols.Add(HeatTransferCoefficientUnit.WattPerSquareMeterCelsius, "W/m²·°C");
                Symbols.Add(HeatTransferCoefficientUnit.BtuPerSquareFootDegreeFahrenheit, "Btu/ft²·°F");
                Symbols.Add(HeatTransferCoefficientUnit.BtuPerHourSquareFootDegreeFahrenheit, "Btu/h·ft²·°F");
                Symbols.Add(HeatTransferCoefficientUnit.CaloriePerHourSquareMeterDegreeCelsius, "kcal/h·m²·°C");
                Symbols.Add(HeatTransferCoefficientUnit.Yottawattpersquaremeterkelvin, "YW/m²·K");
                Symbols.Add(HeatTransferCoefficientUnit.Zettawattpersquaremeterkelvin, "ZW/m²·K");
                Symbols.Add(HeatTransferCoefficientUnit.Exawattpersquaremeterkelvin, "EW/m²·K");
                Symbols.Add(HeatTransferCoefficientUnit.Petawattpersquaremeterkelvin, "PW/m²·K");
                Symbols.Add(HeatTransferCoefficientUnit.Terawattpersquaremeterkelvin, "TW/m²·K");
                Symbols.Add(HeatTransferCoefficientUnit.Gigawattpersquaremeterkelvin, "GW/m²·K");
                Symbols.Add(HeatTransferCoefficientUnit.Megawattpersquaremeterkelvin, "MW/m²·K");
                Symbols.Add(HeatTransferCoefficientUnit.Kilowattpersquaremeterkelvin, "kW/m²·K");
                Symbols.Add(HeatTransferCoefficientUnit.Hectowattpersquaremeterkelvin, "hW/m²·K");
                Symbols.Add(HeatTransferCoefficientUnit.Dekawattpersquaremeterkelvin, "daW/m²·K");
                Symbols.Add(HeatTransferCoefficientUnit.WattPerSquareMeterKelvin, "W/m²·K");
                Symbols.Add(HeatTransferCoefficientUnit.Deciwattpersquaremeterkelvin, "dW/m²·K");
                Symbols.Add(HeatTransferCoefficientUnit.Centiwattpersquaremeterkelvin, "cW/m²·K");
                Symbols.Add(HeatTransferCoefficientUnit.Milliwattpersquaremeterkelvin, "mW/m²·K");
                Symbols.Add(HeatTransferCoefficientUnit.Microwattpersquaremeterkelvin, "µW/m²·K");
                Symbols.Add(HeatTransferCoefficientUnit.Nanowattpersquaremeterkelvin, "nW/m²·K");
                Symbols.Add(HeatTransferCoefficientUnit.Picowattpersquaremeterkelvin, "pW/m²·K");
                Symbols.Add(HeatTransferCoefficientUnit.Femtowattpersquaremeterkelvin, "fW/m²·K");
                Symbols.Add(HeatTransferCoefficientUnit.Attowattpersquaremeterkelvin, "aW/m²·K");
                Symbols.Add(HeatTransferCoefficientUnit.Zeptowattpersquaremeterkelvin, "zW/m²·K");
                Symbols.Add(HeatTransferCoefficientUnit.Yoctowattpersquaremeterkelvin, "yW/m²·K");
                
                PluralSymbols.Add(HeatTransferCoefficientUnit.BtuPerHourSquareFootDegreeFahrenheit, "Btu/ft²·h·°F");
                PluralSymbols.Add(HeatTransferCoefficientUnit.CaloriePerHourSquareMeterDegreeCelsius, "kcal/m²·h·°C");
                
                ConversionFunctions.Add(HeatTransferCoefficientUnit.WattPerSquareMeterCelsius, "x");
                ConversionFunctions.Add(HeatTransferCoefficientUnit.BtuPerSquareFootDegreeFahrenheit, "x * 5.6782633411134878");
                ConversionFunctions.Add(HeatTransferCoefficientUnit.BtuPerHourSquareFootDegreeFahrenheit, "x * 5.6782633411134878");
                ConversionFunctions.Add(HeatTransferCoefficientUnit.CaloriePerHourSquareMeterDegreeCelsius, "(x * 4.1868) / 3600");
                ConversionFunctions.Add(HeatTransferCoefficientUnit.Yottawattpersquaremeterkelvin, "x * 1e24");
                ConversionFunctions.Add(HeatTransferCoefficientUnit.Zettawattpersquaremeterkelvin, "x * 1e21");
                ConversionFunctions.Add(HeatTransferCoefficientUnit.Exawattpersquaremeterkelvin, "x * 1e18");
                ConversionFunctions.Add(HeatTransferCoefficientUnit.Petawattpersquaremeterkelvin, "x * 1e15");
                ConversionFunctions.Add(HeatTransferCoefficientUnit.Terawattpersquaremeterkelvin, "x * 1e12");
                ConversionFunctions.Add(HeatTransferCoefficientUnit.Gigawattpersquaremeterkelvin, "x * 1e9");
                ConversionFunctions.Add(HeatTransferCoefficientUnit.Megawattpersquaremeterkelvin, "x * 1e6");
                ConversionFunctions.Add(HeatTransferCoefficientUnit.Kilowattpersquaremeterkelvin, "x * 1e3");
                ConversionFunctions.Add(HeatTransferCoefficientUnit.Hectowattpersquaremeterkelvin, "x * 1e2");
                ConversionFunctions.Add(HeatTransferCoefficientUnit.Dekawattpersquaremeterkelvin, "x * 1e1");
                ConversionFunctions.Add(HeatTransferCoefficientUnit.WattPerSquareMeterKelvin, "x * 1e0");
                ConversionFunctions.Add(HeatTransferCoefficientUnit.Deciwattpersquaremeterkelvin, "x * 1e-1");
                ConversionFunctions.Add(HeatTransferCoefficientUnit.Centiwattpersquaremeterkelvin, "x * 1e-2");
                ConversionFunctions.Add(HeatTransferCoefficientUnit.Milliwattpersquaremeterkelvin, "x * 1e-3");
                ConversionFunctions.Add(HeatTransferCoefficientUnit.Microwattpersquaremeterkelvin, "x * 1e-6");
                ConversionFunctions.Add(HeatTransferCoefficientUnit.Nanowattpersquaremeterkelvin, "x * 1e-9");
                ConversionFunctions.Add(HeatTransferCoefficientUnit.Picowattpersquaremeterkelvin, "x * 1e-12");
                ConversionFunctions.Add(HeatTransferCoefficientUnit.Femtowattpersquaremeterkelvin, "x * 1e-15");
                ConversionFunctions.Add(HeatTransferCoefficientUnit.Attowattpersquaremeterkelvin, "x * 1e-18");
                ConversionFunctions.Add(HeatTransferCoefficientUnit.Zeptowattpersquaremeterkelvin, "x * 1e-21");
                ConversionFunctions.Add(HeatTransferCoefficientUnit.Yoctowattpersquaremeterkelvin, "x * 1e-24");
            }
        }
    }
