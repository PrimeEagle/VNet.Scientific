
    // Auto-generated for VNet on 2023-07-03 11:25:32
    using System.Numerics;
    
    
    namespace VNet.Scientific.Measurement.Dimensions
    {
        public sealed class SpecificEntropy<TVal> : DimensionBase<SpecificEntropyUnit, TVal> where TVal : notnull, INumber<TVal>
        {
            public override string IdTag => nameof(SpecificEntropy<TVal>);
            
            public SpecificEntropy() : base()
            {
                DimensionComponent.Exponents.Length = 2;
                DimensionComponent.Exponents.Mass = 0;
                DimensionComponent.Exponents.Time = -2;
                DimensionComponent.Exponents.ElectricalCurrent = 0;
                DimensionComponent.Exponents.LuminousIntensity = 0;
                DimensionComponent.Exponents.Temperature = -1;
                DimensionComponent.Exponents.Amount = 0;
                
                DefaultUnit = SpecificEntropyUnit.JoulePerKilogramKelvin;
                
                
                _conversionFunctions.Add("JoulePerKilogramDegreeCelsius", "x");
                _conversionFunctions.Add("CaloriePerGramKelvin", "x * 4.184e3");
                _conversionFunctions.Add("BtuPerPoundFahrenheit", "x * 4.1868e3");
                _conversionFunctions.Add("YottaJoulePerKilogramKelvin", "x * 1e24");
                _conversionFunctions.Add("ZettaJoulePerKilogramKelvin", "x * 1e21");
                _conversionFunctions.Add("ExaJoulePerKilogramKelvin", "x * 1e18");
                _conversionFunctions.Add("PetaJoulePerKilogramKelvin", "x * 1e15");
                _conversionFunctions.Add("TeraJoulePerKilogramKelvin", "x * 1e12");
                _conversionFunctions.Add("GigaJoulePerKilogramKelvin", "x * 1e9");
                _conversionFunctions.Add("MegaJoulePerKilogramKelvin", "x * 1e6");
                _conversionFunctions.Add("KiloJoulePerKilogramKelvin", "x * 1e3");
                _conversionFunctions.Add("HectoJoulePerKilogramKelvin", "x * 1e2");
                _conversionFunctions.Add("DekaJoulePerKilogramKelvin", "x * 1e1");
                _conversionFunctions.Add("JoulePerKilogramKelvin", "x * 1e0");
                _conversionFunctions.Add("DeciJoulePerKilogramKelvin", "x * 1e-1");
                _conversionFunctions.Add("CentiJoulePerKilogramKelvin", "x * 1e-2");
                _conversionFunctions.Add("MilliJoulePerKilogramKelvin", "x * 1e-3");
                _conversionFunctions.Add("MicroJoulePerKilogramKelvin", "x * 1e-6");
                _conversionFunctions.Add("NanoJoulePerKilogramKelvin", "x * 1e-9");
                _conversionFunctions.Add("PicoJoulePerKilogramKelvin", "x * 1e-12");
                _conversionFunctions.Add("FemtoJoulePerKilogramKelvin", "x * 1e-15");
                _conversionFunctions.Add("AttoJoulePerKilogramKelvin", "x * 1e-18");
                _conversionFunctions.Add("ZeptoJoulePerKilogramKelvin", "x * 1e-21");
                _conversionFunctions.Add("YoctoJoulePerKilogramKelvin", "x * 1e-24");
            }
        }
    }
