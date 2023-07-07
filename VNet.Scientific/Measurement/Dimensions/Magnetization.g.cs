
    // Auto-generated for VNet on 2023-07-06 12:42:23
    using System.Numerics;
    
    
    namespace VNet.Scientific.Measurement.Dimensions
    {
        public sealed class Magnetization<TVal> : DimensionBase<MagnetizationUnit, TVal> where TVal : notnull, INumber<TVal>
        {
            public override string IdTag => nameof(Magnetization<TVal>);
            
            public Magnetization() : base()
            {
                Exponents.Length = -1;
                Exponents.Mass = 0;
                Exponents.Time = 0;
                Exponents.ElectricalCurrent = 1;
                Exponents.LuminousIntensity = 0;
                Exponents.Temperature = 0;
                Exponents.Amount = 0;
                
                DefaultUnit = MagnetizationUnit.AmperePerMeter;
                
                Symbols.Add(MagnetizationUnit.Yottaamperepermeter, "YA/m");
                Symbols.Add(MagnetizationUnit.Zettaamperepermeter, "ZA/m");
                Symbols.Add(MagnetizationUnit.Exaamperepermeter, "EA/m");
                Symbols.Add(MagnetizationUnit.Petaamperepermeter, "PA/m");
                Symbols.Add(MagnetizationUnit.Teraamperepermeter, "TA/m");
                Symbols.Add(MagnetizationUnit.Gigaamperepermeter, "GA/m");
                Symbols.Add(MagnetizationUnit.Megaamperepermeter, "MA/m");
                Symbols.Add(MagnetizationUnit.Kiloamperepermeter, "kA/m");
                Symbols.Add(MagnetizationUnit.Hectoamperepermeter, "hA/m");
                Symbols.Add(MagnetizationUnit.Dekaamperepermeter, "daA/m");
                Symbols.Add(MagnetizationUnit.AmperePerMeter, "A/m");
                Symbols.Add(MagnetizationUnit.Deciamperepermeter, "dA/m");
                Symbols.Add(MagnetizationUnit.Centiamperepermeter, "cA/m");
                Symbols.Add(MagnetizationUnit.Milliamperepermeter, "mA/m");
                Symbols.Add(MagnetizationUnit.Microamperepermeter, "µA/m");
                Symbols.Add(MagnetizationUnit.Nanoamperepermeter, "nA/m");
                Symbols.Add(MagnetizationUnit.Picoamperepermeter, "pA/m");
                Symbols.Add(MagnetizationUnit.Femtoamperepermeter, "fA/m");
                Symbols.Add(MagnetizationUnit.Attoamperepermeter, "aA/m");
                Symbols.Add(MagnetizationUnit.Zeptoamperepermeter, "zA/m");
                Symbols.Add(MagnetizationUnit.Yoctoamperepermeter, "yA/m");
                
                
                ConversionFunctions.Add(MagnetizationUnit.Yottaamperepermeter, "x * 1e24");
                ConversionFunctions.Add(MagnetizationUnit.Zettaamperepermeter, "x * 1e21");
                ConversionFunctions.Add(MagnetizationUnit.Exaamperepermeter, "x * 1e18");
                ConversionFunctions.Add(MagnetizationUnit.Petaamperepermeter, "x * 1e15");
                ConversionFunctions.Add(MagnetizationUnit.Teraamperepermeter, "x * 1e12");
                ConversionFunctions.Add(MagnetizationUnit.Gigaamperepermeter, "x * 1e9");
                ConversionFunctions.Add(MagnetizationUnit.Megaamperepermeter, "x * 1e6");
                ConversionFunctions.Add(MagnetizationUnit.Kiloamperepermeter, "x * 1e3");
                ConversionFunctions.Add(MagnetizationUnit.Hectoamperepermeter, "x * 1e2");
                ConversionFunctions.Add(MagnetizationUnit.Dekaamperepermeter, "x * 1e1");
                ConversionFunctions.Add(MagnetizationUnit.AmperePerMeter, "x * 1e0");
                ConversionFunctions.Add(MagnetizationUnit.Deciamperepermeter, "x * 1e-1");
                ConversionFunctions.Add(MagnetizationUnit.Centiamperepermeter, "x * 1e-2");
                ConversionFunctions.Add(MagnetizationUnit.Milliamperepermeter, "x * 1e-3");
                ConversionFunctions.Add(MagnetizationUnit.Microamperepermeter, "x * 1e-6");
                ConversionFunctions.Add(MagnetizationUnit.Nanoamperepermeter, "x * 1e-9");
                ConversionFunctions.Add(MagnetizationUnit.Picoamperepermeter, "x * 1e-12");
                ConversionFunctions.Add(MagnetizationUnit.Femtoamperepermeter, "x * 1e-15");
                ConversionFunctions.Add(MagnetizationUnit.Attoamperepermeter, "x * 1e-18");
                ConversionFunctions.Add(MagnetizationUnit.Zeptoamperepermeter, "x * 1e-21");
                ConversionFunctions.Add(MagnetizationUnit.Yoctoamperepermeter, "x * 1e-24");
            }
        }
    }
