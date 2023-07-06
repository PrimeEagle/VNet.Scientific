
    // Auto-generated for VNet on 2023-07-05 10:24:46
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
