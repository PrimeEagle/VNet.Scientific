
    // Auto-generated for VNet on 2023-07-03 11:25:32
    using System.Numerics;
    
    
    namespace VNet.Scientific.Measurement.Dimensions
    {
        public sealed class SpecificFuelConsumption<TVal> : DimensionBase<SpecificFuelConsumptionUnit, TVal> where TVal : notnull, INumber<TVal>
        {
            public override string IdTag => nameof(SpecificFuelConsumption<TVal>);
            
            public SpecificFuelConsumption() : base()
            {
                DimensionComponent.Exponents.Length = 0;
                DimensionComponent.Exponents.Mass = 0;
                DimensionComponent.Exponents.Time = 0;
                DimensionComponent.Exponents.ElectricalCurrent = 0;
                DimensionComponent.Exponents.LuminousIntensity = 0;
                DimensionComponent.Exponents.Temperature = 0;
                DimensionComponent.Exponents.Amount = 0;
                
                DefaultUnit = SpecificFuelConsumptionUnit.GramPerKiloNewtonSecond;
                
                
                _conversionFunctions.Add("PoundMassPerPoundForceHour", "x * 28.33");
                _conversionFunctions.Add("KilogramPerKilogramForceHour", "x * 28.33");
                _conversionFunctions.Add("YottaGramPerKiloNewtonSecond", "x * 1e24");
                _conversionFunctions.Add("ZettaGramPerKiloNewtonSecond", "x * 1e21");
                _conversionFunctions.Add("ExaGramPerKiloNewtonSecond", "x * 1e18");
                _conversionFunctions.Add("PetaGramPerKiloNewtonSecond", "x * 1e15");
                _conversionFunctions.Add("TeraGramPerKiloNewtonSecond", "x * 1e12");
                _conversionFunctions.Add("GigaGramPerKiloNewtonSecond", "x * 1e9");
                _conversionFunctions.Add("MegaGramPerKiloNewtonSecond", "x * 1e6");
                _conversionFunctions.Add("KiloGramPerKiloNewtonSecond", "x * 1e3");
                _conversionFunctions.Add("HectoGramPerKiloNewtonSecond", "x * 1e2");
                _conversionFunctions.Add("DekaGramPerKiloNewtonSecond", "x * 1e1");
                _conversionFunctions.Add("GramPerKiloNewtonSecond", "x * 1e0");
                _conversionFunctions.Add("DeciGramPerKiloNewtonSecond", "x * 1e-1");
                _conversionFunctions.Add("CentiGramPerKiloNewtonSecond", "x * 1e-2");
                _conversionFunctions.Add("MilliGramPerKiloNewtonSecond", "x * 1e-3");
                _conversionFunctions.Add("MicroGramPerKiloNewtonSecond", "x * 1e-6");
                _conversionFunctions.Add("NanoGramPerKiloNewtonSecond", "x * 1e-9");
                _conversionFunctions.Add("PicoGramPerKiloNewtonSecond", "x * 1e-12");
                _conversionFunctions.Add("FemtoGramPerKiloNewtonSecond", "x * 1e-15");
                _conversionFunctions.Add("AttoGramPerKiloNewtonSecond", "x * 1e-18");
                _conversionFunctions.Add("ZeptoGramPerKiloNewtonSecond", "x * 1e-21");
                _conversionFunctions.Add("YoctoGramPerKiloNewtonSecond", "x * 1e-24");
            }
        }
    }
