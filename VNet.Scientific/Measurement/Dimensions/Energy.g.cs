
    // Auto-generated for VNet on 2023-07-06 12:42:23
    using System.Numerics;
    
    
    namespace VNet.Scientific.Measurement.Dimensions
    {
        public sealed class Energy<TVal> : DimensionBase<EnergyUnit, TVal> where TVal : notnull, INumber<TVal>
        {
            public override string IdTag => nameof(Energy<TVal>);
            
            public Energy() : base()
            {
                Exponents.Length = 2;
                Exponents.Mass = 1;
                Exponents.Time = -2;
                Exponents.ElectricalCurrent = 0;
                Exponents.LuminousIntensity = 0;
                Exponents.Temperature = 0;
                Exponents.Amount = 0;
                
                DefaultUnit = EnergyUnit.Joule;
                
                Symbols.Add(EnergyUnit.Calorie, "cal");
                Symbols.Add(EnergyUnit.BritishThermalUnit, "BTU");
                Symbols.Add(EnergyUnit.ElectronVolt, "eV");
                Symbols.Add(EnergyUnit.FootPound, "ft·lb");
                Symbols.Add(EnergyUnit.Erg, "erg");
                Symbols.Add(EnergyUnit.WattHour, "Wh");
                Symbols.Add(EnergyUnit.WattDay, "Wd");
                Symbols.Add(EnergyUnit.ThermEc, "th (E.C.)");
                Symbols.Add(EnergyUnit.ThermUs, "th (U.S.)");
                Symbols.Add(EnergyUnit.ThermImperial, "th (imp.)");
                Symbols.Add(EnergyUnit.HorsepowerHour, "hp·h");
                Symbols.Add(EnergyUnit.Yottajoule, "YJ");
                Symbols.Add(EnergyUnit.Zettajoule, "ZJ");
                Symbols.Add(EnergyUnit.Exajoule, "EJ");
                Symbols.Add(EnergyUnit.Petajoule, "PJ");
                Symbols.Add(EnergyUnit.Terajoule, "TJ");
                Symbols.Add(EnergyUnit.Gigajoule, "GJ");
                Symbols.Add(EnergyUnit.Megajoule, "MJ");
                Symbols.Add(EnergyUnit.Kilojoule, "kJ");
                Symbols.Add(EnergyUnit.Hectojoule, "hJ");
                Symbols.Add(EnergyUnit.Dekajoule, "daJ");
                Symbols.Add(EnergyUnit.Joule, "J");
                Symbols.Add(EnergyUnit.Decijoule, "dJ");
                Symbols.Add(EnergyUnit.Centijoule, "cJ");
                Symbols.Add(EnergyUnit.Millijoule, "mJ");
                Symbols.Add(EnergyUnit.Microjoule, "µJ");
                Symbols.Add(EnergyUnit.Nanojoule, "nJ");
                Symbols.Add(EnergyUnit.Picojoule, "pJ");
                Symbols.Add(EnergyUnit.Femtojoule, "fJ");
                Symbols.Add(EnergyUnit.Attojoule, "aJ");
                Symbols.Add(EnergyUnit.Zeptojoule, "zJ");
                Symbols.Add(EnergyUnit.Yoctojoule, "yJ");
                
                
                ConversionFunctions.Add(EnergyUnit.Calorie, "x * 4.184");
                ConversionFunctions.Add(EnergyUnit.BritishThermalUnit, "x * 1055.05585262");
                ConversionFunctions.Add(EnergyUnit.ElectronVolt, "x * 1.602176565e-19");
                ConversionFunctions.Add(EnergyUnit.FootPound, "x * 1.355817948");
                ConversionFunctions.Add(EnergyUnit.Erg, "x * 1e-7");
                ConversionFunctions.Add(EnergyUnit.WattHour, "x * 3600d");
                ConversionFunctions.Add(EnergyUnit.WattDay, "x * 24 * 3600d");
                ConversionFunctions.Add(EnergyUnit.ThermEc, "x * 1.05505585262e8");
                ConversionFunctions.Add(EnergyUnit.ThermUs, "x * 1.054804e8");
                ConversionFunctions.Add(EnergyUnit.ThermImperial, "x * 1.05505585257348e8");
                ConversionFunctions.Add(EnergyUnit.HorsepowerHour, "x * 2.6845195377e6");
                ConversionFunctions.Add(EnergyUnit.Yottajoule, "x * 1e24");
                ConversionFunctions.Add(EnergyUnit.Zettajoule, "x * 1e21");
                ConversionFunctions.Add(EnergyUnit.Exajoule, "x * 1e18");
                ConversionFunctions.Add(EnergyUnit.Petajoule, "x * 1e15");
                ConversionFunctions.Add(EnergyUnit.Terajoule, "x * 1e12");
                ConversionFunctions.Add(EnergyUnit.Gigajoule, "x * 1e9");
                ConversionFunctions.Add(EnergyUnit.Megajoule, "x * 1e6");
                ConversionFunctions.Add(EnergyUnit.Kilojoule, "x * 1e3");
                ConversionFunctions.Add(EnergyUnit.Hectojoule, "x * 1e2");
                ConversionFunctions.Add(EnergyUnit.Dekajoule, "x * 1e1");
                ConversionFunctions.Add(EnergyUnit.Joule, "x * 1e0");
                ConversionFunctions.Add(EnergyUnit.Decijoule, "x * 1e-1");
                ConversionFunctions.Add(EnergyUnit.Centijoule, "x * 1e-2");
                ConversionFunctions.Add(EnergyUnit.Millijoule, "x * 1e-3");
                ConversionFunctions.Add(EnergyUnit.Microjoule, "x * 1e-6");
                ConversionFunctions.Add(EnergyUnit.Nanojoule, "x * 1e-9");
                ConversionFunctions.Add(EnergyUnit.Picojoule, "x * 1e-12");
                ConversionFunctions.Add(EnergyUnit.Femtojoule, "x * 1e-15");
                ConversionFunctions.Add(EnergyUnit.Attojoule, "x * 1e-18");
                ConversionFunctions.Add(EnergyUnit.Zeptojoule, "x * 1e-21");
                ConversionFunctions.Add(EnergyUnit.Yoctojoule, "x * 1e-24");
            }
        }
    }
