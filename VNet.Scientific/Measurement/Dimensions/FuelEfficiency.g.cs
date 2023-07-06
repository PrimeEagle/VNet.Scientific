
    // Auto-generated for VNet on 2023-07-05 10:35:43
    using System.Numerics;
    
    
    namespace VNet.Scientific.Measurement.Dimensions
    {
        public sealed class FuelEfficiency<TVal> : DimensionBase<FuelEfficiencyUnit, TVal> where TVal : notnull, INumber<TVal>
        {
            public override string IdTag => nameof(FuelEfficiency<TVal>);
            
            public FuelEfficiency() : base()
            {
                DimensionComponent.Exponents.Length = 0;
                DimensionComponent.Exponents.Mass = 0;
                DimensionComponent.Exponents.Time = 0;
                DimensionComponent.Exponents.ElectricalCurrent = 0;
                DimensionComponent.Exponents.LuminousIntensity = 0;
                DimensionComponent.Exponents.Temperature = 0;
                DimensionComponent.Exponents.Amount = 0;
                
                DefaultUnit = FuelEfficiencyUnit.LiterPer100Kilometers;
                
                Symbols.Add(FuelEfficiencyUnit.MilePerUsGallon, "mpg (U.S.)");
                Symbols.Add(FuelEfficiencyUnit.MilePerUkGallon, "mpg (imp.)");
                Symbols.Add(FuelEfficiencyUnit.KilometerPerLiter, "km/L");
                Symbols.Add(FuelEfficiencyUnit.Yottaliterper100kilometers, "YL/100km");
                Symbols.Add(FuelEfficiencyUnit.Zettaliterper100kilometers, "ZL/100km");
                Symbols.Add(FuelEfficiencyUnit.Exaliterper100kilometers, "EL/100km");
                Symbols.Add(FuelEfficiencyUnit.Petaliterper100kilometers, "PL/100km");
                Symbols.Add(FuelEfficiencyUnit.Teraliterper100kilometers, "TL/100km");
                Symbols.Add(FuelEfficiencyUnit.Gigaliterper100kilometers, "GL/100km");
                Symbols.Add(FuelEfficiencyUnit.Megaliterper100kilometers, "ML/100km");
                Symbols.Add(FuelEfficiencyUnit.Kiloliterper100kilometers, "kL/100km");
                Symbols.Add(FuelEfficiencyUnit.Hectoliterper100kilometers, "hL/100km");
                Symbols.Add(FuelEfficiencyUnit.Dekaliterper100kilometers, "daL/100km");
                Symbols.Add(FuelEfficiencyUnit.LiterPer100Kilometers, "L/100km");
                Symbols.Add(FuelEfficiencyUnit.Deciliterper100kilometers, "dL/100km");
                Symbols.Add(FuelEfficiencyUnit.Centiliterper100kilometers, "cL/100km");
                Symbols.Add(FuelEfficiencyUnit.Milliliterper100kilometers, "mL/100km");
                Symbols.Add(FuelEfficiencyUnit.Microliterper100kilometers, "µL/100km");
                Symbols.Add(FuelEfficiencyUnit.Nanoliterper100kilometers, "nL/100km");
                Symbols.Add(FuelEfficiencyUnit.Picoliterper100kilometers, "pL/100km");
                Symbols.Add(FuelEfficiencyUnit.Femtoliterper100kilometers, "fL/100km");
                Symbols.Add(FuelEfficiencyUnit.Attoliterper100kilometers, "aL/100km");
                Symbols.Add(FuelEfficiencyUnit.Zeptoliterper100kilometers, "zL/100km");
                Symbols.Add(FuelEfficiencyUnit.Yoctoliterper100kilometers, "yL/100km");
                
                
                ConversionFunctions.Add(FuelEfficiencyUnit.MilePerUsGallon, "(100 * 3.785411784) / (1.609344 * x)");
                ConversionFunctions.Add(FuelEfficiencyUnit.MilePerUkGallon, "(100 * 4.54609188) / (1.609344 * x)");
                ConversionFunctions.Add(FuelEfficiencyUnit.KilometerPerLiter, "100 / x");
                ConversionFunctions.Add(FuelEfficiencyUnit.Yottaliterper100kilometers, "x * 1e24");
                ConversionFunctions.Add(FuelEfficiencyUnit.Zettaliterper100kilometers, "x * 1e21");
                ConversionFunctions.Add(FuelEfficiencyUnit.Exaliterper100kilometers, "x * 1e18");
                ConversionFunctions.Add(FuelEfficiencyUnit.Petaliterper100kilometers, "x * 1e15");
                ConversionFunctions.Add(FuelEfficiencyUnit.Teraliterper100kilometers, "x * 1e12");
                ConversionFunctions.Add(FuelEfficiencyUnit.Gigaliterper100kilometers, "x * 1e9");
                ConversionFunctions.Add(FuelEfficiencyUnit.Megaliterper100kilometers, "x * 1e6");
                ConversionFunctions.Add(FuelEfficiencyUnit.Kiloliterper100kilometers, "x * 1e3");
                ConversionFunctions.Add(FuelEfficiencyUnit.Hectoliterper100kilometers, "x * 1e2");
                ConversionFunctions.Add(FuelEfficiencyUnit.Dekaliterper100kilometers, "x * 1e1");
                ConversionFunctions.Add(FuelEfficiencyUnit.LiterPer100Kilometers, "x * 1e0");
                ConversionFunctions.Add(FuelEfficiencyUnit.Deciliterper100kilometers, "x * 1e-1");
                ConversionFunctions.Add(FuelEfficiencyUnit.Centiliterper100kilometers, "x * 1e-2");
                ConversionFunctions.Add(FuelEfficiencyUnit.Milliliterper100kilometers, "x * 1e-3");
                ConversionFunctions.Add(FuelEfficiencyUnit.Microliterper100kilometers, "x * 1e-6");
                ConversionFunctions.Add(FuelEfficiencyUnit.Nanoliterper100kilometers, "x * 1e-9");
                ConversionFunctions.Add(FuelEfficiencyUnit.Picoliterper100kilometers, "x * 1e-12");
                ConversionFunctions.Add(FuelEfficiencyUnit.Femtoliterper100kilometers, "x * 1e-15");
                ConversionFunctions.Add(FuelEfficiencyUnit.Attoliterper100kilometers, "x * 1e-18");
                ConversionFunctions.Add(FuelEfficiencyUnit.Zeptoliterper100kilometers, "x * 1e-21");
                ConversionFunctions.Add(FuelEfficiencyUnit.Yoctoliterper100kilometers, "x * 1e-24");
            }
        }
    }
