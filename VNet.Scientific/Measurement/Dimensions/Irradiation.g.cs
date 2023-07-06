
    // Auto-generated for VNet on 2023-07-05 10:35:43
    using System.Numerics;
    
    
    namespace VNet.Scientific.Measurement.Dimensions
    {
        public sealed class Irradiation<TVal> : DimensionBase<IrradiationUnit, TVal> where TVal : notnull, INumber<TVal>
        {
            public override string IdTag => nameof(Irradiation<TVal>);
            
            public Irradiation() : base()
            {
                DimensionComponent.Exponents.Length = 0;
                DimensionComponent.Exponents.Mass = 1;
                DimensionComponent.Exponents.Time = -2;
                DimensionComponent.Exponents.ElectricalCurrent = 0;
                DimensionComponent.Exponents.LuminousIntensity = 0;
                DimensionComponent.Exponents.Temperature = 0;
                DimensionComponent.Exponents.Amount = 0;
                
                DefaultUnit = IrradiationUnit.JoulePerSquareMeter;
                
                Symbols.Add(IrradiationUnit.JoulePerSquareCentimeter, "J/cm²");
                Symbols.Add(IrradiationUnit.JoulePerSquareMillimeter, "J/mm²");
                Symbols.Add(IrradiationUnit.WattHourPerSquareMeter, "Wh/m²");
                Symbols.Add(IrradiationUnit.Yottajoulepersquaremeter, "YJ/m²");
                Symbols.Add(IrradiationUnit.Zettajoulepersquaremeter, "ZJ/m²");
                Symbols.Add(IrradiationUnit.Exajoulepersquaremeter, "EJ/m²");
                Symbols.Add(IrradiationUnit.Petajoulepersquaremeter, "PJ/m²");
                Symbols.Add(IrradiationUnit.Terajoulepersquaremeter, "TJ/m²");
                Symbols.Add(IrradiationUnit.Gigajoulepersquaremeter, "GJ/m²");
                Symbols.Add(IrradiationUnit.Megajoulepersquaremeter, "MJ/m²");
                Symbols.Add(IrradiationUnit.Kilojoulepersquaremeter, "kJ/m²");
                Symbols.Add(IrradiationUnit.Hectojoulepersquaremeter, "hJ/m²");
                Symbols.Add(IrradiationUnit.Dekajoulepersquaremeter, "daJ/m²");
                Symbols.Add(IrradiationUnit.JoulePerSquareMeter, "J/m²");
                Symbols.Add(IrradiationUnit.Decijoulepersquaremeter, "dJ/m²");
                Symbols.Add(IrradiationUnit.Centijoulepersquaremeter, "cJ/m²");
                Symbols.Add(IrradiationUnit.Millijoulepersquaremeter, "mJ/m²");
                Symbols.Add(IrradiationUnit.Microjoulepersquaremeter, "µJ/m²");
                Symbols.Add(IrradiationUnit.Nanojoulepersquaremeter, "nJ/m²");
                Symbols.Add(IrradiationUnit.Picojoulepersquaremeter, "pJ/m²");
                Symbols.Add(IrradiationUnit.Femtojoulepersquaremeter, "fJ/m²");
                Symbols.Add(IrradiationUnit.Attojoulepersquaremeter, "aJ/m²");
                Symbols.Add(IrradiationUnit.Zeptojoulepersquaremeter, "zJ/m²");
                Symbols.Add(IrradiationUnit.Yoctojoulepersquaremeter, "yJ/m²");
                
                
                ConversionFunctions.Add(IrradiationUnit.JoulePerSquareCentimeter, "x * 1e4");
                ConversionFunctions.Add(IrradiationUnit.JoulePerSquareMillimeter, "x * 1e6");
                ConversionFunctions.Add(IrradiationUnit.WattHourPerSquareMeter, "x * 3600d");
                ConversionFunctions.Add(IrradiationUnit.Yottajoulepersquaremeter, "x * 1e24");
                ConversionFunctions.Add(IrradiationUnit.Zettajoulepersquaremeter, "x * 1e21");
                ConversionFunctions.Add(IrradiationUnit.Exajoulepersquaremeter, "x * 1e18");
                ConversionFunctions.Add(IrradiationUnit.Petajoulepersquaremeter, "x * 1e15");
                ConversionFunctions.Add(IrradiationUnit.Terajoulepersquaremeter, "x * 1e12");
                ConversionFunctions.Add(IrradiationUnit.Gigajoulepersquaremeter, "x * 1e9");
                ConversionFunctions.Add(IrradiationUnit.Megajoulepersquaremeter, "x * 1e6");
                ConversionFunctions.Add(IrradiationUnit.Kilojoulepersquaremeter, "x * 1e3");
                ConversionFunctions.Add(IrradiationUnit.Hectojoulepersquaremeter, "x * 1e2");
                ConversionFunctions.Add(IrradiationUnit.Dekajoulepersquaremeter, "x * 1e1");
                ConversionFunctions.Add(IrradiationUnit.JoulePerSquareMeter, "x * 1e0");
                ConversionFunctions.Add(IrradiationUnit.Decijoulepersquaremeter, "x * 1e-1");
                ConversionFunctions.Add(IrradiationUnit.Centijoulepersquaremeter, "x * 1e-2");
                ConversionFunctions.Add(IrradiationUnit.Millijoulepersquaremeter, "x * 1e-3");
                ConversionFunctions.Add(IrradiationUnit.Microjoulepersquaremeter, "x * 1e-6");
                ConversionFunctions.Add(IrradiationUnit.Nanojoulepersquaremeter, "x * 1e-9");
                ConversionFunctions.Add(IrradiationUnit.Picojoulepersquaremeter, "x * 1e-12");
                ConversionFunctions.Add(IrradiationUnit.Femtojoulepersquaremeter, "x * 1e-15");
                ConversionFunctions.Add(IrradiationUnit.Attojoulepersquaremeter, "x * 1e-18");
                ConversionFunctions.Add(IrradiationUnit.Zeptojoulepersquaremeter, "x * 1e-21");
                ConversionFunctions.Add(IrradiationUnit.Yoctojoulepersquaremeter, "x * 1e-24");
            }
        }
    }
