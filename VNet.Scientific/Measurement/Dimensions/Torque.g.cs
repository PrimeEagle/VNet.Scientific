
    // Auto-generated for VNet on 2023-07-03 11:25:32
    using System.Numerics;
    
    
    namespace VNet.Scientific.Measurement.Dimensions
    {
        public sealed class Torque<TVal> : DimensionBase<TorqueUnit, TVal> where TVal : notnull, INumber<TVal>
        {
            public override string IdTag => nameof(Torque<TVal>);
            
            public Torque() : base()
            {
                DimensionComponent.Exponents.Length = 2;
                DimensionComponent.Exponents.Mass = 1;
                DimensionComponent.Exponents.Time = -2;
                DimensionComponent.Exponents.ElectricalCurrent = 0;
                DimensionComponent.Exponents.LuminousIntensity = 0;
                DimensionComponent.Exponents.Temperature = 0;
                DimensionComponent.Exponents.Amount = 0;
                
                DefaultUnit = TorqueUnit.NewtonMeter;
                
                
                _conversionFunctions.Add("NewtonMillimeter", "x * 0.001");
                _conversionFunctions.Add("NewtonCentimeter", "x * 0.01");
                _conversionFunctions.Add("PoundalFoot", "x * 4.21401100938048e-2");
                _conversionFunctions.Add("PoundForceInch", "x * 1.129848290276167e-1");
                _conversionFunctions.Add("PoundForceFoot", "x * 1.3558179483314");
                _conversionFunctions.Add("GramForceMillimeter", "x * 9.80665e-6");
                _conversionFunctions.Add("GramForceCentimeter", "x * 9.80665e-5");
                _conversionFunctions.Add("GramForceMeter", "x * 9.80665e-3");
                _conversionFunctions.Add("KilogramForceMillimeter", "x * 9.80665e-3");
                _conversionFunctions.Add("KilogramForceCentimeter", "x * 9.80665e-2");
                _conversionFunctions.Add("KilogramForceMeter", "x * 9.80665");
                _conversionFunctions.Add("TonneForceMillimeter", "x * 9.80665");
                _conversionFunctions.Add("TonneForceCentimeter", "x * 9.80665e1");
                _conversionFunctions.Add("TonneForceMeter", "x * 9.80665e3");
                _conversionFunctions.Add("YottaNewtonMeter", "x * 1e24");
                _conversionFunctions.Add("ZettaNewtonMeter", "x * 1e21");
                _conversionFunctions.Add("ExaNewtonMeter", "x * 1e18");
                _conversionFunctions.Add("PetaNewtonMeter", "x * 1e15");
                _conversionFunctions.Add("TeraNewtonMeter", "x * 1e12");
                _conversionFunctions.Add("GigaNewtonMeter", "x * 1e9");
                _conversionFunctions.Add("MegaNewtonMeter", "x * 1e6");
                _conversionFunctions.Add("KiloNewtonMeter", "x * 1e3");
                _conversionFunctions.Add("HectoNewtonMeter", "x * 1e2");
                _conversionFunctions.Add("DekaNewtonMeter", "x * 1e1");
                _conversionFunctions.Add("NewtonMeter", "x * 1e0");
                _conversionFunctions.Add("DeciNewtonMeter", "x * 1e-1");
                _conversionFunctions.Add("CentiNewtonMeter", "x * 1e-2");
                _conversionFunctions.Add("MilliNewtonMeter", "x * 1e-3");
                _conversionFunctions.Add("MicroNewtonMeter", "x * 1e-6");
                _conversionFunctions.Add("NanoNewtonMeter", "x * 1e-9");
                _conversionFunctions.Add("PicoNewtonMeter", "x * 1e-12");
                _conversionFunctions.Add("FemtoNewtonMeter", "x * 1e-15");
                _conversionFunctions.Add("AttoNewtonMeter", "x * 1e-18");
                _conversionFunctions.Add("ZeptoNewtonMeter", "x * 1e-21");
                _conversionFunctions.Add("YoctoNewtonMeter", "x * 1e-24");
            }
        }
    }
