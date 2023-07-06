
    // Auto-generated for VNet on 2023-07-05 10:35:43
    using System.Numerics;
    
    
    namespace VNet.Scientific.Measurement.Dimensions
    {
        public sealed class Density<TVal> : DimensionBase<DensityUnit, TVal> where TVal : notnull, INumber<TVal>
        {
            public override string IdTag => nameof(Density<TVal>);
            
            public Density() : base()
            {
                DimensionComponent.Exponents.Length = -3;
                DimensionComponent.Exponents.Mass = 1;
                DimensionComponent.Exponents.Time = 0;
                DimensionComponent.Exponents.ElectricalCurrent = 0;
                DimensionComponent.Exponents.LuminousIntensity = 0;
                DimensionComponent.Exponents.Temperature = 0;
                DimensionComponent.Exponents.Amount = 0;
                
                DefaultUnit = DensityUnit.KilogramPerCubicMeter;
                
                Symbols.Add(DensityUnit.GramPerCubicMillimeter, "g/mm³");
                Symbols.Add(DensityUnit.GramPerCubicCentimeter, "g/cm³");
                Symbols.Add(DensityUnit.GramPerCubicMeter, "g/m³");
                Symbols.Add(DensityUnit.PoundPerCubicInch, "lb/in³");
                Symbols.Add(DensityUnit.PoundPerCubicFoot, "lb/ft³");
                Symbols.Add(DensityUnit.TonnePerCubicMillimeter, "t/mm³");
                Symbols.Add(DensityUnit.TonnePerCubicCentimeter, "t/cm³");
                Symbols.Add(DensityUnit.TonnePerCubicMeter, "t/m³");
                Symbols.Add(DensityUnit.SlugPerCubicFoot, "slug/ft³");
                Symbols.Add(DensityUnit.GramPerLiter, "g/L");
                Symbols.Add(DensityUnit.GramPerDeciliter, "g/dl");
                Symbols.Add(DensityUnit.GramPerMilliliter, "g/ml");
                Symbols.Add(DensityUnit.PoundPerUSGallon, "ppg (U.S.)");
                Symbols.Add(DensityUnit.PoundPerImperialGallon, "ppg (imp.)");
                Symbols.Add(DensityUnit.KilogramPerLiter, "kg/l");
                Symbols.Add(DensityUnit.TonnePerCubicFoot, "t/ft³");
                Symbols.Add(DensityUnit.TonnePerCubicInch, "t/in³");
                Symbols.Add(DensityUnit.GramPerCubicFoot, "g/ft³");
                Symbols.Add(DensityUnit.GramPerCubicInch, "g/in³");
                Symbols.Add(DensityUnit.PoundPerCubicMeter, "lb/m³");
                Symbols.Add(DensityUnit.PoundPerCubicCentimeter, "lb/cm³");
                Symbols.Add(DensityUnit.PoundPerCubicMillimeter, "lb/mm³");
                Symbols.Add(DensityUnit.SlugPerCubicMeter, "slug/m³");
                Symbols.Add(DensityUnit.SlugPerCubicCentimeter, "slug/cm³");
                Symbols.Add(DensityUnit.SlugPerCubicMillimeter, "slug/mm³");
                Symbols.Add(DensityUnit.SlugPerCubicInch, "slug/in³");
                Symbols.Add(DensityUnit.YottagramPerCubicMeter, "Yg");
                Symbols.Add(DensityUnit.ZettagramPerCubicMeter, "Zg");
                Symbols.Add(DensityUnit.ExagramPerCubicMeter, "Eg");
                Symbols.Add(DensityUnit.PetagramPerCubicMeter, "Pg");
                Symbols.Add(DensityUnit.TeragramPerCubicMeter, "Tg");
                Symbols.Add(DensityUnit.GigagramPerCubicMeter, "Gg");
                Symbols.Add(DensityUnit.MegagramPerCubicMeter, "Mg");
                Symbols.Add(DensityUnit.HectogramPerCubicMeter, "hg");
                Symbols.Add(DensityUnit.DekagramPerCubicMeter, "dag");
                Symbols.Add(DensityUnit.KilogramPerCubicMeter, "g");
                Symbols.Add(DensityUnit.DecigramPerCubicMeter, "dg");
                Symbols.Add(DensityUnit.CentigramPerCubicMeter, "cg");
                Symbols.Add(DensityUnit.MilligramPerCubicMeter, "mg");
                Symbols.Add(DensityUnit.MicrogramPerCubicMeter, "µg");
                Symbols.Add(DensityUnit.NanogramPerCubicMeter, "ng");
                Symbols.Add(DensityUnit.PicogramPerCubicMeter, "pg");
                Symbols.Add(DensityUnit.FemtogramPerCubicMeter, "fg");
                Symbols.Add(DensityUnit.AttogramPerCubicMeter, "ag");
                Symbols.Add(DensityUnit.ZeptogramPerCubicMeter, "zg");
                Symbols.Add(DensityUnit.YoctogramPerCubicMeter, "yg");
                
                
                ConversionFunctions.Add(DensityUnit.GramPerCubicMillimeter, "1000 * (x / 1e-6)");
                ConversionFunctions.Add(DensityUnit.GramPerCubicCentimeter, "1000 * (x / 1e-3)");
                ConversionFunctions.Add(DensityUnit.GramPerCubicMeter, "1000 * (x / 1e3)");
                ConversionFunctions.Add(DensityUnit.PoundPerCubicInch, "1000 * (x / 3.6127298147753e-5)");
                ConversionFunctions.Add(DensityUnit.PoundPerCubicFoot, "1000 * (x / 0.062427961)");
                ConversionFunctions.Add(DensityUnit.TonnePerCubicMillimeter, "1000 * (x / 1e-12)");
                ConversionFunctions.Add(DensityUnit.TonnePerCubicCentimeter, "1000 * (x / 1e-9)");
                ConversionFunctions.Add(DensityUnit.TonnePerCubicMeter, "1000 * (x / 0.001)");
                ConversionFunctions.Add(DensityUnit.SlugPerCubicFoot, "1000 * (x * 515.378818)");
                ConversionFunctions.Add(DensityUnit.GramPerLiter, "1000 * (x / 1)");
                ConversionFunctions.Add(DensityUnit.GramPerDeciliter, "1000 * (x / 1e-1)");
                ConversionFunctions.Add(DensityUnit.GramPerMilliliter, "1000 * (x / 1e-3)");
                ConversionFunctions.Add(DensityUnit.PoundPerUSGallon, "1000 * (x * 1.19826427e2)");
                ConversionFunctions.Add(DensityUnit.PoundPerImperialGallon, "1000 * (x * 9.9776398e1)");
                ConversionFunctions.Add(DensityUnit.KilogramPerLiter, "1000 * (x * 1e3)");
                ConversionFunctions.Add(DensityUnit.TonnePerCubicFoot, "1000 * (x * 3.53146667214886e4)");
                ConversionFunctions.Add(DensityUnit.TonnePerCubicInch, "1000 * (x * 6.10237440947323e7)");
                ConversionFunctions.Add(DensityUnit.GramPerCubicFoot, "1000 * (x * 0.0353146667214886)");
                ConversionFunctions.Add(DensityUnit.GramPerCubicInch, "1000 * (x * 61.0237440947323)");
                ConversionFunctions.Add(DensityUnit.PoundPerCubicMeter, "1000 * (x / 2.204622621848775)");
                ConversionFunctions.Add(DensityUnit.PoundPerCubicCentimeter, "1000 * (x / 2.204622621848775e-6)");
                ConversionFunctions.Add(DensityUnit.PoundPerCubicMillimeter, "1000 * (x / 2.204622621848775e-9)");
                ConversionFunctions.Add(DensityUnit.SlugPerCubicMeter, "1000 * (x * 14.5939)");
                ConversionFunctions.Add(DensityUnit.SlugPerCubicCentimeter, "1000 * (x * 14593903)");
                ConversionFunctions.Add(DensityUnit.SlugPerCubicMillimeter, "1000 * (x * 14593903000)");
                ConversionFunctions.Add(DensityUnit.SlugPerCubicInch, "1000 * (x * 890574.60201535)");
                ConversionFunctions.Add(DensityUnit.YottagramPerCubicMeter, "1000 * (x * 1e24)");
                ConversionFunctions.Add(DensityUnit.ZettagramPerCubicMeter, "1000 * (x * 1e21)");
                ConversionFunctions.Add(DensityUnit.ExagramPerCubicMeter, "1000 * (x * 1e18)");
                ConversionFunctions.Add(DensityUnit.PetagramPerCubicMeter, "1000 * (x * 1e15)");
                ConversionFunctions.Add(DensityUnit.TeragramPerCubicMeter, "1000 * (x * 1e12)");
                ConversionFunctions.Add(DensityUnit.GigagramPerCubicMeter, "1000 * (x * 1e9)");
                ConversionFunctions.Add(DensityUnit.MegagramPerCubicMeter, "1000 * (x * 1e6)");
                ConversionFunctions.Add(DensityUnit.HectogramPerCubicMeter, "1000 * (x * 1e2)");
                ConversionFunctions.Add(DensityUnit.DekagramPerCubicMeter, "1000 * (x * 1e1)");
                ConversionFunctions.Add(DensityUnit.KilogramPerCubicMeter, "1000 * (x * 1e0)");
                ConversionFunctions.Add(DensityUnit.DecigramPerCubicMeter, "1000 * (x * 1e-1)");
                ConversionFunctions.Add(DensityUnit.CentigramPerCubicMeter, "1000 * (x * 1e-2)");
                ConversionFunctions.Add(DensityUnit.MilligramPerCubicMeter, "1000 * (x * 1e-3)");
                ConversionFunctions.Add(DensityUnit.MicrogramPerCubicMeter, "1000 * (x * 1e-6)");
                ConversionFunctions.Add(DensityUnit.NanogramPerCubicMeter, "1000 * (x * 1e-9)");
                ConversionFunctions.Add(DensityUnit.PicogramPerCubicMeter, "1000 * (x * 1e-12)");
                ConversionFunctions.Add(DensityUnit.FemtogramPerCubicMeter, "1000 * (x * 1e-15)");
                ConversionFunctions.Add(DensityUnit.AttogramPerCubicMeter, "1000 * (x * 1e-18)");
                ConversionFunctions.Add(DensityUnit.ZeptogramPerCubicMeter, "1000 * (x * 1e-21)");
                ConversionFunctions.Add(DensityUnit.YoctogramPerCubicMeter, "1000 * (x * 1e-24)");
            }
        }
    }
