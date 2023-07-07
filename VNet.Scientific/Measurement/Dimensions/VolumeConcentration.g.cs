
    // Auto-generated for VNet on 2023-07-06 12:42:23
    using System.Numerics;
    
    
    namespace VNet.Scientific.Measurement.Dimensions
    {
        public sealed class VolumeConcentration<TVal> : DimensionBase<VolumeConcentrationUnit, TVal> where TVal : notnull, INumber<TVal>
        {
            public override string IdTag => nameof(VolumeConcentration<TVal>);
            
            public VolumeConcentration() : base()
            {
                Exponents.Length = 0;
                Exponents.Mass = 0;
                Exponents.Time = 0;
                Exponents.ElectricalCurrent = 0;
                Exponents.LuminousIntensity = 0;
                Exponents.Temperature = 0;
                Exponents.Amount = 0;
                
                DefaultUnit = VolumeConcentrationUnit.DecimalFraction;
                
                Symbols.Add(VolumeConcentrationUnit.LitersPerLiter, "L/L");
                Symbols.Add(VolumeConcentrationUnit.LitersPerMililiter, "L/mL");
                Symbols.Add(VolumeConcentrationUnit.Percent, "%");
                Symbols.Add(VolumeConcentrationUnit.PartPerThousand, "‰");
                Symbols.Add(VolumeConcentrationUnit.PartPerMillion, "ppm");
                Symbols.Add(VolumeConcentrationUnit.PartPerBillion, "ppb");
                Symbols.Add(VolumeConcentrationUnit.PartPerTrillion, "ppt");
                
                PluralSymbols.Add(VolumeConcentrationUnit.Percent, "% (v/v)");
                
                ConversionFunctions.Add(VolumeConcentrationUnit.DecimalFraction, "x");
                ConversionFunctions.Add(VolumeConcentrationUnit.LitersPerLiter, "x");
                ConversionFunctions.Add(VolumeConcentrationUnit.LitersPerMililiter, "x / 1e-3");
                ConversionFunctions.Add(VolumeConcentrationUnit.Percent, "x / 1e2");
                ConversionFunctions.Add(VolumeConcentrationUnit.PartPerThousand, "x / 1e3");
                ConversionFunctions.Add(VolumeConcentrationUnit.PartPerMillion, "x / 1e6");
                ConversionFunctions.Add(VolumeConcentrationUnit.PartPerBillion, "x / 1e9");
                ConversionFunctions.Add(VolumeConcentrationUnit.PartPerTrillion, "x / 1e12");
            }
        }
    }
