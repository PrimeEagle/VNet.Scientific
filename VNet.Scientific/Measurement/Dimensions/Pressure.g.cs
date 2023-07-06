
    // Auto-generated for VNet on 2023-07-05 10:24:46
    using System.Numerics;
    
    
    namespace VNet.Scientific.Measurement.Dimensions
    {
        public sealed class Pressure<TVal> : DimensionBase<PressureUnit, TVal> where TVal : notnull, INumber<TVal>
        {
            public override string IdTag => nameof(Pressure<TVal>);
            
            public Pressure() : base()
            {
                DimensionComponent.Exponents.Length = -1;
                DimensionComponent.Exponents.Mass = 1;
                DimensionComponent.Exponents.Time = -2;
                DimensionComponent.Exponents.ElectricalCurrent = 0;
                DimensionComponent.Exponents.LuminousIntensity = 0;
                DimensionComponent.Exponents.Temperature = 0;
                DimensionComponent.Exponents.Amount = 0;
                
                DefaultUnit = PressureUnit.Pascal;
                
                
                ConversionFunctions.Add(PressureUnit.Atmosphere, "x * 1.01325 * 1e5");
                ConversionFunctions.Add(PressureUnit.Bar, "x * 1e5");
                ConversionFunctions.Add(PressureUnit.KilogramForcePerSquareMeter, "x * 9.80665019960652");
                ConversionFunctions.Add(PressureUnit.KilogramForcePerSquareCentimeter, "x * 9.80665e4");
                ConversionFunctions.Add(PressureUnit.KilogramForcePerSquareMillimeter, "x * 9.80665e6");
                ConversionFunctions.Add(PressureUnit.NewtonPerSquareMeter, "x");
                ConversionFunctions.Add(PressureUnit.NewtonPerSquareCentimeter, "x * 1e4");
                ConversionFunctions.Add(PressureUnit.NewtonPerSquareMillimeter, "x * 1e6");
                ConversionFunctions.Add(PressureUnit.TechnicalAtmosphere, "x * 9.80680592331 * 1e4");
                ConversionFunctions.Add(PressureUnit.Torr, "x * 1.3332266752 * 1e2");
                ConversionFunctions.Add(PressureUnit.PoundForcePerSquareInch, "x * 6.894757293168361e3");
                ConversionFunctions.Add(PressureUnit.PoundForcePerSquareMil, "x * 6.894757293168361e9");
                ConversionFunctions.Add(PressureUnit.PoundForcePerSquareFoot, "x * 4.788025898033584e1");
                ConversionFunctions.Add(PressureUnit.TonneForcePerSquareMillimeter, "x * 9.80665e9");
                ConversionFunctions.Add(PressureUnit.TonneForcePerSquareMeter, "x * 9.80665e3");
                ConversionFunctions.Add(PressureUnit.MeterOfHead, "x * 9804.139432");
                ConversionFunctions.Add(PressureUnit.TonneForcePerSquareCentimeter, "x * 9.80665e7");
                ConversionFunctions.Add(PressureUnit.FootOfHead, "x * 2989.0669");
                ConversionFunctions.Add(PressureUnit.MillimeterOfMercury, "x / 7.50061561302643e-3");
                ConversionFunctions.Add(PressureUnit.InchOfMercury, "x / 2.95299830714159e-4");
                ConversionFunctions.Add(PressureUnit.DynePerSquareCentimeter, "x * 1.0e-1");
                ConversionFunctions.Add(PressureUnit.PoundPerInchSecondSquared, "x * 1.785796732283465e1");
                ConversionFunctions.Add(PressureUnit.MeterOfWaterColumn, "x * 9.806650000000272e3");
                ConversionFunctions.Add(PressureUnit.InchOfWaterColumn, "x * 249.08890833333");
                ConversionFunctions.Add(PressureUnit.MeterOfElevation, "Math.Pow(1.0 - (x / 44307.69396), 5.2553026003237266401799415610351) * 101325.0");
                ConversionFunctions.Add(PressureUnit.FootOfElevation, "Math.Pow(1.0 - (x / 145366.45), 5.2553026003237266401799415610351) * 101325.0");
                ConversionFunctions.Add(PressureUnit.Yottapascal, "x * 1e24");
                ConversionFunctions.Add(PressureUnit.Zettapascal, "x * 1e21");
                ConversionFunctions.Add(PressureUnit.Exapascal, "x * 1e18");
                ConversionFunctions.Add(PressureUnit.Petapascal, "x * 1e15");
                ConversionFunctions.Add(PressureUnit.Terapascal, "x * 1e12");
                ConversionFunctions.Add(PressureUnit.Gigapascal, "x * 1e9");
                ConversionFunctions.Add(PressureUnit.Megapascal, "x * 1e6");
                ConversionFunctions.Add(PressureUnit.Kilopascal, "x * 1e3");
                ConversionFunctions.Add(PressureUnit.Hectopascal, "x * 1e2");
                ConversionFunctions.Add(PressureUnit.Dekapascal, "x * 1e1");
                ConversionFunctions.Add(PressureUnit.Pascal, "x * 1e0");
                ConversionFunctions.Add(PressureUnit.Decipascal, "x * 1e-1");
                ConversionFunctions.Add(PressureUnit.Centipascal, "x * 1e-2");
                ConversionFunctions.Add(PressureUnit.Millipascal, "x * 1e-3");
                ConversionFunctions.Add(PressureUnit.Micropascal, "x * 1e-6");
                ConversionFunctions.Add(PressureUnit.Nanopascal, "x * 1e-9");
                ConversionFunctions.Add(PressureUnit.Picopascal, "x * 1e-12");
                ConversionFunctions.Add(PressureUnit.Femtopascal, "x * 1e-15");
                ConversionFunctions.Add(PressureUnit.Attopascal, "x * 1e-18");
                ConversionFunctions.Add(PressureUnit.Zeptopascal, "x * 1e-21");
                ConversionFunctions.Add(PressureUnit.Yoctopascal, "x * 1e-24");
            }
        }
    }
