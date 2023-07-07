
    // Auto-generated for VNet on 2023-07-06 12:42:23
    using System.Numerics;
    
    
    namespace VNet.Scientific.Measurement.Dimensions
    {
        public sealed class ElectricCurrentDensity<TVal> : DimensionBase<ElectricCurrentDensityUnit, TVal> where TVal : notnull, INumber<TVal>
        {
            public override string IdTag => nameof(ElectricCurrentDensity<TVal>);
            
            public ElectricCurrentDensity() : base()
            {
                Exponents.Length = -2;
                Exponents.Mass = 0;
                Exponents.Time = 0;
                Exponents.ElectricalCurrent = 1;
                Exponents.LuminousIntensity = 0;
                Exponents.Temperature = 0;
                Exponents.Amount = 0;
                
                DefaultUnit = ElectricCurrentDensityUnit.AmperePerSquareMeter;
                
                Symbols.Add(ElectricCurrentDensityUnit.AmperePerSquareInch, "A/in²");
                Symbols.Add(ElectricCurrentDensityUnit.AmperePerSquareFoot, "A/ft²");
                Symbols.Add(ElectricCurrentDensityUnit.Yottaamperepersquaremeter, "YA/m²");
                Symbols.Add(ElectricCurrentDensityUnit.Zettaamperepersquaremeter, "ZA/m²");
                Symbols.Add(ElectricCurrentDensityUnit.Exaamperepersquaremeter, "EA/m²");
                Symbols.Add(ElectricCurrentDensityUnit.Petaamperepersquaremeter, "PA/m²");
                Symbols.Add(ElectricCurrentDensityUnit.Teraamperepersquaremeter, "TA/m²");
                Symbols.Add(ElectricCurrentDensityUnit.Gigaamperepersquaremeter, "GA/m²");
                Symbols.Add(ElectricCurrentDensityUnit.Megaamperepersquaremeter, "MA/m²");
                Symbols.Add(ElectricCurrentDensityUnit.Kiloamperepersquaremeter, "kA/m²");
                Symbols.Add(ElectricCurrentDensityUnit.Hectoamperepersquaremeter, "hA/m²");
                Symbols.Add(ElectricCurrentDensityUnit.Dekaamperepersquaremeter, "daA/m²");
                Symbols.Add(ElectricCurrentDensityUnit.AmperePerSquareMeter, "A/m²");
                Symbols.Add(ElectricCurrentDensityUnit.Deciamperepersquaremeter, "dA/m²");
                Symbols.Add(ElectricCurrentDensityUnit.Centiamperepersquaremeter, "cA/m²");
                Symbols.Add(ElectricCurrentDensityUnit.Milliamperepersquaremeter, "mA/m²");
                Symbols.Add(ElectricCurrentDensityUnit.Microamperepersquaremeter, "µA/m²");
                Symbols.Add(ElectricCurrentDensityUnit.Nanoamperepersquaremeter, "nA/m²");
                Symbols.Add(ElectricCurrentDensityUnit.Picoamperepersquaremeter, "pA/m²");
                Symbols.Add(ElectricCurrentDensityUnit.Femtoamperepersquaremeter, "fA/m²");
                Symbols.Add(ElectricCurrentDensityUnit.Attoamperepersquaremeter, "aA/m²");
                Symbols.Add(ElectricCurrentDensityUnit.Zeptoamperepersquaremeter, "zA/m²");
                Symbols.Add(ElectricCurrentDensityUnit.Yoctoamperepersquaremeter, "yA/m²");
                
                
                ConversionFunctions.Add(ElectricCurrentDensityUnit.AmperePerSquareInch, "x * 1.5500031000062000e3");
                ConversionFunctions.Add(ElectricCurrentDensityUnit.AmperePerSquareFoot, "x * 1.0763910416709722e1");
                ConversionFunctions.Add(ElectricCurrentDensityUnit.Yottaamperepersquaremeter, "x * 1e24");
                ConversionFunctions.Add(ElectricCurrentDensityUnit.Zettaamperepersquaremeter, "x * 1e21");
                ConversionFunctions.Add(ElectricCurrentDensityUnit.Exaamperepersquaremeter, "x * 1e18");
                ConversionFunctions.Add(ElectricCurrentDensityUnit.Petaamperepersquaremeter, "x * 1e15");
                ConversionFunctions.Add(ElectricCurrentDensityUnit.Teraamperepersquaremeter, "x * 1e12");
                ConversionFunctions.Add(ElectricCurrentDensityUnit.Gigaamperepersquaremeter, "x * 1e9");
                ConversionFunctions.Add(ElectricCurrentDensityUnit.Megaamperepersquaremeter, "x * 1e6");
                ConversionFunctions.Add(ElectricCurrentDensityUnit.Kiloamperepersquaremeter, "x * 1e3");
                ConversionFunctions.Add(ElectricCurrentDensityUnit.Hectoamperepersquaremeter, "x * 1e2");
                ConversionFunctions.Add(ElectricCurrentDensityUnit.Dekaamperepersquaremeter, "x * 1e1");
                ConversionFunctions.Add(ElectricCurrentDensityUnit.AmperePerSquareMeter, "x * 1e0");
                ConversionFunctions.Add(ElectricCurrentDensityUnit.Deciamperepersquaremeter, "x * 1e-1");
                ConversionFunctions.Add(ElectricCurrentDensityUnit.Centiamperepersquaremeter, "x * 1e-2");
                ConversionFunctions.Add(ElectricCurrentDensityUnit.Milliamperepersquaremeter, "x * 1e-3");
                ConversionFunctions.Add(ElectricCurrentDensityUnit.Microamperepersquaremeter, "x * 1e-6");
                ConversionFunctions.Add(ElectricCurrentDensityUnit.Nanoamperepersquaremeter, "x * 1e-9");
                ConversionFunctions.Add(ElectricCurrentDensityUnit.Picoamperepersquaremeter, "x * 1e-12");
                ConversionFunctions.Add(ElectricCurrentDensityUnit.Femtoamperepersquaremeter, "x * 1e-15");
                ConversionFunctions.Add(ElectricCurrentDensityUnit.Attoamperepersquaremeter, "x * 1e-18");
                ConversionFunctions.Add(ElectricCurrentDensityUnit.Zeptoamperepersquaremeter, "x * 1e-21");
                ConversionFunctions.Add(ElectricCurrentDensityUnit.Yoctoamperepersquaremeter, "x * 1e-24");
            }
        }
    }
