
    // Auto-generated for VNet on 2023-07-03 11:25:32
    using System.Numerics;
    
    
    namespace VNet.Scientific.Measurement.Dimensions
    {
        public sealed class RotationalStiffness<TVal> : DimensionBase<RotationalStiffnessUnit, TVal> where TVal : notnull, INumber<TVal>
        {
            public override string IdTag => nameof(RotationalStiffness<TVal>);
            
            public RotationalStiffness() : base()
            {
                DimensionComponent.Exponents.Length = 2;
                DimensionComponent.Exponents.Mass = 1;
                DimensionComponent.Exponents.Time = -2;
                DimensionComponent.Exponents.ElectricalCurrent = 0;
                DimensionComponent.Exponents.LuminousIntensity = 0;
                DimensionComponent.Exponents.Temperature = 0;
                DimensionComponent.Exponents.Amount = 0;
                
                DefaultUnit = RotationalStiffnessUnit.NewtonMeterPerRadian;
                
                
                _conversionFunctions.Add("PoundForceFootPerDegrees", "x * 77.6826");
                _conversionFunctions.Add("KilopoundForceFootPerDegrees", "x * 77682.6");
                _conversionFunctions.Add("NewtonMillimeterPerDegree", "x * 180 / Math.PI * 0.001");
                _conversionFunctions.Add("NewtonMeterPerDegree", "x * (180 / Math.PI)");
                _conversionFunctions.Add("NewtonMillimeterPerRadian", "x * 0.001");
                _conversionFunctions.Add("PoundForceFeetPerRadian", "x * 1.3558179483314");
                _conversionFunctions.Add("YottaNewtonMeterPerRadian", "x * 1e24");
                _conversionFunctions.Add("ZettaNewtonMeterPerRadian", "x * 1e21");
                _conversionFunctions.Add("ExaNewtonMeterPerRadian", "x * 1e18");
                _conversionFunctions.Add("PetaNewtonMeterPerRadian", "x * 1e15");
                _conversionFunctions.Add("TeraNewtonMeterPerRadian", "x * 1e12");
                _conversionFunctions.Add("GigaNewtonMeterPerRadian", "x * 1e9");
                _conversionFunctions.Add("MegaNewtonMeterPerRadian", "x * 1e6");
                _conversionFunctions.Add("KiloNewtonMeterPerRadian", "x * 1e3");
                _conversionFunctions.Add("HectoNewtonMeterPerRadian", "x * 1e2");
                _conversionFunctions.Add("DekaNewtonMeterPerRadian", "x * 1e1");
                _conversionFunctions.Add("NewtonMeterPerRadian", "x * 1e0");
                _conversionFunctions.Add("DeciNewtonMeterPerRadian", "x * 1e-1");
                _conversionFunctions.Add("CentiNewtonMeterPerRadian", "x * 1e-2");
                _conversionFunctions.Add("MilliNewtonMeterPerRadian", "x * 1e-3");
                _conversionFunctions.Add("MicroNewtonMeterPerRadian", "x * 1e-6");
                _conversionFunctions.Add("NanoNewtonMeterPerRadian", "x * 1e-9");
                _conversionFunctions.Add("PicoNewtonMeterPerRadian", "x * 1e-12");
                _conversionFunctions.Add("FemtoNewtonMeterPerRadian", "x * 1e-15");
                _conversionFunctions.Add("AttoNewtonMeterPerRadian", "x * 1e-18");
                _conversionFunctions.Add("ZeptoNewtonMeterPerRadian", "x * 1e-21");
                _conversionFunctions.Add("YoctoNewtonMeterPerRadian", "x * 1e-24");
            }
        }
    }
