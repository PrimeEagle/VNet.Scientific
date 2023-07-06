
    // Auto-generated for VNet on 2023-07-05 10:35:43
    using System.Numerics;
    
    
    namespace VNet.Scientific.Measurement.Dimensions
    {
        public sealed class Capacitance<TVal> : DimensionBase<CapacitanceUnit, TVal> where TVal : notnull, INumber<TVal>
        {
            public override string IdTag => nameof(Capacitance<TVal>);
            
            public Capacitance() : base()
            {
                DimensionComponent.Exponents.Length = -2;
                DimensionComponent.Exponents.Mass = -1;
                DimensionComponent.Exponents.Time = 4;
                DimensionComponent.Exponents.ElectricalCurrent = 2;
                DimensionComponent.Exponents.LuminousIntensity = 0;
                DimensionComponent.Exponents.Temperature = 0;
                DimensionComponent.Exponents.Amount = 0;
                
                DefaultUnit = CapacitanceUnit.Farad;
                
                Symbols.Add(CapacitanceUnit.Yottafarad, "YF");
                Symbols.Add(CapacitanceUnit.Zettafarad, "ZF");
                Symbols.Add(CapacitanceUnit.Exafarad, "EF");
                Symbols.Add(CapacitanceUnit.Petafarad, "PF");
                Symbols.Add(CapacitanceUnit.Terafarad, "TF");
                Symbols.Add(CapacitanceUnit.Gigafarad, "GF");
                Symbols.Add(CapacitanceUnit.Megafarad, "MF");
                Symbols.Add(CapacitanceUnit.Kilofarad, "kF");
                Symbols.Add(CapacitanceUnit.Hectofarad, "hF");
                Symbols.Add(CapacitanceUnit.Dekafarad, "daF");
                Symbols.Add(CapacitanceUnit.Farad, "F");
                Symbols.Add(CapacitanceUnit.Decifarad, "dF");
                Symbols.Add(CapacitanceUnit.Centifarad, "cF");
                Symbols.Add(CapacitanceUnit.Millifarad, "mF");
                Symbols.Add(CapacitanceUnit.Microfarad, "µF");
                Symbols.Add(CapacitanceUnit.Nanofarad, "nF");
                Symbols.Add(CapacitanceUnit.Picofarad, "pF");
                Symbols.Add(CapacitanceUnit.Femtofarad, "fF");
                Symbols.Add(CapacitanceUnit.Attofarad, "aF");
                Symbols.Add(CapacitanceUnit.Zeptofarad, "zF");
                Symbols.Add(CapacitanceUnit.Yoctofarad, "yF");
                
                
                ConversionFunctions.Add(CapacitanceUnit.Yottafarad, "x * 1e24");
                ConversionFunctions.Add(CapacitanceUnit.Zettafarad, "x * 1e21");
                ConversionFunctions.Add(CapacitanceUnit.Exafarad, "x * 1e18");
                ConversionFunctions.Add(CapacitanceUnit.Petafarad, "x * 1e15");
                ConversionFunctions.Add(CapacitanceUnit.Terafarad, "x * 1e12");
                ConversionFunctions.Add(CapacitanceUnit.Gigafarad, "x * 1e9");
                ConversionFunctions.Add(CapacitanceUnit.Megafarad, "x * 1e6");
                ConversionFunctions.Add(CapacitanceUnit.Kilofarad, "x * 1e3");
                ConversionFunctions.Add(CapacitanceUnit.Hectofarad, "x * 1e2");
                ConversionFunctions.Add(CapacitanceUnit.Dekafarad, "x * 1e1");
                ConversionFunctions.Add(CapacitanceUnit.Farad, "x * 1e0");
                ConversionFunctions.Add(CapacitanceUnit.Decifarad, "x * 1e-1");
                ConversionFunctions.Add(CapacitanceUnit.Centifarad, "x * 1e-2");
                ConversionFunctions.Add(CapacitanceUnit.Millifarad, "x * 1e-3");
                ConversionFunctions.Add(CapacitanceUnit.Microfarad, "x * 1e-6");
                ConversionFunctions.Add(CapacitanceUnit.Nanofarad, "x * 1e-9");
                ConversionFunctions.Add(CapacitanceUnit.Picofarad, "x * 1e-12");
                ConversionFunctions.Add(CapacitanceUnit.Femtofarad, "x * 1e-15");
                ConversionFunctions.Add(CapacitanceUnit.Attofarad, "x * 1e-18");
                ConversionFunctions.Add(CapacitanceUnit.Zeptofarad, "x * 1e-21");
                ConversionFunctions.Add(CapacitanceUnit.Yoctofarad, "x * 1e-24");
            }
        }
    }
