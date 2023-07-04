
    // Auto-generated for VNet on 2023-07-03 11:25:32
    using System.Numerics;
    
    
    namespace VNet.Scientific.Measurement.Dimensions
    {
        public sealed class MolarEntropy<TVal> : DimensionBase<MolarEntropyUnit, TVal> where TVal : notnull, INumber<TVal>
        {
            public override string IdTag => nameof(MolarEntropy<TVal>);
            
            public MolarEntropy() : base()
            {
                DimensionComponent.Exponents.Length = 2;
                DimensionComponent.Exponents.Mass = 1;
                DimensionComponent.Exponents.Time = -2;
                DimensionComponent.Exponents.ElectricalCurrent = 0;
                DimensionComponent.Exponents.LuminousIntensity = 0;
                DimensionComponent.Exponents.Temperature = -1;
                DimensionComponent.Exponents.Amount = -1;
                
                DefaultUnit = MolarEntropyUnit.JoulePerMoleKelvin;
                
                
                _conversionFunctions.Add("YottaJoulePerMoleKelvin", "x * 1e24");
                _conversionFunctions.Add("ZettaJoulePerMoleKelvin", "x * 1e21");
                _conversionFunctions.Add("ExaJoulePerMoleKelvin", "x * 1e18");
                _conversionFunctions.Add("PetaJoulePerMoleKelvin", "x * 1e15");
                _conversionFunctions.Add("TeraJoulePerMoleKelvin", "x * 1e12");
                _conversionFunctions.Add("GigaJoulePerMoleKelvin", "x * 1e9");
                _conversionFunctions.Add("MegaJoulePerMoleKelvin", "x * 1e6");
                _conversionFunctions.Add("KiloJoulePerMoleKelvin", "x * 1e3");
                _conversionFunctions.Add("HectoJoulePerMoleKelvin", "x * 1e2");
                _conversionFunctions.Add("DekaJoulePerMoleKelvin", "x * 1e1");
                _conversionFunctions.Add("JoulePerMoleKelvin", "x * 1e0");
                _conversionFunctions.Add("DeciJoulePerMoleKelvin", "x * 1e-1");
                _conversionFunctions.Add("CentiJoulePerMoleKelvin", "x * 1e-2");
                _conversionFunctions.Add("MilliJoulePerMoleKelvin", "x * 1e-3");
                _conversionFunctions.Add("MicroJoulePerMoleKelvin", "x * 1e-6");
                _conversionFunctions.Add("NanoJoulePerMoleKelvin", "x * 1e-9");
                _conversionFunctions.Add("PicoJoulePerMoleKelvin", "x * 1e-12");
                _conversionFunctions.Add("FemtoJoulePerMoleKelvin", "x * 1e-15");
                _conversionFunctions.Add("AttoJoulePerMoleKelvin", "x * 1e-18");
                _conversionFunctions.Add("ZeptoJoulePerMoleKelvin", "x * 1e-21");
                _conversionFunctions.Add("YoctoJoulePerMoleKelvin", "x * 1e-24");
            }
        }
    }
