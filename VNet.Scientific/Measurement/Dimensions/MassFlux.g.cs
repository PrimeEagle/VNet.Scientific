
    // Auto-generated for VNet on 2023-07-03 11:25:32
    using System.Numerics;
    
    
    namespace VNet.Scientific.Measurement.Dimensions
    {
        public sealed class MassFlux<TVal> : DimensionBase<MassFluxUnit, TVal> where TVal : notnull, INumber<TVal>
        {
            public override string IdTag => nameof(MassFlux<TVal>);
            
            public MassFlux() : base()
            {
                DimensionComponent.Exponents.Length = -2;
                DimensionComponent.Exponents.Mass = 1;
                DimensionComponent.Exponents.Time = -1;
                DimensionComponent.Exponents.ElectricalCurrent = 0;
                DimensionComponent.Exponents.LuminousIntensity = 0;
                DimensionComponent.Exponents.Temperature = 0;
                DimensionComponent.Exponents.Amount = 0;
                
                DefaultUnit = MassFluxUnit.KilogramPerSecondPerSquareMeter;
                
                
                _conversionFunctions.Add("GramPerSecondPerSquareCentimeter", "1000 * (1000 * (1000 * (1000 * (1000 * (1000 * (1000 * (1000 * (x / 1e-1))))))))");
                _conversionFunctions.Add("GramPerSecondPerSquareMillimeter", "1000 * (1000 * (1000 * (1000 * (1000 * (1000 * (1000 * (1000 * (x / 1e-3))))))))");
                _conversionFunctions.Add("GramPerHourPerSquareMeter", "1000 * (1000 * (1000 * (1000 * (1000 * (1000 * (1000 * (1000 * (x / 3.6e6))))))))");
                _conversionFunctions.Add("GramPerHourPerSquareCentimeter", "1000 * (1000 * (1000 * (1000 * (1000 * (1000 * (1000 * (1000 * (x / 3.6e2))))))))");
                _conversionFunctions.Add("GramPerHourPerSquareMillimeter", "1000 * (1000 * (1000 * (1000 * (1000 * (1000 * (1000 * (1000 * (x / 3.6e0))))))))");
                _conversionFunctions.Add("YottaGramPerSecondPerSquareMeter", "1000 * (x * 1e24)");
                _conversionFunctions.Add("ZettaGramPerSecondPerSquareMeter", "1000 * (x * 1e21)");
                _conversionFunctions.Add("ExaGramPerSecondPerSquareMeter", "1000 * (x * 1e18)");
                _conversionFunctions.Add("PetaGramPerSecondPerSquareMeter", "1000 * (x * 1e15)");
                _conversionFunctions.Add("TeraGramPerSecondPerSquareMeter", "1000 * (x * 1e12)");
                _conversionFunctions.Add("GigaGramPerSecondPerSquareMeter", "1000 * (x * 1e9)");
                _conversionFunctions.Add("MegaGramPerSecondPerSquareMeter", "1000 * (x * 1e6)");
                _conversionFunctions.Add("KiloGramPerSecondPerSquareMeter", "1000 * (x * 1e3)");
                _conversionFunctions.Add("HectoGramPerSecondPerSquareMeter", "1000 * (x * 1e2)");
                _conversionFunctions.Add("DekaGramPerSecondPerSquareMeter", "1000 * (x * 1e1)");
                _conversionFunctions.Add("GramPerSecondPerSquareMeter", "1000 * (x * 1e0)");
                _conversionFunctions.Add("DeciGramPerSecondPerSquareMeter", "1000 * (x * 1e-1)");
                _conversionFunctions.Add("CentiGramPerSecondPerSquareMeter", "1000 * (x * 1e-2)");
                _conversionFunctions.Add("MilliGramPerSecondPerSquareMeter", "1000 * (x * 1e-3)");
                _conversionFunctions.Add("MicroGramPerSecondPerSquareMeter", "1000 * (x * 1e-6)");
                _conversionFunctions.Add("NanoGramPerSecondPerSquareMeter", "1000 * (x * 1e-9)");
                _conversionFunctions.Add("PicoGramPerSecondPerSquareMeter", "1000 * (x * 1e-12)");
                _conversionFunctions.Add("FemtoGramPerSecondPerSquareMeter", "1000 * (x * 1e-15)");
                _conversionFunctions.Add("AttoGramPerSecondPerSquareMeter", "1000 * (x * 1e-18)");
                _conversionFunctions.Add("ZeptoGramPerSecondPerSquareMeter", "1000 * (x * 1e-21)");
                _conversionFunctions.Add("YoctoGramPerSecondPerSquareMeter", "1000 * (x * 1e-24)");
            }
        }
    }
