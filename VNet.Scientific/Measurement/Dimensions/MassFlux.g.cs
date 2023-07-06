
    // Auto-generated for VNet on 2023-07-05 10:35:43
    using System.Numerics;
    
    
    namespace VNet.Scientific.Measurement.Dimensions
    {
        public sealed class MassFlux<TVal> : DimensionBase<MassFluxUnit, TVal> where TVal : notnull, INumber<TVal>
        {
            public override string IdTag => nameof(MassFlux<TVal>);
            
            public MassFlux() : base()
            {
                DimensionComponent.Exponents.Length = -2;
                DimensionComponent.Exponents.Mass = 1;
                DimensionComponent.Exponents.Time = -1;
                DimensionComponent.Exponents.ElectricalCurrent = 0;
                DimensionComponent.Exponents.LuminousIntensity = 0;
                DimensionComponent.Exponents.Temperature = 0;
                DimensionComponent.Exponents.Amount = 0;
                
                DefaultUnit = MassFluxUnit.KilogramPerSecondPerSquareMeter;
                
                Symbols.Add(MassFluxUnit.GramPerSecondPerSquareMeter, "g·s⁻¹·m⁻²");
                Symbols.Add(MassFluxUnit.GramPerSecondPerSquareCentimeter, "g·s⁻¹·cm⁻²");
                Symbols.Add(MassFluxUnit.GramPerSecondPerSquareMillimeter, "g·s⁻¹·mm⁻²");
                Symbols.Add(MassFluxUnit.GramPerHourPerSquareMeter, "g·h⁻¹·m⁻²");
                Symbols.Add(MassFluxUnit.GramPerHourPerSquareCentimeter, "g·h⁻¹·cm⁻²");
                Symbols.Add(MassFluxUnit.GramPerHourPerSquareMillimeter, "g·h⁻¹·mm⁻²");
                Symbols.Add(MassFluxUnit.YottagramPerSecondPerSquareMeter, "Yg");
                Symbols.Add(MassFluxUnit.ZettagramPerSecondPerSquareMeter, "Zg");
                Symbols.Add(MassFluxUnit.ExagramPerSecondPerSquareMeter, "Eg");
                Symbols.Add(MassFluxUnit.PetagramPerSecondPerSquareMeter, "Pg");
                Symbols.Add(MassFluxUnit.TeragramPerSecondPerSquareMeter, "Tg");
                Symbols.Add(MassFluxUnit.GigagramPerSecondPerSquareMeter, "Gg");
                Symbols.Add(MassFluxUnit.MegagramPerSecondPerSquareMeter, "Mg");
                Symbols.Add(MassFluxUnit.HectogramPerSecondPerSquareMeter, "hg");
                Symbols.Add(MassFluxUnit.DekagramPerSecondPerSquareMeter, "dag");
                Symbols.Add(MassFluxUnit.KilogramPerSecondPerSquareMeter, "g");
                Symbols.Add(MassFluxUnit.DecigramPerSecondPerSquareMeter, "dg");
                Symbols.Add(MassFluxUnit.CentigramPerSecondPerSquareMeter, "cg");
                Symbols.Add(MassFluxUnit.MilligramPerSecondPerSquareMeter, "mg");
                Symbols.Add(MassFluxUnit.MicrogramPerSecondPerSquareMeter, "µg");
                Symbols.Add(MassFluxUnit.NanogramPerSecondPerSquareMeter, "ng");
                Symbols.Add(MassFluxUnit.PicogramPerSecondPerSquareMeter, "pg");
                Symbols.Add(MassFluxUnit.FemtogramPerSecondPerSquareMeter, "fg");
                Symbols.Add(MassFluxUnit.AttogramPerSecondPerSquareMeter, "ag");
                Symbols.Add(MassFluxUnit.ZeptogramPerSecondPerSquareMeter, "zg");
                Symbols.Add(MassFluxUnit.YoctogramPerSecondPerSquareMeter, "yg");
                
                
                ConversionFunctions.Add(MassFluxUnit.GramPerSecondPerSquareMeter, "1000 * (x / 1e3)");
                ConversionFunctions.Add(MassFluxUnit.GramPerSecondPerSquareCentimeter, "1000 * (x / 1e-1)");
                ConversionFunctions.Add(MassFluxUnit.GramPerSecondPerSquareMillimeter, "1000 * (x / 1e-3)");
                ConversionFunctions.Add(MassFluxUnit.GramPerHourPerSquareMeter, "1000 * (x / 3.6e6)");
                ConversionFunctions.Add(MassFluxUnit.GramPerHourPerSquareCentimeter, "1000 * (x / 3.6e2)");
                ConversionFunctions.Add(MassFluxUnit.GramPerHourPerSquareMillimeter, "1000 * (x / 3.6e0)");
                ConversionFunctions.Add(MassFluxUnit.YottagramPerSecondPerSquareMeter, "1000 * (x * 1e24)");
                ConversionFunctions.Add(MassFluxUnit.ZettagramPerSecondPerSquareMeter, "1000 * (x * 1e21)");
                ConversionFunctions.Add(MassFluxUnit.ExagramPerSecondPerSquareMeter, "1000 * (x * 1e18)");
                ConversionFunctions.Add(MassFluxUnit.PetagramPerSecondPerSquareMeter, "1000 * (x * 1e15)");
                ConversionFunctions.Add(MassFluxUnit.TeragramPerSecondPerSquareMeter, "1000 * (x * 1e12)");
                ConversionFunctions.Add(MassFluxUnit.GigagramPerSecondPerSquareMeter, "1000 * (x * 1e9)");
                ConversionFunctions.Add(MassFluxUnit.MegagramPerSecondPerSquareMeter, "1000 * (x * 1e6)");
                ConversionFunctions.Add(MassFluxUnit.HectogramPerSecondPerSquareMeter, "1000 * (x * 1e2)");
                ConversionFunctions.Add(MassFluxUnit.DekagramPerSecondPerSquareMeter, "1000 * (x * 1e1)");
                ConversionFunctions.Add(MassFluxUnit.KilogramPerSecondPerSquareMeter, "1000 * (x * 1e0)");
                ConversionFunctions.Add(MassFluxUnit.DecigramPerSecondPerSquareMeter, "1000 * (x * 1e-1)");
                ConversionFunctions.Add(MassFluxUnit.CentigramPerSecondPerSquareMeter, "1000 * (x * 1e-2)");
                ConversionFunctions.Add(MassFluxUnit.MilligramPerSecondPerSquareMeter, "1000 * (x * 1e-3)");
                ConversionFunctions.Add(MassFluxUnit.MicrogramPerSecondPerSquareMeter, "1000 * (x * 1e-6)");
                ConversionFunctions.Add(MassFluxUnit.NanogramPerSecondPerSquareMeter, "1000 * (x * 1e-9)");
                ConversionFunctions.Add(MassFluxUnit.PicogramPerSecondPerSquareMeter, "1000 * (x * 1e-12)");
                ConversionFunctions.Add(MassFluxUnit.FemtogramPerSecondPerSquareMeter, "1000 * (x * 1e-15)");
                ConversionFunctions.Add(MassFluxUnit.AttogramPerSecondPerSquareMeter, "1000 * (x * 1e-18)");
                ConversionFunctions.Add(MassFluxUnit.ZeptogramPerSecondPerSquareMeter, "1000 * (x * 1e-21)");
                ConversionFunctions.Add(MassFluxUnit.YoctogramPerSecondPerSquareMeter, "1000 * (x * 1e-24)");
            }
        }
    }
