
    // Auto-generated for VNet on 2023-07-05 10:35:43
    using System.Numerics;
    
    
    namespace VNet.Scientific.Measurement.Dimensions
    {
        public sealed class Luminosity<TVal> : DimensionBase<LuminosityUnit, TVal> where TVal : notnull, INumber<TVal>
        {
            public override string IdTag => nameof(Luminosity<TVal>);
            
            public Luminosity() : base()
            {
                DimensionComponent.Exponents.Length = 2;
                DimensionComponent.Exponents.Mass = 1;
                DimensionComponent.Exponents.Time = -3;
                DimensionComponent.Exponents.ElectricalCurrent = 0;
                DimensionComponent.Exponents.LuminousIntensity = 0;
                DimensionComponent.Exponents.Temperature = 0;
                DimensionComponent.Exponents.Amount = 0;
                
                DefaultUnit = LuminosityUnit.Watt;
                
                Symbols.Add(LuminosityUnit.SolarLuminosity, "L⊙");
                Symbols.Add(LuminosityUnit.Yottawatt, "YW");
                Symbols.Add(LuminosityUnit.Zettawatt, "ZW");
                Symbols.Add(LuminosityUnit.Exawatt, "EW");
                Symbols.Add(LuminosityUnit.Petawatt, "PW");
                Symbols.Add(LuminosityUnit.Terawatt, "TW");
                Symbols.Add(LuminosityUnit.Gigawatt, "GW");
                Symbols.Add(LuminosityUnit.Megawatt, "MW");
                Symbols.Add(LuminosityUnit.Kilowatt, "kW");
                Symbols.Add(LuminosityUnit.Hectowatt, "hW");
                Symbols.Add(LuminosityUnit.Dekawatt, "daW");
                Symbols.Add(LuminosityUnit.Watt, "W");
                Symbols.Add(LuminosityUnit.Deciwatt, "dW");
                Symbols.Add(LuminosityUnit.Centiwatt, "cW");
                Symbols.Add(LuminosityUnit.Milliwatt, "mW");
                Symbols.Add(LuminosityUnit.Microwatt, "µW");
                Symbols.Add(LuminosityUnit.Nanowatt, "nW");
                Symbols.Add(LuminosityUnit.Picowatt, "pW");
                Symbols.Add(LuminosityUnit.Femtowatt, "fW");
                Symbols.Add(LuminosityUnit.Attowatt, "aW");
                Symbols.Add(LuminosityUnit.Zeptowatt, "zW");
                Symbols.Add(LuminosityUnit.Yoctowatt, "yW");
                
                
                ConversionFunctions.Add(LuminosityUnit.SolarLuminosity, "x * 3.846e26");
                ConversionFunctions.Add(LuminosityUnit.Yottawatt, "x * 1e24");
                ConversionFunctions.Add(LuminosityUnit.Zettawatt, "x * 1e21");
                ConversionFunctions.Add(LuminosityUnit.Exawatt, "x * 1e18");
                ConversionFunctions.Add(LuminosityUnit.Petawatt, "x * 1e15");
                ConversionFunctions.Add(LuminosityUnit.Terawatt, "x * 1e12");
                ConversionFunctions.Add(LuminosityUnit.Gigawatt, "x * 1e9");
                ConversionFunctions.Add(LuminosityUnit.Megawatt, "x * 1e6");
                ConversionFunctions.Add(LuminosityUnit.Kilowatt, "x * 1e3");
                ConversionFunctions.Add(LuminosityUnit.Hectowatt, "x * 1e2");
                ConversionFunctions.Add(LuminosityUnit.Dekawatt, "x * 1e1");
                ConversionFunctions.Add(LuminosityUnit.Watt, "x * 1e0");
                ConversionFunctions.Add(LuminosityUnit.Deciwatt, "x * 1e-1");
                ConversionFunctions.Add(LuminosityUnit.Centiwatt, "x * 1e-2");
                ConversionFunctions.Add(LuminosityUnit.Milliwatt, "x * 1e-3");
                ConversionFunctions.Add(LuminosityUnit.Microwatt, "x * 1e-6");
                ConversionFunctions.Add(LuminosityUnit.Nanowatt, "x * 1e-9");
                ConversionFunctions.Add(LuminosityUnit.Picowatt, "x * 1e-12");
                ConversionFunctions.Add(LuminosityUnit.Femtowatt, "x * 1e-15");
                ConversionFunctions.Add(LuminosityUnit.Attowatt, "x * 1e-18");
                ConversionFunctions.Add(LuminosityUnit.Zeptowatt, "x * 1e-21");
                ConversionFunctions.Add(LuminosityUnit.Yoctowatt, "x * 1e-24");
            }
        }
    }
