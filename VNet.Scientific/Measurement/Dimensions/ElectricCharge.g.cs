
    // Auto-generated for VNet on 2023-07-06 12:42:23
    using System.Numerics;
    
    
    namespace VNet.Scientific.Measurement.Dimensions
    {
        public sealed class ElectricCharge<TVal> : DimensionBase<ElectricChargeUnit, TVal> where TVal : notnull, INumber<TVal>
        {
            public override string IdTag => nameof(ElectricCharge<TVal>);
            
            public ElectricCharge() : base()
            {
                Exponents.Length = 0;
                Exponents.Mass = 0;
                Exponents.Time = 1;
                Exponents.ElectricalCurrent = 1;
                Exponents.LuminousIntensity = 0;
                Exponents.Temperature = 0;
                Exponents.Amount = 0;
                
                DefaultUnit = ElectricChargeUnit.Coulomb;
                
                Symbols.Add(ElectricChargeUnit.AmpereHour, "A-h");
                Symbols.Add(ElectricChargeUnit.Yottacoulomb, "YC");
                Symbols.Add(ElectricChargeUnit.Zettacoulomb, "ZC");
                Symbols.Add(ElectricChargeUnit.Exacoulomb, "EC");
                Symbols.Add(ElectricChargeUnit.Petacoulomb, "PC");
                Symbols.Add(ElectricChargeUnit.Teracoulomb, "TC");
                Symbols.Add(ElectricChargeUnit.Gigacoulomb, "GC");
                Symbols.Add(ElectricChargeUnit.Megacoulomb, "MC");
                Symbols.Add(ElectricChargeUnit.Kilocoulomb, "kC");
                Symbols.Add(ElectricChargeUnit.Hectocoulomb, "hC");
                Symbols.Add(ElectricChargeUnit.Dekacoulomb, "daC");
                Symbols.Add(ElectricChargeUnit.Coulomb, "C");
                Symbols.Add(ElectricChargeUnit.Decicoulomb, "dC");
                Symbols.Add(ElectricChargeUnit.Centicoulomb, "cC");
                Symbols.Add(ElectricChargeUnit.Millicoulomb, "mC");
                Symbols.Add(ElectricChargeUnit.Microcoulomb, "µC");
                Symbols.Add(ElectricChargeUnit.Nanocoulomb, "nC");
                Symbols.Add(ElectricChargeUnit.Picocoulomb, "pC");
                Symbols.Add(ElectricChargeUnit.Femtocoulomb, "fC");
                Symbols.Add(ElectricChargeUnit.Attocoulomb, "aC");
                Symbols.Add(ElectricChargeUnit.Zeptocoulomb, "zC");
                Symbols.Add(ElectricChargeUnit.Yoctocoulomb, "yC");
                
                PluralSymbols.Add(ElectricChargeUnit.AmpereHour, "Ah");
                
                ConversionFunctions.Add(ElectricChargeUnit.AmpereHour, "x / 2.77777777777e-4");
                ConversionFunctions.Add(ElectricChargeUnit.Yottacoulomb, "x * 1e24");
                ConversionFunctions.Add(ElectricChargeUnit.Zettacoulomb, "x * 1e21");
                ConversionFunctions.Add(ElectricChargeUnit.Exacoulomb, "x * 1e18");
                ConversionFunctions.Add(ElectricChargeUnit.Petacoulomb, "x * 1e15");
                ConversionFunctions.Add(ElectricChargeUnit.Teracoulomb, "x * 1e12");
                ConversionFunctions.Add(ElectricChargeUnit.Gigacoulomb, "x * 1e9");
                ConversionFunctions.Add(ElectricChargeUnit.Megacoulomb, "x * 1e6");
                ConversionFunctions.Add(ElectricChargeUnit.Kilocoulomb, "x * 1e3");
                ConversionFunctions.Add(ElectricChargeUnit.Hectocoulomb, "x * 1e2");
                ConversionFunctions.Add(ElectricChargeUnit.Dekacoulomb, "x * 1e1");
                ConversionFunctions.Add(ElectricChargeUnit.Coulomb, "x * 1e0");
                ConversionFunctions.Add(ElectricChargeUnit.Decicoulomb, "x * 1e-1");
                ConversionFunctions.Add(ElectricChargeUnit.Centicoulomb, "x * 1e-2");
                ConversionFunctions.Add(ElectricChargeUnit.Millicoulomb, "x * 1e-3");
                ConversionFunctions.Add(ElectricChargeUnit.Microcoulomb, "x * 1e-6");
                ConversionFunctions.Add(ElectricChargeUnit.Nanocoulomb, "x * 1e-9");
                ConversionFunctions.Add(ElectricChargeUnit.Picocoulomb, "x * 1e-12");
                ConversionFunctions.Add(ElectricChargeUnit.Femtocoulomb, "x * 1e-15");
                ConversionFunctions.Add(ElectricChargeUnit.Attocoulomb, "x * 1e-18");
                ConversionFunctions.Add(ElectricChargeUnit.Zeptocoulomb, "x * 1e-21");
                ConversionFunctions.Add(ElectricChargeUnit.Yoctocoulomb, "x * 1e-24");
            }
        }
    }
