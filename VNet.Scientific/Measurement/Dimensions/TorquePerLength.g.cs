
    // Auto-generated for VNet on 2023-07-03 11:25:32
    using System.Numerics;
    
    
    namespace VNet.Scientific.Measurement.Dimensions
    {
        public sealed class TorquePerLength<TVal> : DimensionBase<TorquePerLengthUnit, TVal> where TVal : notnull, INumber<TVal>
        {
            public override string IdTag => nameof(TorquePerLength<TVal>);
            
            public TorquePerLength() : base()
            {
                DimensionComponent.Exponents.Length = 1;
                DimensionComponent.Exponents.Mass = 1;
                DimensionComponent.Exponents.Time = -2;
                DimensionComponent.Exponents.ElectricalCurrent = 0;
                DimensionComponent.Exponents.LuminousIntensity = 0;
                DimensionComponent.Exponents.Temperature = 0;
                DimensionComponent.Exponents.Amount = 0;
                
                DefaultUnit = TorquePerLengthUnit.NewtonMeterPerMeter;
                
                
                _conversionFunctions.Add("NewtonMillimeterPerMeter", "x * 0.001");
                _conversionFunctions.Add("NewtonCentimeterPerMeter", "x * 0.01");
                _conversionFunctions.Add("PoundForceInchPerFoot", "x * 0.370685147638");
                _conversionFunctions.Add("PoundForceFootPerFoot", "x * 4.44822161526");
                _conversionFunctions.Add("KilogramForceMillimeterPerMeter", "x * 0.00980665019960652");
                _conversionFunctions.Add("KilogramForceCentimeterPerMeter", "x * 0.0980665019960652");
                _conversionFunctions.Add("KilogramForceMeterPerMeter", "x * 9.80665019960652");
                _conversionFunctions.Add("TonneForceMillimeterPerMeter", "x * 9.80665019960652");
                _conversionFunctions.Add("TonneForceCentimeterPerMeter", "x * 98.0665019960652");
                _conversionFunctions.Add("TonneForceMeterPerMeter", "x * 9806.65019960653");
                _conversionFunctions.Add("YottaNewtonMeterPerMeter", "x * 1e24");
                _conversionFunctions.Add("ZettaNewtonMeterPerMeter", "x * 1e21");
                _conversionFunctions.Add("ExaNewtonMeterPerMeter", "x * 1e18");
                _conversionFunctions.Add("PetaNewtonMeterPerMeter", "x * 1e15");
                _conversionFunctions.Add("TeraNewtonMeterPerMeter", "x * 1e12");
                _conversionFunctions.Add("GigaNewtonMeterPerMeter", "x * 1e9");
                _conversionFunctions.Add("MegaNewtonMeterPerMeter", "x * 1e6");
                _conversionFunctions.Add("KiloNewtonMeterPerMeter", "x * 1e3");
                _conversionFunctions.Add("HectoNewtonMeterPerMeter", "x * 1e2");
                _conversionFunctions.Add("DekaNewtonMeterPerMeter", "x * 1e1");
                _conversionFunctions.Add("NewtonMeterPerMeter", "x * 1e0");
                _conversionFunctions.Add("DeciNewtonMeterPerMeter", "x * 1e-1");
                _conversionFunctions.Add("CentiNewtonMeterPerMeter", "x * 1e-2");
                _conversionFunctions.Add("MilliNewtonMeterPerMeter", "x * 1e-3");
                _conversionFunctions.Add("MicroNewtonMeterPerMeter", "x * 1e-6");
                _conversionFunctions.Add("NanoNewtonMeterPerMeter", "x * 1e-9");
                _conversionFunctions.Add("PicoNewtonMeterPerMeter", "x * 1e-12");
                _conversionFunctions.Add("FemtoNewtonMeterPerMeter", "x * 1e-15");
                _conversionFunctions.Add("AttoNewtonMeterPerMeter", "x * 1e-18");
                _conversionFunctions.Add("ZeptoNewtonMeterPerMeter", "x * 1e-21");
                _conversionFunctions.Add("YoctoNewtonMeterPerMeter", "x * 1e-24");
            }
        }
    }
