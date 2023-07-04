
    // Auto-generated for VNet on 2023-07-03 11:25:32
    using System.Numerics;
    
    
    namespace VNet.Scientific.Measurement.Dimensions
    {
        public sealed class ReciprocalArea<TVal> : DimensionBase<ReciprocalAreaUnit, TVal> where TVal : notnull, INumber<TVal>
        {
            public override string IdTag => nameof(ReciprocalArea<TVal>);
            
            public ReciprocalArea() : base()
            {
                DimensionComponent.Exponents.Length = -2;
                DimensionComponent.Exponents.Mass = 0;
                DimensionComponent.Exponents.Time = 0;
                DimensionComponent.Exponents.ElectricalCurrent = 0;
                DimensionComponent.Exponents.LuminousIntensity = 0;
                DimensionComponent.Exponents.Temperature = 0;
                DimensionComponent.Exponents.Amount = 0;
                
                DefaultUnit = ReciprocalAreaUnit.InverseSquareMeter;
                
                
                _conversionFunctions.Add("InverseSquareMile", "x / 2.59e6");
                _conversionFunctions.Add("InverseSquareYard", "x / 0.836127");
                _conversionFunctions.Add("InverseSquareFoot", "x / 0.092903");
                _conversionFunctions.Add("InverseUsSurveySquareFoot", "x / 0.09290341161");
                _conversionFunctions.Add("InverseSquareInch", "x / 0.00064516");
                _conversionFunctions.Add("InversesquareYottaMeter", "x / 1e48");
                _conversionFunctions.Add("InversesquareZettaMeter", "x / 1e42");
                _conversionFunctions.Add("InversesquareExaMeter", "x / 1e36");
                _conversionFunctions.Add("InversesquarePetaMeter", "x / 1e30");
                _conversionFunctions.Add("InversesquareTeraMeter", "x / 1e24");
                _conversionFunctions.Add("InversesquareGigaMeter", "x / 1e18");
                _conversionFunctions.Add("InversesquareMegaMeter", "x / 1e12");
                _conversionFunctions.Add("InversesquareKiloMeter", "x / 1e6");
                _conversionFunctions.Add("InversesquareHectoMeter", "x / 1e4");
                _conversionFunctions.Add("InversesquareDekaMeter", "x / 1e2");
                _conversionFunctions.Add("InversesquareMeter", "x / 1e0");
                _conversionFunctions.Add("InversesquareDeciMeter", "x / 1e-2");
                _conversionFunctions.Add("InversesquareCentiMeter", "x / 1e-4");
                _conversionFunctions.Add("InversesquareMilliMeter", "x / 1e-6");
                _conversionFunctions.Add("InversesquareMicroMeter", "x / 1e-12");
                _conversionFunctions.Add("InversesquareNanoMeter", "x / 1e-18");
                _conversionFunctions.Add("InversesquarePicoMeter", "x / 1e-24");
                _conversionFunctions.Add("InversesquareFemtoMeter", "x / 1e-30");
                _conversionFunctions.Add("InversesquareAttoMeter", "x / 1e-36");
                _conversionFunctions.Add("InversesquareZeptoMeter", "x / 1e-42");
                _conversionFunctions.Add("InversesquareYoctoMeter", "x / 1e-48");
            }
        }
    }
