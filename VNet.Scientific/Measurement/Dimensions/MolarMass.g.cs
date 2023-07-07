
    // Auto-generated for VNet on 2023-07-06 12:42:23
    using System.Numerics;
    
    
    namespace VNet.Scientific.Measurement.Dimensions
    {
        public sealed class MolarMass<TVal> : DimensionBase<MolarMassUnit, TVal> where TVal : notnull, INumber<TVal>
        {
            public override string IdTag => nameof(MolarMass<TVal>);
            
            public MolarMass() : base()
            {
                Exponents.Length = 0;
                Exponents.Mass = 1;
                Exponents.Time = 0;
                Exponents.ElectricalCurrent = 0;
                Exponents.LuminousIntensity = 0;
                Exponents.Temperature = 0;
                Exponents.Amount = -1;
                
                DefaultUnit = MolarMassUnit.KilogramPerMole;
                
                Symbols.Add(MolarMassUnit.GramPerMole, "g/mol");
                Symbols.Add(MolarMassUnit.KilogramPerKilomole, "kg/kmol");
                Symbols.Add(MolarMassUnit.PoundPerMole, "lb/mol");
                Symbols.Add(MolarMassUnit.YottagramPerMole, "Yg");
                Symbols.Add(MolarMassUnit.ZettagramPerMole, "Zg");
                Symbols.Add(MolarMassUnit.ExagramPerMole, "Eg");
                Symbols.Add(MolarMassUnit.PetagramPerMole, "Pg");
                Symbols.Add(MolarMassUnit.TeragramPerMole, "Tg");
                Symbols.Add(MolarMassUnit.GigagramPerMole, "Gg");
                Symbols.Add(MolarMassUnit.MegagramPerMole, "Mg");
                Symbols.Add(MolarMassUnit.HectogramPerMole, "hg");
                Symbols.Add(MolarMassUnit.DekagramPerMole, "dag");
                Symbols.Add(MolarMassUnit.KilogramPerMole, "g");
                Symbols.Add(MolarMassUnit.DecigramPerMole, "dg");
                Symbols.Add(MolarMassUnit.CentigramPerMole, "cg");
                Symbols.Add(MolarMassUnit.MilligramPerMole, "mg");
                Symbols.Add(MolarMassUnit.MicrogramPerMole, "µg");
                Symbols.Add(MolarMassUnit.NanogramPerMole, "ng");
                Symbols.Add(MolarMassUnit.PicogramPerMole, "pg");
                Symbols.Add(MolarMassUnit.FemtogramPerMole, "fg");
                Symbols.Add(MolarMassUnit.AttogramPerMole, "ag");
                Symbols.Add(MolarMassUnit.ZeptogramPerMole, "zg");
                Symbols.Add(MolarMassUnit.YoctogramPerMole, "yg");
                
                
                ConversionFunctions.Add(MolarMassUnit.GramPerMole, "1000 * (x / 1e3)");
                ConversionFunctions.Add(MolarMassUnit.KilogramPerKilomole, "1000 * (x / 1e3)");
                ConversionFunctions.Add(MolarMassUnit.PoundPerMole, "1000 * (x * 0.45359237)");
                ConversionFunctions.Add(MolarMassUnit.YottagramPerMole, "1000 * (x * 1e24)");
                ConversionFunctions.Add(MolarMassUnit.ZettagramPerMole, "1000 * (x * 1e21)");
                ConversionFunctions.Add(MolarMassUnit.ExagramPerMole, "1000 * (x * 1e18)");
                ConversionFunctions.Add(MolarMassUnit.PetagramPerMole, "1000 * (x * 1e15)");
                ConversionFunctions.Add(MolarMassUnit.TeragramPerMole, "1000 * (x * 1e12)");
                ConversionFunctions.Add(MolarMassUnit.GigagramPerMole, "1000 * (x * 1e9)");
                ConversionFunctions.Add(MolarMassUnit.MegagramPerMole, "1000 * (x * 1e6)");
                ConversionFunctions.Add(MolarMassUnit.HectogramPerMole, "1000 * (x * 1e2)");
                ConversionFunctions.Add(MolarMassUnit.DekagramPerMole, "1000 * (x * 1e1)");
                ConversionFunctions.Add(MolarMassUnit.KilogramPerMole, "1000 * (x * 1e0)");
                ConversionFunctions.Add(MolarMassUnit.DecigramPerMole, "1000 * (x * 1e-1)");
                ConversionFunctions.Add(MolarMassUnit.CentigramPerMole, "1000 * (x * 1e-2)");
                ConversionFunctions.Add(MolarMassUnit.MilligramPerMole, "1000 * (x * 1e-3)");
                ConversionFunctions.Add(MolarMassUnit.MicrogramPerMole, "1000 * (x * 1e-6)");
                ConversionFunctions.Add(MolarMassUnit.NanogramPerMole, "1000 * (x * 1e-9)");
                ConversionFunctions.Add(MolarMassUnit.PicogramPerMole, "1000 * (x * 1e-12)");
                ConversionFunctions.Add(MolarMassUnit.FemtogramPerMole, "1000 * (x * 1e-15)");
                ConversionFunctions.Add(MolarMassUnit.AttogramPerMole, "1000 * (x * 1e-18)");
                ConversionFunctions.Add(MolarMassUnit.ZeptogramPerMole, "1000 * (x * 1e-21)");
                ConversionFunctions.Add(MolarMassUnit.YoctogramPerMole, "1000 * (x * 1e-24)");
            }
        }
    }
