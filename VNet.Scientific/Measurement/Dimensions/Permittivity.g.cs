
    // Auto-generated for VNet on 2023-07-03 11:25:32
    using System.Numerics;
    
    
    namespace VNet.Scientific.Measurement.Dimensions
    {
        public sealed class Permittivity<TVal> : DimensionBase<PermittivityUnit, TVal> where TVal : notnull, INumber<TVal>
        {
            public override string IdTag => nameof(Permittivity<TVal>);
            
            public Permittivity() : base()
            {
                DimensionComponent.Exponents.Length = -3;
                DimensionComponent.Exponents.Mass = -1;
                DimensionComponent.Exponents.Time = 4;
                DimensionComponent.Exponents.ElectricalCurrent = 2;
                DimensionComponent.Exponents.LuminousIntensity = 0;
                DimensionComponent.Exponents.Temperature = 0;
                DimensionComponent.Exponents.Amount = 0;
                
                DefaultUnit = PermittivityUnit.FaradPerMeter;
                
                
                _conversionFunctions.Add("YottaFaradPerMeter", "x * 1e24");
                _conversionFunctions.Add("ZettaFaradPerMeter", "x * 1e21");
                _conversionFunctions.Add("ExaFaradPerMeter", "x * 1e18");
                _conversionFunctions.Add("PetaFaradPerMeter", "x * 1e15");
                _conversionFunctions.Add("TeraFaradPerMeter", "x * 1e12");
                _conversionFunctions.Add("GigaFaradPerMeter", "x * 1e9");
                _conversionFunctions.Add("MegaFaradPerMeter", "x * 1e6");
                _conversionFunctions.Add("KiloFaradPerMeter", "x * 1e3");
                _conversionFunctions.Add("HectoFaradPerMeter", "x * 1e2");
                _conversionFunctions.Add("DekaFaradPerMeter", "x * 1e1");
                _conversionFunctions.Add("FaradPerMeter", "x * 1e0");
                _conversionFunctions.Add("DeciFaradPerMeter", "x * 1e-1");
                _conversionFunctions.Add("CentiFaradPerMeter", "x * 1e-2");
                _conversionFunctions.Add("MilliFaradPerMeter", "x * 1e-3");
                _conversionFunctions.Add("MicroFaradPerMeter", "x * 1e-6");
                _conversionFunctions.Add("NanoFaradPerMeter", "x * 1e-9");
                _conversionFunctions.Add("PicoFaradPerMeter", "x * 1e-12");
                _conversionFunctions.Add("FemtoFaradPerMeter", "x * 1e-15");
                _conversionFunctions.Add("AttoFaradPerMeter", "x * 1e-18");
                _conversionFunctions.Add("ZeptoFaradPerMeter", "x * 1e-21");
                _conversionFunctions.Add("YoctoFaradPerMeter", "x * 1e-24");
            }
        }
    }
