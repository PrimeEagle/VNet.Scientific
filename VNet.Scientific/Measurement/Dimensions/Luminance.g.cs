
    // Auto-generated for VNet on 2023-07-06 12:42:23
    using System.Numerics;
    
    
    namespace VNet.Scientific.Measurement.Dimensions
    {
        public sealed class Luminance<TVal> : DimensionBase<LuminanceUnit, TVal> where TVal : notnull, INumber<TVal>
        {
            public override string IdTag => nameof(Luminance<TVal>);
            
            public Luminance() : base()
            {
                Exponents.Length = -2;
                Exponents.Mass = 0;
                Exponents.Time = 0;
                Exponents.ElectricalCurrent = 0;
                Exponents.LuminousIntensity = 1;
                Exponents.Temperature = 0;
                Exponents.Amount = 0;
                
                DefaultUnit = LuminanceUnit.CandelaPerSquareMeter;
                
                Symbols.Add(LuminanceUnit.CandelaPerSquareFoot, "Cd/ft²");
                Symbols.Add(LuminanceUnit.CandelaPerSquareInch, "Cd/in²");
                Symbols.Add(LuminanceUnit.Nit, "nt");
                Symbols.Add(LuminanceUnit.Yottacandelapersquaremeter, "YCd/m²");
                Symbols.Add(LuminanceUnit.Zettacandelapersquaremeter, "ZCd/m²");
                Symbols.Add(LuminanceUnit.Exacandelapersquaremeter, "ECd/m²");
                Symbols.Add(LuminanceUnit.Petacandelapersquaremeter, "PCd/m²");
                Symbols.Add(LuminanceUnit.Teracandelapersquaremeter, "TCd/m²");
                Symbols.Add(LuminanceUnit.Gigacandelapersquaremeter, "GCd/m²");
                Symbols.Add(LuminanceUnit.Megacandelapersquaremeter, "MCd/m²");
                Symbols.Add(LuminanceUnit.Kilocandelapersquaremeter, "kCd/m²");
                Symbols.Add(LuminanceUnit.Hectocandelapersquaremeter, "hCd/m²");
                Symbols.Add(LuminanceUnit.Dekacandelapersquaremeter, "daCd/m²");
                Symbols.Add(LuminanceUnit.CandelaPerSquareMeter, "Cd/m²");
                Symbols.Add(LuminanceUnit.Decicandelapersquaremeter, "dCd/m²");
                Symbols.Add(LuminanceUnit.Centicandelapersquaremeter, "cCd/m²");
                Symbols.Add(LuminanceUnit.Millicandelapersquaremeter, "mCd/m²");
                Symbols.Add(LuminanceUnit.Microcandelapersquaremeter, "µCd/m²");
                Symbols.Add(LuminanceUnit.Nanocandelapersquaremeter, "nCd/m²");
                Symbols.Add(LuminanceUnit.Picocandelapersquaremeter, "pCd/m²");
                Symbols.Add(LuminanceUnit.Femtocandelapersquaremeter, "fCd/m²");
                Symbols.Add(LuminanceUnit.Attocandelapersquaremeter, "aCd/m²");
                Symbols.Add(LuminanceUnit.Zeptocandelapersquaremeter, "zCd/m²");
                Symbols.Add(LuminanceUnit.Yoctocandelapersquaremeter, "yCd/m²");
                
                
                ConversionFunctions.Add(LuminanceUnit.CandelaPerSquareFoot, "x* 1.07639e1");
                ConversionFunctions.Add(LuminanceUnit.CandelaPerSquareInch, "x* 1.5500031e3");
                ConversionFunctions.Add(LuminanceUnit.Nit, "x");
                ConversionFunctions.Add(LuminanceUnit.Yottacandelapersquaremeter, "x * 1e24");
                ConversionFunctions.Add(LuminanceUnit.Zettacandelapersquaremeter, "x * 1e21");
                ConversionFunctions.Add(LuminanceUnit.Exacandelapersquaremeter, "x * 1e18");
                ConversionFunctions.Add(LuminanceUnit.Petacandelapersquaremeter, "x * 1e15");
                ConversionFunctions.Add(LuminanceUnit.Teracandelapersquaremeter, "x * 1e12");
                ConversionFunctions.Add(LuminanceUnit.Gigacandelapersquaremeter, "x * 1e9");
                ConversionFunctions.Add(LuminanceUnit.Megacandelapersquaremeter, "x * 1e6");
                ConversionFunctions.Add(LuminanceUnit.Kilocandelapersquaremeter, "x * 1e3");
                ConversionFunctions.Add(LuminanceUnit.Hectocandelapersquaremeter, "x * 1e2");
                ConversionFunctions.Add(LuminanceUnit.Dekacandelapersquaremeter, "x * 1e1");
                ConversionFunctions.Add(LuminanceUnit.CandelaPerSquareMeter, "x * 1e0");
                ConversionFunctions.Add(LuminanceUnit.Decicandelapersquaremeter, "x * 1e-1");
                ConversionFunctions.Add(LuminanceUnit.Centicandelapersquaremeter, "x * 1e-2");
                ConversionFunctions.Add(LuminanceUnit.Millicandelapersquaremeter, "x * 1e-3");
                ConversionFunctions.Add(LuminanceUnit.Microcandelapersquaremeter, "x * 1e-6");
                ConversionFunctions.Add(LuminanceUnit.Nanocandelapersquaremeter, "x * 1e-9");
                ConversionFunctions.Add(LuminanceUnit.Picocandelapersquaremeter, "x * 1e-12");
                ConversionFunctions.Add(LuminanceUnit.Femtocandelapersquaremeter, "x * 1e-15");
                ConversionFunctions.Add(LuminanceUnit.Attocandelapersquaremeter, "x * 1e-18");
                ConversionFunctions.Add(LuminanceUnit.Zeptocandelapersquaremeter, "x * 1e-21");
                ConversionFunctions.Add(LuminanceUnit.Yoctocandelapersquaremeter, "x * 1e-24");
            }
        }
    }
