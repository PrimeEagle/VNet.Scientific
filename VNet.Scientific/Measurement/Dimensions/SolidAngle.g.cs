
    // Auto-generated for VNet on 2023-07-03 11:25:32
    using System.Numerics;
    
    
    namespace VNet.Scientific.Measurement.Dimensions
    {
        public sealed class SolidAngle<TVal> : DimensionBase<SolidAngleUnit, TVal> where TVal : notnull, INumber<TVal>
        {
            public override string IdTag => nameof(SolidAngle<TVal>);
            
            public SolidAngle() : base()
            {
                DimensionComponent.Exponents.Length = 0;
                DimensionComponent.Exponents.Mass = 0;
                DimensionComponent.Exponents.Time = 0;
                DimensionComponent.Exponents.ElectricalCurrent = 0;
                DimensionComponent.Exponents.LuminousIntensity = 0;
                DimensionComponent.Exponents.Temperature = 0;
                DimensionComponent.Exponents.Amount = 0;
                
                DefaultUnit = SolidAngleUnit.Steradian;
                
                
                _conversionFunctions.Add("YottaSteradian", "x * 1e24");
                _conversionFunctions.Add("ZettaSteradian", "x * 1e21");
                _conversionFunctions.Add("ExaSteradian", "x * 1e18");
                _conversionFunctions.Add("PetaSteradian", "x * 1e15");
                _conversionFunctions.Add("TeraSteradian", "x * 1e12");
                _conversionFunctions.Add("GigaSteradian", "x * 1e9");
                _conversionFunctions.Add("MegaSteradian", "x * 1e6");
                _conversionFunctions.Add("KiloSteradian", "x * 1e3");
                _conversionFunctions.Add("HectoSteradian", "x * 1e2");
                _conversionFunctions.Add("DekaSteradian", "x * 1e1");
                _conversionFunctions.Add("Steradian", "x * 1e0");
                _conversionFunctions.Add("DeciSteradian", "x * 1e-1");
                _conversionFunctions.Add("CentiSteradian", "x * 1e-2");
                _conversionFunctions.Add("MilliSteradian", "x * 1e-3");
                _conversionFunctions.Add("MicroSteradian", "x * 1e-6");
                _conversionFunctions.Add("NanoSteradian", "x * 1e-9");
                _conversionFunctions.Add("PicoSteradian", "x * 1e-12");
                _conversionFunctions.Add("FemtoSteradian", "x * 1e-15");
                _conversionFunctions.Add("AttoSteradian", "x * 1e-18");
                _conversionFunctions.Add("ZeptoSteradian", "x * 1e-21");
                _conversionFunctions.Add("YoctoSteradian", "x * 1e-24");
            }
        }
    }
