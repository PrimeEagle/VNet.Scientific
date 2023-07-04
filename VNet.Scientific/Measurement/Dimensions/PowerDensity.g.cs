
    // Auto-generated for VNet on 2023-07-03 11:25:32
    using System.Numerics;
    
    
    namespace VNet.Scientific.Measurement.Dimensions
    {
        public sealed class PowerDensity<TVal> : DimensionBase<PowerDensityUnit, TVal> where TVal : notnull, INumber<TVal>
        {
            public override string IdTag => nameof(PowerDensity<TVal>);
            
            public PowerDensity() : base()
            {
                DimensionComponent.Exponents.Length = -1;
                DimensionComponent.Exponents.Mass = 1;
                DimensionComponent.Exponents.Time = -3;
                DimensionComponent.Exponents.ElectricalCurrent = 0;
                DimensionComponent.Exponents.LuminousIntensity = 0;
                DimensionComponent.Exponents.Temperature = 0;
                DimensionComponent.Exponents.Amount = 0;
                
                DefaultUnit = PowerDensityUnit.WattPerCubicMeter;
                
                
                _conversionFunctions.Add("WattPerCubicInch", "x * 6.102374409473228e4");
                _conversionFunctions.Add("WattPerCubicFoot", "x * 3.531466672148859e1");
                _conversionFunctions.Add("WattPerLiter", "x * 1.0e3");
                _conversionFunctions.Add("YottaWattPerCubicMeter", "x * 1e24");
                _conversionFunctions.Add("ZettaWattPerCubicMeter", "x * 1e21");
                _conversionFunctions.Add("ExaWattPerCubicMeter", "x * 1e18");
                _conversionFunctions.Add("PetaWattPerCubicMeter", "x * 1e15");
                _conversionFunctions.Add("TeraWattPerCubicMeter", "x * 1e12");
                _conversionFunctions.Add("GigaWattPerCubicMeter", "x * 1e9");
                _conversionFunctions.Add("MegaWattPerCubicMeter", "x * 1e6");
                _conversionFunctions.Add("KiloWattPerCubicMeter", "x * 1e3");
                _conversionFunctions.Add("HectoWattPerCubicMeter", "x * 1e2");
                _conversionFunctions.Add("DekaWattPerCubicMeter", "x * 1e1");
                _conversionFunctions.Add("WattPerCubicMeter", "x * 1e0");
                _conversionFunctions.Add("DeciWattPerCubicMeter", "x * 1e-1");
                _conversionFunctions.Add("CentiWattPerCubicMeter", "x * 1e-2");
                _conversionFunctions.Add("MilliWattPerCubicMeter", "x * 1e-3");
                _conversionFunctions.Add("MicroWattPerCubicMeter", "x * 1e-6");
                _conversionFunctions.Add("NanoWattPerCubicMeter", "x * 1e-9");
                _conversionFunctions.Add("PicoWattPerCubicMeter", "x * 1e-12");
                _conversionFunctions.Add("FemtoWattPerCubicMeter", "x * 1e-15");
                _conversionFunctions.Add("AttoWattPerCubicMeter", "x * 1e-18");
                _conversionFunctions.Add("ZeptoWattPerCubicMeter", "x * 1e-21");
                _conversionFunctions.Add("YoctoWattPerCubicMeter", "x * 1e-24");
            }
        }
    }
