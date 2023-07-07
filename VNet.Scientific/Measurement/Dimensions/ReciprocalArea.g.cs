
    // Auto-generated for VNet on 2023-07-06 12:42:23
    using System.Numerics;
    
    
    namespace VNet.Scientific.Measurement.Dimensions
    {
        public sealed class ReciprocalArea<TVal> : DimensionBase<ReciprocalAreaUnit, TVal> where TVal : notnull, INumber<TVal>
        {
            public override string IdTag => nameof(ReciprocalArea<TVal>);
            
            public ReciprocalArea() : base()
            {
                Exponents.Length = -2;
                Exponents.Mass = 0;
                Exponents.Time = 0;
                Exponents.ElectricalCurrent = 0;
                Exponents.LuminousIntensity = 0;
                Exponents.Temperature = 0;
                Exponents.Amount = 0;
                
                DefaultUnit = ReciprocalAreaUnit.InverseSquareMeter;
                
                Symbols.Add(ReciprocalAreaUnit.InverseSquareMile, "mi⁻²");
                Symbols.Add(ReciprocalAreaUnit.InverseSquareYard, "yd⁻²");
                Symbols.Add(ReciprocalAreaUnit.InverseSquareFoot, "ft⁻²");
                Symbols.Add(ReciprocalAreaUnit.InverseUsSurveySquareFoot, "ft⁻² (US)");
                Symbols.Add(ReciprocalAreaUnit.InverseSquareInch, "in⁻²");
                Symbols.Add(ReciprocalAreaUnit.InversesquareYottameter, "Ym⁻²");
                Symbols.Add(ReciprocalAreaUnit.InversesquareZettameter, "Zm⁻²");
                Symbols.Add(ReciprocalAreaUnit.InversesquareExameter, "Em⁻²");
                Symbols.Add(ReciprocalAreaUnit.InversesquarePetameter, "Pm⁻²");
                Symbols.Add(ReciprocalAreaUnit.InversesquareTerameter, "Tm⁻²");
                Symbols.Add(ReciprocalAreaUnit.InversesquareGigameter, "Gm⁻²");
                Symbols.Add(ReciprocalAreaUnit.InversesquareMegameter, "Mm⁻²");
                Symbols.Add(ReciprocalAreaUnit.InversesquareKilometer, "km⁻²");
                Symbols.Add(ReciprocalAreaUnit.InversesquareHectometer, "hm⁻²");
                Symbols.Add(ReciprocalAreaUnit.InversesquareDekameter, "dam⁻²");
                Symbols.Add(ReciprocalAreaUnit.InverseSquareMeter, "m⁻²");
                Symbols.Add(ReciprocalAreaUnit.InversesquareDecimeter, "dm⁻²");
                Symbols.Add(ReciprocalAreaUnit.InversesquareCentimeter, "cm⁻²");
                Symbols.Add(ReciprocalAreaUnit.InversesquareMillimeter, "mm⁻²");
                Symbols.Add(ReciprocalAreaUnit.InversesquareMicrometer, "µm⁻²");
                Symbols.Add(ReciprocalAreaUnit.InversesquareNanometer, "nm⁻²");
                Symbols.Add(ReciprocalAreaUnit.InversesquarePicometer, "pm⁻²");
                Symbols.Add(ReciprocalAreaUnit.InversesquareFemtometer, "fm⁻²");
                Symbols.Add(ReciprocalAreaUnit.InversesquareAttometer, "am⁻²");
                Symbols.Add(ReciprocalAreaUnit.InversesquareZeptometer, "zm⁻²");
                Symbols.Add(ReciprocalAreaUnit.InversesquareYoctometer, "ym⁻²");
                
                
                ConversionFunctions.Add(ReciprocalAreaUnit.InverseSquareMile, "x / 2.59e6");
                ConversionFunctions.Add(ReciprocalAreaUnit.InverseSquareYard, "x / 0.836127");
                ConversionFunctions.Add(ReciprocalAreaUnit.InverseSquareFoot, "x / 0.092903");
                ConversionFunctions.Add(ReciprocalAreaUnit.InverseUsSurveySquareFoot, "x / 0.09290341161");
                ConversionFunctions.Add(ReciprocalAreaUnit.InverseSquareInch, "x / 0.00064516");
                ConversionFunctions.Add(ReciprocalAreaUnit.InversesquareYottameter, "x / 1e48");
                ConversionFunctions.Add(ReciprocalAreaUnit.InversesquareZettameter, "x / 1e42");
                ConversionFunctions.Add(ReciprocalAreaUnit.InversesquareExameter, "x / 1e36");
                ConversionFunctions.Add(ReciprocalAreaUnit.InversesquarePetameter, "x / 1e30");
                ConversionFunctions.Add(ReciprocalAreaUnit.InversesquareTerameter, "x / 1e24");
                ConversionFunctions.Add(ReciprocalAreaUnit.InversesquareGigameter, "x / 1e18");
                ConversionFunctions.Add(ReciprocalAreaUnit.InversesquareMegameter, "x / 1e12");
                ConversionFunctions.Add(ReciprocalAreaUnit.InversesquareKilometer, "x / 1e6");
                ConversionFunctions.Add(ReciprocalAreaUnit.InversesquareHectometer, "x / 1e4");
                ConversionFunctions.Add(ReciprocalAreaUnit.InversesquareDekameter, "x / 1e2");
                ConversionFunctions.Add(ReciprocalAreaUnit.InverseSquareMeter, "x / 1e0");
                ConversionFunctions.Add(ReciprocalAreaUnit.InversesquareDecimeter, "x / 1e-2");
                ConversionFunctions.Add(ReciprocalAreaUnit.InversesquareCentimeter, "x / 1e-4");
                ConversionFunctions.Add(ReciprocalAreaUnit.InversesquareMillimeter, "x / 1e-6");
                ConversionFunctions.Add(ReciprocalAreaUnit.InversesquareMicrometer, "x / 1e-12");
                ConversionFunctions.Add(ReciprocalAreaUnit.InversesquareNanometer, "x / 1e-18");
                ConversionFunctions.Add(ReciprocalAreaUnit.InversesquarePicometer, "x / 1e-24");
                ConversionFunctions.Add(ReciprocalAreaUnit.InversesquareFemtometer, "x / 1e-30");
                ConversionFunctions.Add(ReciprocalAreaUnit.InversesquareAttometer, "x / 1e-36");
                ConversionFunctions.Add(ReciprocalAreaUnit.InversesquareZeptometer, "x / 1e-42");
                ConversionFunctions.Add(ReciprocalAreaUnit.InversesquareYoctometer, "x / 1e-48");
            }
        }
    }
