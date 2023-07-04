
    // Auto-generated for VNet on 2023-07-03 11:25:32
    using System.Numerics;
    
    
    namespace VNet.Scientific.Measurement.Dimensions
    {
        public sealed class RotationalSpeed<TVal> : DimensionBase<RotationalSpeedUnit, TVal> where TVal : notnull, INumber<TVal>
        {
            public override string IdTag => nameof(RotationalSpeed<TVal>);
            
            public RotationalSpeed() : base()
            {
                DimensionComponent.Exponents.Length = 0;
                DimensionComponent.Exponents.Mass = 0;
                DimensionComponent.Exponents.Time = -1;
                DimensionComponent.Exponents.ElectricalCurrent = 0;
                DimensionComponent.Exponents.LuminousIntensity = 0;
                DimensionComponent.Exponents.Temperature = 0;
                DimensionComponent.Exponents.Amount = 0;
                
                DefaultUnit = RotationalSpeedUnit.RadianPerSecond;
                
                
                _conversionFunctions.Add("DegreePerSecond", "(Math.PI / 180) * x");
                _conversionFunctions.Add("DegreePerMinute", "(Math.PI / (180 * 60)) * x");
                _conversionFunctions.Add("RevolutionPerSecond", "x * 6.2831853072");
                _conversionFunctions.Add("RevolutionPerMinute", "(x * 6.2831853072) / 60");
                _conversionFunctions.Add("YottaRadianPerSecond", "x * 1e24");
                _conversionFunctions.Add("ZettaRadianPerSecond", "x * 1e21");
                _conversionFunctions.Add("ExaRadianPerSecond", "x * 1e18");
                _conversionFunctions.Add("PetaRadianPerSecond", "x * 1e15");
                _conversionFunctions.Add("TeraRadianPerSecond", "x * 1e12");
                _conversionFunctions.Add("GigaRadianPerSecond", "x * 1e9");
                _conversionFunctions.Add("MegaRadianPerSecond", "x * 1e6");
                _conversionFunctions.Add("KiloRadianPerSecond", "x * 1e3");
                _conversionFunctions.Add("HectoRadianPerSecond", "x * 1e2");
                _conversionFunctions.Add("DekaRadianPerSecond", "x * 1e1");
                _conversionFunctions.Add("RadianPerSecond", "x * 1e0");
                _conversionFunctions.Add("DeciRadianPerSecond", "x * 1e-1");
                _conversionFunctions.Add("CentiRadianPerSecond", "x * 1e-2");
                _conversionFunctions.Add("MilliRadianPerSecond", "x * 1e-3");
                _conversionFunctions.Add("MicroRadianPerSecond", "x * 1e-6");
                _conversionFunctions.Add("NanoRadianPerSecond", "x * 1e-9");
                _conversionFunctions.Add("PicoRadianPerSecond", "x * 1e-12");
                _conversionFunctions.Add("FemtoRadianPerSecond", "x * 1e-15");
                _conversionFunctions.Add("AttoRadianPerSecond", "x * 1e-18");
                _conversionFunctions.Add("ZeptoRadianPerSecond", "x * 1e-21");
                _conversionFunctions.Add("YoctoRadianPerSecond", "x * 1e-24");
            }
        }
    }
