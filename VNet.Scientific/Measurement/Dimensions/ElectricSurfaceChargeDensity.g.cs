
    // Auto-generated for VNet on 2023-07-05 10:35:43
    using System.Numerics;
    
    
    namespace VNet.Scientific.Measurement.Dimensions
    {
        public sealed class ElectricSurfaceChargeDensity<TVal> : DimensionBase<ElectricSurfaceChargeDensityUnit, TVal> where TVal : notnull, INumber<TVal>
        {
            public override string IdTag => nameof(ElectricSurfaceChargeDensity<TVal>);
            
            public ElectricSurfaceChargeDensity() : base()
            {
                DimensionComponent.Exponents.Length = -2;
                DimensionComponent.Exponents.Mass = 0;
                DimensionComponent.Exponents.Time = 1;
                DimensionComponent.Exponents.ElectricalCurrent = 1;
                DimensionComponent.Exponents.LuminousIntensity = 0;
                DimensionComponent.Exponents.Temperature = 0;
                DimensionComponent.Exponents.Amount = 0;
                
                DefaultUnit = ElectricSurfaceChargeDensityUnit.CoulombPerSquareMeter;
                
                Symbols.Add(ElectricSurfaceChargeDensityUnit.CoulombPerSquareCentimeter, "C/cm²");
                Symbols.Add(ElectricSurfaceChargeDensityUnit.CoulombPerSquareInch, "C/in²");
                Symbols.Add(ElectricSurfaceChargeDensityUnit.Yottacoulombpersquaremeter, "YC/m²");
                Symbols.Add(ElectricSurfaceChargeDensityUnit.Zettacoulombpersquaremeter, "ZC/m²");
                Symbols.Add(ElectricSurfaceChargeDensityUnit.Exacoulombpersquaremeter, "EC/m²");
                Symbols.Add(ElectricSurfaceChargeDensityUnit.Petacoulombpersquaremeter, "PC/m²");
                Symbols.Add(ElectricSurfaceChargeDensityUnit.Teracoulombpersquaremeter, "TC/m²");
                Symbols.Add(ElectricSurfaceChargeDensityUnit.Gigacoulombpersquaremeter, "GC/m²");
                Symbols.Add(ElectricSurfaceChargeDensityUnit.Megacoulombpersquaremeter, "MC/m²");
                Symbols.Add(ElectricSurfaceChargeDensityUnit.Kilocoulombpersquaremeter, "kC/m²");
                Symbols.Add(ElectricSurfaceChargeDensityUnit.Hectocoulombpersquaremeter, "hC/m²");
                Symbols.Add(ElectricSurfaceChargeDensityUnit.Dekacoulombpersquaremeter, "daC/m²");
                Symbols.Add(ElectricSurfaceChargeDensityUnit.CoulombPerSquareMeter, "C/m²");
                Symbols.Add(ElectricSurfaceChargeDensityUnit.Decicoulombpersquaremeter, "dC/m²");
                Symbols.Add(ElectricSurfaceChargeDensityUnit.Centicoulombpersquaremeter, "cC/m²");
                Symbols.Add(ElectricSurfaceChargeDensityUnit.Millicoulombpersquaremeter, "mC/m²");
                Symbols.Add(ElectricSurfaceChargeDensityUnit.Microcoulombpersquaremeter, "µC/m²");
                Symbols.Add(ElectricSurfaceChargeDensityUnit.Nanocoulombpersquaremeter, "nC/m²");
                Symbols.Add(ElectricSurfaceChargeDensityUnit.Picocoulombpersquaremeter, "pC/m²");
                Symbols.Add(ElectricSurfaceChargeDensityUnit.Femtocoulombpersquaremeter, "fC/m²");
                Symbols.Add(ElectricSurfaceChargeDensityUnit.Attocoulombpersquaremeter, "aC/m²");
                Symbols.Add(ElectricSurfaceChargeDensityUnit.Zeptocoulombpersquaremeter, "zC/m²");
                Symbols.Add(ElectricSurfaceChargeDensityUnit.Yoctocoulombpersquaremeter, "yC/m²");
                
                
                ConversionFunctions.Add(ElectricSurfaceChargeDensityUnit.CoulombPerSquareCentimeter, "x * 1.0e4");
                ConversionFunctions.Add(ElectricSurfaceChargeDensityUnit.CoulombPerSquareInch, "x * 1.5500031000062000e3");
                ConversionFunctions.Add(ElectricSurfaceChargeDensityUnit.Yottacoulombpersquaremeter, "x * 1e24");
                ConversionFunctions.Add(ElectricSurfaceChargeDensityUnit.Zettacoulombpersquaremeter, "x * 1e21");
                ConversionFunctions.Add(ElectricSurfaceChargeDensityUnit.Exacoulombpersquaremeter, "x * 1e18");
                ConversionFunctions.Add(ElectricSurfaceChargeDensityUnit.Petacoulombpersquaremeter, "x * 1e15");
                ConversionFunctions.Add(ElectricSurfaceChargeDensityUnit.Teracoulombpersquaremeter, "x * 1e12");
                ConversionFunctions.Add(ElectricSurfaceChargeDensityUnit.Gigacoulombpersquaremeter, "x * 1e9");
                ConversionFunctions.Add(ElectricSurfaceChargeDensityUnit.Megacoulombpersquaremeter, "x * 1e6");
                ConversionFunctions.Add(ElectricSurfaceChargeDensityUnit.Kilocoulombpersquaremeter, "x * 1e3");
                ConversionFunctions.Add(ElectricSurfaceChargeDensityUnit.Hectocoulombpersquaremeter, "x * 1e2");
                ConversionFunctions.Add(ElectricSurfaceChargeDensityUnit.Dekacoulombpersquaremeter, "x * 1e1");
                ConversionFunctions.Add(ElectricSurfaceChargeDensityUnit.CoulombPerSquareMeter, "x * 1e0");
                ConversionFunctions.Add(ElectricSurfaceChargeDensityUnit.Decicoulombpersquaremeter, "x * 1e-1");
                ConversionFunctions.Add(ElectricSurfaceChargeDensityUnit.Centicoulombpersquaremeter, "x * 1e-2");
                ConversionFunctions.Add(ElectricSurfaceChargeDensityUnit.Millicoulombpersquaremeter, "x * 1e-3");
                ConversionFunctions.Add(ElectricSurfaceChargeDensityUnit.Microcoulombpersquaremeter, "x * 1e-6");
                ConversionFunctions.Add(ElectricSurfaceChargeDensityUnit.Nanocoulombpersquaremeter, "x * 1e-9");
                ConversionFunctions.Add(ElectricSurfaceChargeDensityUnit.Picocoulombpersquaremeter, "x * 1e-12");
                ConversionFunctions.Add(ElectricSurfaceChargeDensityUnit.Femtocoulombpersquaremeter, "x * 1e-15");
                ConversionFunctions.Add(ElectricSurfaceChargeDensityUnit.Attocoulombpersquaremeter, "x * 1e-18");
                ConversionFunctions.Add(ElectricSurfaceChargeDensityUnit.Zeptocoulombpersquaremeter, "x * 1e-21");
                ConversionFunctions.Add(ElectricSurfaceChargeDensityUnit.Yoctocoulombpersquaremeter, "x * 1e-24");
            }
        }
    }
