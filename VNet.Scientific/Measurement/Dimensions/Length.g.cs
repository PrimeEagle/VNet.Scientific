
    // Auto-generated for VNet on 2023-07-06 12:42:23
    using System.Numerics;
    
    
    namespace VNet.Scientific.Measurement.Dimensions
    {
        public sealed class Length<TVal> : DimensionBase<LengthUnit, TVal> where TVal : notnull, INumber<TVal>
        {
            public override string IdTag => nameof(Length<TVal>);
            
            public Length() : base()
            {
                Exponents.Length = 1;
                Exponents.Mass = 0;
                Exponents.Time = 0;
                Exponents.ElectricalCurrent = 0;
                Exponents.LuminousIntensity = 0;
                Exponents.Temperature = 0;
                Exponents.Amount = 0;
                
                DefaultUnit = LengthUnit.Meter;
                
                Symbols.Add(LengthUnit.Mile, "mi");
                Symbols.Add(LengthUnit.Yard, "yd");
                Symbols.Add(LengthUnit.Foot, "ft");
                Symbols.Add(LengthUnit.UsSurveyFoot, "ftUS");
                Symbols.Add(LengthUnit.Inch, "in");
                Symbols.Add(LengthUnit.Mil, "mil");
                Symbols.Add(LengthUnit.NauticalMile, "NM");
                Symbols.Add(LengthUnit.Fathom, "fathom");
                Symbols.Add(LengthUnit.Shackle, "shackle");
                Symbols.Add(LengthUnit.Microinch, "µin");
                Symbols.Add(LengthUnit.PrinterPoint, "pt");
                Symbols.Add(LengthUnit.DtpPoint, "pt");
                Symbols.Add(LengthUnit.PrinterPica, "pica");
                Symbols.Add(LengthUnit.DtpPica, "pica");
                Symbols.Add(LengthUnit.Twip, "twip");
                Symbols.Add(LengthUnit.Hand, "h");
                Symbols.Add(LengthUnit.AstronomicalUnit, "au");
                Symbols.Add(LengthUnit.Parsec, "pc");
                Symbols.Add(LengthUnit.LightYear, "ly");
                Symbols.Add(LengthUnit.SolarRadius, "R⊙");
                Symbols.Add(LengthUnit.Chain, "ch");
                Symbols.Add(LengthUnit.Angstrom, "Å");
                Symbols.Add(LengthUnit.DataMile, "DM");
                Symbols.Add(LengthUnit.Yottameter, "Ym");
                Symbols.Add(LengthUnit.Zettameter, "Zm");
                Symbols.Add(LengthUnit.Exameter, "Em");
                Symbols.Add(LengthUnit.Petameter, "Pm");
                Symbols.Add(LengthUnit.Terameter, "Tm");
                Symbols.Add(LengthUnit.Gigameter, "Gm");
                Symbols.Add(LengthUnit.Megameter, "Mm");
                Symbols.Add(LengthUnit.Kilometer, "km");
                Symbols.Add(LengthUnit.Hectometer, "hm");
                Symbols.Add(LengthUnit.Dekameter, "dam");
                Symbols.Add(LengthUnit.Meter, "m");
                Symbols.Add(LengthUnit.Decimeter, "dm");
                Symbols.Add(LengthUnit.Centimeter, "cm");
                Symbols.Add(LengthUnit.Millimeter, "mm");
                Symbols.Add(LengthUnit.Micrometer, "µm");
                Symbols.Add(LengthUnit.Nanometer, "nm");
                Symbols.Add(LengthUnit.Picometer, "pm");
                Symbols.Add(LengthUnit.Femtometer, "fm");
                Symbols.Add(LengthUnit.Attometer, "am");
                Symbols.Add(LengthUnit.Zeptometer, "zm");
                Symbols.Add(LengthUnit.Yoctometer, "ym");
                
                PluralSymbols.Add(LengthUnit.Hand, "hh");
                PluralSymbols.Add(LengthUnit.AstronomicalUnit, "ua");
                PluralSymbols.Add(LengthUnit.Angstrom, "A");
                
                ConversionFunctions.Add(LengthUnit.Mile, "x * 1609.344");
                ConversionFunctions.Add(LengthUnit.Yard, "x * 0.9144");
                ConversionFunctions.Add(LengthUnit.Foot, "x * 0.3048");
                ConversionFunctions.Add(LengthUnit.UsSurveyFoot, "x * 1200 / 3937");
                ConversionFunctions.Add(LengthUnit.Inch, "x * 2.54e-2");
                ConversionFunctions.Add(LengthUnit.Mil, "x * 2.54e-5");
                ConversionFunctions.Add(LengthUnit.NauticalMile, "x * 1852");
                ConversionFunctions.Add(LengthUnit.Fathom, "x * 1.8288");
                ConversionFunctions.Add(LengthUnit.Shackle, "x * 27.432");
                ConversionFunctions.Add(LengthUnit.Microinch, "x * 2.54e-8");
                ConversionFunctions.Add(LengthUnit.PrinterPoint, "(x / 72.27) * 2.54e-2");
                ConversionFunctions.Add(LengthUnit.DtpPoint, "(x / 72) * 2.54e-2");
                ConversionFunctions.Add(LengthUnit.PrinterPica, "x / 237.106301584");
                ConversionFunctions.Add(LengthUnit.DtpPica, "x / 236.220472441");
                ConversionFunctions.Add(LengthUnit.Twip, "x / 56692.913385826");
                ConversionFunctions.Add(LengthUnit.Hand, "x * 1.016e-1");
                ConversionFunctions.Add(LengthUnit.AstronomicalUnit, "x * 1.4959787070e11");
                ConversionFunctions.Add(LengthUnit.Parsec, "x * 3.08567758128e16");
                ConversionFunctions.Add(LengthUnit.LightYear, "x * 9.46073047258e15");
                ConversionFunctions.Add(LengthUnit.SolarRadius, "x * 6.95510000E+08");
                ConversionFunctions.Add(LengthUnit.Chain, "x * 20.1168");
                ConversionFunctions.Add(LengthUnit.Angstrom, "x * 1e-10");
                ConversionFunctions.Add(LengthUnit.DataMile, "x * 1828.8");
                ConversionFunctions.Add(LengthUnit.Yottameter, "x * 1e24");
                ConversionFunctions.Add(LengthUnit.Zettameter, "x * 1e21");
                ConversionFunctions.Add(LengthUnit.Exameter, "x * 1e18");
                ConversionFunctions.Add(LengthUnit.Petameter, "x * 1e15");
                ConversionFunctions.Add(LengthUnit.Terameter, "x * 1e12");
                ConversionFunctions.Add(LengthUnit.Gigameter, "x * 1e9");
                ConversionFunctions.Add(LengthUnit.Megameter, "x * 1e6");
                ConversionFunctions.Add(LengthUnit.Kilometer, "x * 1e3");
                ConversionFunctions.Add(LengthUnit.Hectometer, "x * 1e2");
                ConversionFunctions.Add(LengthUnit.Dekameter, "x * 1e1");
                ConversionFunctions.Add(LengthUnit.Meter, "x * 1e0");
                ConversionFunctions.Add(LengthUnit.Decimeter, "x * 1e-1");
                ConversionFunctions.Add(LengthUnit.Centimeter, "x * 1e-2");
                ConversionFunctions.Add(LengthUnit.Millimeter, "x * 1e-3");
                ConversionFunctions.Add(LengthUnit.Micrometer, "x * 1e-6");
                ConversionFunctions.Add(LengthUnit.Nanometer, "x * 1e-9");
                ConversionFunctions.Add(LengthUnit.Picometer, "x * 1e-12");
                ConversionFunctions.Add(LengthUnit.Femtometer, "x * 1e-15");
                ConversionFunctions.Add(LengthUnit.Attometer, "x * 1e-18");
                ConversionFunctions.Add(LengthUnit.Zeptometer, "x * 1e-21");
                ConversionFunctions.Add(LengthUnit.Yoctometer, "x * 1e-24");
            }
        }
    }
