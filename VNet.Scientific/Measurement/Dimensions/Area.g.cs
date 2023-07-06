
    // Auto-generated for VNet on 2023-07-05 10:35:43
    using System.Numerics;
    
    
    namespace VNet.Scientific.Measurement.Dimensions
    {
        public sealed class Area<TVal> : DimensionBase<AreaUnit, TVal> where TVal : notnull, INumber<TVal>
        {
            public override string IdTag => nameof(Area<TVal>);
            
            public Area() : base()
            {
                DimensionComponent.Exponents.Length = 2;
                DimensionComponent.Exponents.Mass = 0;
                DimensionComponent.Exponents.Time = 0;
                DimensionComponent.Exponents.ElectricalCurrent = 0;
                DimensionComponent.Exponents.LuminousIntensity = 0;
                DimensionComponent.Exponents.Temperature = 0;
                DimensionComponent.Exponents.Amount = 0;
                
                DefaultUnit = AreaUnit.SquareMeter;
                
                Symbols.Add(AreaUnit.SquareMile, "mi²");
                Symbols.Add(AreaUnit.SquareYard, "yd²");
                Symbols.Add(AreaUnit.SquareFoot, "ft²");
                Symbols.Add(AreaUnit.UsSurveySquareFoot, "ft² (US)");
                Symbols.Add(AreaUnit.SquareInch, "in²");
                Symbols.Add(AreaUnit.Acre, "ac");
                Symbols.Add(AreaUnit.Hectare, "ha");
                Symbols.Add(AreaUnit.SquareNauticalMile, "nmi²");
                Symbols.Add(AreaUnit.SquareYottameter, "Ym²");
                Symbols.Add(AreaUnit.SquareZettameter, "Zm²");
                Symbols.Add(AreaUnit.SquareExameter, "Em²");
                Symbols.Add(AreaUnit.SquarePetameter, "Pm²");
                Symbols.Add(AreaUnit.SquareTerameter, "Tm²");
                Symbols.Add(AreaUnit.SquareGigameter, "Gm²");
                Symbols.Add(AreaUnit.SquareMegameter, "Mm²");
                Symbols.Add(AreaUnit.SquareKilometer, "km²");
                Symbols.Add(AreaUnit.SquareHectometer, "hm²");
                Symbols.Add(AreaUnit.SquareDekameter, "dam²");
                Symbols.Add(AreaUnit.SquareMeter, "m²");
                Symbols.Add(AreaUnit.SquareDecimeter, "dm²");
                Symbols.Add(AreaUnit.SquareCentimeter, "cm²");
                Symbols.Add(AreaUnit.SquareMillimeter, "mm²");
                Symbols.Add(AreaUnit.SquareMicrometer, "µm²");
                Symbols.Add(AreaUnit.SquareNanometer, "nm²");
                Symbols.Add(AreaUnit.SquarePicometer, "pm²");
                Symbols.Add(AreaUnit.SquareFemtometer, "fm²");
                Symbols.Add(AreaUnit.SquareAttometer, "am²");
                Symbols.Add(AreaUnit.SquareZeptometer, "zm²");
                Symbols.Add(AreaUnit.SquareYoctometer, "ym²");
                
                
                ConversionFunctions.Add(AreaUnit.SquareMile, "x * 1609.344 * 1609.344");
                ConversionFunctions.Add(AreaUnit.SquareYard, "x * 0.9144 * 0.9144");
                ConversionFunctions.Add(AreaUnit.SquareFoot, "x * 9.290304e-2");
                ConversionFunctions.Add(AreaUnit.UsSurveySquareFoot, "x * (1200.0 / 3937.0) * (1200.0 / 3937.0)");
                ConversionFunctions.Add(AreaUnit.SquareInch, "x * 0.00064516");
                ConversionFunctions.Add(AreaUnit.Acre, "x * 4046.8564224");
                ConversionFunctions.Add(AreaUnit.Hectare, "x * 1e4");
                ConversionFunctions.Add(AreaUnit.SquareNauticalMile, "x * 3429904");
                ConversionFunctions.Add(AreaUnit.SquareYottameter, "x * 1e48");
                ConversionFunctions.Add(AreaUnit.SquareZettameter, "x * 1e42");
                ConversionFunctions.Add(AreaUnit.SquareExameter, "x * 1e36");
                ConversionFunctions.Add(AreaUnit.SquarePetameter, "x * 1e30");
                ConversionFunctions.Add(AreaUnit.SquareTerameter, "x * 1e24");
                ConversionFunctions.Add(AreaUnit.SquareGigameter, "x * 1e18");
                ConversionFunctions.Add(AreaUnit.SquareMegameter, "x * 1e12");
                ConversionFunctions.Add(AreaUnit.SquareKilometer, "x * 1e6");
                ConversionFunctions.Add(AreaUnit.SquareHectometer, "x * 1e4");
                ConversionFunctions.Add(AreaUnit.SquareDekameter, "x * 1e2");
                ConversionFunctions.Add(AreaUnit.SquareMeter, "x * 1e0");
                ConversionFunctions.Add(AreaUnit.SquareDecimeter, "x * 1e-2");
                ConversionFunctions.Add(AreaUnit.SquareCentimeter, "x * 1e-4");
                ConversionFunctions.Add(AreaUnit.SquareMillimeter, "x * 1e-6");
                ConversionFunctions.Add(AreaUnit.SquareMicrometer, "x * 1e-12");
                ConversionFunctions.Add(AreaUnit.SquareNanometer, "x * 1e-18");
                ConversionFunctions.Add(AreaUnit.SquarePicometer, "x * 1e-24");
                ConversionFunctions.Add(AreaUnit.SquareFemtometer, "x * 1e-30");
                ConversionFunctions.Add(AreaUnit.SquareAttometer, "x * 1e-36");
                ConversionFunctions.Add(AreaUnit.SquareZeptometer, "x * 1e-42");
                ConversionFunctions.Add(AreaUnit.SquareYoctometer, "x * 1e-48");
            }
        }
    }
