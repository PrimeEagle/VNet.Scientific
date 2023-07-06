
    // Auto-generated for VNet on 2023-07-05 10:35:43
    using System.Numerics;
    
    
    namespace VNet.Scientific.Measurement.Dimensions
    {
        public sealed class WarpingMomentOfInertia<TVal> : DimensionBase<WarpingMomentOfInertiaUnit, TVal> where TVal : notnull, INumber<TVal>
        {
            public override string IdTag => nameof(WarpingMomentOfInertia<TVal>);
            
            public WarpingMomentOfInertia() : base()
            {
                DimensionComponent.Exponents.Length = 6;
                DimensionComponent.Exponents.Mass = 0;
                DimensionComponent.Exponents.Time = 0;
                DimensionComponent.Exponents.ElectricalCurrent = 0;
                DimensionComponent.Exponents.LuminousIntensity = 0;
                DimensionComponent.Exponents.Temperature = 0;
                DimensionComponent.Exponents.Amount = 0;
                
                DefaultUnit = WarpingMomentOfInertiaUnit.MeterToTheSixth;
                
                Symbols.Add(WarpingMomentOfInertiaUnit.FootToTheSixth, "ft⁶");
                Symbols.Add(WarpingMomentOfInertiaUnit.InchToTheSixth, "in⁶");
                Symbols.Add(WarpingMomentOfInertiaUnit.Yottametertothesixth, "Ym⁶");
                Symbols.Add(WarpingMomentOfInertiaUnit.Zettametertothesixth, "Zm⁶");
                Symbols.Add(WarpingMomentOfInertiaUnit.Exametertothesixth, "Em⁶");
                Symbols.Add(WarpingMomentOfInertiaUnit.Petametertothesixth, "Pm⁶");
                Symbols.Add(WarpingMomentOfInertiaUnit.Terametertothesixth, "Tm⁶");
                Symbols.Add(WarpingMomentOfInertiaUnit.Gigametertothesixth, "Gm⁶");
                Symbols.Add(WarpingMomentOfInertiaUnit.Megametertothesixth, "Mm⁶");
                Symbols.Add(WarpingMomentOfInertiaUnit.Kilometertothesixth, "km⁶");
                Symbols.Add(WarpingMomentOfInertiaUnit.Hectometertothesixth, "hm⁶");
                Symbols.Add(WarpingMomentOfInertiaUnit.Dekametertothesixth, "dam⁶");
                Symbols.Add(WarpingMomentOfInertiaUnit.MeterToTheSixth, "m⁶");
                Symbols.Add(WarpingMomentOfInertiaUnit.Decimetertothesixth, "dm⁶");
                Symbols.Add(WarpingMomentOfInertiaUnit.Centimetertothesixth, "cm⁶");
                Symbols.Add(WarpingMomentOfInertiaUnit.Millimetertothesixth, "mm⁶");
                Symbols.Add(WarpingMomentOfInertiaUnit.Micrometertothesixth, "µm⁶");
                Symbols.Add(WarpingMomentOfInertiaUnit.Nanometertothesixth, "nm⁶");
                Symbols.Add(WarpingMomentOfInertiaUnit.Picometertothesixth, "pm⁶");
                Symbols.Add(WarpingMomentOfInertiaUnit.Femtometertothesixth, "fm⁶");
                Symbols.Add(WarpingMomentOfInertiaUnit.Attometertothesixth, "am⁶");
                Symbols.Add(WarpingMomentOfInertiaUnit.Zeptometertothesixth, "zm⁶");
                Symbols.Add(WarpingMomentOfInertiaUnit.Yoctometertothesixth, "ym⁶");
                
                PluralSymbols.Add(WarpingMomentOfInertiaUnit.FootToTheSixth, "ft^6");
                PluralSymbols.Add(WarpingMomentOfInertiaUnit.InchToTheSixth, "in^6");
                PluralSymbols.Add(WarpingMomentOfInertiaUnit.Yottametertothesixth, "Ym^6");
                PluralSymbols.Add(WarpingMomentOfInertiaUnit.Zettametertothesixth, "Zm^6");
                PluralSymbols.Add(WarpingMomentOfInertiaUnit.Exametertothesixth, "Em^6");
                PluralSymbols.Add(WarpingMomentOfInertiaUnit.Petametertothesixth, "Pm^6");
                PluralSymbols.Add(WarpingMomentOfInertiaUnit.Terametertothesixth, "Tm^6");
                PluralSymbols.Add(WarpingMomentOfInertiaUnit.Gigametertothesixth, "Gm^6");
                PluralSymbols.Add(WarpingMomentOfInertiaUnit.Megametertothesixth, "Mm^6");
                PluralSymbols.Add(WarpingMomentOfInertiaUnit.Kilometertothesixth, "km^6");
                PluralSymbols.Add(WarpingMomentOfInertiaUnit.Hectometertothesixth, "hm^6");
                PluralSymbols.Add(WarpingMomentOfInertiaUnit.Dekametertothesixth, "dam^6");
                PluralSymbols.Add(WarpingMomentOfInertiaUnit.MeterToTheSixth, "m^6");
                PluralSymbols.Add(WarpingMomentOfInertiaUnit.Decimetertothesixth, "dm^6");
                PluralSymbols.Add(WarpingMomentOfInertiaUnit.Centimetertothesixth, "cm^6");
                PluralSymbols.Add(WarpingMomentOfInertiaUnit.Millimetertothesixth, "mm^6");
                PluralSymbols.Add(WarpingMomentOfInertiaUnit.Micrometertothesixth, "µm^6");
                PluralSymbols.Add(WarpingMomentOfInertiaUnit.Nanometertothesixth, "nm^6");
                PluralSymbols.Add(WarpingMomentOfInertiaUnit.Picometertothesixth, "pm^6");
                PluralSymbols.Add(WarpingMomentOfInertiaUnit.Femtometertothesixth, "fm^6");
                PluralSymbols.Add(WarpingMomentOfInertiaUnit.Attometertothesixth, "am^6");
                PluralSymbols.Add(WarpingMomentOfInertiaUnit.Zeptometertothesixth, "zm^6");
                PluralSymbols.Add(WarpingMomentOfInertiaUnit.Yoctometertothesixth, "ym^6");
                
                ConversionFunctions.Add(WarpingMomentOfInertiaUnit.FootToTheSixth, "x * Math.Pow(0.3048, 6)");
                ConversionFunctions.Add(WarpingMomentOfInertiaUnit.InchToTheSixth, "x * Math.Pow(2.54e-2, 6)");
                ConversionFunctions.Add(WarpingMomentOfInertiaUnit.Yottametertothesixth, "x * 1e24");
                ConversionFunctions.Add(WarpingMomentOfInertiaUnit.Zettametertothesixth, "x * 1e21");
                ConversionFunctions.Add(WarpingMomentOfInertiaUnit.Exametertothesixth, "x * 1e18");
                ConversionFunctions.Add(WarpingMomentOfInertiaUnit.Petametertothesixth, "x * 1e15");
                ConversionFunctions.Add(WarpingMomentOfInertiaUnit.Terametertothesixth, "x * 1e12");
                ConversionFunctions.Add(WarpingMomentOfInertiaUnit.Gigametertothesixth, "x * 1e9");
                ConversionFunctions.Add(WarpingMomentOfInertiaUnit.Megametertothesixth, "x * 1e6");
                ConversionFunctions.Add(WarpingMomentOfInertiaUnit.Kilometertothesixth, "x * 1e3");
                ConversionFunctions.Add(WarpingMomentOfInertiaUnit.Hectometertothesixth, "x * 1e2");
                ConversionFunctions.Add(WarpingMomentOfInertiaUnit.Dekametertothesixth, "x * 1e1");
                ConversionFunctions.Add(WarpingMomentOfInertiaUnit.MeterToTheSixth, "x * 1e0");
                ConversionFunctions.Add(WarpingMomentOfInertiaUnit.Decimetertothesixth, "x * 1e-1");
                ConversionFunctions.Add(WarpingMomentOfInertiaUnit.Centimetertothesixth, "x * 1e-2");
                ConversionFunctions.Add(WarpingMomentOfInertiaUnit.Millimetertothesixth, "x * 1e-3");
                ConversionFunctions.Add(WarpingMomentOfInertiaUnit.Micrometertothesixth, "x * 1e-6");
                ConversionFunctions.Add(WarpingMomentOfInertiaUnit.Nanometertothesixth, "x * 1e-9");
                ConversionFunctions.Add(WarpingMomentOfInertiaUnit.Picometertothesixth, "x * 1e-12");
                ConversionFunctions.Add(WarpingMomentOfInertiaUnit.Femtometertothesixth, "x * 1e-15");
                ConversionFunctions.Add(WarpingMomentOfInertiaUnit.Attometertothesixth, "x * 1e-18");
                ConversionFunctions.Add(WarpingMomentOfInertiaUnit.Zeptometertothesixth, "x * 1e-21");
                ConversionFunctions.Add(WarpingMomentOfInertiaUnit.Yoctometertothesixth, "x * 1e-24");
            }
        }
    }
