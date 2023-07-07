
    // Auto-generated for VNet on 2023-07-06 12:42:23
    using System.Numerics;
    
    
    namespace VNet.Scientific.Measurement.Dimensions
    {
        public sealed class Molarity<TVal> : DimensionBase<MolarityUnit, TVal> where TVal : notnull, INumber<TVal>
        {
            public override string IdTag => nameof(Molarity<TVal>);
            
            public Molarity() : base()
            {
                Exponents.Length = -3;
                Exponents.Mass = 0;
                Exponents.Time = 0;
                Exponents.ElectricalCurrent = 0;
                Exponents.LuminousIntensity = 0;
                Exponents.Temperature = 0;
                Exponents.Amount = 1;
                
                DefaultUnit = MolarityUnit.MolePerCubicMeter;
                
                Symbols.Add(MolarityUnit.MolePerLiter, "mol/L");
                Symbols.Add(MolarityUnit.PoundMolePerCubicFoot, "lbmol/ft³");
                Symbols.Add(MolarityUnit.Yottamolepercubicmeter, "Ymol/m³");
                Symbols.Add(MolarityUnit.Zettamolepercubicmeter, "Zmol/m³");
                Symbols.Add(MolarityUnit.Examolepercubicmeter, "Emol/m³");
                Symbols.Add(MolarityUnit.Petamolepercubicmeter, "Pmol/m³");
                Symbols.Add(MolarityUnit.Teramolepercubicmeter, "Tmol/m³");
                Symbols.Add(MolarityUnit.Gigamolepercubicmeter, "Gmol/m³");
                Symbols.Add(MolarityUnit.Megamolepercubicmeter, "Mmol/m³");
                Symbols.Add(MolarityUnit.Kilomolepercubicmeter, "kmol/m³");
                Symbols.Add(MolarityUnit.Hectomolepercubicmeter, "hmol/m³");
                Symbols.Add(MolarityUnit.Dekamolepercubicmeter, "damol/m³");
                Symbols.Add(MolarityUnit.MolePerCubicMeter, "mol/m³");
                Symbols.Add(MolarityUnit.Decimolepercubicmeter, "dmol/m³");
                Symbols.Add(MolarityUnit.Centimolepercubicmeter, "cmol/m³");
                Symbols.Add(MolarityUnit.Millimolepercubicmeter, "mmol/m³");
                Symbols.Add(MolarityUnit.Micromolepercubicmeter, "µmol/m³");
                Symbols.Add(MolarityUnit.Nanomolepercubicmeter, "nmol/m³");
                Symbols.Add(MolarityUnit.Picomolepercubicmeter, "pmol/m³");
                Symbols.Add(MolarityUnit.Femtomolepercubicmeter, "fmol/m³");
                Symbols.Add(MolarityUnit.Attomolepercubicmeter, "amol/m³");
                Symbols.Add(MolarityUnit.Zeptomolepercubicmeter, "zmol/m³");
                Symbols.Add(MolarityUnit.Yoctomolepercubicmeter, "ymol/m³");
                
                PluralSymbols.Add(MolarityUnit.MolePerLiter, "M");
                
                ConversionFunctions.Add(MolarityUnit.MolePerLiter, "x / 1e-3");
                ConversionFunctions.Add(MolarityUnit.PoundMolePerCubicFoot, "x / 6.2427960576144611956325455827221e-5");
                ConversionFunctions.Add(MolarityUnit.Yottamolepercubicmeter, "x * 1e24");
                ConversionFunctions.Add(MolarityUnit.Zettamolepercubicmeter, "x * 1e21");
                ConversionFunctions.Add(MolarityUnit.Examolepercubicmeter, "x * 1e18");
                ConversionFunctions.Add(MolarityUnit.Petamolepercubicmeter, "x * 1e15");
                ConversionFunctions.Add(MolarityUnit.Teramolepercubicmeter, "x * 1e12");
                ConversionFunctions.Add(MolarityUnit.Gigamolepercubicmeter, "x * 1e9");
                ConversionFunctions.Add(MolarityUnit.Megamolepercubicmeter, "x * 1e6");
                ConversionFunctions.Add(MolarityUnit.Kilomolepercubicmeter, "x * 1e3");
                ConversionFunctions.Add(MolarityUnit.Hectomolepercubicmeter, "x * 1e2");
                ConversionFunctions.Add(MolarityUnit.Dekamolepercubicmeter, "x * 1e1");
                ConversionFunctions.Add(MolarityUnit.MolePerCubicMeter, "x * 1e0");
                ConversionFunctions.Add(MolarityUnit.Decimolepercubicmeter, "x * 1e-1");
                ConversionFunctions.Add(MolarityUnit.Centimolepercubicmeter, "x * 1e-2");
                ConversionFunctions.Add(MolarityUnit.Millimolepercubicmeter, "x * 1e-3");
                ConversionFunctions.Add(MolarityUnit.Micromolepercubicmeter, "x * 1e-6");
                ConversionFunctions.Add(MolarityUnit.Nanomolepercubicmeter, "x * 1e-9");
                ConversionFunctions.Add(MolarityUnit.Picomolepercubicmeter, "x * 1e-12");
                ConversionFunctions.Add(MolarityUnit.Femtomolepercubicmeter, "x * 1e-15");
                ConversionFunctions.Add(MolarityUnit.Attomolepercubicmeter, "x * 1e-18");
                ConversionFunctions.Add(MolarityUnit.Zeptomolepercubicmeter, "x * 1e-21");
                ConversionFunctions.Add(MolarityUnit.Yoctomolepercubicmeter, "x * 1e-24");
            }
        }
    }
