
    // Auto-generated for VNet on 2023-07-05 10:35:43
    using System.Numerics;
    
    
    namespace VNet.Scientific.Measurement.Dimensions
    {
        public sealed class Mass<TVal> : DimensionBase<MassUnit, TVal> where TVal : notnull, INumber<TVal>
        {
            public override string IdTag => nameof(Mass<TVal>);
            
            public Mass() : base()
            {
                DimensionComponent.Exponents.Length = 0;
                DimensionComponent.Exponents.Mass = 1;
                DimensionComponent.Exponents.Time = 0;
                DimensionComponent.Exponents.ElectricalCurrent = 0;
                DimensionComponent.Exponents.LuminousIntensity = 0;
                DimensionComponent.Exponents.Temperature = 0;
                DimensionComponent.Exponents.Amount = 0;
                
                DefaultUnit = MassUnit.Kilogram;
                
                Symbols.Add(MassUnit.Gram, "g");
                Symbols.Add(MassUnit.Tonne, "t");
                Symbols.Add(MassUnit.ShortTon, "t (short)");
                Symbols.Add(MassUnit.LongTon, "long tn");
                Symbols.Add(MassUnit.Pound, "lb");
                Symbols.Add(MassUnit.Ounce, "oz");
                Symbols.Add(MassUnit.Slug, "slug");
                Symbols.Add(MassUnit.Stone, "st");
                Symbols.Add(MassUnit.ShortHundredweight, "cwt");
                Symbols.Add(MassUnit.LongHundredweight, "cwt");
                Symbols.Add(MassUnit.Grain, "gr");
                Symbols.Add(MassUnit.SolarMass, "M☉");
                Symbols.Add(MassUnit.EarthMass, "em");
                Symbols.Add(MassUnit.Yottagram, "Yg");
                Symbols.Add(MassUnit.Zettagram, "Zg");
                Symbols.Add(MassUnit.Exagram, "Eg");
                Symbols.Add(MassUnit.Petagram, "Pg");
                Symbols.Add(MassUnit.Teragram, "Tg");
                Symbols.Add(MassUnit.Gigagram, "Gg");
                Symbols.Add(MassUnit.Megagram, "Mg");
                Symbols.Add(MassUnit.Hectogram, "hg");
                Symbols.Add(MassUnit.Dekagram, "dag");
                Symbols.Add(MassUnit.Kilogram, "g");
                Symbols.Add(MassUnit.Decigram, "dg");
                Symbols.Add(MassUnit.Centigram, "cg");
                Symbols.Add(MassUnit.Milligram, "mg");
                Symbols.Add(MassUnit.Microgram, "µg");
                Symbols.Add(MassUnit.Nanogram, "ng");
                Symbols.Add(MassUnit.Picogram, "pg");
                Symbols.Add(MassUnit.Femtogram, "fg");
                Symbols.Add(MassUnit.Attogram, "ag");
                Symbols.Add(MassUnit.Zeptogram, "zg");
                Symbols.Add(MassUnit.Yoctogram, "yg");
                
                PluralSymbols.Add(MassUnit.ShortTon, "short tn");
                PluralSymbols.Add(MassUnit.Pound, "lbs");
                PluralSymbols.Add(MassUnit.SolarMass, "M⊙");
                
                ConversionFunctions.Add(MassUnit.Gram, "1000 * (x / 1e3)");
                ConversionFunctions.Add(MassUnit.Tonne, "1000 * (x * 1e3)");
                ConversionFunctions.Add(MassUnit.ShortTon, "1000 * (x * 9.0718474e2)");
                ConversionFunctions.Add(MassUnit.LongTon, "1000 * (x * 1.0160469088e3)");
                ConversionFunctions.Add(MassUnit.Pound, "1000 * (x * 0.45359237)");
                ConversionFunctions.Add(MassUnit.Ounce, "1000 * (x * 0.028349523125)");
                ConversionFunctions.Add(MassUnit.Slug, "1000 * (x / 6.852176556196105e-2)");
                ConversionFunctions.Add(MassUnit.Stone, "1000 * (x / 0.1574731728702698)");
                ConversionFunctions.Add(MassUnit.ShortHundredweight, "1000 * (x / 0.022046226218487758)");
                ConversionFunctions.Add(MassUnit.LongHundredweight, "1000 * (x / 0.01968413055222121)");
                ConversionFunctions.Add(MassUnit.Grain, "1000 * (x / 15432.358352941431)");
                ConversionFunctions.Add(MassUnit.SolarMass, "1000 * (x * 1.98947e30)");
                ConversionFunctions.Add(MassUnit.EarthMass, "1000 * (x * 5.9722E+24)");
                ConversionFunctions.Add(MassUnit.Yottagram, "1000 * (x * 1e24)");
                ConversionFunctions.Add(MassUnit.Zettagram, "1000 * (x * 1e21)");
                ConversionFunctions.Add(MassUnit.Exagram, "1000 * (x * 1e18)");
                ConversionFunctions.Add(MassUnit.Petagram, "1000 * (x * 1e15)");
                ConversionFunctions.Add(MassUnit.Teragram, "1000 * (x * 1e12)");
                ConversionFunctions.Add(MassUnit.Gigagram, "1000 * (x * 1e9)");
                ConversionFunctions.Add(MassUnit.Megagram, "1000 * (x * 1e6)");
                ConversionFunctions.Add(MassUnit.Hectogram, "1000 * (x * 1e2)");
                ConversionFunctions.Add(MassUnit.Dekagram, "1000 * (x * 1e1)");
                ConversionFunctions.Add(MassUnit.Kilogram, "1000 * (x * 1e0)");
                ConversionFunctions.Add(MassUnit.Decigram, "1000 * (x * 1e-1)");
                ConversionFunctions.Add(MassUnit.Centigram, "1000 * (x * 1e-2)");
                ConversionFunctions.Add(MassUnit.Milligram, "1000 * (x * 1e-3)");
                ConversionFunctions.Add(MassUnit.Microgram, "1000 * (x * 1e-6)");
                ConversionFunctions.Add(MassUnit.Nanogram, "1000 * (x * 1e-9)");
                ConversionFunctions.Add(MassUnit.Picogram, "1000 * (x * 1e-12)");
                ConversionFunctions.Add(MassUnit.Femtogram, "1000 * (x * 1e-15)");
                ConversionFunctions.Add(MassUnit.Attogram, "1000 * (x * 1e-18)");
                ConversionFunctions.Add(MassUnit.Zeptogram, "1000 * (x * 1e-21)");
                ConversionFunctions.Add(MassUnit.Yoctogram, "1000 * (x * 1e-24)");
            }
        }
    }
