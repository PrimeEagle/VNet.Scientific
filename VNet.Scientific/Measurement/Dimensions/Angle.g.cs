
    // Auto-generated for VNet on 2023-07-06 12:42:23
    using System.Numerics;
    
    
    namespace VNet.Scientific.Measurement.Dimensions
    {
        public sealed class Angle<TVal> : DimensionBase<AngleUnit, TVal> where TVal : notnull, INumber<TVal>
        {
            public override string IdTag => nameof(Angle<TVal>);
            
            public Angle() : base()
            {
                Exponents.Length = 0;
                Exponents.Mass = 0;
                Exponents.Time = 0;
                Exponents.ElectricalCurrent = 0;
                Exponents.LuminousIntensity = 0;
                Exponents.Temperature = 0;
                Exponents.Amount = 0;
                
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
