
    // Auto-generated for VNet on 2023-07-03 11:25:32
    using System.Numerics;
    
    
    namespace VNet.Scientific.Measurement.Dimensions
    {
        public sealed class MolarMass<TVal> : DimensionBase<MolarMassUnit, TVal> where TVal : notnull, INumber<TVal>
        {
            public override string IdTag => nameof(MolarMass<TVal>);
            
            public MolarMass() : base()
            {
                DimensionComponent.Exponents.Length = 0;
                DimensionComponent.Exponents.Mass = 1;
                DimensionComponent.Exponents.Time = 0;
                DimensionComponent.Exponents.ElectricalCurrent = 0;
                DimensionComponent.Exponents.LuminousIntensity = 0;
                DimensionComponent.Exponents.Temperature = 0;
                DimensionComponent.Exponents.Amount = -1;
                
                DefaultUnit = MolarMassUnit.KilogramPerMole;
                
                
                _conversionFunctions.Add("KilogramPerKilomole", "1000 * (1000 * (1000 * (1000 * (1000 * (1000 * (1000 * (1000 * (x / 1e3))))))))");
                _conversionFunctions.Add("PoundPerMole", "1000 * (1000 * (1000 * (1000 * (1000 * (1000 * (1000 * (1000 * (x * 0.45359237))))))))");
                _conversionFunctions.Add("YottaGramPerMole", "1000 * (x * 1e24)");
                _conversionFunctions.Add("ZettaGramPerMole", "1000 * (x * 1e21)");
                _conversionFunctions.Add("ExaGramPerMole", "1000 * (x * 1e18)");
                _conversionFunctions.Add("PetaGramPerMole", "1000 * (x * 1e15)");
                _conversionFunctions.Add("TeraGramPerMole", "1000 * (x * 1e12)");
                _conversionFunctions.Add("GigaGramPerMole", "1000 * (x * 1e9)");
                _conversionFunctions.Add("MegaGramPerMole", "1000 * (x * 1e6)");
                _conversionFunctions.Add("KiloGramPerMole", "1000 * (x * 1e3)");
                _conversionFunctions.Add("HectoGramPerMole", "1000 * (x * 1e2)");
                _conversionFunctions.Add("DekaGramPerMole", "1000 * (x * 1e1)");
                _conversionFunctions.Add("GramPerMole", "1000 * (x * 1e0)");
                _conversionFunctions.Add("DeciGramPerMole", "1000 * (x * 1e-1)");
                _conversionFunctions.Add("CentiGramPerMole", "1000 * (x * 1e-2)");
                _conversionFunctions.Add("MilliGramPerMole", "1000 * (x * 1e-3)");
                _conversionFunctions.Add("MicroGramPerMole", "1000 * (x * 1e-6)");
                _conversionFunctions.Add("NanoGramPerMole", "1000 * (x * 1e-9)");
                _conversionFunctions.Add("PicoGramPerMole", "1000 * (x * 1e-12)");
                _conversionFunctions.Add("FemtoGramPerMole", "1000 * (x * 1e-15)");
                _conversionFunctions.Add("AttoGramPerMole", "1000 * (x * 1e-18)");
                _conversionFunctions.Add("ZeptoGramPerMole", "1000 * (x * 1e-21)");
                _conversionFunctions.Add("YoctoGramPerMole", "1000 * (x * 1e-24)");
            }
        }
    }
