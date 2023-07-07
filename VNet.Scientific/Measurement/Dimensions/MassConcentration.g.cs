
    // Auto-generated for VNet on 2023-07-06 12:42:23
    using System.Numerics;
    
    
    namespace VNet.Scientific.Measurement.Dimensions
    {
        public sealed class MassConcentration<TVal> : DimensionBase<MassConcentrationUnit, TVal> where TVal : notnull, INumber<TVal>
        {
            public override string IdTag => nameof(MassConcentration<TVal>);
            
            public MassConcentration() : base()
            {
                Exponents.Length = -3;
                Exponents.Mass = 1;
                Exponents.Time = 0;
                Exponents.ElectricalCurrent = 0;
                Exponents.LuminousIntensity = 0;
                Exponents.Temperature = 0;
                Exponents.Amount = 0;
                
                DefaultUnit = MassConcentrationUnit.KilogramPerCubicMeter;
                
                Symbols.Add(MassConcentrationUnit.GramPerCubicMillimeter, "g/mm³");
                Symbols.Add(MassConcentrationUnit.GramPerCubicCentimeter, "g/cm³");
                Symbols.Add(MassConcentrationUnit.GramPerCubicMeter, "g/m³");
                Symbols.Add(MassConcentrationUnit.GramPerMicroliter, "g/μL");
                Symbols.Add(MassConcentrationUnit.GramPerMilliliter, "g/mL");
                Symbols.Add(MassConcentrationUnit.GramPerDeciliter, "g/dL");
                Symbols.Add(MassConcentrationUnit.GramPerLiter, "g/L");
                Symbols.Add(MassConcentrationUnit.TonnePerCubicMillimeter, "t/mm³");
                Symbols.Add(MassConcentrationUnit.TonnePerCubicCentimeter, "t/cm³");
                Symbols.Add(MassConcentrationUnit.TonnePerCubicMeter, "t/m³");
                Symbols.Add(MassConcentrationUnit.PoundPerCubicInch, "lb/in³");
                Symbols.Add(MassConcentrationUnit.PoundPerCubicFoot, "lb/ft³");
                Symbols.Add(MassConcentrationUnit.SlugPerCubicFoot, "slug/ft³");
                Symbols.Add(MassConcentrationUnit.PoundPerUSGallon, "ppg (U.S.)");
                Symbols.Add(MassConcentrationUnit.OuncePerUSGallon, "oz/gal (U.S.)");
                Symbols.Add(MassConcentrationUnit.OuncePerImperialGallon, "oz/gal (imp.)");
                Symbols.Add(MassConcentrationUnit.PoundPerImperialGallon, "ppg (imp.)");
                Symbols.Add(MassConcentrationUnit.YottagramPerCubicMeter, "Yg");
                Symbols.Add(MassConcentrationUnit.ZettagramPerCubicMeter, "Zg");
                Symbols.Add(MassConcentrationUnit.ExagramPerCubicMeter, "Eg");
                Symbols.Add(MassConcentrationUnit.PetagramPerCubicMeter, "Pg");
                Symbols.Add(MassConcentrationUnit.TeragramPerCubicMeter, "Tg");
                Symbols.Add(MassConcentrationUnit.GigagramPerCubicMeter, "Gg");
                Symbols.Add(MassConcentrationUnit.MegagramPerCubicMeter, "Mg");
                Symbols.Add(MassConcentrationUnit.HectogramPerCubicMeter, "hg");
                Symbols.Add(MassConcentrationUnit.DekagramPerCubicMeter, "dag");
                Symbols.Add(MassConcentrationUnit.KilogramPerCubicMeter, "g");
                Symbols.Add(MassConcentrationUnit.DecigramPerCubicMeter, "dg");
                Symbols.Add(MassConcentrationUnit.CentigramPerCubicMeter, "cg");
                Symbols.Add(MassConcentrationUnit.MilligramPerCubicMeter, "mg");
                Symbols.Add(MassConcentrationUnit.MicrogramPerCubicMeter, "µg");
                Symbols.Add(MassConcentrationUnit.NanogramPerCubicMeter, "ng");
                Symbols.Add(MassConcentrationUnit.PicogramPerCubicMeter, "pg");
                Symbols.Add(MassConcentrationUnit.FemtogramPerCubicMeter, "fg");
                Symbols.Add(MassConcentrationUnit.AttogramPerCubicMeter, "ag");
                Symbols.Add(MassConcentrationUnit.ZeptogramPerCubicMeter, "zg");
                Symbols.Add(MassConcentrationUnit.YoctogramPerCubicMeter, "yg");
                
                
                ConversionFunctions.Add(MassConcentrationUnit.GramPerCubicMillimeter, "1000 * (x / 1e-6)");
                ConversionFunctions.Add(MassConcentrationUnit.GramPerCubicCentimeter, "1000 * (x / 1e-3)");
                ConversionFunctions.Add(MassConcentrationUnit.GramPerCubicMeter, "1000 * (x / 1e3)");
                ConversionFunctions.Add(MassConcentrationUnit.GramPerMicroliter, "1000 * (x / 1e-6)");
                ConversionFunctions.Add(MassConcentrationUnit.GramPerMilliliter, "1000 * (x / 1e-3)");
                ConversionFunctions.Add(MassConcentrationUnit.GramPerDeciliter, "1000 * (x / 1e-1)");
                ConversionFunctions.Add(MassConcentrationUnit.GramPerLiter, "1000 * (x)");
                ConversionFunctions.Add(MassConcentrationUnit.TonnePerCubicMillimeter, "1000 * (x / 1e-12)");
                ConversionFunctions.Add(MassConcentrationUnit.TonnePerCubicCentimeter, "1000 * (x / 1e-9)");
                ConversionFunctions.Add(MassConcentrationUnit.TonnePerCubicMeter, "1000 * (x / 0.001)");
                ConversionFunctions.Add(MassConcentrationUnit.PoundPerCubicInch, "1000 * (x / 3.6127298147753e-5)");
                ConversionFunctions.Add(MassConcentrationUnit.PoundPerCubicFoot, "1000 * (x / 0.062427961)");
                ConversionFunctions.Add(MassConcentrationUnit.SlugPerCubicFoot, "1000 * (x * 515.378818)");
                ConversionFunctions.Add(MassConcentrationUnit.PoundPerUSGallon, "1000 * (x * 1.19826427e2)");
                ConversionFunctions.Add(MassConcentrationUnit.OuncePerUSGallon, "1000 * ( x / 0.1335264711843)");
                ConversionFunctions.Add(MassConcentrationUnit.OuncePerImperialGallon, "1000 * ( x / 0.1603586720609)");
                ConversionFunctions.Add(MassConcentrationUnit.PoundPerImperialGallon, "1000 * (x * 9.9776398e1)");
                ConversionFunctions.Add(MassConcentrationUnit.YottagramPerCubicMeter, "1000 * (x * 1e24)");
                ConversionFunctions.Add(MassConcentrationUnit.ZettagramPerCubicMeter, "1000 * (x * 1e21)");
                ConversionFunctions.Add(MassConcentrationUnit.ExagramPerCubicMeter, "1000 * (x * 1e18)");
                ConversionFunctions.Add(MassConcentrationUnit.PetagramPerCubicMeter, "1000 * (x * 1e15)");
                ConversionFunctions.Add(MassConcentrationUnit.TeragramPerCubicMeter, "1000 * (x * 1e12)");
                ConversionFunctions.Add(MassConcentrationUnit.GigagramPerCubicMeter, "1000 * (x * 1e9)");
                ConversionFunctions.Add(MassConcentrationUnit.MegagramPerCubicMeter, "1000 * (x * 1e6)");
                ConversionFunctions.Add(MassConcentrationUnit.HectogramPerCubicMeter, "1000 * (x * 1e2)");
                ConversionFunctions.Add(MassConcentrationUnit.DekagramPerCubicMeter, "1000 * (x * 1e1)");
                ConversionFunctions.Add(MassConcentrationUnit.KilogramPerCubicMeter, "1000 * (x * 1e0)");
                ConversionFunctions.Add(MassConcentrationUnit.DecigramPerCubicMeter, "1000 * (x * 1e-1)");
                ConversionFunctions.Add(MassConcentrationUnit.CentigramPerCubicMeter, "1000 * (x * 1e-2)");
                ConversionFunctions.Add(MassConcentrationUnit.MilligramPerCubicMeter, "1000 * (x * 1e-3)");
                ConversionFunctions.Add(MassConcentrationUnit.MicrogramPerCubicMeter, "1000 * (x * 1e-6)");
                ConversionFunctions.Add(MassConcentrationUnit.NanogramPerCubicMeter, "1000 * (x * 1e-9)");
                ConversionFunctions.Add(MassConcentrationUnit.PicogramPerCubicMeter, "1000 * (x * 1e-12)");
                ConversionFunctions.Add(MassConcentrationUnit.FemtogramPerCubicMeter, "1000 * (x * 1e-15)");
                ConversionFunctions.Add(MassConcentrationUnit.AttogramPerCubicMeter, "1000 * (x * 1e-18)");
                ConversionFunctions.Add(MassConcentrationUnit.ZeptogramPerCubicMeter, "1000 * (x * 1e-21)");
                ConversionFunctions.Add(MassConcentrationUnit.YoctogramPerCubicMeter, "1000 * (x * 1e-24)");
            }
        }
    }
