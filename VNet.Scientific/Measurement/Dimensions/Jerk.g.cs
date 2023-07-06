
    // Auto-generated for VNet on 2023-07-05 10:35:43
    using System.Numerics;
    
    
    namespace VNet.Scientific.Measurement.Dimensions
    {
        public sealed class Jerk<TVal> : DimensionBase<JerkUnit, TVal> where TVal : notnull, INumber<TVal>
        {
            public override string IdTag => nameof(Jerk<TVal>);
            
            public Jerk() : base()
            {
                DimensionComponent.Exponents.Length = 1;
                DimensionComponent.Exponents.Mass = 0;
                DimensionComponent.Exponents.Time = -3;
                DimensionComponent.Exponents.ElectricalCurrent = 0;
                DimensionComponent.Exponents.LuminousIntensity = 0;
                DimensionComponent.Exponents.Temperature = 0;
                DimensionComponent.Exponents.Amount = 0;
                
                DefaultUnit = JerkUnit.MeterPerSecondCubed;
                
                Symbols.Add(JerkUnit.InchPerSecondCubed, "in/s³");
                Symbols.Add(JerkUnit.FootPerSecondCubed, "ft/s³");
                Symbols.Add(JerkUnit.StandardGravitiesPerSecond, "g/s");
                Symbols.Add(JerkUnit.Yottameterpersecondcubed, "Ym/s³");
                Symbols.Add(JerkUnit.Zettameterpersecondcubed, "Zm/s³");
                Symbols.Add(JerkUnit.Exameterpersecondcubed, "Em/s³");
                Symbols.Add(JerkUnit.Petameterpersecondcubed, "Pm/s³");
                Symbols.Add(JerkUnit.Terameterpersecondcubed, "Tm/s³");
                Symbols.Add(JerkUnit.Gigameterpersecondcubed, "Gm/s³");
                Symbols.Add(JerkUnit.Megameterpersecondcubed, "Mm/s³");
                Symbols.Add(JerkUnit.Kilometerpersecondcubed, "km/s³");
                Symbols.Add(JerkUnit.Hectometerpersecondcubed, "hm/s³");
                Symbols.Add(JerkUnit.Dekameterpersecondcubed, "dam/s³");
                Symbols.Add(JerkUnit.MeterPerSecondCubed, "m/s³");
                Symbols.Add(JerkUnit.Decimeterpersecondcubed, "dm/s³");
                Symbols.Add(JerkUnit.Centimeterpersecondcubed, "cm/s³");
                Symbols.Add(JerkUnit.Millimeterpersecondcubed, "mm/s³");
                Symbols.Add(JerkUnit.Micrometerpersecondcubed, "µm/s³");
                Symbols.Add(JerkUnit.Nanometerpersecondcubed, "nm/s³");
                Symbols.Add(JerkUnit.Picometerpersecondcubed, "pm/s³");
                Symbols.Add(JerkUnit.Femtometerpersecondcubed, "fm/s³");
                Symbols.Add(JerkUnit.Attometerpersecondcubed, "am/s³");
                Symbols.Add(JerkUnit.Zeptometerpersecondcubed, "zm/s³");
                Symbols.Add(JerkUnit.Yoctometerpersecondcubed, "ym/s³");
                
                
                ConversionFunctions.Add(JerkUnit.InchPerSecondCubed, "x * 0.0254");
                ConversionFunctions.Add(JerkUnit.FootPerSecondCubed, "x * 0.304800");
                ConversionFunctions.Add(JerkUnit.StandardGravitiesPerSecond, "x * 9.80665");
                ConversionFunctions.Add(JerkUnit.Yottameterpersecondcubed, "x * 1e24");
                ConversionFunctions.Add(JerkUnit.Zettameterpersecondcubed, "x * 1e21");
                ConversionFunctions.Add(JerkUnit.Exameterpersecondcubed, "x * 1e18");
                ConversionFunctions.Add(JerkUnit.Petameterpersecondcubed, "x * 1e15");
                ConversionFunctions.Add(JerkUnit.Terameterpersecondcubed, "x * 1e12");
                ConversionFunctions.Add(JerkUnit.Gigameterpersecondcubed, "x * 1e9");
                ConversionFunctions.Add(JerkUnit.Megameterpersecondcubed, "x * 1e6");
                ConversionFunctions.Add(JerkUnit.Kilometerpersecondcubed, "x * 1e3");
                ConversionFunctions.Add(JerkUnit.Hectometerpersecondcubed, "x * 1e2");
                ConversionFunctions.Add(JerkUnit.Dekameterpersecondcubed, "x * 1e1");
                ConversionFunctions.Add(JerkUnit.MeterPerSecondCubed, "x * 1e0");
                ConversionFunctions.Add(JerkUnit.Decimeterpersecondcubed, "x * 1e-1");
                ConversionFunctions.Add(JerkUnit.Centimeterpersecondcubed, "x * 1e-2");
                ConversionFunctions.Add(JerkUnit.Millimeterpersecondcubed, "x * 1e-3");
                ConversionFunctions.Add(JerkUnit.Micrometerpersecondcubed, "x * 1e-6");
                ConversionFunctions.Add(JerkUnit.Nanometerpersecondcubed, "x * 1e-9");
                ConversionFunctions.Add(JerkUnit.Picometerpersecondcubed, "x * 1e-12");
                ConversionFunctions.Add(JerkUnit.Femtometerpersecondcubed, "x * 1e-15");
                ConversionFunctions.Add(JerkUnit.Attometerpersecondcubed, "x * 1e-18");
                ConversionFunctions.Add(JerkUnit.Zeptometerpersecondcubed, "x * 1e-21");
                ConversionFunctions.Add(JerkUnit.Yoctometerpersecondcubed, "x * 1e-24");
            }
        }
    }
