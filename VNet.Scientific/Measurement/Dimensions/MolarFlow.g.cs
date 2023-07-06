
    // Auto-generated for VNet on 2023-07-05 10:35:43
    using System.Numerics;
    
    
    namespace VNet.Scientific.Measurement.Dimensions
    {
        public sealed class MolarFlow<TVal> : DimensionBase<MolarFlowUnit, TVal> where TVal : notnull, INumber<TVal>
        {
            public override string IdTag => nameof(MolarFlow<TVal>);
            
            public MolarFlow() : base()
            {
                DimensionComponent.Exponents.Length = 0;
                DimensionComponent.Exponents.Mass = 0;
                DimensionComponent.Exponents.Time = -1;
                DimensionComponent.Exponents.ElectricalCurrent = 0;
                DimensionComponent.Exponents.LuminousIntensity = 0;
                DimensionComponent.Exponents.Temperature = 0;
                DimensionComponent.Exponents.Amount = 1;
                
                DefaultUnit = MolarFlowUnit.MolePerSecond;
                
                Symbols.Add(MolarFlowUnit.MolePerMinute, "mol/min");
                Symbols.Add(MolarFlowUnit.MolePerHour, "kmol/h");
                Symbols.Add(MolarFlowUnit.PoundMolePerSecond, "lbmol/s");
                Symbols.Add(MolarFlowUnit.PoundMolePerMinute, "lbmol/min");
                Symbols.Add(MolarFlowUnit.PoundMolePerHour, "lbmol/h");
                Symbols.Add(MolarFlowUnit.Yottamolepersecond, "Ymol/s");
                Symbols.Add(MolarFlowUnit.Zettamolepersecond, "Zmol/s");
                Symbols.Add(MolarFlowUnit.Examolepersecond, "Emol/s");
                Symbols.Add(MolarFlowUnit.Petamolepersecond, "Pmol/s");
                Symbols.Add(MolarFlowUnit.Teramolepersecond, "Tmol/s");
                Symbols.Add(MolarFlowUnit.Gigamolepersecond, "Gmol/s");
                Symbols.Add(MolarFlowUnit.Megamolepersecond, "Mmol/s");
                Symbols.Add(MolarFlowUnit.Kilomolepersecond, "kmol/s");
                Symbols.Add(MolarFlowUnit.Hectomolepersecond, "hmol/s");
                Symbols.Add(MolarFlowUnit.Dekamolepersecond, "damol/s");
                Symbols.Add(MolarFlowUnit.MolePerSecond, "mol/s");
                Symbols.Add(MolarFlowUnit.Decimolepersecond, "dmol/s");
                Symbols.Add(MolarFlowUnit.Centimolepersecond, "cmol/s");
                Symbols.Add(MolarFlowUnit.Millimolepersecond, "mmol/s");
                Symbols.Add(MolarFlowUnit.Micromolepersecond, "µmol/s");
                Symbols.Add(MolarFlowUnit.Nanomolepersecond, "nmol/s");
                Symbols.Add(MolarFlowUnit.Picomolepersecond, "pmol/s");
                Symbols.Add(MolarFlowUnit.Femtomolepersecond, "fmol/s");
                Symbols.Add(MolarFlowUnit.Attomolepersecond, "amol/s");
                Symbols.Add(MolarFlowUnit.Zeptomolepersecond, "zmol/s");
                Symbols.Add(MolarFlowUnit.Yoctomolepersecond, "ymol/s");
                
                
                ConversionFunctions.Add(MolarFlowUnit.MolePerMinute, "x / 60");
                ConversionFunctions.Add(MolarFlowUnit.MolePerHour, "x / 3600");
                ConversionFunctions.Add(MolarFlowUnit.PoundMolePerSecond, "x * 453.59237");
                ConversionFunctions.Add(MolarFlowUnit.PoundMolePerMinute, "(x * 453.59237) / 60");
                ConversionFunctions.Add(MolarFlowUnit.PoundMolePerHour, "(x * 453.59237) / 3600");
                ConversionFunctions.Add(MolarFlowUnit.Yottamolepersecond, "x * 1e24");
                ConversionFunctions.Add(MolarFlowUnit.Zettamolepersecond, "x * 1e21");
                ConversionFunctions.Add(MolarFlowUnit.Examolepersecond, "x * 1e18");
                ConversionFunctions.Add(MolarFlowUnit.Petamolepersecond, "x * 1e15");
                ConversionFunctions.Add(MolarFlowUnit.Teramolepersecond, "x * 1e12");
                ConversionFunctions.Add(MolarFlowUnit.Gigamolepersecond, "x * 1e9");
                ConversionFunctions.Add(MolarFlowUnit.Megamolepersecond, "x * 1e6");
                ConversionFunctions.Add(MolarFlowUnit.Kilomolepersecond, "x * 1e3");
                ConversionFunctions.Add(MolarFlowUnit.Hectomolepersecond, "x * 1e2");
                ConversionFunctions.Add(MolarFlowUnit.Dekamolepersecond, "x * 1e1");
                ConversionFunctions.Add(MolarFlowUnit.MolePerSecond, "x * 1e0");
                ConversionFunctions.Add(MolarFlowUnit.Decimolepersecond, "x * 1e-1");
                ConversionFunctions.Add(MolarFlowUnit.Centimolepersecond, "x * 1e-2");
                ConversionFunctions.Add(MolarFlowUnit.Millimolepersecond, "x * 1e-3");
                ConversionFunctions.Add(MolarFlowUnit.Micromolepersecond, "x * 1e-6");
                ConversionFunctions.Add(MolarFlowUnit.Nanomolepersecond, "x * 1e-9");
                ConversionFunctions.Add(MolarFlowUnit.Picomolepersecond, "x * 1e-12");
                ConversionFunctions.Add(MolarFlowUnit.Femtomolepersecond, "x * 1e-15");
                ConversionFunctions.Add(MolarFlowUnit.Attomolepersecond, "x * 1e-18");
                ConversionFunctions.Add(MolarFlowUnit.Zeptomolepersecond, "x * 1e-21");
                ConversionFunctions.Add(MolarFlowUnit.Yoctomolepersecond, "x * 1e-24");
            }
        }
    }
