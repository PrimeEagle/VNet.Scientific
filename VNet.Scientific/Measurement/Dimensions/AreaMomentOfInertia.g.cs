
    // Auto-generated for VNet on 2023-07-06 12:42:23
    using System.Numerics;
    
    
    namespace VNet.Scientific.Measurement.Dimensions
    {
        public sealed class AreaMomentOfInertia<TVal> : DimensionBase<AreaMomentOfInertiaUnit, TVal> where TVal : notnull, INumber<TVal>
        {
            public override string IdTag => nameof(AreaMomentOfInertia<TVal>);
            
            public AreaMomentOfInertia() : base()
            {
                Exponents.Length = 4;
                Exponents.Mass = 0;
                Exponents.Time = 0;
                Exponents.ElectricalCurrent = 0;
                Exponents.LuminousIntensity = 0;
                Exponents.Temperature = 0;
                Exponents.Amount = 0;
                
                DefaultUnit = AreaMomentOfInertiaUnit.MeterToTheFourth;
                
                Symbols.Add(AreaMomentOfInertiaUnit.FootToTheFourth, "ft⁴");
                Symbols.Add(AreaMomentOfInertiaUnit.InchToTheFourth, "in⁴");
                Symbols.Add(AreaMomentOfInertiaUnit.Yottametertothefourth, "Ym⁴");
                Symbols.Add(AreaMomentOfInertiaUnit.Zettametertothefourth, "Zm⁴");
                Symbols.Add(AreaMomentOfInertiaUnit.Exametertothefourth, "Em⁴");
                Symbols.Add(AreaMomentOfInertiaUnit.Petametertothefourth, "Pm⁴");
                Symbols.Add(AreaMomentOfInertiaUnit.Terametertothefourth, "Tm⁴");
                Symbols.Add(AreaMomentOfInertiaUnit.Gigametertothefourth, "Gm⁴");
                Symbols.Add(AreaMomentOfInertiaUnit.Megametertothefourth, "Mm⁴");
                Symbols.Add(AreaMomentOfInertiaUnit.Kilometertothefourth, "km⁴");
                Symbols.Add(AreaMomentOfInertiaUnit.Hectometertothefourth, "hm⁴");
                Symbols.Add(AreaMomentOfInertiaUnit.Dekametertothefourth, "dam⁴");
                Symbols.Add(AreaMomentOfInertiaUnit.MeterToTheFourth, "m⁴");
                Symbols.Add(AreaMomentOfInertiaUnit.Decimetertothefourth, "dm⁴");
                Symbols.Add(AreaMomentOfInertiaUnit.Centimetertothefourth, "cm⁴");
                Symbols.Add(AreaMomentOfInertiaUnit.Millimetertothefourth, "mm⁴");
                Symbols.Add(AreaMomentOfInertiaUnit.Micrometertothefourth, "µm⁴");
                Symbols.Add(AreaMomentOfInertiaUnit.Nanometertothefourth, "nm⁴");
                Symbols.Add(AreaMomentOfInertiaUnit.Picometertothefourth, "pm⁴");
                Symbols.Add(AreaMomentOfInertiaUnit.Femtometertothefourth, "fm⁴");
                Symbols.Add(AreaMomentOfInertiaUnit.Attometertothefourth, "am⁴");
                Symbols.Add(AreaMomentOfInertiaUnit.Zeptometertothefourth, "zm⁴");
                Symbols.Add(AreaMomentOfInertiaUnit.Yoctometertothefourth, "ym⁴");
                
                PluralSymbols.Add(AreaMomentOfInertiaUnit.FootToTheFourth, "ft^4");
                PluralSymbols.Add(AreaMomentOfInertiaUnit.InchToTheFourth, "in^4");
                PluralSymbols.Add(AreaMomentOfInertiaUnit.Yottametertothefourth, "Ym^4");
                PluralSymbols.Add(AreaMomentOfInertiaUnit.Zettametertothefourth, "Zm^4");
                PluralSymbols.Add(AreaMomentOfInertiaUnit.Exametertothefourth, "Em^4");
                PluralSymbols.Add(AreaMomentOfInertiaUnit.Petametertothefourth, "Pm^4");
                PluralSymbols.Add(AreaMomentOfInertiaUnit.Terametertothefourth, "Tm^4");
                PluralSymbols.Add(AreaMomentOfInertiaUnit.Gigametertothefourth, "Gm^4");
                PluralSymbols.Add(AreaMomentOfInertiaUnit.Megametertothefourth, "Mm^4");
                PluralSymbols.Add(AreaMomentOfInertiaUnit.Kilometertothefourth, "km^4");
                PluralSymbols.Add(AreaMomentOfInertiaUnit.Hectometertothefourth, "hm^4");
                PluralSymbols.Add(AreaMomentOfInertiaUnit.Dekametertothefourth, "dam^4");
                PluralSymbols.Add(AreaMomentOfInertiaUnit.MeterToTheFourth, "m^4");
                PluralSymbols.Add(AreaMomentOfInertiaUnit.Decimetertothefourth, "dm^4");
                PluralSymbols.Add(AreaMomentOfInertiaUnit.Centimetertothefourth, "cm^4");
                PluralSymbols.Add(AreaMomentOfInertiaUnit.Millimetertothefourth, "mm^4");
                PluralSymbols.Add(AreaMomentOfInertiaUnit.Micrometertothefourth, "µm^4");
                PluralSymbols.Add(AreaMomentOfInertiaUnit.Nanometertothefourth, "nm^4");
                PluralSymbols.Add(AreaMomentOfInertiaUnit.Picometertothefourth, "pm^4");
                PluralSymbols.Add(AreaMomentOfInertiaUnit.Femtometertothefourth, "fm^4");
                PluralSymbols.Add(AreaMomentOfInertiaUnit.Attometertothefourth, "am^4");
                PluralSymbols.Add(AreaMomentOfInertiaUnit.Zeptometertothefourth, "zm^4");
                PluralSymbols.Add(AreaMomentOfInertiaUnit.Yoctometertothefourth, "ym^4");
                
                ConversionFunctions.Add(AreaMomentOfInertiaUnit.FootToTheFourth, "x * Math.Pow(0.3048, 4)");
                ConversionFunctions.Add(AreaMomentOfInertiaUnit.InchToTheFourth, "x * Math.Pow(2.54e-2, 4)");
                ConversionFunctions.Add(AreaMomentOfInertiaUnit.Yottametertothefourth, "x * 1e24");
                ConversionFunctions.Add(AreaMomentOfInertiaUnit.Zettametertothefourth, "x * 1e21");
                ConversionFunctions.Add(AreaMomentOfInertiaUnit.Exametertothefourth, "x * 1e18");
                ConversionFunctions.Add(AreaMomentOfInertiaUnit.Petametertothefourth, "x * 1e15");
                ConversionFunctions.Add(AreaMomentOfInertiaUnit.Terametertothefourth, "x * 1e12");
                ConversionFunctions.Add(AreaMomentOfInertiaUnit.Gigametertothefourth, "x * 1e9");
                ConversionFunctions.Add(AreaMomentOfInertiaUnit.Megametertothefourth, "x * 1e6");
                ConversionFunctions.Add(AreaMomentOfInertiaUnit.Kilometertothefourth, "x * 1e3");
                ConversionFunctions.Add(AreaMomentOfInertiaUnit.Hectometertothefourth, "x * 1e2");
                ConversionFunctions.Add(AreaMomentOfInertiaUnit.Dekametertothefourth, "x * 1e1");
                ConversionFunctions.Add(AreaMomentOfInertiaUnit.MeterToTheFourth, "x * 1e0");
                ConversionFunctions.Add(AreaMomentOfInertiaUnit.Decimetertothefourth, "x * 1e-1");
                ConversionFunctions.Add(AreaMomentOfInertiaUnit.Centimetertothefourth, "x * 1e-2");
                ConversionFunctions.Add(AreaMomentOfInertiaUnit.Millimetertothefourth, "x * 1e-3");
                ConversionFunctions.Add(AreaMomentOfInertiaUnit.Micrometertothefourth, "x * 1e-6");
                ConversionFunctions.Add(AreaMomentOfInertiaUnit.Nanometertothefourth, "x * 1e-9");
                ConversionFunctions.Add(AreaMomentOfInertiaUnit.Picometertothefourth, "x * 1e-12");
                ConversionFunctions.Add(AreaMomentOfInertiaUnit.Femtometertothefourth, "x * 1e-15");
                ConversionFunctions.Add(AreaMomentOfInertiaUnit.Attometertothefourth, "x * 1e-18");
                ConversionFunctions.Add(AreaMomentOfInertiaUnit.Zeptometertothefourth, "x * 1e-21");
                ConversionFunctions.Add(AreaMomentOfInertiaUnit.Yoctometertothefourth, "x * 1e-24");
            }
        }
    }
