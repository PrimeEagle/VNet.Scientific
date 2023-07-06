
    // Auto-generated for VNet on 2023-07-05 10:35:43
    using System.Numerics;
    
    
    namespace VNet.Scientific.Measurement.Dimensions
    {
        public sealed class ElectricInductance<TVal> : DimensionBase<ElectricInductanceUnit, TVal> where TVal : notnull, INumber<TVal>
        {
            public override string IdTag => nameof(ElectricInductance<TVal>);
            
            public ElectricInductance() : base()
            {
                DimensionComponent.Exponents.Length = 2;
                DimensionComponent.Exponents.Mass = 1;
                DimensionComponent.Exponents.Time = -2;
                DimensionComponent.Exponents.ElectricalCurrent = -2;
                DimensionComponent.Exponents.LuminousIntensity = 0;
                DimensionComponent.Exponents.Temperature = 0;
                DimensionComponent.Exponents.Amount = 0;
                
                DefaultUnit = ElectricInductanceUnit.Henry;
                
                Symbols.Add(ElectricInductanceUnit.Yottahenry, "YH");
                Symbols.Add(ElectricInductanceUnit.Zettahenry, "ZH");
                Symbols.Add(ElectricInductanceUnit.Exahenry, "EH");
                Symbols.Add(ElectricInductanceUnit.Petahenry, "PH");
                Symbols.Add(ElectricInductanceUnit.Terahenry, "TH");
                Symbols.Add(ElectricInductanceUnit.Gigahenry, "GH");
                Symbols.Add(ElectricInductanceUnit.Megahenry, "MH");
                Symbols.Add(ElectricInductanceUnit.Kilohenry, "kH");
                Symbols.Add(ElectricInductanceUnit.Hectohenry, "hH");
                Symbols.Add(ElectricInductanceUnit.Dekahenry, "daH");
                Symbols.Add(ElectricInductanceUnit.Henry, "H");
                Symbols.Add(ElectricInductanceUnit.Decihenry, "dH");
                Symbols.Add(ElectricInductanceUnit.Centihenry, "cH");
                Symbols.Add(ElectricInductanceUnit.Millihenry, "mH");
                Symbols.Add(ElectricInductanceUnit.Microhenry, "µH");
                Symbols.Add(ElectricInductanceUnit.Nanohenry, "nH");
                Symbols.Add(ElectricInductanceUnit.Picohenry, "pH");
                Symbols.Add(ElectricInductanceUnit.Femtohenry, "fH");
                Symbols.Add(ElectricInductanceUnit.Attohenry, "aH");
                Symbols.Add(ElectricInductanceUnit.Zeptohenry, "zH");
                Symbols.Add(ElectricInductanceUnit.Yoctohenry, "yH");
                
                
                ConversionFunctions.Add(ElectricInductanceUnit.Yottahenry, "x * 1e24");
                ConversionFunctions.Add(ElectricInductanceUnit.Zettahenry, "x * 1e21");
                ConversionFunctions.Add(ElectricInductanceUnit.Exahenry, "x * 1e18");
                ConversionFunctions.Add(ElectricInductanceUnit.Petahenry, "x * 1e15");
                ConversionFunctions.Add(ElectricInductanceUnit.Terahenry, "x * 1e12");
                ConversionFunctions.Add(ElectricInductanceUnit.Gigahenry, "x * 1e9");
                ConversionFunctions.Add(ElectricInductanceUnit.Megahenry, "x * 1e6");
                ConversionFunctions.Add(ElectricInductanceUnit.Kilohenry, "x * 1e3");
                ConversionFunctions.Add(ElectricInductanceUnit.Hectohenry, "x * 1e2");
                ConversionFunctions.Add(ElectricInductanceUnit.Dekahenry, "x * 1e1");
                ConversionFunctions.Add(ElectricInductanceUnit.Henry, "x * 1e0");
                ConversionFunctions.Add(ElectricInductanceUnit.Decihenry, "x * 1e-1");
                ConversionFunctions.Add(ElectricInductanceUnit.Centihenry, "x * 1e-2");
                ConversionFunctions.Add(ElectricInductanceUnit.Millihenry, "x * 1e-3");
                ConversionFunctions.Add(ElectricInductanceUnit.Microhenry, "x * 1e-6");
                ConversionFunctions.Add(ElectricInductanceUnit.Nanohenry, "x * 1e-9");
                ConversionFunctions.Add(ElectricInductanceUnit.Picohenry, "x * 1e-12");
                ConversionFunctions.Add(ElectricInductanceUnit.Femtohenry, "x * 1e-15");
                ConversionFunctions.Add(ElectricInductanceUnit.Attohenry, "x * 1e-18");
                ConversionFunctions.Add(ElectricInductanceUnit.Zeptohenry, "x * 1e-21");
                ConversionFunctions.Add(ElectricInductanceUnit.Yoctohenry, "x * 1e-24");
            }
        }
    }
