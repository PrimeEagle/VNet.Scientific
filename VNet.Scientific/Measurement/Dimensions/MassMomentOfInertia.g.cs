
    // Auto-generated for VNet on 2023-07-05 10:35:43
    using System.Numerics;
    
    
    namespace VNet.Scientific.Measurement.Dimensions
    {
        public sealed class MassMomentOfInertia<TVal> : DimensionBase<MassMomentOfInertiaUnit, TVal> where TVal : notnull, INumber<TVal>
        {
            public override string IdTag => nameof(MassMomentOfInertia<TVal>);
            
            public MassMomentOfInertia() : base()
            {
                DimensionComponent.Exponents.Length = 2;
                DimensionComponent.Exponents.Mass = 1;
                DimensionComponent.Exponents.Time = 0;
                DimensionComponent.Exponents.ElectricalCurrent = 0;
                DimensionComponent.Exponents.LuminousIntensity = 0;
                DimensionComponent.Exponents.Temperature = 0;
                DimensionComponent.Exponents.Amount = 0;
                
                DefaultUnit = MassMomentOfInertiaUnit.KilogramSquareMeter;
                
                Symbols.Add(MassMomentOfInertiaUnit.GramSquareMeter, "g·m²");
                Symbols.Add(MassMomentOfInertiaUnit.GramSquareDecimeter, "g·dm²");
                Symbols.Add(MassMomentOfInertiaUnit.GramSquareCentimeter, "g·cm²");
                Symbols.Add(MassMomentOfInertiaUnit.GramSquareMillimeter, "g·mm²");
                Symbols.Add(MassMomentOfInertiaUnit.TonneSquareMeter, "t·m²");
                Symbols.Add(MassMomentOfInertiaUnit.TonneSquareDecimeter, "t·dm²");
                Symbols.Add(MassMomentOfInertiaUnit.TonneSquareCentimeter, "t·cm²");
                Symbols.Add(MassMomentOfInertiaUnit.TonneSquareMilimeter, "t·mm²");
                Symbols.Add(MassMomentOfInertiaUnit.PoundSquareFoot, "lb·ft²");
                Symbols.Add(MassMomentOfInertiaUnit.PoundSquareInch, "lb·in²");
                Symbols.Add(MassMomentOfInertiaUnit.SlugSquareFoot, "slug·ft²");
                Symbols.Add(MassMomentOfInertiaUnit.SlugSquareInch, "slug·in²");
                Symbols.Add(MassMomentOfInertiaUnit.YottagramSquareMeter, "Yg");
                Symbols.Add(MassMomentOfInertiaUnit.ZettagramSquareMeter, "Zg");
                Symbols.Add(MassMomentOfInertiaUnit.ExagramSquareMeter, "Eg");
                Symbols.Add(MassMomentOfInertiaUnit.PetagramSquareMeter, "Pg");
                Symbols.Add(MassMomentOfInertiaUnit.TeragramSquareMeter, "Tg");
                Symbols.Add(MassMomentOfInertiaUnit.GigagramSquareMeter, "Gg");
                Symbols.Add(MassMomentOfInertiaUnit.MegagramSquareMeter, "Mg");
                Symbols.Add(MassMomentOfInertiaUnit.HectogramSquareMeter, "hg");
                Symbols.Add(MassMomentOfInertiaUnit.DekagramSquareMeter, "dag");
                Symbols.Add(MassMomentOfInertiaUnit.KilogramSquareMeter, "g");
                Symbols.Add(MassMomentOfInertiaUnit.DecigramSquareMeter, "dg");
                Symbols.Add(MassMomentOfInertiaUnit.CentigramSquareMeter, "cg");
                Symbols.Add(MassMomentOfInertiaUnit.MilligramSquareMeter, "mg");
                Symbols.Add(MassMomentOfInertiaUnit.MicrogramSquareMeter, "µg");
                Symbols.Add(MassMomentOfInertiaUnit.NanogramSquareMeter, "ng");
                Symbols.Add(MassMomentOfInertiaUnit.PicogramSquareMeter, "pg");
                Symbols.Add(MassMomentOfInertiaUnit.FemtogramSquareMeter, "fg");
                Symbols.Add(MassMomentOfInertiaUnit.AttogramSquareMeter, "ag");
                Symbols.Add(MassMomentOfInertiaUnit.ZeptogramSquareMeter, "zg");
                Symbols.Add(MassMomentOfInertiaUnit.YoctogramSquareMeter, "yg");
                
                
                ConversionFunctions.Add(MassMomentOfInertiaUnit.GramSquareMeter, "1000 * (x / 1e3)");
                ConversionFunctions.Add(MassMomentOfInertiaUnit.GramSquareDecimeter, "1000 * (x / 1e5)");
                ConversionFunctions.Add(MassMomentOfInertiaUnit.GramSquareCentimeter, "1000 * (x / 1e7)");
                ConversionFunctions.Add(MassMomentOfInertiaUnit.GramSquareMillimeter, "1000 * (x / 1e9)");
                ConversionFunctions.Add(MassMomentOfInertiaUnit.TonneSquareMeter, "1000 * (x / 1e-3)");
                ConversionFunctions.Add(MassMomentOfInertiaUnit.TonneSquareDecimeter, "1000 * (x / 1e-1)");
                ConversionFunctions.Add(MassMomentOfInertiaUnit.TonneSquareCentimeter, "1000 * (x / 1e1)");
                ConversionFunctions.Add(MassMomentOfInertiaUnit.TonneSquareMilimeter, "1000 * (x / 1e3)");
                ConversionFunctions.Add(MassMomentOfInertiaUnit.PoundSquareFoot, "1000 * (x * 4.21401101e-2)");
                ConversionFunctions.Add(MassMomentOfInertiaUnit.PoundSquareInch, "1000 * (x * 2.9263965e-4)");
                ConversionFunctions.Add(MassMomentOfInertiaUnit.SlugSquareFoot, "1000 * (x * 1.3558179619)");
                ConversionFunctions.Add(MassMomentOfInertiaUnit.SlugSquareInch, "1000 * (x * 9.41540242e-3)");
                ConversionFunctions.Add(MassMomentOfInertiaUnit.YottagramSquareMeter, "1000 * (x * 1e24)");
                ConversionFunctions.Add(MassMomentOfInertiaUnit.ZettagramSquareMeter, "1000 * (x * 1e21)");
                ConversionFunctions.Add(MassMomentOfInertiaUnit.ExagramSquareMeter, "1000 * (x * 1e18)");
                ConversionFunctions.Add(MassMomentOfInertiaUnit.PetagramSquareMeter, "1000 * (x * 1e15)");
                ConversionFunctions.Add(MassMomentOfInertiaUnit.TeragramSquareMeter, "1000 * (x * 1e12)");
                ConversionFunctions.Add(MassMomentOfInertiaUnit.GigagramSquareMeter, "1000 * (x * 1e9)");
                ConversionFunctions.Add(MassMomentOfInertiaUnit.MegagramSquareMeter, "1000 * (x * 1e6)");
                ConversionFunctions.Add(MassMomentOfInertiaUnit.HectogramSquareMeter, "1000 * (x * 1e2)");
                ConversionFunctions.Add(MassMomentOfInertiaUnit.DekagramSquareMeter, "1000 * (x * 1e1)");
                ConversionFunctions.Add(MassMomentOfInertiaUnit.KilogramSquareMeter, "1000 * (x * 1e0)");
                ConversionFunctions.Add(MassMomentOfInertiaUnit.DecigramSquareMeter, "1000 * (x * 1e-1)");
                ConversionFunctions.Add(MassMomentOfInertiaUnit.CentigramSquareMeter, "1000 * (x * 1e-2)");
                ConversionFunctions.Add(MassMomentOfInertiaUnit.MilligramSquareMeter, "1000 * (x * 1e-3)");
                ConversionFunctions.Add(MassMomentOfInertiaUnit.MicrogramSquareMeter, "1000 * (x * 1e-6)");
                ConversionFunctions.Add(MassMomentOfInertiaUnit.NanogramSquareMeter, "1000 * (x * 1e-9)");
                ConversionFunctions.Add(MassMomentOfInertiaUnit.PicogramSquareMeter, "1000 * (x * 1e-12)");
                ConversionFunctions.Add(MassMomentOfInertiaUnit.FemtogramSquareMeter, "1000 * (x * 1e-15)");
                ConversionFunctions.Add(MassMomentOfInertiaUnit.AttogramSquareMeter, "1000 * (x * 1e-18)");
                ConversionFunctions.Add(MassMomentOfInertiaUnit.ZeptogramSquareMeter, "1000 * (x * 1e-21)");
                ConversionFunctions.Add(MassMomentOfInertiaUnit.YoctogramSquareMeter, "1000 * (x * 1e-24)");
            }
        }
    }
