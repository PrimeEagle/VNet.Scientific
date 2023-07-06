
    // Auto-generated for VNet on 2023-07-05 10:35:43
    using System.Numerics;
    
    
    namespace VNet.Scientific.Measurement.Dimensions
    {
        public sealed class ElectricCurrentGradient<TVal> : DimensionBase<ElectricCurrentGradientUnit, TVal> where TVal : notnull, INumber<TVal>
        {
            public override string IdTag => nameof(ElectricCurrentGradient<TVal>);
            
            public ElectricCurrentGradient() : base()
            {
                DimensionComponent.Exponents.Length = 0;
                DimensionComponent.Exponents.Mass = 0;
                DimensionComponent.Exponents.Time = -1;
                DimensionComponent.Exponents.ElectricalCurrent = 1;
                DimensionComponent.Exponents.LuminousIntensity = 0;
                DimensionComponent.Exponents.Temperature = 0;
                DimensionComponent.Exponents.Amount = 0;
                
                DefaultUnit = ElectricCurrentGradientUnit.AmperePerSecond;
                
                Symbols.Add(ElectricCurrentGradientUnit.AmperePerMillisecond, "A/ms");
                Symbols.Add(ElectricCurrentGradientUnit.AmperePerMicrosecond, "A/μs");
                Symbols.Add(ElectricCurrentGradientUnit.AmperePerNanosecond, "A/ns");
                Symbols.Add(ElectricCurrentGradientUnit.Yottaamperepersecond, "YA/s");
                Symbols.Add(ElectricCurrentGradientUnit.Zettaamperepersecond, "ZA/s");
                Symbols.Add(ElectricCurrentGradientUnit.Exaamperepersecond, "EA/s");
                Symbols.Add(ElectricCurrentGradientUnit.Petaamperepersecond, "PA/s");
                Symbols.Add(ElectricCurrentGradientUnit.Teraamperepersecond, "TA/s");
                Symbols.Add(ElectricCurrentGradientUnit.Gigaamperepersecond, "GA/s");
                Symbols.Add(ElectricCurrentGradientUnit.Megaamperepersecond, "MA/s");
                Symbols.Add(ElectricCurrentGradientUnit.Kiloamperepersecond, "kA/s");
                Symbols.Add(ElectricCurrentGradientUnit.Hectoamperepersecond, "hA/s");
                Symbols.Add(ElectricCurrentGradientUnit.Dekaamperepersecond, "daA/s");
                Symbols.Add(ElectricCurrentGradientUnit.AmperePerSecond, "A/s");
                Symbols.Add(ElectricCurrentGradientUnit.Deciamperepersecond, "dA/s");
                Symbols.Add(ElectricCurrentGradientUnit.Centiamperepersecond, "cA/s");
                Symbols.Add(ElectricCurrentGradientUnit.Milliamperepersecond, "mA/s");
                Symbols.Add(ElectricCurrentGradientUnit.Microamperepersecond, "µA/s");
                Symbols.Add(ElectricCurrentGradientUnit.Nanoamperepersecond, "nA/s");
                Symbols.Add(ElectricCurrentGradientUnit.Picoamperepersecond, "pA/s");
                Symbols.Add(ElectricCurrentGradientUnit.Femtoamperepersecond, "fA/s");
                Symbols.Add(ElectricCurrentGradientUnit.Attoamperepersecond, "aA/s");
                Symbols.Add(ElectricCurrentGradientUnit.Zeptoamperepersecond, "zA/s");
                Symbols.Add(ElectricCurrentGradientUnit.Yoctoamperepersecond, "yA/s");
                
                
                ConversionFunctions.Add(ElectricCurrentGradientUnit.AmperePerMillisecond, "x * 1E3");
                ConversionFunctions.Add(ElectricCurrentGradientUnit.AmperePerMicrosecond, "x * 1E6");
                ConversionFunctions.Add(ElectricCurrentGradientUnit.AmperePerNanosecond, "x * 1E9");
                ConversionFunctions.Add(ElectricCurrentGradientUnit.Yottaamperepersecond, "x * 1e24");
                ConversionFunctions.Add(ElectricCurrentGradientUnit.Zettaamperepersecond, "x * 1e21");
                ConversionFunctions.Add(ElectricCurrentGradientUnit.Exaamperepersecond, "x * 1e18");
                ConversionFunctions.Add(ElectricCurrentGradientUnit.Petaamperepersecond, "x * 1e15");
                ConversionFunctions.Add(ElectricCurrentGradientUnit.Teraamperepersecond, "x * 1e12");
                ConversionFunctions.Add(ElectricCurrentGradientUnit.Gigaamperepersecond, "x * 1e9");
                ConversionFunctions.Add(ElectricCurrentGradientUnit.Megaamperepersecond, "x * 1e6");
                ConversionFunctions.Add(ElectricCurrentGradientUnit.Kiloamperepersecond, "x * 1e3");
                ConversionFunctions.Add(ElectricCurrentGradientUnit.Hectoamperepersecond, "x * 1e2");
                ConversionFunctions.Add(ElectricCurrentGradientUnit.Dekaamperepersecond, "x * 1e1");
                ConversionFunctions.Add(ElectricCurrentGradientUnit.AmperePerSecond, "x * 1e0");
                ConversionFunctions.Add(ElectricCurrentGradientUnit.Deciamperepersecond, "x * 1e-1");
                ConversionFunctions.Add(ElectricCurrentGradientUnit.Centiamperepersecond, "x * 1e-2");
                ConversionFunctions.Add(ElectricCurrentGradientUnit.Milliamperepersecond, "x * 1e-3");
                ConversionFunctions.Add(ElectricCurrentGradientUnit.Microamperepersecond, "x * 1e-6");
                ConversionFunctions.Add(ElectricCurrentGradientUnit.Nanoamperepersecond, "x * 1e-9");
                ConversionFunctions.Add(ElectricCurrentGradientUnit.Picoamperepersecond, "x * 1e-12");
                ConversionFunctions.Add(ElectricCurrentGradientUnit.Femtoamperepersecond, "x * 1e-15");
                ConversionFunctions.Add(ElectricCurrentGradientUnit.Attoamperepersecond, "x * 1e-18");
                ConversionFunctions.Add(ElectricCurrentGradientUnit.Zeptoamperepersecond, "x * 1e-21");
                ConversionFunctions.Add(ElectricCurrentGradientUnit.Yoctoamperepersecond, "x * 1e-24");
            }
        }
    }
