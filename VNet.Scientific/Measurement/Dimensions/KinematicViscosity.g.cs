
    // Auto-generated for VNet on 2023-07-06 12:42:23
    using System.Numerics;
    
    
    namespace VNet.Scientific.Measurement.Dimensions
    {
        public sealed class KinematicViscosity<TVal> : DimensionBase<KinematicViscosityUnit, TVal> where TVal : notnull, INumber<TVal>
        {
            public override string IdTag => nameof(KinematicViscosity<TVal>);
            
            public KinematicViscosity() : base()
            {
                Exponents.Length = 2;
                Exponents.Mass = 0;
                Exponents.Time = -1;
                Exponents.ElectricalCurrent = 0;
                Exponents.LuminousIntensity = 0;
                Exponents.Temperature = 0;
                Exponents.Amount = 0;
                
                DefaultUnit = KinematicViscosityUnit.SquareMeterPerSecond;
                
                Symbols.Add(KinematicViscosityUnit.Stokes, "St");
                Symbols.Add(KinematicViscosityUnit.SquareFootPerSecond, "ft²/s");
                Symbols.Add(KinematicViscosityUnit.Yottasquaremeterpersecond, "Ym²/s");
                Symbols.Add(KinematicViscosityUnit.Zettasquaremeterpersecond, "Zm²/s");
                Symbols.Add(KinematicViscosityUnit.Exasquaremeterpersecond, "Em²/s");
                Symbols.Add(KinematicViscosityUnit.Petasquaremeterpersecond, "Pm²/s");
                Symbols.Add(KinematicViscosityUnit.Terasquaremeterpersecond, "Tm²/s");
                Symbols.Add(KinematicViscosityUnit.Gigasquaremeterpersecond, "Gm²/s");
                Symbols.Add(KinematicViscosityUnit.Megasquaremeterpersecond, "Mm²/s");
                Symbols.Add(KinematicViscosityUnit.Kilosquaremeterpersecond, "km²/s");
                Symbols.Add(KinematicViscosityUnit.Hectosquaremeterpersecond, "hm²/s");
                Symbols.Add(KinematicViscosityUnit.Dekasquaremeterpersecond, "dam²/s");
                Symbols.Add(KinematicViscosityUnit.SquareMeterPerSecond, "m²/s");
                Symbols.Add(KinematicViscosityUnit.Decisquaremeterpersecond, "dm²/s");
                Symbols.Add(KinematicViscosityUnit.Centisquaremeterpersecond, "cm²/s");
                Symbols.Add(KinematicViscosityUnit.Millisquaremeterpersecond, "mm²/s");
                Symbols.Add(KinematicViscosityUnit.Microsquaremeterpersecond, "µm²/s");
                Symbols.Add(KinematicViscosityUnit.Nanosquaremeterpersecond, "nm²/s");
                Symbols.Add(KinematicViscosityUnit.Picosquaremeterpersecond, "pm²/s");
                Symbols.Add(KinematicViscosityUnit.Femtosquaremeterpersecond, "fm²/s");
                Symbols.Add(KinematicViscosityUnit.Attosquaremeterpersecond, "am²/s");
                Symbols.Add(KinematicViscosityUnit.Zeptosquaremeterpersecond, "zm²/s");
                Symbols.Add(KinematicViscosityUnit.Yoctosquaremeterpersecond, "ym²/s");
                
                
                ConversionFunctions.Add(KinematicViscosityUnit.Stokes, "x / 1e4");
                ConversionFunctions.Add(KinematicViscosityUnit.SquareFootPerSecond, "x / 10.7639");
                ConversionFunctions.Add(KinematicViscosityUnit.Yottasquaremeterpersecond, "x * 1e24");
                ConversionFunctions.Add(KinematicViscosityUnit.Zettasquaremeterpersecond, "x * 1e21");
                ConversionFunctions.Add(KinematicViscosityUnit.Exasquaremeterpersecond, "x * 1e18");
                ConversionFunctions.Add(KinematicViscosityUnit.Petasquaremeterpersecond, "x * 1e15");
                ConversionFunctions.Add(KinematicViscosityUnit.Terasquaremeterpersecond, "x * 1e12");
                ConversionFunctions.Add(KinematicViscosityUnit.Gigasquaremeterpersecond, "x * 1e9");
                ConversionFunctions.Add(KinematicViscosityUnit.Megasquaremeterpersecond, "x * 1e6");
                ConversionFunctions.Add(KinematicViscosityUnit.Kilosquaremeterpersecond, "x * 1e3");
                ConversionFunctions.Add(KinematicViscosityUnit.Hectosquaremeterpersecond, "x * 1e2");
                ConversionFunctions.Add(KinematicViscosityUnit.Dekasquaremeterpersecond, "x * 1e1");
                ConversionFunctions.Add(KinematicViscosityUnit.SquareMeterPerSecond, "x * 1e0");
                ConversionFunctions.Add(KinematicViscosityUnit.Decisquaremeterpersecond, "x * 1e-1");
                ConversionFunctions.Add(KinematicViscosityUnit.Centisquaremeterpersecond, "x * 1e-2");
                ConversionFunctions.Add(KinematicViscosityUnit.Millisquaremeterpersecond, "x * 1e-3");
                ConversionFunctions.Add(KinematicViscosityUnit.Microsquaremeterpersecond, "x * 1e-6");
                ConversionFunctions.Add(KinematicViscosityUnit.Nanosquaremeterpersecond, "x * 1e-9");
                ConversionFunctions.Add(KinematicViscosityUnit.Picosquaremeterpersecond, "x * 1e-12");
                ConversionFunctions.Add(KinematicViscosityUnit.Femtosquaremeterpersecond, "x * 1e-15");
                ConversionFunctions.Add(KinematicViscosityUnit.Attosquaremeterpersecond, "x * 1e-18");
                ConversionFunctions.Add(KinematicViscosityUnit.Zeptosquaremeterpersecond, "x * 1e-21");
                ConversionFunctions.Add(KinematicViscosityUnit.Yoctosquaremeterpersecond, "x * 1e-24");
            }
        }
    }
