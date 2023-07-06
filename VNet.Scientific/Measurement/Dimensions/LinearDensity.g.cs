
    // Auto-generated for VNet on 2023-07-05 10:35:43
    using System.Numerics;
    
    
    namespace VNet.Scientific.Measurement.Dimensions
    {
        public sealed class LinearDensity<TVal> : DimensionBase<LinearDensityUnit, TVal> where TVal : notnull, INumber<TVal>
        {
            public override string IdTag => nameof(LinearDensity<TVal>);
            
            public LinearDensity() : base()
            {
                DimensionComponent.Exponents.Length = -1;
                DimensionComponent.Exponents.Mass = 1;
                DimensionComponent.Exponents.Time = 0;
                DimensionComponent.Exponents.ElectricalCurrent = 0;
                DimensionComponent.Exponents.LuminousIntensity = 0;
                DimensionComponent.Exponents.Temperature = 0;
                DimensionComponent.Exponents.Amount = 0;
                
                DefaultUnit = LinearDensityUnit.KilogramPerMeter;
                
                Symbols.Add(LinearDensityUnit.GramPerMillimeter, "g/mm");
                Symbols.Add(LinearDensityUnit.GramPerCentimeter, "g/cm");
                Symbols.Add(LinearDensityUnit.GramPerMeter, "g/m");
                Symbols.Add(LinearDensityUnit.PoundPerInch, "lb/in");
                Symbols.Add(LinearDensityUnit.PoundPerFoot, "lb/ft");
                Symbols.Add(LinearDensityUnit.YottagramPerMeter, "Yg");
                Symbols.Add(LinearDensityUnit.ZettagramPerMeter, "Zg");
                Symbols.Add(LinearDensityUnit.ExagramPerMeter, "Eg");
                Symbols.Add(LinearDensityUnit.PetagramPerMeter, "Pg");
                Symbols.Add(LinearDensityUnit.TeragramPerMeter, "Tg");
                Symbols.Add(LinearDensityUnit.GigagramPerMeter, "Gg");
                Symbols.Add(LinearDensityUnit.MegagramPerMeter, "Mg");
                Symbols.Add(LinearDensityUnit.HectogramPerMeter, "hg");
                Symbols.Add(LinearDensityUnit.DekagramPerMeter, "dag");
                Symbols.Add(LinearDensityUnit.KilogramPerMeter, "g");
                Symbols.Add(LinearDensityUnit.DecigramPerMeter, "dg");
                Symbols.Add(LinearDensityUnit.CentigramPerMeter, "cg");
                Symbols.Add(LinearDensityUnit.MilligramPerMeter, "mg");
                Symbols.Add(LinearDensityUnit.MicrogramPerMeter, "µg");
                Symbols.Add(LinearDensityUnit.NanogramPerMeter, "ng");
                Symbols.Add(LinearDensityUnit.PicogramPerMeter, "pg");
                Symbols.Add(LinearDensityUnit.FemtogramPerMeter, "fg");
                Symbols.Add(LinearDensityUnit.AttogramPerMeter, "ag");
                Symbols.Add(LinearDensityUnit.ZeptogramPerMeter, "zg");
                Symbols.Add(LinearDensityUnit.YoctogramPerMeter, "yg");
                
                
                ConversionFunctions.Add(LinearDensityUnit.GramPerMillimeter, "1000 * (x)");
                ConversionFunctions.Add(LinearDensityUnit.GramPerCentimeter, "1000 * (x * 1e-1)");
                ConversionFunctions.Add(LinearDensityUnit.GramPerMeter, "1000 * (x * 1e-3)");
                ConversionFunctions.Add(LinearDensityUnit.PoundPerInch, "1000 * (x / 5.5997415e-2)");
                ConversionFunctions.Add(LinearDensityUnit.PoundPerFoot, "1000 * (x * 1.48816394)");
                ConversionFunctions.Add(LinearDensityUnit.YottagramPerMeter, "1000 * (x * 1e24)");
                ConversionFunctions.Add(LinearDensityUnit.ZettagramPerMeter, "1000 * (x * 1e21)");
                ConversionFunctions.Add(LinearDensityUnit.ExagramPerMeter, "1000 * (x * 1e18)");
                ConversionFunctions.Add(LinearDensityUnit.PetagramPerMeter, "1000 * (x * 1e15)");
                ConversionFunctions.Add(LinearDensityUnit.TeragramPerMeter, "1000 * (x * 1e12)");
                ConversionFunctions.Add(LinearDensityUnit.GigagramPerMeter, "1000 * (x * 1e9)");
                ConversionFunctions.Add(LinearDensityUnit.MegagramPerMeter, "1000 * (x * 1e6)");
                ConversionFunctions.Add(LinearDensityUnit.HectogramPerMeter, "1000 * (x * 1e2)");
                ConversionFunctions.Add(LinearDensityUnit.DekagramPerMeter, "1000 * (x * 1e1)");
                ConversionFunctions.Add(LinearDensityUnit.KilogramPerMeter, "1000 * (x * 1e0)");
                ConversionFunctions.Add(LinearDensityUnit.DecigramPerMeter, "1000 * (x * 1e-1)");
                ConversionFunctions.Add(LinearDensityUnit.CentigramPerMeter, "1000 * (x * 1e-2)");
                ConversionFunctions.Add(LinearDensityUnit.MilligramPerMeter, "1000 * (x * 1e-3)");
                ConversionFunctions.Add(LinearDensityUnit.MicrogramPerMeter, "1000 * (x * 1e-6)");
                ConversionFunctions.Add(LinearDensityUnit.NanogramPerMeter, "1000 * (x * 1e-9)");
                ConversionFunctions.Add(LinearDensityUnit.PicogramPerMeter, "1000 * (x * 1e-12)");
                ConversionFunctions.Add(LinearDensityUnit.FemtogramPerMeter, "1000 * (x * 1e-15)");
                ConversionFunctions.Add(LinearDensityUnit.AttogramPerMeter, "1000 * (x * 1e-18)");
                ConversionFunctions.Add(LinearDensityUnit.ZeptogramPerMeter, "1000 * (x * 1e-21)");
                ConversionFunctions.Add(LinearDensityUnit.YoctogramPerMeter, "1000 * (x * 1e-24)");
            }
        }
    }
