
    // Auto-generated for VNet on 2023-07-03 11:25:32
    using System.Numerics;
    
    
    namespace VNet.Scientific.Measurement.Dimensions
    {
        public sealed class MolarFlow<TVal> : DimensionBase<MolarFlowUnit, TVal> where TVal : notnull, INumber<TVal>
        {
            public override string IdTag => nameof(MolarFlow<TVal>);
            
            public MolarFlow() : base()
            {
                DimensionComponent.Exponents.Length = 0;
                DimensionComponent.Exponents.Mass = 0;
                DimensionComponent.Exponents.Time = -1;
                DimensionComponent.Exponents.ElectricalCurrent = 0;
                DimensionComponent.Exponents.LuminousIntensity = 0;
                DimensionComponent.Exponents.Temperature = 0;
                DimensionComponent.Exponents.Amount = 1;
                
                DefaultUnit = MolarFlowUnit.MolePerSecond;
                
                
                _conversionFunctions.Add("MolePerMinute", "x / 60");
                _conversionFunctions.Add("MolePerHour", "x / 3600");
                _conversionFunctions.Add("PoundMolePerSecond", "x * 453.59237");
                _conversionFunctions.Add("PoundMolePerMinute", "(x * 453.59237) / 60");
                _conversionFunctions.Add("PoundMolePerHour", "(x * 453.59237) / 3600");
                _conversionFunctions.Add("YottaMolePerSecond", "x * 1e24");
                _conversionFunctions.Add("ZettaMolePerSecond", "x * 1e21");
                _conversionFunctions.Add("ExaMolePerSecond", "x * 1e18");
                _conversionFunctions.Add("PetaMolePerSecond", "x * 1e15");
                _conversionFunctions.Add("TeraMolePerSecond", "x * 1e12");
                _conversionFunctions.Add("GigaMolePerSecond", "x * 1e9");
                _conversionFunctions.Add("MegaMolePerSecond", "x * 1e6");
                _conversionFunctions.Add("KiloMolePerSecond", "x * 1e3");
                _conversionFunctions.Add("HectoMolePerSecond", "x * 1e2");
                _conversionFunctions.Add("DekaMolePerSecond", "x * 1e1");
                _conversionFunctions.Add("MolePerSecond", "x * 1e0");
                _conversionFunctions.Add("DeciMolePerSecond", "x * 1e-1");
                _conversionFunctions.Add("CentiMolePerSecond", "x * 1e-2");
                _conversionFunctions.Add("MilliMolePerSecond", "x * 1e-3");
                _conversionFunctions.Add("MicroMolePerSecond", "x * 1e-6");
                _conversionFunctions.Add("NanoMolePerSecond", "x * 1e-9");
                _conversionFunctions.Add("PicoMolePerSecond", "x * 1e-12");
                _conversionFunctions.Add("FemtoMolePerSecond", "x * 1e-15");
                _conversionFunctions.Add("AttoMolePerSecond", "x * 1e-18");
                _conversionFunctions.Add("ZeptoMolePerSecond", "x * 1e-21");
                _conversionFunctions.Add("YoctoMolePerSecond", "x * 1e-24");
            }
        }
    }
