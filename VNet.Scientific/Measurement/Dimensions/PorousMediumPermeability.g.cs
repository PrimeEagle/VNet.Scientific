
    // Auto-generated for VNet on 2023-07-05 10:24:46
    using System.Numerics;
    
    
    namespace VNet.Scientific.Measurement.Dimensions
    {
        public sealed class PorousMediumPermeability<TVal> : DimensionBase<PorousMediumPermeabilityUnit, TVal> where TVal : notnull, INumber<TVal>
        {
            public override string IdTag => nameof(PorousMediumPermeability<TVal>);
            
            public PorousMediumPermeability() : base()
            {
                DimensionComponent.Exponents.Length = 2;
                DimensionComponent.Exponents.Mass = 0;
                DimensionComponent.Exponents.Time = 0;
                DimensionComponent.Exponents.ElectricalCurrent = 0;
                DimensionComponent.Exponents.LuminousIntensity = 0;
                DimensionComponent.Exponents.Temperature = 0;
                DimensionComponent.Exponents.Amount = 0;
                
                DefaultUnit = PorousMediumPermeabilityUnit.SquareMeter;
                
                
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
