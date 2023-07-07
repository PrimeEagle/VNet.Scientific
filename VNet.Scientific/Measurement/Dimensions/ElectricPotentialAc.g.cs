
    // Auto-generated for VNet on 2023-07-06 12:42:23
    using System.Numerics;
    
    
    namespace VNet.Scientific.Measurement.Dimensions
    {
        public sealed class ElectricPotentialAc<TVal> : DimensionBase<ElectricPotentialAcUnit, TVal> where TVal : notnull, INumber<TVal>
        {
            public override string IdTag => nameof(ElectricPotentialAc<TVal>);
            
            public ElectricPotentialAc() : base()
            {
                Exponents.Length = 0;
                Exponents.Mass = 0;
                Exponents.Time = 0;
                Exponents.ElectricalCurrent = 0;
                Exponents.LuminousIntensity = 0;
                Exponents.Temperature = 0;
                Exponents.Amount = 0;
                
                DefaultUnit = ElectricPotentialAcUnit.VoltAc;
                
                Symbols.Add(ElectricPotentialAcUnit.Yottavoltac, "YVac");
                Symbols.Add(ElectricPotentialAcUnit.Zettavoltac, "ZVac");
                Symbols.Add(ElectricPotentialAcUnit.Exavoltac, "EVac");
                Symbols.Add(ElectricPotentialAcUnit.Petavoltac, "PVac");
                Symbols.Add(ElectricPotentialAcUnit.Teravoltac, "TVac");
                Symbols.Add(ElectricPotentialAcUnit.Gigavoltac, "GVac");
                Symbols.Add(ElectricPotentialAcUnit.Megavoltac, "MVac");
                Symbols.Add(ElectricPotentialAcUnit.Kilovoltac, "kVac");
                Symbols.Add(ElectricPotentialAcUnit.Hectovoltac, "hVac");
                Symbols.Add(ElectricPotentialAcUnit.Dekavoltac, "daVac");
                Symbols.Add(ElectricPotentialAcUnit.VoltAc, "Vac");
                Symbols.Add(ElectricPotentialAcUnit.Decivoltac, "dVac");
                Symbols.Add(ElectricPotentialAcUnit.Centivoltac, "cVac");
                Symbols.Add(ElectricPotentialAcUnit.Millivoltac, "mVac");
                Symbols.Add(ElectricPotentialAcUnit.Microvoltac, "µVac");
                Symbols.Add(ElectricPotentialAcUnit.Nanovoltac, "nVac");
                Symbols.Add(ElectricPotentialAcUnit.Picovoltac, "pVac");
                Symbols.Add(ElectricPotentialAcUnit.Femtovoltac, "fVac");
                Symbols.Add(ElectricPotentialAcUnit.Attovoltac, "aVac");
                Symbols.Add(ElectricPotentialAcUnit.Zeptovoltac, "zVac");
                Symbols.Add(ElectricPotentialAcUnit.Yoctovoltac, "yVac");
                
                
                ConversionFunctions.Add(ElectricPotentialAcUnit.Yottavoltac, "x * 1e24");
                ConversionFunctions.Add(ElectricPotentialAcUnit.Zettavoltac, "x * 1e21");
                ConversionFunctions.Add(ElectricPotentialAcUnit.Exavoltac, "x * 1e18");
                ConversionFunctions.Add(ElectricPotentialAcUnit.Petavoltac, "x * 1e15");
                ConversionFunctions.Add(ElectricPotentialAcUnit.Teravoltac, "x * 1e12");
                ConversionFunctions.Add(ElectricPotentialAcUnit.Gigavoltac, "x * 1e9");
                ConversionFunctions.Add(ElectricPotentialAcUnit.Megavoltac, "x * 1e6");
                ConversionFunctions.Add(ElectricPotentialAcUnit.Kilovoltac, "x * 1e3");
                ConversionFunctions.Add(ElectricPotentialAcUnit.Hectovoltac, "x * 1e2");
                ConversionFunctions.Add(ElectricPotentialAcUnit.Dekavoltac, "x * 1e1");
                ConversionFunctions.Add(ElectricPotentialAcUnit.VoltAc, "x * 1e0");
                ConversionFunctions.Add(ElectricPotentialAcUnit.Decivoltac, "x * 1e-1");
                ConversionFunctions.Add(ElectricPotentialAcUnit.Centivoltac, "x * 1e-2");
                ConversionFunctions.Add(ElectricPotentialAcUnit.Millivoltac, "x * 1e-3");
                ConversionFunctions.Add(ElectricPotentialAcUnit.Microvoltac, "x * 1e-6");
                ConversionFunctions.Add(ElectricPotentialAcUnit.Nanovoltac, "x * 1e-9");
                ConversionFunctions.Add(ElectricPotentialAcUnit.Picovoltac, "x * 1e-12");
                ConversionFunctions.Add(ElectricPotentialAcUnit.Femtovoltac, "x * 1e-15");
                ConversionFunctions.Add(ElectricPotentialAcUnit.Attovoltac, "x * 1e-18");
                ConversionFunctions.Add(ElectricPotentialAcUnit.Zeptovoltac, "x * 1e-21");
                ConversionFunctions.Add(ElectricPotentialAcUnit.Yoctovoltac, "x * 1e-24");
            }
        }
    }
