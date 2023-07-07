
    // Auto-generated for VNet on 2023-07-06 12:42:23
    using System.Numerics;
    
    
    namespace VNet.Scientific.Measurement.Dimensions
    {
        public sealed class ReciprocalLength<TVal> : DimensionBase<ReciprocalLengthUnit, TVal> where TVal : notnull, INumber<TVal>
        {
            public override string IdTag => nameof(ReciprocalLength<TVal>);
            
            public ReciprocalLength() : base()
            {
                Exponents.Length = -1;
                Exponents.Mass = 0;
                Exponents.Time = 0;
                Exponents.ElectricalCurrent = 0;
                Exponents.LuminousIntensity = 0;
                Exponents.Temperature = 0;
                Exponents.Amount = 0;
                
                DefaultUnit = ReciprocalLengthUnit.InverseMeter;
                
                Symbols.Add(ReciprocalLengthUnit.InverseMile, "mi⁻¹");
                Symbols.Add(ReciprocalLengthUnit.InverseYard, "yd⁻¹");
                Symbols.Add(ReciprocalLengthUnit.InverseFoot, "ft⁻¹");
                Symbols.Add(ReciprocalLengthUnit.InverseUsSurveyFoot, "ftUS⁻¹");
                Symbols.Add(ReciprocalLengthUnit.InverseInch, "in⁻¹");
                Symbols.Add(ReciprocalLengthUnit.InverseMil, "mil⁻¹");
                Symbols.Add(ReciprocalLengthUnit.InverseMicroinch, "µin⁻¹");
                Symbols.Add(ReciprocalLengthUnit.InverseYottameter, "Ym⁻¹");
                Symbols.Add(ReciprocalLengthUnit.InverseZettameter, "Zm⁻¹");
                Symbols.Add(ReciprocalLengthUnit.InverseExameter, "Em⁻¹");
                Symbols.Add(ReciprocalLengthUnit.InversePetameter, "Pm⁻¹");
                Symbols.Add(ReciprocalLengthUnit.InverseTerameter, "Tm⁻¹");
                Symbols.Add(ReciprocalLengthUnit.InverseGigameter, "Gm⁻¹");
                Symbols.Add(ReciprocalLengthUnit.InverseMegameter, "Mm⁻¹");
                Symbols.Add(ReciprocalLengthUnit.InverseKilometer, "km⁻¹");
                Symbols.Add(ReciprocalLengthUnit.InverseHectometer, "hm⁻¹");
                Symbols.Add(ReciprocalLengthUnit.InverseDekameter, "dam⁻¹");
                Symbols.Add(ReciprocalLengthUnit.InverseMeter, "m⁻¹");
                Symbols.Add(ReciprocalLengthUnit.InverseDecimeter, "dm⁻¹");
                Symbols.Add(ReciprocalLengthUnit.InverseCentimeter, "cm⁻¹");
                Symbols.Add(ReciprocalLengthUnit.InverseMillimeter, "mm⁻¹");
                Symbols.Add(ReciprocalLengthUnit.InverseMicrometer, "µm⁻¹");
                Symbols.Add(ReciprocalLengthUnit.InverseNanometer, "nm⁻¹");
                Symbols.Add(ReciprocalLengthUnit.InversePicometer, "pm⁻¹");
                Symbols.Add(ReciprocalLengthUnit.InverseFemtometer, "fm⁻¹");
                Symbols.Add(ReciprocalLengthUnit.InverseAttometer, "am⁻¹");
                Symbols.Add(ReciprocalLengthUnit.InverseZeptometer, "zm⁻¹");
                Symbols.Add(ReciprocalLengthUnit.InverseYoctometer, "ym⁻¹");
                
                PluralSymbols.Add(ReciprocalLengthUnit.InverseMile, "1/mi");
                PluralSymbols.Add(ReciprocalLengthUnit.InverseYard, "1/yd");
                PluralSymbols.Add(ReciprocalLengthUnit.InverseFoot, "1/ft");
                PluralSymbols.Add(ReciprocalLengthUnit.InverseUsSurveyFoot, "1/ftUS");
                PluralSymbols.Add(ReciprocalLengthUnit.InverseInch, "1/in");
                PluralSymbols.Add(ReciprocalLengthUnit.InverseMil, "1/mil");
                PluralSymbols.Add(ReciprocalLengthUnit.InverseMicroinch, "1/µin");
                PluralSymbols.Add(ReciprocalLengthUnit.InverseYottameter, "Y1/m");
                PluralSymbols.Add(ReciprocalLengthUnit.InverseZettameter, "Z1/m");
                PluralSymbols.Add(ReciprocalLengthUnit.InverseExameter, "E1/m");
                PluralSymbols.Add(ReciprocalLengthUnit.InversePetameter, "P1/m");
                PluralSymbols.Add(ReciprocalLengthUnit.InverseTerameter, "T1/m");
                PluralSymbols.Add(ReciprocalLengthUnit.InverseGigameter, "G1/m");
                PluralSymbols.Add(ReciprocalLengthUnit.InverseMegameter, "M1/m");
                PluralSymbols.Add(ReciprocalLengthUnit.InverseKilometer, "k1/m");
                PluralSymbols.Add(ReciprocalLengthUnit.InverseHectometer, "h1/m");
                PluralSymbols.Add(ReciprocalLengthUnit.InverseDekameter, "da1/m");
                PluralSymbols.Add(ReciprocalLengthUnit.InverseMeter, "1/m");
                PluralSymbols.Add(ReciprocalLengthUnit.InverseDecimeter, "d1/m");
                PluralSymbols.Add(ReciprocalLengthUnit.InverseCentimeter, "c1/m");
                PluralSymbols.Add(ReciprocalLengthUnit.InverseMillimeter, "m1/m");
                PluralSymbols.Add(ReciprocalLengthUnit.InverseMicrometer, "µ1/m");
                PluralSymbols.Add(ReciprocalLengthUnit.InverseNanometer, "n1/m");
                PluralSymbols.Add(ReciprocalLengthUnit.InversePicometer, "p1/m");
                PluralSymbols.Add(ReciprocalLengthUnit.InverseFemtometer, "f1/m");
                PluralSymbols.Add(ReciprocalLengthUnit.InverseAttometer, "a1/m");
                PluralSymbols.Add(ReciprocalLengthUnit.InverseZeptometer, "z1/m");
                PluralSymbols.Add(ReciprocalLengthUnit.InverseYoctometer, "y1/m");
                
                ConversionFunctions.Add(ReciprocalLengthUnit.InverseMile, "x / 1609.344");
                ConversionFunctions.Add(ReciprocalLengthUnit.InverseYard, "x / 0.9144");
                ConversionFunctions.Add(ReciprocalLengthUnit.InverseFoot, "x / 0.3048");
                ConversionFunctions.Add(ReciprocalLengthUnit.InverseUsSurveyFoot, "x * 3937 / 1200");
                ConversionFunctions.Add(ReciprocalLengthUnit.InverseInch, "x / 2.54e-2");
                ConversionFunctions.Add(ReciprocalLengthUnit.InverseMil, "x / 2.54e-5");
                ConversionFunctions.Add(ReciprocalLengthUnit.InverseMicroinch, "x / 2.54e-8");
                ConversionFunctions.Add(ReciprocalLengthUnit.InverseYottameter, "x / 1e24");
                ConversionFunctions.Add(ReciprocalLengthUnit.InverseZettameter, "x / 1e21");
                ConversionFunctions.Add(ReciprocalLengthUnit.InverseExameter, "x / 1e18");
                ConversionFunctions.Add(ReciprocalLengthUnit.InversePetameter, "x / 1e15");
                ConversionFunctions.Add(ReciprocalLengthUnit.InverseTerameter, "x / 1e12");
                ConversionFunctions.Add(ReciprocalLengthUnit.InverseGigameter, "x / 1e9");
                ConversionFunctions.Add(ReciprocalLengthUnit.InverseMegameter, "x / 1e6");
                ConversionFunctions.Add(ReciprocalLengthUnit.InverseKilometer, "x / 1e3");
                ConversionFunctions.Add(ReciprocalLengthUnit.InverseHectometer, "x / 1e2");
                ConversionFunctions.Add(ReciprocalLengthUnit.InverseDekameter, "x / 1e1");
                ConversionFunctions.Add(ReciprocalLengthUnit.InverseMeter, "x / 1e0");
                ConversionFunctions.Add(ReciprocalLengthUnit.InverseDecimeter, "x / 1e-1");
                ConversionFunctions.Add(ReciprocalLengthUnit.InverseCentimeter, "x / 1e-2");
                ConversionFunctions.Add(ReciprocalLengthUnit.InverseMillimeter, "x / 1e-3");
                ConversionFunctions.Add(ReciprocalLengthUnit.InverseMicrometer, "x / 1e-6");
                ConversionFunctions.Add(ReciprocalLengthUnit.InverseNanometer, "x / 1e-9");
                ConversionFunctions.Add(ReciprocalLengthUnit.InversePicometer, "x / 1e-12");
                ConversionFunctions.Add(ReciprocalLengthUnit.InverseFemtometer, "x / 1e-15");
                ConversionFunctions.Add(ReciprocalLengthUnit.InverseAttometer, "x / 1e-18");
                ConversionFunctions.Add(ReciprocalLengthUnit.InverseZeptometer, "x / 1e-21");
                ConversionFunctions.Add(ReciprocalLengthUnit.InverseYoctometer, "x / 1e-24");
            }
        }
    }
