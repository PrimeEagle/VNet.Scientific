
    // Auto-generated for VNet on 2023-07-05 10:35:43
    using System.Numerics;
    
    
    namespace VNet.Scientific.Measurement.Dimensions
    {
        public sealed class SpecificEntropy<TVal> : DimensionBase<SpecificEntropyUnit, TVal> where TVal : notnull, INumber<TVal>
        {
            public override string IdTag => nameof(SpecificEntropy<TVal>);
            
            public SpecificEntropy() : base()
            {
                DimensionComponent.Exponents.Length = 2;
                DimensionComponent.Exponents.Mass = 0;
                DimensionComponent.Exponents.Time = -2;
                DimensionComponent.Exponents.ElectricalCurrent = 0;
                DimensionComponent.Exponents.LuminousIntensity = 0;
                DimensionComponent.Exponents.Temperature = -1;
                DimensionComponent.Exponents.Amount = 0;
                
                DefaultUnit = SpecificEntropyUnit.JoulePerKilogramKelvin;
                
                Symbols.Add(SpecificEntropyUnit.JoulePerKilogramDegreeCelsius, "J/kg.C");
                Symbols.Add(SpecificEntropyUnit.CaloriePerGramKelvin, "cal/g.K");
                Symbols.Add(SpecificEntropyUnit.BtuPerPoundFahrenheit, "BTU/lb·°F");
                Symbols.Add(SpecificEntropyUnit.Yottajouleperkilogramkelvin, "YJ/kg.K");
                Symbols.Add(SpecificEntropyUnit.Zettajouleperkilogramkelvin, "ZJ/kg.K");
                Symbols.Add(SpecificEntropyUnit.Exajouleperkilogramkelvin, "EJ/kg.K");
                Symbols.Add(SpecificEntropyUnit.Petajouleperkilogramkelvin, "PJ/kg.K");
                Symbols.Add(SpecificEntropyUnit.Terajouleperkilogramkelvin, "TJ/kg.K");
                Symbols.Add(SpecificEntropyUnit.Gigajouleperkilogramkelvin, "GJ/kg.K");
                Symbols.Add(SpecificEntropyUnit.Megajouleperkilogramkelvin, "MJ/kg.K");
                Symbols.Add(SpecificEntropyUnit.Kilojouleperkilogramkelvin, "kJ/kg.K");
                Symbols.Add(SpecificEntropyUnit.Hectojouleperkilogramkelvin, "hJ/kg.K");
                Symbols.Add(SpecificEntropyUnit.Dekajouleperkilogramkelvin, "daJ/kg.K");
                Symbols.Add(SpecificEntropyUnit.JoulePerKilogramKelvin, "J/kg.K");
                Symbols.Add(SpecificEntropyUnit.Decijouleperkilogramkelvin, "dJ/kg.K");
                Symbols.Add(SpecificEntropyUnit.Centijouleperkilogramkelvin, "cJ/kg.K");
                Symbols.Add(SpecificEntropyUnit.Millijouleperkilogramkelvin, "mJ/kg.K");
                Symbols.Add(SpecificEntropyUnit.Microjouleperkilogramkelvin, "µJ/kg.K");
                Symbols.Add(SpecificEntropyUnit.Nanojouleperkilogramkelvin, "nJ/kg.K");
                Symbols.Add(SpecificEntropyUnit.Picojouleperkilogramkelvin, "pJ/kg.K");
                Symbols.Add(SpecificEntropyUnit.Femtojouleperkilogramkelvin, "fJ/kg.K");
                Symbols.Add(SpecificEntropyUnit.Attojouleperkilogramkelvin, "aJ/kg.K");
                Symbols.Add(SpecificEntropyUnit.Zeptojouleperkilogramkelvin, "zJ/kg.K");
                Symbols.Add(SpecificEntropyUnit.Yoctojouleperkilogramkelvin, "yJ/kg.K");
                
                PluralSymbols.Add(SpecificEntropyUnit.BtuPerPoundFahrenheit, "BTU/lbm·°F");
                
                ConversionFunctions.Add(SpecificEntropyUnit.JoulePerKilogramDegreeCelsius, "x");
                ConversionFunctions.Add(SpecificEntropyUnit.CaloriePerGramKelvin, "x * 4.184e3");
                ConversionFunctions.Add(SpecificEntropyUnit.BtuPerPoundFahrenheit, "x * 4.1868e3");
                ConversionFunctions.Add(SpecificEntropyUnit.Yottajouleperkilogramkelvin, "x * 1e24");
                ConversionFunctions.Add(SpecificEntropyUnit.Zettajouleperkilogramkelvin, "x * 1e21");
                ConversionFunctions.Add(SpecificEntropyUnit.Exajouleperkilogramkelvin, "x * 1e18");
                ConversionFunctions.Add(SpecificEntropyUnit.Petajouleperkilogramkelvin, "x * 1e15");
                ConversionFunctions.Add(SpecificEntropyUnit.Terajouleperkilogramkelvin, "x * 1e12");
                ConversionFunctions.Add(SpecificEntropyUnit.Gigajouleperkilogramkelvin, "x * 1e9");
                ConversionFunctions.Add(SpecificEntropyUnit.Megajouleperkilogramkelvin, "x * 1e6");
                ConversionFunctions.Add(SpecificEntropyUnit.Kilojouleperkilogramkelvin, "x * 1e3");
                ConversionFunctions.Add(SpecificEntropyUnit.Hectojouleperkilogramkelvin, "x * 1e2");
                ConversionFunctions.Add(SpecificEntropyUnit.Dekajouleperkilogramkelvin, "x * 1e1");
                ConversionFunctions.Add(SpecificEntropyUnit.JoulePerKilogramKelvin, "x * 1e0");
                ConversionFunctions.Add(SpecificEntropyUnit.Decijouleperkilogramkelvin, "x * 1e-1");
                ConversionFunctions.Add(SpecificEntropyUnit.Centijouleperkilogramkelvin, "x * 1e-2");
                ConversionFunctions.Add(SpecificEntropyUnit.Millijouleperkilogramkelvin, "x * 1e-3");
                ConversionFunctions.Add(SpecificEntropyUnit.Microjouleperkilogramkelvin, "x * 1e-6");
                ConversionFunctions.Add(SpecificEntropyUnit.Nanojouleperkilogramkelvin, "x * 1e-9");
                ConversionFunctions.Add(SpecificEntropyUnit.Picojouleperkilogramkelvin, "x * 1e-12");
                ConversionFunctions.Add(SpecificEntropyUnit.Femtojouleperkilogramkelvin, "x * 1e-15");
                ConversionFunctions.Add(SpecificEntropyUnit.Attojouleperkilogramkelvin, "x * 1e-18");
                ConversionFunctions.Add(SpecificEntropyUnit.Zeptojouleperkilogramkelvin, "x * 1e-21");
                ConversionFunctions.Add(SpecificEntropyUnit.Yoctojouleperkilogramkelvin, "x * 1e-24");
            }
        }
    }
