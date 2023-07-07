
    // Auto-generated for VNet on 2023-07-06 12:42:23
    using System.Numerics;
    
    
    namespace VNet.Scientific.Measurement.Dimensions
    {
        public sealed class PorousMediumPermeability<TVal> : DimensionBase<PorousMediumPermeabilityUnit, TVal> where TVal : notnull, INumber<TVal>
        {
            public override string IdTag => nameof(PorousMediumPermeability<TVal>);
            
            public PorousMediumPermeability() : base()
            {
                Exponents.Length = 2;
                Exponents.Mass = 0;
                Exponents.Time = 0;
                Exponents.ElectricalCurrent = 0;
                Exponents.LuminousIntensity = 0;
                Exponents.Temperature = 0;
                Exponents.Amount = 0;
                
                DefaultUnit = PorousMediumPermeabilityUnit.SquareMeter;
                
                Symbols.Add(PorousMediumPermeabilityUnit.Darcy, "D");
                Symbols.Add(PorousMediumPermeabilityUnit.SquareYottameter, "Ym²");
                Symbols.Add(PorousMediumPermeabilityUnit.SquareZettameter, "Zm²");
                Symbols.Add(PorousMediumPermeabilityUnit.SquareExameter, "Em²");
                Symbols.Add(PorousMediumPermeabilityUnit.SquarePetameter, "Pm²");
                Symbols.Add(PorousMediumPermeabilityUnit.SquareTerameter, "Tm²");
                Symbols.Add(PorousMediumPermeabilityUnit.SquareGigameter, "Gm²");
                Symbols.Add(PorousMediumPermeabilityUnit.SquareMegameter, "Mm²");
                Symbols.Add(PorousMediumPermeabilityUnit.SquareKilometer, "km²");
                Symbols.Add(PorousMediumPermeabilityUnit.SquareHectometer, "hm²");
                Symbols.Add(PorousMediumPermeabilityUnit.SquareDekameter, "dam²");
                Symbols.Add(PorousMediumPermeabilityUnit.SquareMeter, "m²");
                Symbols.Add(PorousMediumPermeabilityUnit.SquareDecimeter, "dm²");
                Symbols.Add(PorousMediumPermeabilityUnit.SquareCentimeter, "cm²");
                Symbols.Add(PorousMediumPermeabilityUnit.SquareMillimeter, "mm²");
                Symbols.Add(PorousMediumPermeabilityUnit.SquareMicrometer, "µm²");
                Symbols.Add(PorousMediumPermeabilityUnit.SquareNanometer, "nm²");
                Symbols.Add(PorousMediumPermeabilityUnit.SquarePicometer, "pm²");
                Symbols.Add(PorousMediumPermeabilityUnit.SquareFemtometer, "fm²");
                Symbols.Add(PorousMediumPermeabilityUnit.SquareAttometer, "am²");
                Symbols.Add(PorousMediumPermeabilityUnit.SquareZeptometer, "zm²");
                Symbols.Add(PorousMediumPermeabilityUnit.SquareYoctometer, "ym²");
                
                
                ConversionFunctions.Add(PorousMediumPermeabilityUnit.Darcy, "x * 9.869233e-13");
                ConversionFunctions.Add(PorousMediumPermeabilityUnit.SquareYottameter, "x * 1e48");
                ConversionFunctions.Add(PorousMediumPermeabilityUnit.SquareZettameter, "x * 1e42");
                ConversionFunctions.Add(PorousMediumPermeabilityUnit.SquareExameter, "x * 1e36");
                ConversionFunctions.Add(PorousMediumPermeabilityUnit.SquarePetameter, "x * 1e30");
                ConversionFunctions.Add(PorousMediumPermeabilityUnit.SquareTerameter, "x * 1e24");
                ConversionFunctions.Add(PorousMediumPermeabilityUnit.SquareGigameter, "x * 1e18");
                ConversionFunctions.Add(PorousMediumPermeabilityUnit.SquareMegameter, "x * 1e12");
                ConversionFunctions.Add(PorousMediumPermeabilityUnit.SquareKilometer, "x * 1e6");
                ConversionFunctions.Add(PorousMediumPermeabilityUnit.SquareHectometer, "x * 1e4");
                ConversionFunctions.Add(PorousMediumPermeabilityUnit.SquareDekameter, "x * 1e2");
                ConversionFunctions.Add(PorousMediumPermeabilityUnit.SquareMeter, "x * 1e0");
                ConversionFunctions.Add(PorousMediumPermeabilityUnit.SquareDecimeter, "x * 1e-2");
                ConversionFunctions.Add(PorousMediumPermeabilityUnit.SquareCentimeter, "x * 1e-4");
                ConversionFunctions.Add(PorousMediumPermeabilityUnit.SquareMillimeter, "x * 1e-6");
                ConversionFunctions.Add(PorousMediumPermeabilityUnit.SquareMicrometer, "x * 1e-12");
                ConversionFunctions.Add(PorousMediumPermeabilityUnit.SquareNanometer, "x * 1e-18");
                ConversionFunctions.Add(PorousMediumPermeabilityUnit.SquarePicometer, "x * 1e-24");
                ConversionFunctions.Add(PorousMediumPermeabilityUnit.SquareFemtometer, "x * 1e-30");
                ConversionFunctions.Add(PorousMediumPermeabilityUnit.SquareAttometer, "x * 1e-36");
                ConversionFunctions.Add(PorousMediumPermeabilityUnit.SquareZeptometer, "x * 1e-42");
                ConversionFunctions.Add(PorousMediumPermeabilityUnit.SquareYoctometer, "x * 1e-48");
            }
        }
    }
