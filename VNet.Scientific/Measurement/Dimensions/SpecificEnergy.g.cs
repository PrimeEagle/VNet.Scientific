
    // Auto-generated for VNet on 2023-07-06 12:42:23
    using System.Numerics;
    
    
    namespace VNet.Scientific.Measurement.Dimensions
    {
        public sealed class SpecificEnergy<TVal> : DimensionBase<SpecificEnergyUnit, TVal> where TVal : notnull, INumber<TVal>
        {
            public override string IdTag => nameof(SpecificEnergy<TVal>);
            
            public SpecificEnergy() : base()
            {
                Exponents.Length = 2;
                Exponents.Mass = 0;
                Exponents.Time = -2;
                Exponents.ElectricalCurrent = 0;
                Exponents.LuminousIntensity = 0;
                Exponents.Temperature = 0;
                Exponents.Amount = 0;
                
                DefaultUnit = SpecificEnergyUnit.JoulePerKilogram;
                
                Symbols.Add(SpecificEnergyUnit.MegaJoulePerTonne, "MJ/t");
                Symbols.Add(SpecificEnergyUnit.CaloriePerGram, "cal/g");
                Symbols.Add(SpecificEnergyUnit.WattHourPerKilogram, "Wh/kg");
                Symbols.Add(SpecificEnergyUnit.WattDayPerKilogram, "Wd/kg");
                Symbols.Add(SpecificEnergyUnit.WattDayPerTonne, "Wd/t");
                Symbols.Add(SpecificEnergyUnit.WattDayPerShortTon, "Wd/ST");
                Symbols.Add(SpecificEnergyUnit.WattHourPerPound, "Wh/lbs");
                Symbols.Add(SpecificEnergyUnit.BtuPerPound, "btu/lb");
                Symbols.Add(SpecificEnergyUnit.Yottajouleperkilogram, "YJ/kg");
                Symbols.Add(SpecificEnergyUnit.Zettajouleperkilogram, "ZJ/kg");
                Symbols.Add(SpecificEnergyUnit.Exajouleperkilogram, "EJ/kg");
                Symbols.Add(SpecificEnergyUnit.Petajouleperkilogram, "PJ/kg");
                Symbols.Add(SpecificEnergyUnit.Terajouleperkilogram, "TJ/kg");
                Symbols.Add(SpecificEnergyUnit.Gigajouleperkilogram, "GJ/kg");
                Symbols.Add(SpecificEnergyUnit.Megajouleperkilogram, "MJ/kg");
                Symbols.Add(SpecificEnergyUnit.Kilojouleperkilogram, "kJ/kg");
                Symbols.Add(SpecificEnergyUnit.Hectojouleperkilogram, "hJ/kg");
                Symbols.Add(SpecificEnergyUnit.Dekajouleperkilogram, "daJ/kg");
                Symbols.Add(SpecificEnergyUnit.JoulePerKilogram, "J/kg");
                Symbols.Add(SpecificEnergyUnit.Decijouleperkilogram, "dJ/kg");
                Symbols.Add(SpecificEnergyUnit.Centijouleperkilogram, "cJ/kg");
                Symbols.Add(SpecificEnergyUnit.Millijouleperkilogram, "mJ/kg");
                Symbols.Add(SpecificEnergyUnit.Microjouleperkilogram, "µJ/kg");
                Symbols.Add(SpecificEnergyUnit.Nanojouleperkilogram, "nJ/kg");
                Symbols.Add(SpecificEnergyUnit.Picojouleperkilogram, "pJ/kg");
                Symbols.Add(SpecificEnergyUnit.Femtojouleperkilogram, "fJ/kg");
                Symbols.Add(SpecificEnergyUnit.Attojouleperkilogram, "aJ/kg");
                Symbols.Add(SpecificEnergyUnit.Zeptojouleperkilogram, "zJ/kg");
                Symbols.Add(SpecificEnergyUnit.Yoctojouleperkilogram, "yJ/kg");
                
                
                ConversionFunctions.Add(SpecificEnergyUnit.MegaJoulePerTonne, "x * 1e3");
                ConversionFunctions.Add(SpecificEnergyUnit.CaloriePerGram, "x * 4.184e3");
                ConversionFunctions.Add(SpecificEnergyUnit.WattHourPerKilogram, "x * 3.6e3");
                ConversionFunctions.Add(SpecificEnergyUnit.WattDayPerKilogram, "x * (24 * 3.6e3)");
                ConversionFunctions.Add(SpecificEnergyUnit.WattDayPerTonne, "x * ((24 * 3.6e3) / 1e3)");
                ConversionFunctions.Add(SpecificEnergyUnit.WattDayPerShortTon, "x * ((24 * 3.6e3) / 9.0718474e2)");
                ConversionFunctions.Add(SpecificEnergyUnit.WattHourPerPound, "x * 7.93664e3");
                ConversionFunctions.Add(SpecificEnergyUnit.BtuPerPound, "x * 2326.000075362");
                ConversionFunctions.Add(SpecificEnergyUnit.Yottajouleperkilogram, "x * 1e24");
                ConversionFunctions.Add(SpecificEnergyUnit.Zettajouleperkilogram, "x * 1e21");
                ConversionFunctions.Add(SpecificEnergyUnit.Exajouleperkilogram, "x * 1e18");
                ConversionFunctions.Add(SpecificEnergyUnit.Petajouleperkilogram, "x * 1e15");
                ConversionFunctions.Add(SpecificEnergyUnit.Terajouleperkilogram, "x * 1e12");
                ConversionFunctions.Add(SpecificEnergyUnit.Gigajouleperkilogram, "x * 1e9");
                ConversionFunctions.Add(SpecificEnergyUnit.Megajouleperkilogram, "x * 1e6");
                ConversionFunctions.Add(SpecificEnergyUnit.Kilojouleperkilogram, "x * 1e3");
                ConversionFunctions.Add(SpecificEnergyUnit.Hectojouleperkilogram, "x * 1e2");
                ConversionFunctions.Add(SpecificEnergyUnit.Dekajouleperkilogram, "x * 1e1");
                ConversionFunctions.Add(SpecificEnergyUnit.JoulePerKilogram, "x * 1e0");
                ConversionFunctions.Add(SpecificEnergyUnit.Decijouleperkilogram, "x * 1e-1");
                ConversionFunctions.Add(SpecificEnergyUnit.Centijouleperkilogram, "x * 1e-2");
                ConversionFunctions.Add(SpecificEnergyUnit.Millijouleperkilogram, "x * 1e-3");
                ConversionFunctions.Add(SpecificEnergyUnit.Microjouleperkilogram, "x * 1e-6");
                ConversionFunctions.Add(SpecificEnergyUnit.Nanojouleperkilogram, "x * 1e-9");
                ConversionFunctions.Add(SpecificEnergyUnit.Picojouleperkilogram, "x * 1e-12");
                ConversionFunctions.Add(SpecificEnergyUnit.Femtojouleperkilogram, "x * 1e-15");
                ConversionFunctions.Add(SpecificEnergyUnit.Attojouleperkilogram, "x * 1e-18");
                ConversionFunctions.Add(SpecificEnergyUnit.Zeptojouleperkilogram, "x * 1e-21");
                ConversionFunctions.Add(SpecificEnergyUnit.Yoctojouleperkilogram, "x * 1e-24");
            }
        }
    }
