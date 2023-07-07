
    // Auto-generated for VNet on 2023-07-06 12:42:23
    using System.Numerics;
    
    
    namespace VNet.Scientific.Measurement.Dimensions
    {
        public sealed class HeatFlux<TVal> : DimensionBase<HeatFluxUnit, TVal> where TVal : notnull, INumber<TVal>
        {
            public override string IdTag => nameof(HeatFlux<TVal>);
            
            public HeatFlux() : base()
            {
                Exponents.Length = 0;
                Exponents.Mass = 1;
                Exponents.Time = -3;
                Exponents.ElectricalCurrent = 0;
                Exponents.LuminousIntensity = 0;
                Exponents.Temperature = 0;
                Exponents.Amount = 0;
                
                DefaultUnit = HeatFluxUnit.WattPerSquareMeter;
                
                Symbols.Add(HeatFluxUnit.WattPerSquareInch, "W/in²");
                Symbols.Add(HeatFluxUnit.WattPerSquareFoot, "W/ft²");
                Symbols.Add(HeatFluxUnit.BtuPerSecondSquareInch, "BTU/s·in²");
                Symbols.Add(HeatFluxUnit.BtuPerSecondSquareFoot, "BTU/s·ft²");
                Symbols.Add(HeatFluxUnit.BtuPerMinuteSquareFoot, "BTU/min·ft²");
                Symbols.Add(HeatFluxUnit.BtuPerHourSquareFoot, "BTU/h·ft²");
                Symbols.Add(HeatFluxUnit.CaloriePerSecondSquareCentimeter, "cal/s·cm²");
                Symbols.Add(HeatFluxUnit.KilocaloriePerHourSquareMeter, "kcal/h·m²");
                Symbols.Add(HeatFluxUnit.PoundForcePerFootSecond, "lbf/(ft·s)");
                Symbols.Add(HeatFluxUnit.PoundPerSecondCubed, "lb/s³");
                Symbols.Add(HeatFluxUnit.Yottawattpersquaremeter, "YW/m²");
                Symbols.Add(HeatFluxUnit.Zettawattpersquaremeter, "ZW/m²");
                Symbols.Add(HeatFluxUnit.Exawattpersquaremeter, "EW/m²");
                Symbols.Add(HeatFluxUnit.Petawattpersquaremeter, "PW/m²");
                Symbols.Add(HeatFluxUnit.Terawattpersquaremeter, "TW/m²");
                Symbols.Add(HeatFluxUnit.Gigawattpersquaremeter, "GW/m²");
                Symbols.Add(HeatFluxUnit.Megawattpersquaremeter, "MW/m²");
                Symbols.Add(HeatFluxUnit.Kilowattpersquaremeter, "kW/m²");
                Symbols.Add(HeatFluxUnit.Hectowattpersquaremeter, "hW/m²");
                Symbols.Add(HeatFluxUnit.Dekawattpersquaremeter, "daW/m²");
                Symbols.Add(HeatFluxUnit.WattPerSquareMeter, "W/m²");
                Symbols.Add(HeatFluxUnit.Deciwattpersquaremeter, "dW/m²");
                Symbols.Add(HeatFluxUnit.Centiwattpersquaremeter, "cW/m²");
                Symbols.Add(HeatFluxUnit.Milliwattpersquaremeter, "mW/m²");
                Symbols.Add(HeatFluxUnit.Microwattpersquaremeter, "µW/m²");
                Symbols.Add(HeatFluxUnit.Nanowattpersquaremeter, "nW/m²");
                Symbols.Add(HeatFluxUnit.Picowattpersquaremeter, "pW/m²");
                Symbols.Add(HeatFluxUnit.Femtowattpersquaremeter, "fW/m²");
                Symbols.Add(HeatFluxUnit.Attowattpersquaremeter, "aW/m²");
                Symbols.Add(HeatFluxUnit.Zeptowattpersquaremeter, "zW/m²");
                Symbols.Add(HeatFluxUnit.Yoctowattpersquaremeter, "yW/m²");
                
                PluralSymbols.Add(HeatFluxUnit.PoundPerSecondCubed, "lbm/s³");
                
                ConversionFunctions.Add(HeatFluxUnit.WattPerSquareInch, "x * 1.5500031e3");
                ConversionFunctions.Add(HeatFluxUnit.WattPerSquareFoot, "x * 1.07639e1");
                ConversionFunctions.Add(HeatFluxUnit.BtuPerSecondSquareInch, "x * 1.63533984e6");
                ConversionFunctions.Add(HeatFluxUnit.BtuPerSecondSquareFoot, "x * 1.13565267e4");
                ConversionFunctions.Add(HeatFluxUnit.BtuPerMinuteSquareFoot, "x * 1.89275445e2");
                ConversionFunctions.Add(HeatFluxUnit.BtuPerHourSquareFoot, "x * 3.15459075");
                ConversionFunctions.Add(HeatFluxUnit.CaloriePerSecondSquareCentimeter, "x * 4.1868e4");
                ConversionFunctions.Add(HeatFluxUnit.KilocaloriePerHourSquareMeter, "x * 1.163");
                ConversionFunctions.Add(HeatFluxUnit.PoundForcePerFootSecond, "x * 1.459390293720636e1");
                ConversionFunctions.Add(HeatFluxUnit.PoundPerSecondCubed, "x * 4.5359237e-1");
                ConversionFunctions.Add(HeatFluxUnit.Yottawattpersquaremeter, "x * 1e24");
                ConversionFunctions.Add(HeatFluxUnit.Zettawattpersquaremeter, "x * 1e21");
                ConversionFunctions.Add(HeatFluxUnit.Exawattpersquaremeter, "x * 1e18");
                ConversionFunctions.Add(HeatFluxUnit.Petawattpersquaremeter, "x * 1e15");
                ConversionFunctions.Add(HeatFluxUnit.Terawattpersquaremeter, "x * 1e12");
                ConversionFunctions.Add(HeatFluxUnit.Gigawattpersquaremeter, "x * 1e9");
                ConversionFunctions.Add(HeatFluxUnit.Megawattpersquaremeter, "x * 1e6");
                ConversionFunctions.Add(HeatFluxUnit.Kilowattpersquaremeter, "x * 1e3");
                ConversionFunctions.Add(HeatFluxUnit.Hectowattpersquaremeter, "x * 1e2");
                ConversionFunctions.Add(HeatFluxUnit.Dekawattpersquaremeter, "x * 1e1");
                ConversionFunctions.Add(HeatFluxUnit.WattPerSquareMeter, "x * 1e0");
                ConversionFunctions.Add(HeatFluxUnit.Deciwattpersquaremeter, "x * 1e-1");
                ConversionFunctions.Add(HeatFluxUnit.Centiwattpersquaremeter, "x * 1e-2");
                ConversionFunctions.Add(HeatFluxUnit.Milliwattpersquaremeter, "x * 1e-3");
                ConversionFunctions.Add(HeatFluxUnit.Microwattpersquaremeter, "x * 1e-6");
                ConversionFunctions.Add(HeatFluxUnit.Nanowattpersquaremeter, "x * 1e-9");
                ConversionFunctions.Add(HeatFluxUnit.Picowattpersquaremeter, "x * 1e-12");
                ConversionFunctions.Add(HeatFluxUnit.Femtowattpersquaremeter, "x * 1e-15");
                ConversionFunctions.Add(HeatFluxUnit.Attowattpersquaremeter, "x * 1e-18");
                ConversionFunctions.Add(HeatFluxUnit.Zeptowattpersquaremeter, "x * 1e-21");
                ConversionFunctions.Add(HeatFluxUnit.Yoctowattpersquaremeter, "x * 1e-24");
            }
        }
    }
