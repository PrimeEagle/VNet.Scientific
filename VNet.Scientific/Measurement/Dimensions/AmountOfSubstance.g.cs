
    // Auto-generated for VNet on 2023-07-05 10:35:43
    using System.Numerics;
    
    
    namespace VNet.Scientific.Measurement.Dimensions
    {
        public sealed class AmountOfSubstance<TVal> : DimensionBase<AmountOfSubstanceUnit, TVal> where TVal : notnull, INumber<TVal>
        {
            public override string IdTag => nameof(AmountOfSubstance<TVal>);
            
            public AmountOfSubstance() : base()
            {
                DimensionComponent.Exponents.Length = 0;
                DimensionComponent.Exponents.Mass = 0;
                DimensionComponent.Exponents.Time = 0;
                DimensionComponent.Exponents.ElectricalCurrent = 0;
                DimensionComponent.Exponents.LuminousIntensity = 0;
                DimensionComponent.Exponents.Temperature = 0;
                DimensionComponent.Exponents.Amount = 1;
                
                DefaultUnit = AmountOfSubstanceUnit.Mole;
                
                Symbols.Add(AmountOfSubstanceUnit.PoundMole, "lbmol");
                Symbols.Add(AmountOfSubstanceUnit.Yottamole, "Ymol");
                Symbols.Add(AmountOfSubstanceUnit.Zettamole, "Zmol");
                Symbols.Add(AmountOfSubstanceUnit.Examole, "Emol");
                Symbols.Add(AmountOfSubstanceUnit.Petamole, "Pmol");
                Symbols.Add(AmountOfSubstanceUnit.Teramole, "Tmol");
                Symbols.Add(AmountOfSubstanceUnit.Gigamole, "Gmol");
                Symbols.Add(AmountOfSubstanceUnit.Megamole, "Mmol");
                Symbols.Add(AmountOfSubstanceUnit.Kilomole, "kmol");
                Symbols.Add(AmountOfSubstanceUnit.Hectomole, "hmol");
                Symbols.Add(AmountOfSubstanceUnit.Dekamole, "damol");
                Symbols.Add(AmountOfSubstanceUnit.Mole, "mol");
                Symbols.Add(AmountOfSubstanceUnit.Decimole, "dmol");
                Symbols.Add(AmountOfSubstanceUnit.Centimole, "cmol");
                Symbols.Add(AmountOfSubstanceUnit.Millimole, "mmol");
                Symbols.Add(AmountOfSubstanceUnit.Micromole, "µmol");
                Symbols.Add(AmountOfSubstanceUnit.Nanomole, "nmol");
                Symbols.Add(AmountOfSubstanceUnit.Picomole, "pmol");
                Symbols.Add(AmountOfSubstanceUnit.Femtomole, "fmol");
                Symbols.Add(AmountOfSubstanceUnit.Attomole, "amol");
                Symbols.Add(AmountOfSubstanceUnit.Zeptomole, "zmol");
                Symbols.Add(AmountOfSubstanceUnit.Yoctomole, "ymol");
                
                
                ConversionFunctions.Add(AmountOfSubstanceUnit.PoundMole, "x * 453.59237");
                ConversionFunctions.Add(AmountOfSubstanceUnit.Yottamole, "x * 1e24");
                ConversionFunctions.Add(AmountOfSubstanceUnit.Zettamole, "x * 1e21");
                ConversionFunctions.Add(AmountOfSubstanceUnit.Examole, "x * 1e18");
                ConversionFunctions.Add(AmountOfSubstanceUnit.Petamole, "x * 1e15");
                ConversionFunctions.Add(AmountOfSubstanceUnit.Teramole, "x * 1e12");
                ConversionFunctions.Add(AmountOfSubstanceUnit.Gigamole, "x * 1e9");
                ConversionFunctions.Add(AmountOfSubstanceUnit.Megamole, "x * 1e6");
                ConversionFunctions.Add(AmountOfSubstanceUnit.Kilomole, "x * 1e3");
                ConversionFunctions.Add(AmountOfSubstanceUnit.Hectomole, "x * 1e2");
                ConversionFunctions.Add(AmountOfSubstanceUnit.Dekamole, "x * 1e1");
                ConversionFunctions.Add(AmountOfSubstanceUnit.Mole, "x * 1e0");
                ConversionFunctions.Add(AmountOfSubstanceUnit.Decimole, "x * 1e-1");
                ConversionFunctions.Add(AmountOfSubstanceUnit.Centimole, "x * 1e-2");
                ConversionFunctions.Add(AmountOfSubstanceUnit.Millimole, "x * 1e-3");
                ConversionFunctions.Add(AmountOfSubstanceUnit.Micromole, "x * 1e-6");
                ConversionFunctions.Add(AmountOfSubstanceUnit.Nanomole, "x * 1e-9");
                ConversionFunctions.Add(AmountOfSubstanceUnit.Picomole, "x * 1e-12");
                ConversionFunctions.Add(AmountOfSubstanceUnit.Femtomole, "x * 1e-15");
                ConversionFunctions.Add(AmountOfSubstanceUnit.Attomole, "x * 1e-18");
                ConversionFunctions.Add(AmountOfSubstanceUnit.Zeptomole, "x * 1e-21");
                ConversionFunctions.Add(AmountOfSubstanceUnit.Yoctomole, "x * 1e-24");
            }
        }
    }
