
    // Auto-generated for VNet on 2023-07-05 10:24:46
    using System.Numerics;
    
    
    namespace VNet.Scientific.Measurement.Dimensions
    {
        public sealed class SpecificEnergy<TVal> : DimensionBase<SpecificEnergyUnit, TVal> where TVal : notnull, INumber<TVal>
        {
            public override string IdTag => nameof(SpecificEnergy<TVal>);
            
            public SpecificEnergy() : base()
            {
                DimensionComponent.Exponents.Length = 2;
                DimensionComponent.Exponents.Mass = 0;
                DimensionComponent.Exponents.Time = -2;
                DimensionComponent.Exponents.ElectricalCurrent = 0;
                DimensionComponent.Exponents.LuminousIntensity = 0;
                DimensionComponent.Exponents.Temperature = 0;
                DimensionComponent.Exponents.Amount = 0;
                
                DefaultUnit = SpecificEnergyUnit.JoulePerKilogram;
                
                
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
