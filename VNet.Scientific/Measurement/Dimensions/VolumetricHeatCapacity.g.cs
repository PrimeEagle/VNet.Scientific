
    // Auto-generated for VNet on 2023-07-03 11:25:32
    using System.Numerics;
    
    
    namespace VNet.Scientific.Measurement.Dimensions
    {
        public sealed class VolumetricHeatCapacity<TVal> : DimensionBase<VolumetricHeatCapacityUnit, TVal> where TVal : notnull, INumber<TVal>
        {
            public override string IdTag => nameof(VolumetricHeatCapacity<TVal>);
            
            public VolumetricHeatCapacity() : base()
            {
                DimensionComponent.Exponents.Length = -1;
                DimensionComponent.Exponents.Mass = 1;
                DimensionComponent.Exponents.Time = -2;
                DimensionComponent.Exponents.ElectricalCurrent = 0;
                DimensionComponent.Exponents.LuminousIntensity = 0;
                DimensionComponent.Exponents.Temperature = -1;
                DimensionComponent.Exponents.Amount = 0;
                
                DefaultUnit = VolumetricHeatCapacityUnit.JoulePerCubicMeterKelvin;
                
                
                _conversionFunctions.Add("JoulePerCubicMeterDegreeCelsius", "x");
                _conversionFunctions.Add("CaloriePerCubicCentimeterDegreeCelsius", "x / 2.388459e-7");
                _conversionFunctions.Add("BtuPerCubicFootDegreeFahrenheit", "x / 1.4910660e-5");
                _conversionFunctions.Add("YottaJoulePerCubicMeterKelvin", "x * 1e24");
                _conversionFunctions.Add("ZettaJoulePerCubicMeterKelvin", "x * 1e21");
                _conversionFunctions.Add("ExaJoulePerCubicMeterKelvin", "x * 1e18");
                _conversionFunctions.Add("PetaJoulePerCubicMeterKelvin", "x * 1e15");
                _conversionFunctions.Add("TeraJoulePerCubicMeterKelvin", "x * 1e12");
                _conversionFunctions.Add("GigaJoulePerCubicMeterKelvin", "x * 1e9");
                _conversionFunctions.Add("MegaJoulePerCubicMeterKelvin", "x * 1e6");
                _conversionFunctions.Add("KiloJoulePerCubicMeterKelvin", "x * 1e3");
                _conversionFunctions.Add("HectoJoulePerCubicMeterKelvin", "x * 1e2");
                _conversionFunctions.Add("DekaJoulePerCubicMeterKelvin", "x * 1e1");
                _conversionFunctions.Add("JoulePerCubicMeterKelvin", "x * 1e0");
                _conversionFunctions.Add("DeciJoulePerCubicMeterKelvin", "x * 1e-1");
                _conversionFunctions.Add("CentiJoulePerCubicMeterKelvin", "x * 1e-2");
                _conversionFunctions.Add("MilliJoulePerCubicMeterKelvin", "x * 1e-3");
                _conversionFunctions.Add("MicroJoulePerCubicMeterKelvin", "x * 1e-6");
                _conversionFunctions.Add("NanoJoulePerCubicMeterKelvin", "x * 1e-9");
                _conversionFunctions.Add("PicoJoulePerCubicMeterKelvin", "x * 1e-12");
                _conversionFunctions.Add("FemtoJoulePerCubicMeterKelvin", "x * 1e-15");
                _conversionFunctions.Add("AttoJoulePerCubicMeterKelvin", "x * 1e-18");
                _conversionFunctions.Add("ZeptoJoulePerCubicMeterKelvin", "x * 1e-21");
                _conversionFunctions.Add("YoctoJoulePerCubicMeterKelvin", "x * 1e-24");
            }
        }
    }
