
    // Auto-generated for VNet on 2023-07-03 11:25:32
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
                
                
                _conversionFunctions.Add("Darcy", "x * 9.869233e-13");
                _conversionFunctions.Add("SquareYottaMeter", "x * 1e48");
                _conversionFunctions.Add("SquareZettaMeter", "x * 1e42");
                _conversionFunctions.Add("SquareExaMeter", "x * 1e36");
                _conversionFunctions.Add("SquarePetaMeter", "x * 1e30");
                _conversionFunctions.Add("SquareTeraMeter", "x * 1e24");
                _conversionFunctions.Add("SquareGigaMeter", "x * 1e18");
                _conversionFunctions.Add("SquareMegaMeter", "x * 1e12");
                _conversionFunctions.Add("SquareKiloMeter", "x * 1e6");
                _conversionFunctions.Add("SquareHectoMeter", "x * 1e4");
                _conversionFunctions.Add("SquareDekaMeter", "x * 1e2");
                _conversionFunctions.Add("SquareMeter", "x * 1e0");
                _conversionFunctions.Add("SquareDeciMeter", "x * 1e-2");
                _conversionFunctions.Add("SquareCentiMeter", "x * 1e-4");
                _conversionFunctions.Add("SquareMilliMeter", "x * 1e-6");
                _conversionFunctions.Add("SquareMicroMeter", "x * 1e-12");
                _conversionFunctions.Add("SquareNanoMeter", "x * 1e-18");
                _conversionFunctions.Add("SquarePicoMeter", "x * 1e-24");
                _conversionFunctions.Add("SquareFemtoMeter", "x * 1e-30");
                _conversionFunctions.Add("SquareAttoMeter", "x * 1e-36");
                _conversionFunctions.Add("SquareZeptoMeter", "x * 1e-42");
                _conversionFunctions.Add("SquareYoctoMeter", "x * 1e-48");
            }
        }
    }
