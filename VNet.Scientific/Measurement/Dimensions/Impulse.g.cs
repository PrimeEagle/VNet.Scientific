
    // Auto-generated for VNet on 2023-07-06 12:42:23
    using System.Numerics;
    
    
    namespace VNet.Scientific.Measurement.Dimensions
    {
        public sealed class Impulse<TVal> : DimensionBase<ImpulseUnit, TVal> where TVal : notnull, INumber<TVal>
        {
            public override string IdTag => nameof(Impulse<TVal>);
            
            public Impulse() : base()
            {
                Exponents.Length = 1;
                Exponents.Mass = 1;
                Exponents.Time = -1;
                Exponents.ElectricalCurrent = 0;
                Exponents.LuminousIntensity = 0;
                Exponents.Temperature = 0;
                Exponents.Amount = 0;
                
                DefaultUnit = ImpulseUnit.NewtonSecond;
                
                Symbols.Add(ImpulseUnit.KilogramMeterPerSecond, "kg·m/s");
                Symbols.Add(ImpulseUnit.PoundFootPerSecond, "lb·ft/s");
                Symbols.Add(ImpulseUnit.PoundForceSecond, "lbf·s");
                Symbols.Add(ImpulseUnit.SlugFootPerSecond, "slug·ft/s");
                Symbols.Add(ImpulseUnit.Yottanewtonsecond, "YN·s");
                Symbols.Add(ImpulseUnit.Zettanewtonsecond, "ZN·s");
                Symbols.Add(ImpulseUnit.Exanewtonsecond, "EN·s");
                Symbols.Add(ImpulseUnit.Petanewtonsecond, "PN·s");
                Symbols.Add(ImpulseUnit.Teranewtonsecond, "TN·s");
                Symbols.Add(ImpulseUnit.Giganewtonsecond, "GN·s");
                Symbols.Add(ImpulseUnit.Meganewtonsecond, "MN·s");
                Symbols.Add(ImpulseUnit.Kilonewtonsecond, "kN·s");
                Symbols.Add(ImpulseUnit.Hectonewtonsecond, "hN·s");
                Symbols.Add(ImpulseUnit.Dekanewtonsecond, "daN·s");
                Symbols.Add(ImpulseUnit.NewtonSecond, "N·s");
                Symbols.Add(ImpulseUnit.Decinewtonsecond, "dN·s");
                Symbols.Add(ImpulseUnit.Centinewtonsecond, "cN·s");
                Symbols.Add(ImpulseUnit.Millinewtonsecond, "mN·s");
                Symbols.Add(ImpulseUnit.Micronewtonsecond, "µN·s");
                Symbols.Add(ImpulseUnit.Nanonewtonsecond, "nN·s");
                Symbols.Add(ImpulseUnit.Piconewtonsecond, "pN·s");
                Symbols.Add(ImpulseUnit.Femtonewtonsecond, "fN·s");
                Symbols.Add(ImpulseUnit.Attonewtonsecond, "aN·s");
                Symbols.Add(ImpulseUnit.Zeptonewtonsecond, "zN·s");
                Symbols.Add(ImpulseUnit.Yoctonewtonsecond, "yN·s");
                
                
                ConversionFunctions.Add(ImpulseUnit.KilogramMeterPerSecond, "x");
                ConversionFunctions.Add(ImpulseUnit.PoundFootPerSecond, "x / 7.230657989877");
                ConversionFunctions.Add(ImpulseUnit.PoundForceSecond, "x / 0.2248089430997");
                ConversionFunctions.Add(ImpulseUnit.SlugFootPerSecond, "x / 0.224735720691");
                ConversionFunctions.Add(ImpulseUnit.Yottanewtonsecond, "x * 1e24");
                ConversionFunctions.Add(ImpulseUnit.Zettanewtonsecond, "x * 1e21");
                ConversionFunctions.Add(ImpulseUnit.Exanewtonsecond, "x * 1e18");
                ConversionFunctions.Add(ImpulseUnit.Petanewtonsecond, "x * 1e15");
                ConversionFunctions.Add(ImpulseUnit.Teranewtonsecond, "x * 1e12");
                ConversionFunctions.Add(ImpulseUnit.Giganewtonsecond, "x * 1e9");
                ConversionFunctions.Add(ImpulseUnit.Meganewtonsecond, "x * 1e6");
                ConversionFunctions.Add(ImpulseUnit.Kilonewtonsecond, "x * 1e3");
                ConversionFunctions.Add(ImpulseUnit.Hectonewtonsecond, "x * 1e2");
                ConversionFunctions.Add(ImpulseUnit.Dekanewtonsecond, "x * 1e1");
                ConversionFunctions.Add(ImpulseUnit.NewtonSecond, "x * 1e0");
                ConversionFunctions.Add(ImpulseUnit.Decinewtonsecond, "x * 1e-1");
                ConversionFunctions.Add(ImpulseUnit.Centinewtonsecond, "x * 1e-2");
                ConversionFunctions.Add(ImpulseUnit.Millinewtonsecond, "x * 1e-3");
                ConversionFunctions.Add(ImpulseUnit.Micronewtonsecond, "x * 1e-6");
                ConversionFunctions.Add(ImpulseUnit.Nanonewtonsecond, "x * 1e-9");
                ConversionFunctions.Add(ImpulseUnit.Piconewtonsecond, "x * 1e-12");
                ConversionFunctions.Add(ImpulseUnit.Femtonewtonsecond, "x * 1e-15");
                ConversionFunctions.Add(ImpulseUnit.Attonewtonsecond, "x * 1e-18");
                ConversionFunctions.Add(ImpulseUnit.Zeptonewtonsecond, "x * 1e-21");
                ConversionFunctions.Add(ImpulseUnit.Yoctonewtonsecond, "x * 1e-24");
            }
        }
    }
