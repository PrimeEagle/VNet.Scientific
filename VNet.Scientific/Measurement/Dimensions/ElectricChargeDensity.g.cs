
    // Auto-generated for VNet on 2023-07-05 10:35:43
    using System.Numerics;
    
    
    namespace VNet.Scientific.Measurement.Dimensions
    {
        public sealed class ElectricChargeDensity<TVal> : DimensionBase<ElectricChargeDensityUnit, TVal> where TVal : notnull, INumber<TVal>
        {
            public override string IdTag => nameof(ElectricChargeDensity<TVal>);
            
            public ElectricChargeDensity() : base()
            {
                DimensionComponent.Exponents.Length = -3;
                DimensionComponent.Exponents.Mass = 0;
                DimensionComponent.Exponents.Time = 1;
                DimensionComponent.Exponents.ElectricalCurrent = 1;
                DimensionComponent.Exponents.LuminousIntensity = 0;
                DimensionComponent.Exponents.Temperature = 0;
                DimensionComponent.Exponents.Amount = 0;
                
                DefaultUnit = ElectricChargeDensityUnit.CoulombPerCubicMeter;
                
                Symbols.Add(ElectricChargeDensityUnit.Yottacoulombpercubicmeter, "YC/m³");
                Symbols.Add(ElectricChargeDensityUnit.Zettacoulombpercubicmeter, "ZC/m³");
                Symbols.Add(ElectricChargeDensityUnit.Exacoulombpercubicmeter, "EC/m³");
                Symbols.Add(ElectricChargeDensityUnit.Petacoulombpercubicmeter, "PC/m³");
                Symbols.Add(ElectricChargeDensityUnit.Teracoulombpercubicmeter, "TC/m³");
                Symbols.Add(ElectricChargeDensityUnit.Gigacoulombpercubicmeter, "GC/m³");
                Symbols.Add(ElectricChargeDensityUnit.Megacoulombpercubicmeter, "MC/m³");
                Symbols.Add(ElectricChargeDensityUnit.Kilocoulombpercubicmeter, "kC/m³");
                Symbols.Add(ElectricChargeDensityUnit.Hectocoulombpercubicmeter, "hC/m³");
                Symbols.Add(ElectricChargeDensityUnit.Dekacoulombpercubicmeter, "daC/m³");
                Symbols.Add(ElectricChargeDensityUnit.CoulombPerCubicMeter, "C/m³");
                Symbols.Add(ElectricChargeDensityUnit.Decicoulombpercubicmeter, "dC/m³");
                Symbols.Add(ElectricChargeDensityUnit.Centicoulombpercubicmeter, "cC/m³");
                Symbols.Add(ElectricChargeDensityUnit.Millicoulombpercubicmeter, "mC/m³");
                Symbols.Add(ElectricChargeDensityUnit.Microcoulombpercubicmeter, "µC/m³");
                Symbols.Add(ElectricChargeDensityUnit.Nanocoulombpercubicmeter, "nC/m³");
                Symbols.Add(ElectricChargeDensityUnit.Picocoulombpercubicmeter, "pC/m³");
                Symbols.Add(ElectricChargeDensityUnit.Femtocoulombpercubicmeter, "fC/m³");
                Symbols.Add(ElectricChargeDensityUnit.Attocoulombpercubicmeter, "aC/m³");
                Symbols.Add(ElectricChargeDensityUnit.Zeptocoulombpercubicmeter, "zC/m³");
                Symbols.Add(ElectricChargeDensityUnit.Yoctocoulombpercubicmeter, "yC/m³");
                
                
                ConversionFunctions.Add(ElectricChargeDensityUnit.Yottacoulombpercubicmeter, "x * 1e24");
                ConversionFunctions.Add(ElectricChargeDensityUnit.Zettacoulombpercubicmeter, "x * 1e21");
                ConversionFunctions.Add(ElectricChargeDensityUnit.Exacoulombpercubicmeter, "x * 1e18");
                ConversionFunctions.Add(ElectricChargeDensityUnit.Petacoulombpercubicmeter, "x * 1e15");
                ConversionFunctions.Add(ElectricChargeDensityUnit.Teracoulombpercubicmeter, "x * 1e12");
                ConversionFunctions.Add(ElectricChargeDensityUnit.Gigacoulombpercubicmeter, "x * 1e9");
                ConversionFunctions.Add(ElectricChargeDensityUnit.Megacoulombpercubicmeter, "x * 1e6");
                ConversionFunctions.Add(ElectricChargeDensityUnit.Kilocoulombpercubicmeter, "x * 1e3");
                ConversionFunctions.Add(ElectricChargeDensityUnit.Hectocoulombpercubicmeter, "x * 1e2");
                ConversionFunctions.Add(ElectricChargeDensityUnit.Dekacoulombpercubicmeter, "x * 1e1");
                ConversionFunctions.Add(ElectricChargeDensityUnit.CoulombPerCubicMeter, "x * 1e0");
                ConversionFunctions.Add(ElectricChargeDensityUnit.Decicoulombpercubicmeter, "x * 1e-1");
                ConversionFunctions.Add(ElectricChargeDensityUnit.Centicoulombpercubicmeter, "x * 1e-2");
                ConversionFunctions.Add(ElectricChargeDensityUnit.Millicoulombpercubicmeter, "x * 1e-3");
                ConversionFunctions.Add(ElectricChargeDensityUnit.Microcoulombpercubicmeter, "x * 1e-6");
                ConversionFunctions.Add(ElectricChargeDensityUnit.Nanocoulombpercubicmeter, "x * 1e-9");
                ConversionFunctions.Add(ElectricChargeDensityUnit.Picocoulombpercubicmeter, "x * 1e-12");
                ConversionFunctions.Add(ElectricChargeDensityUnit.Femtocoulombpercubicmeter, "x * 1e-15");
                ConversionFunctions.Add(ElectricChargeDensityUnit.Attocoulombpercubicmeter, "x * 1e-18");
                ConversionFunctions.Add(ElectricChargeDensityUnit.Zeptocoulombpercubicmeter, "x * 1e-21");
                ConversionFunctions.Add(ElectricChargeDensityUnit.Yoctocoulombpercubicmeter, "x * 1e-24");
            }
        }
    }
