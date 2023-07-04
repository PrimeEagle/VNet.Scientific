
    // Auto-generated for VNet on 2023-07-03 11:25:32
    using System.Numerics;
    
    
    namespace VNet.Scientific.Measurement.Dimensions
    {
        public sealed class TemperatureChangeRate<TVal> : DimensionBase<TemperatureChangeRateUnit, TVal> where TVal : notnull, INumber<TVal>
        {
            public override string IdTag => nameof(TemperatureChangeRate<TVal>);
            
            public TemperatureChangeRate() : base()
            {
                DimensionComponent.Exponents.Length = 0;
                DimensionComponent.Exponents.Mass = 0;
                DimensionComponent.Exponents.Time = -1;
                DimensionComponent.Exponents.ElectricalCurrent = 0;
                DimensionComponent.Exponents.LuminousIntensity = 0;
                DimensionComponent.Exponents.Temperature = 1;
                DimensionComponent.Exponents.Amount = 0;
                
                DefaultUnit = TemperatureChangeRateUnit.DegreeCelsiusPerSecond;
                
                
                _conversionFunctions.Add("DegreeCelsiusPerMinute", "x / 60");
                _conversionFunctions.Add("YottaDegreeCelsiusPerSecond", "x * 1e24");
                _conversionFunctions.Add("ZettaDegreeCelsiusPerSecond", "x * 1e21");
                _conversionFunctions.Add("ExaDegreeCelsiusPerSecond", "x * 1e18");
                _conversionFunctions.Add("PetaDegreeCelsiusPerSecond", "x * 1e15");
                _conversionFunctions.Add("TeraDegreeCelsiusPerSecond", "x * 1e12");
                _conversionFunctions.Add("GigaDegreeCelsiusPerSecond", "x * 1e9");
                _conversionFunctions.Add("MegaDegreeCelsiusPerSecond", "x * 1e6");
                _conversionFunctions.Add("KiloDegreeCelsiusPerSecond", "x * 1e3");
                _conversionFunctions.Add("HectoDegreeCelsiusPerSecond", "x * 1e2");
                _conversionFunctions.Add("DekaDegreeCelsiusPerSecond", "x * 1e1");
                _conversionFunctions.Add("DegreeCelsiusPerSecond", "x * 1e0");
                _conversionFunctions.Add("DeciDegreeCelsiusPerSecond", "x * 1e-1");
                _conversionFunctions.Add("CentiDegreeCelsiusPerSecond", "x * 1e-2");
                _conversionFunctions.Add("MilliDegreeCelsiusPerSecond", "x * 1e-3");
                _conversionFunctions.Add("MicroDegreeCelsiusPerSecond", "x * 1e-6");
                _conversionFunctions.Add("NanoDegreeCelsiusPerSecond", "x * 1e-9");
                _conversionFunctions.Add("PicoDegreeCelsiusPerSecond", "x * 1e-12");
                _conversionFunctions.Add("FemtoDegreeCelsiusPerSecond", "x * 1e-15");
                _conversionFunctions.Add("AttoDegreeCelsiusPerSecond", "x * 1e-18");
                _conversionFunctions.Add("ZeptoDegreeCelsiusPerSecond", "x * 1e-21");
                _conversionFunctions.Add("YoctoDegreeCelsiusPerSecond", "x * 1e-24");
            }
        }
    }
