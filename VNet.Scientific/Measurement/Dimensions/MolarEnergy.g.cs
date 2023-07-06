
    // Auto-generated for VNet on 2023-07-05 10:35:43
    using System.Numerics;
    
    
    namespace VNet.Scientific.Measurement.Dimensions
    {
        public sealed class MolarEnergy<TVal> : DimensionBase<MolarEnergyUnit, TVal> where TVal : notnull, INumber<TVal>
        {
            public override string IdTag => nameof(MolarEnergy<TVal>);
            
            public MolarEnergy() : base()
            {
                DimensionComponent.Exponents.Length = 2;
                DimensionComponent.Exponents.Mass = 1;
                DimensionComponent.Exponents.Time = -2;
                DimensionComponent.Exponents.ElectricalCurrent = 0;
                DimensionComponent.Exponents.LuminousIntensity = 0;
                DimensionComponent.Exponents.Temperature = 0;
                DimensionComponent.Exponents.Amount = -1;
                
                DefaultUnit = MolarEnergyUnit.JoulePerMole;
                
                Symbols.Add(MolarEnergyUnit.Yottajoulepermole, "YJ/mol");
                Symbols.Add(MolarEnergyUnit.Zettajoulepermole, "ZJ/mol");
                Symbols.Add(MolarEnergyUnit.Exajoulepermole, "EJ/mol");
                Symbols.Add(MolarEnergyUnit.Petajoulepermole, "PJ/mol");
                Symbols.Add(MolarEnergyUnit.Terajoulepermole, "TJ/mol");
                Symbols.Add(MolarEnergyUnit.Gigajoulepermole, "GJ/mol");
                Symbols.Add(MolarEnergyUnit.Megajoulepermole, "MJ/mol");
                Symbols.Add(MolarEnergyUnit.Kilojoulepermole, "kJ/mol");
                Symbols.Add(MolarEnergyUnit.Hectojoulepermole, "hJ/mol");
                Symbols.Add(MolarEnergyUnit.Dekajoulepermole, "daJ/mol");
                Symbols.Add(MolarEnergyUnit.JoulePerMole, "J/mol");
                Symbols.Add(MolarEnergyUnit.Decijoulepermole, "dJ/mol");
                Symbols.Add(MolarEnergyUnit.Centijoulepermole, "cJ/mol");
                Symbols.Add(MolarEnergyUnit.Millijoulepermole, "mJ/mol");
                Symbols.Add(MolarEnergyUnit.Microjoulepermole, "µJ/mol");
                Symbols.Add(MolarEnergyUnit.Nanojoulepermole, "nJ/mol");
                Symbols.Add(MolarEnergyUnit.Picojoulepermole, "pJ/mol");
                Symbols.Add(MolarEnergyUnit.Femtojoulepermole, "fJ/mol");
                Symbols.Add(MolarEnergyUnit.Attojoulepermole, "aJ/mol");
                Symbols.Add(MolarEnergyUnit.Zeptojoulepermole, "zJ/mol");
                Symbols.Add(MolarEnergyUnit.Yoctojoulepermole, "yJ/mol");
                
                
                ConversionFunctions.Add(MolarEnergyUnit.Yottajoulepermole, "x * 1e24");
                ConversionFunctions.Add(MolarEnergyUnit.Zettajoulepermole, "x * 1e21");
                ConversionFunctions.Add(MolarEnergyUnit.Exajoulepermole, "x * 1e18");
                ConversionFunctions.Add(MolarEnergyUnit.Petajoulepermole, "x * 1e15");
                ConversionFunctions.Add(MolarEnergyUnit.Terajoulepermole, "x * 1e12");
                ConversionFunctions.Add(MolarEnergyUnit.Gigajoulepermole, "x * 1e9");
                ConversionFunctions.Add(MolarEnergyUnit.Megajoulepermole, "x * 1e6");
                ConversionFunctions.Add(MolarEnergyUnit.Kilojoulepermole, "x * 1e3");
                ConversionFunctions.Add(MolarEnergyUnit.Hectojoulepermole, "x * 1e2");
                ConversionFunctions.Add(MolarEnergyUnit.Dekajoulepermole, "x * 1e1");
                ConversionFunctions.Add(MolarEnergyUnit.JoulePerMole, "x * 1e0");
                ConversionFunctions.Add(MolarEnergyUnit.Decijoulepermole, "x * 1e-1");
                ConversionFunctions.Add(MolarEnergyUnit.Centijoulepermole, "x * 1e-2");
                ConversionFunctions.Add(MolarEnergyUnit.Millijoulepermole, "x * 1e-3");
                ConversionFunctions.Add(MolarEnergyUnit.Microjoulepermole, "x * 1e-6");
                ConversionFunctions.Add(MolarEnergyUnit.Nanojoulepermole, "x * 1e-9");
                ConversionFunctions.Add(MolarEnergyUnit.Picojoulepermole, "x * 1e-12");
                ConversionFunctions.Add(MolarEnergyUnit.Femtojoulepermole, "x * 1e-15");
                ConversionFunctions.Add(MolarEnergyUnit.Attojoulepermole, "x * 1e-18");
                ConversionFunctions.Add(MolarEnergyUnit.Zeptojoulepermole, "x * 1e-21");
                ConversionFunctions.Add(MolarEnergyUnit.Yoctojoulepermole, "x * 1e-24");
            }
        }
    }
