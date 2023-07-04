
    // Auto-generated for VNet on 2023-07-03 11:25:32
    using System.Numerics;
    
    
    namespace VNet.Scientific.Measurement.Dimensions
    {
        public sealed class Volume<TVal> : DimensionBase<VolumeUnit, TVal> where TVal : notnull, INumber<TVal>
        {
            public override string IdTag => nameof(Volume<TVal>);
            
            public Volume() : base()
            {
                DimensionComponent.Exponents.Length = 3;
                DimensionComponent.Exponents.Mass = 0;
                DimensionComponent.Exponents.Time = 0;
                DimensionComponent.Exponents.ElectricalCurrent = 0;
                DimensionComponent.Exponents.LuminousIntensity = 0;
                DimensionComponent.Exponents.Temperature = 0;
                DimensionComponent.Exponents.Amount = 0;
                
                DefaultUnit = VolumeUnit.CubicMeter;
                
                
                _conversionFunctions.Add("Liter", "x / 1e3");
                _conversionFunctions.Add("CubicMile", "x * 4.16818182544058e9");
                _conversionFunctions.Add("CubicYard", "x * 0.764554858");
                _conversionFunctions.Add("CubicFoot", "x * 2.8316846592e-2");
                _conversionFunctions.Add("CubicInch", "x * 1.6387 * 1e-5");
                _conversionFunctions.Add("ImperialGallon", "x * 0.00454609");
                _conversionFunctions.Add("ImperialOunce", "x * 2.8413062499962901241875439064617e-5");
                _conversionFunctions.Add("UsGallon", "x * 0.003785411784");
                _conversionFunctions.Add("UsOunce", "x * 2.957352956253760505068307980135e-5");
                _conversionFunctions.Add("UsTablespoon", "x * 1.478676478125e-5");
                _conversionFunctions.Add("AuTablespoon", "x * 2e-5");
                _conversionFunctions.Add("UkTablespoon", "x * 1.5e-5");
                _conversionFunctions.Add("MetricTeaspoon", "x * 0.5e-5");
                _conversionFunctions.Add("UsTeaspoon", "x * 4.92892159375e-6");
                _conversionFunctions.Add("MetricCup", "x * 0.00025");
                _conversionFunctions.Add("UsCustomaryCup", "x * 0.0002365882365");
                _conversionFunctions.Add("UsLegalCup", "x * 0.00024");
                _conversionFunctions.Add("OilBarrel", "x * 0.158987294928");
                _conversionFunctions.Add("UsBeerBarrel", "x * 0.1173477658");
                _conversionFunctions.Add("ImperialBeerBarrel", "x * 0.16365924");
                _conversionFunctions.Add("UsQuart", "x * 9.46352946e-4");
                _conversionFunctions.Add("ImperialQuart", "x * 1.1365225e-3");
                _conversionFunctions.Add("UsPint", "x * 4.73176473e-4");
                _conversionFunctions.Add("AcreFoot", "x / 0.000810714");
                _conversionFunctions.Add("ImperialPint", "x * 5.6826125e-4");
                _conversionFunctions.Add("BoardFoot", "x * 2.3597372158e-3");
                _conversionFunctions.Add("CubicYottaMeter", "x * 1e72");
                _conversionFunctions.Add("CubicZettaMeter", "x * 1e63");
                _conversionFunctions.Add("CubicExaMeter", "x * 1e54");
                _conversionFunctions.Add("CubicPetaMeter", "x * 1e45");
                _conversionFunctions.Add("CubicTeraMeter", "x * 1e36");
                _conversionFunctions.Add("CubicGigaMeter", "x * 1e27");
                _conversionFunctions.Add("CubicMegaMeter", "x * 1e18");
                _conversionFunctions.Add("CubicKiloMeter", "x * 1e9");
                _conversionFunctions.Add("CubicHectoMeter", "x * 1e6");
                _conversionFunctions.Add("CubicDekaMeter", "x * 1e3");
                _conversionFunctions.Add("CubicMeter", "x * 1e0");
                _conversionFunctions.Add("CubicDeciMeter", "x * 1e-3");
                _conversionFunctions.Add("CubicCentiMeter", "x * 1e-6");
                _conversionFunctions.Add("CubicMilliMeter", "x * 1e-9");
                _conversionFunctions.Add("CubicMicroMeter", "x * 1e-18");
                _conversionFunctions.Add("CubicNanoMeter", "x * 1e-27");
                _conversionFunctions.Add("CubicPicoMeter", "x * 1e-36");
                _conversionFunctions.Add("CubicFemtoMeter", "x * 1e-45");
                _conversionFunctions.Add("CubicAttoMeter", "x * 1e-54");
                _conversionFunctions.Add("CubicZeptoMeter", "x * 1e-63");
                _conversionFunctions.Add("CubicYoctoMeter", "x * 1e-72");
            }
        }
    }
