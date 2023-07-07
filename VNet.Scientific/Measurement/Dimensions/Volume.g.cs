
    // Auto-generated for VNet on 2023-07-06 12:42:23
    using System.Numerics;
    
    
    namespace VNet.Scientific.Measurement.Dimensions
    {
        public sealed class Volume<TVal> : DimensionBase<VolumeUnit, TVal> where TVal : notnull, INumber<TVal>
        {
            public override string IdTag => nameof(Volume<TVal>);
            
            public Volume() : base()
            {
                Exponents.Length = 3;
                Exponents.Mass = 0;
                Exponents.Time = 0;
                Exponents.ElectricalCurrent = 0;
                Exponents.LuminousIntensity = 0;
                Exponents.Temperature = 0;
                Exponents.Amount = 0;
                
                DefaultUnit = VolumeUnit.CubicMeter;
                
                Symbols.Add(VolumeUnit.Liter, "l");
                Symbols.Add(VolumeUnit.CubicMile, "mi³");
                Symbols.Add(VolumeUnit.CubicYard, "yd³");
                Symbols.Add(VolumeUnit.CubicFoot, "ft³");
                Symbols.Add(VolumeUnit.CubicInch, "in³");
                Symbols.Add(VolumeUnit.ImperialGallon, "gal (imp.)");
                Symbols.Add(VolumeUnit.ImperialOunce, "oz (imp.)");
                Symbols.Add(VolumeUnit.UsGallon, "gal (U.S.)");
                Symbols.Add(VolumeUnit.UsOunce, "oz (U.S.)");
                Symbols.Add(VolumeUnit.MetricTeaspoon, "tsp");
                Symbols.Add(VolumeUnit.OilBarrel, "bbl");
                Symbols.Add(VolumeUnit.UsBeerBarrel, "bl (U.S.)");
                Symbols.Add(VolumeUnit.ImperialBeerBarrel, "bl (imp.)");
                Symbols.Add(VolumeUnit.UsQuart, "qt (U.S.)");
                Symbols.Add(VolumeUnit.ImperialQuart, "qt (imp.)");
                Symbols.Add(VolumeUnit.UsPint, "pt (U.S.)");
                Symbols.Add(VolumeUnit.AcreFoot, "ac-ft");
                Symbols.Add(VolumeUnit.ImperialPint, "pt (imp.)");
                Symbols.Add(VolumeUnit.BoardFoot, "bf");
                Symbols.Add(VolumeUnit.CubicYottameter, "Ym³");
                Symbols.Add(VolumeUnit.CubicZettameter, "Zm³");
                Symbols.Add(VolumeUnit.CubicExameter, "Em³");
                Symbols.Add(VolumeUnit.CubicPetameter, "Pm³");
                Symbols.Add(VolumeUnit.CubicTerameter, "Tm³");
                Symbols.Add(VolumeUnit.CubicGigameter, "Gm³");
                Symbols.Add(VolumeUnit.CubicMegameter, "Mm³");
                Symbols.Add(VolumeUnit.CubicKilometer, "km³");
                Symbols.Add(VolumeUnit.CubicHectometer, "hm³");
                Symbols.Add(VolumeUnit.CubicDekameter, "dam³");
                Symbols.Add(VolumeUnit.CubicMeter, "m³");
                Symbols.Add(VolumeUnit.CubicDecimeter, "dm³");
                Symbols.Add(VolumeUnit.CubicCentimeter, "cm³");
                Symbols.Add(VolumeUnit.CubicMillimeter, "mm³");
                Symbols.Add(VolumeUnit.CubicMicrometer, "µm³");
                Symbols.Add(VolumeUnit.CubicNanometer, "nm³");
                Symbols.Add(VolumeUnit.CubicPicometer, "pm³");
                Symbols.Add(VolumeUnit.CubicFemtometer, "fm³");
                Symbols.Add(VolumeUnit.CubicAttometer, "am³");
                Symbols.Add(VolumeUnit.CubicZeptometer, "zm³");
                Symbols.Add(VolumeUnit.CubicYoctometer, "ym³");
                
                PluralSymbols.Add(VolumeUnit.MetricTeaspoon, "t");
                PluralSymbols.Add(VolumeUnit.AcreFoot, "acre-foot");
                PluralSymbols.Add(VolumeUnit.ImperialPint, "UK pt");
                PluralSymbols.Add(VolumeUnit.BoardFoot, "board foot");
                
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
