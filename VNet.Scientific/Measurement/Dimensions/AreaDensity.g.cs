
    // Auto-generated for VNet on 2023-07-05 10:35:43
    using System.Numerics;
    
    
    namespace VNet.Scientific.Measurement.Dimensions
    {
        public sealed class AreaDensity<TVal> : DimensionBase<AreaDensityUnit, TVal> where TVal : notnull, INumber<TVal>
        {
            public override string IdTag => nameof(AreaDensity<TVal>);
            
            public AreaDensity() : base()
            {
                DimensionComponent.Exponents.Length = -2;
                DimensionComponent.Exponents.Mass = 1;
                DimensionComponent.Exponents.Time = 0;
                DimensionComponent.Exponents.ElectricalCurrent = 0;
                DimensionComponent.Exponents.LuminousIntensity = 0;
                DimensionComponent.Exponents.Temperature = 0;
                DimensionComponent.Exponents.Amount = 0;
                
                DefaultUnit = AreaDensityUnit.KilogramPerSquareMeter;
                
                Symbols.Add(AreaDensityUnit.GramPerSquareMeter, "g/m²");
                Symbols.Add(AreaDensityUnit.MilligramPerSquareMeter, "mg/m²");
                Symbols.Add(AreaDensityUnit.Yottakilogrampersquaremeter, "Ykg/m²");
                Symbols.Add(AreaDensityUnit.Zettakilogrampersquaremeter, "Zkg/m²");
                Symbols.Add(AreaDensityUnit.Exakilogrampersquaremeter, "Ekg/m²");
                Symbols.Add(AreaDensityUnit.Petakilogrampersquaremeter, "Pkg/m²");
                Symbols.Add(AreaDensityUnit.Terakilogrampersquaremeter, "Tkg/m²");
                Symbols.Add(AreaDensityUnit.Gigakilogrampersquaremeter, "Gkg/m²");
                Symbols.Add(AreaDensityUnit.Megakilogrampersquaremeter, "Mkg/m²");
                Symbols.Add(AreaDensityUnit.Kilokilogrampersquaremeter, "kkg/m²");
                Symbols.Add(AreaDensityUnit.Hectokilogrampersquaremeter, "hkg/m²");
                Symbols.Add(AreaDensityUnit.Dekakilogrampersquaremeter, "dakg/m²");
                Symbols.Add(AreaDensityUnit.KilogramPerSquareMeter, "kg/m²");
                Symbols.Add(AreaDensityUnit.Decikilogrampersquaremeter, "dkg/m²");
                Symbols.Add(AreaDensityUnit.Centikilogrampersquaremeter, "ckg/m²");
                Symbols.Add(AreaDensityUnit.Millikilogrampersquaremeter, "mkg/m²");
                Symbols.Add(AreaDensityUnit.Microkilogrampersquaremeter, "µkg/m²");
                Symbols.Add(AreaDensityUnit.Nanokilogrampersquaremeter, "nkg/m²");
                Symbols.Add(AreaDensityUnit.Picokilogrampersquaremeter, "pkg/m²");
                Symbols.Add(AreaDensityUnit.Femtokilogrampersquaremeter, "fkg/m²");
                Symbols.Add(AreaDensityUnit.Attokilogrampersquaremeter, "akg/m²");
                Symbols.Add(AreaDensityUnit.Zeptokilogrampersquaremeter, "zkg/m²");
                Symbols.Add(AreaDensityUnit.Yoctokilogrampersquaremeter, "ykg/m²");
                
                PluralSymbols.Add(AreaDensityUnit.GramPerSquareMeter, "gsm");
                
                ConversionFunctions.Add(AreaDensityUnit.GramPerSquareMeter, "x / 1000");
                ConversionFunctions.Add(AreaDensityUnit.MilligramPerSquareMeter, "x / 1000000");
                ConversionFunctions.Add(AreaDensityUnit.Yottakilogrampersquaremeter, "x * 1e24");
                ConversionFunctions.Add(AreaDensityUnit.Zettakilogrampersquaremeter, "x * 1e21");
                ConversionFunctions.Add(AreaDensityUnit.Exakilogrampersquaremeter, "x * 1e18");
                ConversionFunctions.Add(AreaDensityUnit.Petakilogrampersquaremeter, "x * 1e15");
                ConversionFunctions.Add(AreaDensityUnit.Terakilogrampersquaremeter, "x * 1e12");
                ConversionFunctions.Add(AreaDensityUnit.Gigakilogrampersquaremeter, "x * 1e9");
                ConversionFunctions.Add(AreaDensityUnit.Megakilogrampersquaremeter, "x * 1e6");
                ConversionFunctions.Add(AreaDensityUnit.Kilokilogrampersquaremeter, "x * 1e3");
                ConversionFunctions.Add(AreaDensityUnit.Hectokilogrampersquaremeter, "x * 1e2");
                ConversionFunctions.Add(AreaDensityUnit.Dekakilogrampersquaremeter, "x * 1e1");
                ConversionFunctions.Add(AreaDensityUnit.KilogramPerSquareMeter, "x * 1e0");
                ConversionFunctions.Add(AreaDensityUnit.Decikilogrampersquaremeter, "x * 1e-1");
                ConversionFunctions.Add(AreaDensityUnit.Centikilogrampersquaremeter, "x * 1e-2");
                ConversionFunctions.Add(AreaDensityUnit.Millikilogrampersquaremeter, "x * 1e-3");
                ConversionFunctions.Add(AreaDensityUnit.Microkilogrampersquaremeter, "x * 1e-6");
                ConversionFunctions.Add(AreaDensityUnit.Nanokilogrampersquaremeter, "x * 1e-9");
                ConversionFunctions.Add(AreaDensityUnit.Picokilogrampersquaremeter, "x * 1e-12");
                ConversionFunctions.Add(AreaDensityUnit.Femtokilogrampersquaremeter, "x * 1e-15");
                ConversionFunctions.Add(AreaDensityUnit.Attokilogrampersquaremeter, "x * 1e-18");
                ConversionFunctions.Add(AreaDensityUnit.Zeptokilogrampersquaremeter, "x * 1e-21");
                ConversionFunctions.Add(AreaDensityUnit.Yoctokilogrampersquaremeter, "x * 1e-24");
            }
        }
    }
