
    // Auto-generated for VNet on 2023-07-06 12:42:23
    using System.Numerics;
    
    
    namespace VNet.Scientific.Measurement.Dimensions
    {
        public sealed class Permeability<TVal> : DimensionBase<PermeabilityUnit, TVal> where TVal : notnull, INumber<TVal>
        {
            public override string IdTag => nameof(Permeability<TVal>);
            
            public Permeability() : base()
            {
                Exponents.Length = 1;
                Exponents.Mass = 1;
                Exponents.Time = -2;
                Exponents.ElectricalCurrent = -2;
                Exponents.LuminousIntensity = 0;
                Exponents.Temperature = 0;
                Exponents.Amount = 0;
                
                DefaultUnit = PermeabilityUnit.HenryPerMeter;
                
                Symbols.Add(PermeabilityUnit.Yottahenrypermeter, "YH/m");
                Symbols.Add(PermeabilityUnit.Zettahenrypermeter, "ZH/m");
                Symbols.Add(PermeabilityUnit.Exahenrypermeter, "EH/m");
                Symbols.Add(PermeabilityUnit.Petahenrypermeter, "PH/m");
                Symbols.Add(PermeabilityUnit.Terahenrypermeter, "TH/m");
                Symbols.Add(PermeabilityUnit.Gigahenrypermeter, "GH/m");
                Symbols.Add(PermeabilityUnit.Megahenrypermeter, "MH/m");
                Symbols.Add(PermeabilityUnit.Kilohenrypermeter, "kH/m");
                Symbols.Add(PermeabilityUnit.Hectohenrypermeter, "hH/m");
                Symbols.Add(PermeabilityUnit.Dekahenrypermeter, "daH/m");
                Symbols.Add(PermeabilityUnit.HenryPerMeter, "H/m");
                Symbols.Add(PermeabilityUnit.Decihenrypermeter, "dH/m");
                Symbols.Add(PermeabilityUnit.Centihenrypermeter, "cH/m");
                Symbols.Add(PermeabilityUnit.Millihenrypermeter, "mH/m");
                Symbols.Add(PermeabilityUnit.Microhenrypermeter, "µH/m");
                Symbols.Add(PermeabilityUnit.Nanohenrypermeter, "nH/m");
                Symbols.Add(PermeabilityUnit.Picohenrypermeter, "pH/m");
                Symbols.Add(PermeabilityUnit.Femtohenrypermeter, "fH/m");
                Symbols.Add(PermeabilityUnit.Attohenrypermeter, "aH/m");
                Symbols.Add(PermeabilityUnit.Zeptohenrypermeter, "zH/m");
                Symbols.Add(PermeabilityUnit.Yoctohenrypermeter, "yH/m");
                
                
                ConversionFunctions.Add(PermeabilityUnit.Yottahenrypermeter, "x * 1e24");
                ConversionFunctions.Add(PermeabilityUnit.Zettahenrypermeter, "x * 1e21");
                ConversionFunctions.Add(PermeabilityUnit.Exahenrypermeter, "x * 1e18");
                ConversionFunctions.Add(PermeabilityUnit.Petahenrypermeter, "x * 1e15");
                ConversionFunctions.Add(PermeabilityUnit.Terahenrypermeter, "x * 1e12");
                ConversionFunctions.Add(PermeabilityUnit.Gigahenrypermeter, "x * 1e9");
                ConversionFunctions.Add(PermeabilityUnit.Megahenrypermeter, "x * 1e6");
                ConversionFunctions.Add(PermeabilityUnit.Kilohenrypermeter, "x * 1e3");
                ConversionFunctions.Add(PermeabilityUnit.Hectohenrypermeter, "x * 1e2");
                ConversionFunctions.Add(PermeabilityUnit.Dekahenrypermeter, "x * 1e1");
                ConversionFunctions.Add(PermeabilityUnit.HenryPerMeter, "x * 1e0");
                ConversionFunctions.Add(PermeabilityUnit.Decihenrypermeter, "x * 1e-1");
                ConversionFunctions.Add(PermeabilityUnit.Centihenrypermeter, "x * 1e-2");
                ConversionFunctions.Add(PermeabilityUnit.Millihenrypermeter, "x * 1e-3");
                ConversionFunctions.Add(PermeabilityUnit.Microhenrypermeter, "x * 1e-6");
                ConversionFunctions.Add(PermeabilityUnit.Nanohenrypermeter, "x * 1e-9");
                ConversionFunctions.Add(PermeabilityUnit.Picohenrypermeter, "x * 1e-12");
                ConversionFunctions.Add(PermeabilityUnit.Femtohenrypermeter, "x * 1e-15");
                ConversionFunctions.Add(PermeabilityUnit.Attohenrypermeter, "x * 1e-18");
                ConversionFunctions.Add(PermeabilityUnit.Zeptohenrypermeter, "x * 1e-21");
                ConversionFunctions.Add(PermeabilityUnit.Yoctohenrypermeter, "x * 1e-24");
            }
        }
    }
