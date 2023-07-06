
    // Auto-generated for VNet on 2023-07-05 10:35:43
    using System.Numerics;
    
    
    namespace VNet.Scientific.Measurement.Dimensions
    {
        public sealed class Angle<TVal> : DimensionBase<AngleUnit, TVal> where TVal : notnull, INumber<TVal>
        {
            public override string IdTag => nameof(Angle<TVal>);
            
            public Angle() : base()
            {
                DimensionComponent.Exponents.Length = 0;
                DimensionComponent.Exponents.Mass = 0;
                DimensionComponent.Exponents.Time = 0;
                DimensionComponent.Exponents.ElectricalCurrent = 0;
                DimensionComponent.Exponents.LuminousIntensity = 0;
                DimensionComponent.Exponents.Temperature = 0;
                DimensionComponent.Exponents.Amount = 0;
                
                DefaultUnit = AngleUnit.Degree;
                
                Symbols.Add(AngleUnit.Radian, "rad");
                Symbols.Add(AngleUnit.Degree, "°");
                Symbols.Add(AngleUnit.Arcsecond, "″");
                Symbols.Add(AngleUnit.Gradian, "g");
                Symbols.Add(AngleUnit.NatoMil, "mil");
                Symbols.Add(AngleUnit.Revolution, "r");
                Symbols.Add(AngleUnit.Tilt, "sin(θ)");
                
                PluralSymbols.Add(AngleUnit.Degree, "deg");
                PluralSymbols.Add(AngleUnit.Arcminute, "arcmin");
                PluralSymbols.Add(AngleUnit.Arcsecond, "arcsec");
                
                ConversionFunctions.Add(AngleUnit.Radian, "x * 180 / Math.PI");
                ConversionFunctions.Add(AngleUnit.Degree, "x");
                ConversionFunctions.Add(AngleUnit.Arcminute, "x / 60");
                ConversionFunctions.Add(AngleUnit.Arcsecond, "x / 3600");
                ConversionFunctions.Add(AngleUnit.Gradian, "x * 0.9");
                ConversionFunctions.Add(AngleUnit.NatoMil, "x * 9 / 160");
                ConversionFunctions.Add(AngleUnit.Revolution, "x * 360");
                ConversionFunctions.Add(AngleUnit.Tilt, "Math.Asin(x) * 180 / Math.PI");
            }
        }
    }
