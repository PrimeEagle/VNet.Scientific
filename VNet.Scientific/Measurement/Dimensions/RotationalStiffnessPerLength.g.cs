
    // Auto-generated for VNet on 2023-07-03 11:25:32
    using System.Numerics;
    
    
    namespace VNet.Scientific.Measurement.Dimensions
    {
        public sealed class RotationalStiffnessPerLength<TVal> : DimensionBase<RotationalStiffnessPerLengthUnit, TVal> where TVal : notnull, INumber<TVal>
        {
            public override string IdTag => nameof(RotationalStiffnessPerLength<TVal>);
            
            public RotationalStiffnessPerLength() : base()
            {
                DimensionComponent.Exponents.Length = 1;
                DimensionComponent.Exponents.Mass = 1;
                DimensionComponent.Exponents.Time = -2;
                DimensionComponent.Exponents.ElectricalCurrent = 0;
                DimensionComponent.Exponents.LuminousIntensity = 0;
                DimensionComponent.Exponents.Temperature = 0;
                DimensionComponent.Exponents.Amount = 0;
                
                DefaultUnit = RotationalStiffnessPerLengthUnit.NewtonMeterPerRadianPerMeter;
                
                
                _conversionFunctions.Add("PoundForceFootPerDegreesPerFoot", "x * 254.864324570");
                _conversionFunctions.Add("KilopoundForceFootPerDegreesPerFoot", "x * 254864.324570");
                _conversionFunctions.Add("YottaNewtonMeterPerRadianPerMeter", "x * 1e24");
                _conversionFunctions.Add("ZettaNewtonMeterPerRadianPerMeter", "x * 1e21");
                _conversionFunctions.Add("ExaNewtonMeterPerRadianPerMeter", "x * 1e18");
                _conversionFunctions.Add("PetaNewtonMeterPerRadianPerMeter", "x * 1e15");
                _conversionFunctions.Add("TeraNewtonMeterPerRadianPerMeter", "x * 1e12");
                _conversionFunctions.Add("GigaNewtonMeterPerRadianPerMeter", "x * 1e9");
                _conversionFunctions.Add("MegaNewtonMeterPerRadianPerMeter", "x * 1e6");
                _conversionFunctions.Add("KiloNewtonMeterPerRadianPerMeter", "x * 1e3");
                _conversionFunctions.Add("HectoNewtonMeterPerRadianPerMeter", "x * 1e2");
                _conversionFunctions.Add("DekaNewtonMeterPerRadianPerMeter", "x * 1e1");
                _conversionFunctions.Add("NewtonMeterPerRadianPerMeter", "x * 1e0");
                _conversionFunctions.Add("DeciNewtonMeterPerRadianPerMeter", "x * 1e-1");
                _conversionFunctions.Add("CentiNewtonMeterPerRadianPerMeter", "x * 1e-2");
                _conversionFunctions.Add("MilliNewtonMeterPerRadianPerMeter", "x * 1e-3");
                _conversionFunctions.Add("MicroNewtonMeterPerRadianPerMeter", "x * 1e-6");
                _conversionFunctions.Add("NanoNewtonMeterPerRadianPerMeter", "x * 1e-9");
                _conversionFunctions.Add("PicoNewtonMeterPerRadianPerMeter", "x * 1e-12");
                _conversionFunctions.Add("FemtoNewtonMeterPerRadianPerMeter", "x * 1e-15");
                _conversionFunctions.Add("AttoNewtonMeterPerRadianPerMeter", "x * 1e-18");
                _conversionFunctions.Add("ZeptoNewtonMeterPerRadianPerMeter", "x * 1e-21");
                _conversionFunctions.Add("YoctoNewtonMeterPerRadianPerMeter", "x * 1e-24");
            }
        }
    }
