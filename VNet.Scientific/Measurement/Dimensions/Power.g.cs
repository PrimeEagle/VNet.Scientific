
    // Auto-generated for VNet on 2023-07-03 11:25:32
    using System.Numerics;
    
    
    namespace VNet.Scientific.Measurement.Dimensions
    {
        public sealed class Power<TVal> : DimensionBase<PowerUnit, TVal> where TVal : notnull, INumber<TVal>
        {
            public override string IdTag => nameof(Power<TVal>);
            
            public Power() : base()
            {
                DimensionComponent.Exponents.Length = 2;
                DimensionComponent.Exponents.Mass = 1;
                DimensionComponent.Exponents.Time = -3;
                DimensionComponent.Exponents.ElectricalCurrent = 0;
                DimensionComponent.Exponents.LuminousIntensity = 0;
                DimensionComponent.Exponents.Temperature = 0;
                DimensionComponent.Exponents.Amount = 0;
                
                DefaultUnit = PowerUnit.Watt;
                
                
                _conversionFunctions.Add("MechanicalHorsepower", "x * 745.69m");
                _conversionFunctions.Add("MetricHorsepower", "x * 735.49875m");
                _conversionFunctions.Add("ElectricalHorsepower", "x * 746m");
                _conversionFunctions.Add("BoilerHorsepower", "x * 9812.5m");
                _conversionFunctions.Add("HydraulicHorsepower", "x * 745.69988145m");
                _conversionFunctions.Add("BritishThermalUnitPerHour", "x * 0.29307107017m");
                _conversionFunctions.Add("JoulePerHour", "x / 3600m");
                _conversionFunctions.Add("YottaWatt", "x * 1e24");
                _conversionFunctions.Add("ZettaWatt", "x * 1e21");
                _conversionFunctions.Add("ExaWatt", "x * 1e18");
                _conversionFunctions.Add("PetaWatt", "x * 1e15");
                _conversionFunctions.Add("TeraWatt", "x * 1e12");
                _conversionFunctions.Add("GigaWatt", "x * 1e9");
                _conversionFunctions.Add("MegaWatt", "x * 1e6");
                _conversionFunctions.Add("KiloWatt", "x * 1e3");
                _conversionFunctions.Add("HectoWatt", "x * 1e2");
                _conversionFunctions.Add("DekaWatt", "x * 1e1");
                _conversionFunctions.Add("Watt", "x * 1e0");
                _conversionFunctions.Add("DeciWatt", "x * 1e-1");
                _conversionFunctions.Add("CentiWatt", "x * 1e-2");
                _conversionFunctions.Add("MilliWatt", "x * 1e-3");
                _conversionFunctions.Add("MicroWatt", "x * 1e-6");
                _conversionFunctions.Add("NanoWatt", "x * 1e-9");
                _conversionFunctions.Add("PicoWatt", "x * 1e-12");
                _conversionFunctions.Add("FemtoWatt", "x * 1e-15");
                _conversionFunctions.Add("AttoWatt", "x * 1e-18");
                _conversionFunctions.Add("ZeptoWatt", "x * 1e-21");
                _conversionFunctions.Add("YoctoWatt", "x * 1e-24");
            }
        }
    }
