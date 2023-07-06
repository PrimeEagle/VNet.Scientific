
    // Auto-generated for VNet on 2023-07-05 10:24:46
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
                
                
                ConversionFunctions.Add(PowerUnit.MechanicalHorsepower, "x * 745.69m");
                ConversionFunctions.Add(PowerUnit.MetricHorsepower, "x * 735.49875m");
                ConversionFunctions.Add(PowerUnit.ElectricalHorsepower, "x * 746m");
                ConversionFunctions.Add(PowerUnit.BoilerHorsepower, "x * 9812.5m");
                ConversionFunctions.Add(PowerUnit.HydraulicHorsepower, "x * 745.69988145m");
                ConversionFunctions.Add(PowerUnit.BritishThermalUnitPerHour, "x * 0.29307107017m");
                ConversionFunctions.Add(PowerUnit.JoulePerHour, "x / 3600m");
                ConversionFunctions.Add(PowerUnit.Yottawatt, "x * 1e24");
                ConversionFunctions.Add(PowerUnit.Zettawatt, "x * 1e21");
                ConversionFunctions.Add(PowerUnit.Exawatt, "x * 1e18");
                ConversionFunctions.Add(PowerUnit.Petawatt, "x * 1e15");
                ConversionFunctions.Add(PowerUnit.Terawatt, "x * 1e12");
                ConversionFunctions.Add(PowerUnit.Gigawatt, "x * 1e9");
                ConversionFunctions.Add(PowerUnit.Megawatt, "x * 1e6");
                ConversionFunctions.Add(PowerUnit.Kilowatt, "x * 1e3");
                ConversionFunctions.Add(PowerUnit.Hectowatt, "x * 1e2");
                ConversionFunctions.Add(PowerUnit.Dekawatt, "x * 1e1");
                ConversionFunctions.Add(PowerUnit.Watt, "x * 1e0");
                ConversionFunctions.Add(PowerUnit.Deciwatt, "x * 1e-1");
                ConversionFunctions.Add(PowerUnit.Centiwatt, "x * 1e-2");
                ConversionFunctions.Add(PowerUnit.Milliwatt, "x * 1e-3");
                ConversionFunctions.Add(PowerUnit.Microwatt, "x * 1e-6");
                ConversionFunctions.Add(PowerUnit.Nanowatt, "x * 1e-9");
                ConversionFunctions.Add(PowerUnit.Picowatt, "x * 1e-12");
                ConversionFunctions.Add(PowerUnit.Femtowatt, "x * 1e-15");
                ConversionFunctions.Add(PowerUnit.Attowatt, "x * 1e-18");
                ConversionFunctions.Add(PowerUnit.Zeptowatt, "x * 1e-21");
                ConversionFunctions.Add(PowerUnit.Yoctowatt, "x * 1e-24");
            }
        }
    }
