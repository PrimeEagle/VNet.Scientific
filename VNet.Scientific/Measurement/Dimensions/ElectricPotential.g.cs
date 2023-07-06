
    // Auto-generated for VNet on 2023-07-05 10:35:43
    using System.Numerics;
    
    
    namespace VNet.Scientific.Measurement.Dimensions
    {
        public sealed class ElectricPotential<TVal> : DimensionBase<ElectricPotentialUnit, TVal> where TVal : notnull, INumber<TVal>
        {
            public override string IdTag => nameof(ElectricPotential<TVal>);
            
            public ElectricPotential() : base()
            {
                DimensionComponent.Exponents.Length = 2;
                DimensionComponent.Exponents.Mass = 1;
                DimensionComponent.Exponents.Time = -3;
                DimensionComponent.Exponents.ElectricalCurrent = -1;
                DimensionComponent.Exponents.LuminousIntensity = 0;
                DimensionComponent.Exponents.Temperature = 0;
                DimensionComponent.Exponents.Amount = 0;
                
                DefaultUnit = ElectricPotentialUnit.Volt;
                
                Symbols.Add(ElectricPotentialUnit.Yottavolt, "YV");
                Symbols.Add(ElectricPotentialUnit.Zettavolt, "ZV");
                Symbols.Add(ElectricPotentialUnit.Exavolt, "EV");
                Symbols.Add(ElectricPotentialUnit.Petavolt, "PV");
                Symbols.Add(ElectricPotentialUnit.Teravolt, "TV");
                Symbols.Add(ElectricPotentialUnit.Gigavolt, "GV");
                Symbols.Add(ElectricPotentialUnit.Megavolt, "MV");
                Symbols.Add(ElectricPotentialUnit.Kilovolt, "kV");
                Symbols.Add(ElectricPotentialUnit.Hectovolt, "hV");
                Symbols.Add(ElectricPotentialUnit.Dekavolt, "daV");
                Symbols.Add(ElectricPotentialUnit.Volt, "V");
                Symbols.Add(ElectricPotentialUnit.Decivolt, "dV");
                Symbols.Add(ElectricPotentialUnit.Centivolt, "cV");
                Symbols.Add(ElectricPotentialUnit.Millivolt, "mV");
                Symbols.Add(ElectricPotentialUnit.Microvolt, "µV");
                Symbols.Add(ElectricPotentialUnit.Nanovolt, "nV");
                Symbols.Add(ElectricPotentialUnit.Picovolt, "pV");
                Symbols.Add(ElectricPotentialUnit.Femtovolt, "fV");
                Symbols.Add(ElectricPotentialUnit.Attovolt, "aV");
                Symbols.Add(ElectricPotentialUnit.Zeptovolt, "zV");
                Symbols.Add(ElectricPotentialUnit.Yoctovolt, "yV");
                
                
                ConversionFunctions.Add(ElectricPotentialUnit.Yottavolt, "x * 1e24");
                ConversionFunctions.Add(ElectricPotentialUnit.Zettavolt, "x * 1e21");
                ConversionFunctions.Add(ElectricPotentialUnit.Exavolt, "x * 1e18");
                ConversionFunctions.Add(ElectricPotentialUnit.Petavolt, "x * 1e15");
                ConversionFunctions.Add(ElectricPotentialUnit.Teravolt, "x * 1e12");
                ConversionFunctions.Add(ElectricPotentialUnit.Gigavolt, "x * 1e9");
                ConversionFunctions.Add(ElectricPotentialUnit.Megavolt, "x * 1e6");
                ConversionFunctions.Add(ElectricPotentialUnit.Kilovolt, "x * 1e3");
                ConversionFunctions.Add(ElectricPotentialUnit.Hectovolt, "x * 1e2");
                ConversionFunctions.Add(ElectricPotentialUnit.Dekavolt, "x * 1e1");
                ConversionFunctions.Add(ElectricPotentialUnit.Volt, "x * 1e0");
                ConversionFunctions.Add(ElectricPotentialUnit.Decivolt, "x * 1e-1");
                ConversionFunctions.Add(ElectricPotentialUnit.Centivolt, "x * 1e-2");
                ConversionFunctions.Add(ElectricPotentialUnit.Millivolt, "x * 1e-3");
                ConversionFunctions.Add(ElectricPotentialUnit.Microvolt, "x * 1e-6");
                ConversionFunctions.Add(ElectricPotentialUnit.Nanovolt, "x * 1e-9");
                ConversionFunctions.Add(ElectricPotentialUnit.Picovolt, "x * 1e-12");
                ConversionFunctions.Add(ElectricPotentialUnit.Femtovolt, "x * 1e-15");
                ConversionFunctions.Add(ElectricPotentialUnit.Attovolt, "x * 1e-18");
                ConversionFunctions.Add(ElectricPotentialUnit.Zeptovolt, "x * 1e-21");
                ConversionFunctions.Add(ElectricPotentialUnit.Yoctovolt, "x * 1e-24");
            }
        }
    }
