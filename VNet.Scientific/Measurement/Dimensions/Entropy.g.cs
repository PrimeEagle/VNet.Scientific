
    // Auto-generated for VNet on 2023-07-06 12:42:23
    using System.Numerics;
    
    
    namespace VNet.Scientific.Measurement.Dimensions
    {
        public sealed class Entropy<TVal> : DimensionBase<EntropyUnit, TVal> where TVal : notnull, INumber<TVal>
        {
            public override string IdTag => nameof(Entropy<TVal>);
            
            public Entropy() : base()
            {
                Exponents.Length = 2;
                Exponents.Mass = 1;
                Exponents.Time = -2;
                Exponents.ElectricalCurrent = 0;
                Exponents.LuminousIntensity = 0;
                Exponents.Temperature = -1;
                Exponents.Amount = 0;
                
                DefaultUnit = EntropyUnit.JoulePerKelvin;
                
                Symbols.Add(EntropyUnit.CaloriePerKelvin, "cal/K");
                Symbols.Add(EntropyUnit.JoulePerDegreeCelsius, "J/C");
                Symbols.Add(EntropyUnit.Yottajouleperkelvin, "YJ/K");
                Symbols.Add(EntropyUnit.Zettajouleperkelvin, "ZJ/K");
                Symbols.Add(EntropyUnit.Exajouleperkelvin, "EJ/K");
                Symbols.Add(EntropyUnit.Petajouleperkelvin, "PJ/K");
                Symbols.Add(EntropyUnit.Terajouleperkelvin, "TJ/K");
                Symbols.Add(EntropyUnit.Gigajouleperkelvin, "GJ/K");
                Symbols.Add(EntropyUnit.Megajouleperkelvin, "MJ/K");
                Symbols.Add(EntropyUnit.Kilojouleperkelvin, "kJ/K");
                Symbols.Add(EntropyUnit.Hectojouleperkelvin, "hJ/K");
                Symbols.Add(EntropyUnit.Dekajouleperkelvin, "daJ/K");
                Symbols.Add(EntropyUnit.JoulePerKelvin, "J/K");
                Symbols.Add(EntropyUnit.Decijouleperkelvin, "dJ/K");
                Symbols.Add(EntropyUnit.Centijouleperkelvin, "cJ/K");
                Symbols.Add(EntropyUnit.Millijouleperkelvin, "mJ/K");
                Symbols.Add(EntropyUnit.Microjouleperkelvin, "µJ/K");
                Symbols.Add(EntropyUnit.Nanojouleperkelvin, "nJ/K");
                Symbols.Add(EntropyUnit.Picojouleperkelvin, "pJ/K");
                Symbols.Add(EntropyUnit.Femtojouleperkelvin, "fJ/K");
                Symbols.Add(EntropyUnit.Attojouleperkelvin, "aJ/K");
                Symbols.Add(EntropyUnit.Zeptojouleperkelvin, "zJ/K");
                Symbols.Add(EntropyUnit.Yoctojouleperkelvin, "yJ/K");
                
                
                ConversionFunctions.Add(EntropyUnit.CaloriePerKelvin, "x * 4.184");
                ConversionFunctions.Add(EntropyUnit.JoulePerDegreeCelsius, "x");
                ConversionFunctions.Add(EntropyUnit.Yottajouleperkelvin, "x * 1e24");
                ConversionFunctions.Add(EntropyUnit.Zettajouleperkelvin, "x * 1e21");
                ConversionFunctions.Add(EntropyUnit.Exajouleperkelvin, "x * 1e18");
                ConversionFunctions.Add(EntropyUnit.Petajouleperkelvin, "x * 1e15");
                ConversionFunctions.Add(EntropyUnit.Terajouleperkelvin, "x * 1e12");
                ConversionFunctions.Add(EntropyUnit.Gigajouleperkelvin, "x * 1e9");
                ConversionFunctions.Add(EntropyUnit.Megajouleperkelvin, "x * 1e6");
                ConversionFunctions.Add(EntropyUnit.Kilojouleperkelvin, "x * 1e3");
                ConversionFunctions.Add(EntropyUnit.Hectojouleperkelvin, "x * 1e2");
                ConversionFunctions.Add(EntropyUnit.Dekajouleperkelvin, "x * 1e1");
                ConversionFunctions.Add(EntropyUnit.JoulePerKelvin, "x * 1e0");
                ConversionFunctions.Add(EntropyUnit.Decijouleperkelvin, "x * 1e-1");
                ConversionFunctions.Add(EntropyUnit.Centijouleperkelvin, "x * 1e-2");
                ConversionFunctions.Add(EntropyUnit.Millijouleperkelvin, "x * 1e-3");
                ConversionFunctions.Add(EntropyUnit.Microjouleperkelvin, "x * 1e-6");
                ConversionFunctions.Add(EntropyUnit.Nanojouleperkelvin, "x * 1e-9");
                ConversionFunctions.Add(EntropyUnit.Picojouleperkelvin, "x * 1e-12");
                ConversionFunctions.Add(EntropyUnit.Femtojouleperkelvin, "x * 1e-15");
                ConversionFunctions.Add(EntropyUnit.Attojouleperkelvin, "x * 1e-18");
                ConversionFunctions.Add(EntropyUnit.Zeptojouleperkelvin, "x * 1e-21");
                ConversionFunctions.Add(EntropyUnit.Yoctojouleperkelvin, "x * 1e-24");
            }
        }
    }
