
    // Auto-generated for VNet on 2023-07-03 11:25:32
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
                
                
                _conversionFunctions.Add("Atmosphere", "x * 1.01325 * 1e5");
                _conversionFunctions.Add("Bar", "x * 1e5");
                _conversionFunctions.Add("KilogramForcePerSquareMeter", "x * 9.80665019960652");
                _conversionFunctions.Add("KilogramForcePerSquareCentimeter", "x * 9.80665e4");
                _conversionFunctions.Add("KilogramForcePerSquareMillimeter", "x * 9.80665e6");
                _conversionFunctions.Add("NewtonPerSquareMeter", "x");
                _conversionFunctions.Add("NewtonPerSquareCentimeter", "x * 1e4");
                _conversionFunctions.Add("NewtonPerSquareMillimeter", "x * 1e6");
                _conversionFunctions.Add("TechnicalAtmosphere", "x * 9.80680592331 * 1e4");
                _conversionFunctions.Add("Torr", "x * 1.3332266752 * 1e2");
                _conversionFunctions.Add("PoundForcePerSquareInch", "x * 6.894757293168361e3");
                _conversionFunctions.Add("PoundForcePerSquareMil", "x * 6.894757293168361e9");
                _conversionFunctions.Add("PoundForcePerSquareFoot", "x * 4.788025898033584e1");
                _conversionFunctions.Add("TonneForcePerSquareMillimeter", "x * 9.80665e9");
                _conversionFunctions.Add("TonneForcePerSquareMeter", "x * 9.80665e3");
                _conversionFunctions.Add("MeterOfHead", "x * 9804.139432");
                _conversionFunctions.Add("TonneForcePerSquareCentimeter", "x * 9.80665e7");
                _conversionFunctions.Add("FootOfHead", "x * 2989.0669");
                _conversionFunctions.Add("MillimeterOfMercury", "x / 7.50061561302643e-3");
                _conversionFunctions.Add("InchOfMercury", "x / 2.95299830714159e-4");
                _conversionFunctions.Add("DynePerSquareCentimeter", "x * 1.0e-1");
                _conversionFunctions.Add("PoundPerInchSecondSquared", "x * 1.785796732283465e1");
                _conversionFunctions.Add("MeterOfWaterColumn", "x * 9.806650000000272e3");
                _conversionFunctions.Add("InchOfWaterColumn", "x * 249.08890833333");
                _conversionFunctions.Add("MeterOfElevation", "Math.Pow(1.0 - (x / 44307.69396), 5.2553026003237266401799415610351) * 101325.0");
                _conversionFunctions.Add("FootOfElevation", "Math.Pow(1.0 - (x / 145366.45), 5.2553026003237266401799415610351) * 101325.0");
                _conversionFunctions.Add("YottaPascal", "x * 1e24");
                _conversionFunctions.Add("ZettaPascal", "x * 1e21");
                _conversionFunctions.Add("ExaPascal", "x * 1e18");
                _conversionFunctions.Add("PetaPascal", "x * 1e15");
                _conversionFunctions.Add("TeraPascal", "x * 1e12");
                _conversionFunctions.Add("GigaPascal", "x * 1e9");
                _conversionFunctions.Add("MegaPascal", "x * 1e6");
                _conversionFunctions.Add("KiloPascal", "x * 1e3");
                _conversionFunctions.Add("HectoPascal", "x * 1e2");
                _conversionFunctions.Add("DekaPascal", "x * 1e1");
                _conversionFunctions.Add("Pascal", "x * 1e0");
                _conversionFunctions.Add("DeciPascal", "x * 1e-1");
                _conversionFunctions.Add("CentiPascal", "x * 1e-2");
                _conversionFunctions.Add("MilliPascal", "x * 1e-3");
                _conversionFunctions.Add("MicroPascal", "x * 1e-6");
                _conversionFunctions.Add("NanoPascal", "x * 1e-9");
                _conversionFunctions.Add("PicoPascal", "x * 1e-12");
                _conversionFunctions.Add("FemtoPascal", "x * 1e-15");
                _conversionFunctions.Add("AttoPascal", "x * 1e-18");
                _conversionFunctions.Add("ZeptoPascal", "x * 1e-21");
                _conversionFunctions.Add("YoctoPascal", "x * 1e-24");
            }
        }
    }
