
    // Auto-generated for VNet on 2023-07-05 10:24:46
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
                
                
                ConversionFunctions.Add(VolumeUnit.Liter, "x / 1e3");
                ConversionFunctions.Add(VolumeUnit.CubicMile, "x * 4.16818182544058e9");
                ConversionFunctions.Add(VolumeUnit.CubicYard, "x * 0.764554858");
                ConversionFunctions.Add(VolumeUnit.CubicFoot, "x * 2.8316846592e-2");
                ConversionFunctions.Add(VolumeUnit.CubicInch, "x * 1.6387 * 1e-5");
                ConversionFunctions.Add(VolumeUnit.ImperialGallon, "x * 0.00454609");
                ConversionFunctions.Add(VolumeUnit.ImperialOunce, "x * 2.8413062499962901241875439064617e-5");
                ConversionFunctions.Add(VolumeUnit.UsGallon, "x * 0.003785411784");
                ConversionFunctions.Add(VolumeUnit.UsOunce, "x * 2.957352956253760505068307980135e-5");
                ConversionFunctions.Add(VolumeUnit.UsTablespoon, "x * 1.478676478125e-5");
                ConversionFunctions.Add(VolumeUnit.AuTablespoon, "x * 2e-5");
                ConversionFunctions.Add(VolumeUnit.UkTablespoon, "x * 1.5e-5");
                ConversionFunctions.Add(VolumeUnit.MetricTeaspoon, "x * 0.5e-5");
                ConversionFunctions.Add(VolumeUnit.UsTeaspoon, "x * 4.92892159375e-6");
                ConversionFunctions.Add(VolumeUnit.MetricCup, "x * 0.00025");
                ConversionFunctions.Add(VolumeUnit.UsCustomaryCup, "x * 0.0002365882365");
                ConversionFunctions.Add(VolumeUnit.UsLegalCup, "x * 0.00024");
                ConversionFunctions.Add(VolumeUnit.OilBarrel, "x * 0.158987294928");
                ConversionFunctions.Add(VolumeUnit.UsBeerBarrel, "x * 0.1173477658");
                ConversionFunctions.Add(VolumeUnit.ImperialBeerBarrel, "x * 0.16365924");
                ConversionFunctions.Add(VolumeUnit.UsQuart, "x * 9.46352946e-4");
                ConversionFunctions.Add(VolumeUnit.ImperialQuart, "x * 1.1365225e-3");
                ConversionFunctions.Add(VolumeUnit.UsPint, "x * 4.73176473e-4");
                ConversionFunctions.Add(VolumeUnit.AcreFoot, "x / 0.000810714");
                ConversionFunctions.Add(VolumeUnit.ImperialPint, "x * 5.6826125e-4");
                ConversionFunctions.Add(VolumeUnit.BoardFoot, "x * 2.3597372158e-3");
                ConversionFunctions.Add(VolumeUnit.CubicYottameter, "x * 1e72");
                ConversionFunctions.Add(VolumeUnit.CubicZettameter, "x * 1e63");
                ConversionFunctions.Add(VolumeUnit.CubicExameter, "x * 1e54");
                ConversionFunctions.Add(VolumeUnit.CubicPetameter, "x * 1e45");
                ConversionFunctions.Add(VolumeUnit.CubicTerameter, "x * 1e36");
                ConversionFunctions.Add(VolumeUnit.CubicGigameter, "x * 1e27");
                ConversionFunctions.Add(VolumeUnit.CubicMegameter, "x * 1e18");
                ConversionFunctions.Add(VolumeUnit.CubicKilometer, "x * 1e9");
                ConversionFunctions.Add(VolumeUnit.CubicHectometer, "x * 1e6");
                ConversionFunctions.Add(VolumeUnit.CubicDekameter, "x * 1e3");
                ConversionFunctions.Add(VolumeUnit.CubicMeter, "x * 1e0");
                ConversionFunctions.Add(VolumeUnit.CubicDecimeter, "x * 1e-3");
                ConversionFunctions.Add(VolumeUnit.CubicCentimeter, "x * 1e-6");
                ConversionFunctions.Add(VolumeUnit.CubicMillimeter, "x * 1e-9");
                ConversionFunctions.Add(VolumeUnit.CubicMicrometer, "x * 1e-18");
                ConversionFunctions.Add(VolumeUnit.CubicNanometer, "x * 1e-27");
                ConversionFunctions.Add(VolumeUnit.CubicPicometer, "x * 1e-36");
                ConversionFunctions.Add(VolumeUnit.CubicFemtometer, "x * 1e-45");
                ConversionFunctions.Add(VolumeUnit.CubicAttometer, "x * 1e-54");
                ConversionFunctions.Add(VolumeUnit.CubicZeptometer, "x * 1e-63");
                ConversionFunctions.Add(VolumeUnit.CubicYoctometer, "x * 1e-72");
            }
        }
    }
