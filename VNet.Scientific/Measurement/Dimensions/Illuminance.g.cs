
    // Auto-generated for VNet on 2023-07-05 10:35:43
    using System.Numerics;
    
    
    namespace VNet.Scientific.Measurement.Dimensions
    {
        public sealed class Illuminance<TVal> : DimensionBase<IlluminanceUnit, TVal> where TVal : notnull, INumber<TVal>
        {
            public override string IdTag => nameof(Illuminance<TVal>);
            
            public Illuminance() : base()
            {
                DimensionComponent.Exponents.Length = -2;
                DimensionComponent.Exponents.Mass = 0;
                DimensionComponent.Exponents.Time = 0;
                DimensionComponent.Exponents.ElectricalCurrent = 0;
                DimensionComponent.Exponents.LuminousIntensity = 1;
                DimensionComponent.Exponents.Temperature = 0;
                DimensionComponent.Exponents.Amount = 0;
                
                DefaultUnit = IlluminanceUnit.Lux;
                
                Symbols.Add(IlluminanceUnit.Yottalux, "Ylx");
                Symbols.Add(IlluminanceUnit.Zettalux, "Zlx");
                Symbols.Add(IlluminanceUnit.Exalux, "Elx");
                Symbols.Add(IlluminanceUnit.Petalux, "Plx");
                Symbols.Add(IlluminanceUnit.Teralux, "Tlx");
                Symbols.Add(IlluminanceUnit.Gigalux, "Glx");
                Symbols.Add(IlluminanceUnit.Megalux, "Mlx");
                Symbols.Add(IlluminanceUnit.Kilolux, "klx");
                Symbols.Add(IlluminanceUnit.Hectolux, "hlx");
                Symbols.Add(IlluminanceUnit.Dekalux, "dalx");
                Symbols.Add(IlluminanceUnit.Lux, "lx");
                Symbols.Add(IlluminanceUnit.Decilux, "dlx");
                Symbols.Add(IlluminanceUnit.Centilux, "clx");
                Symbols.Add(IlluminanceUnit.Millilux, "mlx");
                Symbols.Add(IlluminanceUnit.Microlux, "µlx");
                Symbols.Add(IlluminanceUnit.Nanolux, "nlx");
                Symbols.Add(IlluminanceUnit.Picolux, "plx");
                Symbols.Add(IlluminanceUnit.Femtolux, "flx");
                Symbols.Add(IlluminanceUnit.Attolux, "alx");
                Symbols.Add(IlluminanceUnit.Zeptolux, "zlx");
                Symbols.Add(IlluminanceUnit.Yoctolux, "ylx");
                
                
                ConversionFunctions.Add(IlluminanceUnit.Yottalux, "x * 1e24");
                ConversionFunctions.Add(IlluminanceUnit.Zettalux, "x * 1e21");
                ConversionFunctions.Add(IlluminanceUnit.Exalux, "x * 1e18");
                ConversionFunctions.Add(IlluminanceUnit.Petalux, "x * 1e15");
                ConversionFunctions.Add(IlluminanceUnit.Teralux, "x * 1e12");
                ConversionFunctions.Add(IlluminanceUnit.Gigalux, "x * 1e9");
                ConversionFunctions.Add(IlluminanceUnit.Megalux, "x * 1e6");
                ConversionFunctions.Add(IlluminanceUnit.Kilolux, "x * 1e3");
                ConversionFunctions.Add(IlluminanceUnit.Hectolux, "x * 1e2");
                ConversionFunctions.Add(IlluminanceUnit.Dekalux, "x * 1e1");
                ConversionFunctions.Add(IlluminanceUnit.Lux, "x * 1e0");
                ConversionFunctions.Add(IlluminanceUnit.Decilux, "x * 1e-1");
                ConversionFunctions.Add(IlluminanceUnit.Centilux, "x * 1e-2");
                ConversionFunctions.Add(IlluminanceUnit.Millilux, "x * 1e-3");
                ConversionFunctions.Add(IlluminanceUnit.Microlux, "x * 1e-6");
                ConversionFunctions.Add(IlluminanceUnit.Nanolux, "x * 1e-9");
                ConversionFunctions.Add(IlluminanceUnit.Picolux, "x * 1e-12");
                ConversionFunctions.Add(IlluminanceUnit.Femtolux, "x * 1e-15");
                ConversionFunctions.Add(IlluminanceUnit.Attolux, "x * 1e-18");
                ConversionFunctions.Add(IlluminanceUnit.Zeptolux, "x * 1e-21");
                ConversionFunctions.Add(IlluminanceUnit.Yoctolux, "x * 1e-24");
            }
        }
    }
