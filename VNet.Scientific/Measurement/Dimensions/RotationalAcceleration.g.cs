
    // Auto-generated for VNet on 2023-07-05 10:35:43
    using System.Numerics;
    
    
    namespace VNet.Scientific.Measurement.Dimensions
    {
        public sealed class RotationalAcceleration<TVal> : DimensionBase<RotationalAccelerationUnit, TVal> where TVal : notnull, INumber<TVal>
        {
            public override string IdTag => nameof(RotationalAcceleration<TVal>);
            
            public RotationalAcceleration() : base()
            {
                DimensionComponent.Exponents.Length = 0;
                DimensionComponent.Exponents.Mass = 0;
                DimensionComponent.Exponents.Time = -2;
                DimensionComponent.Exponents.ElectricalCurrent = 0;
                DimensionComponent.Exponents.LuminousIntensity = 0;
                DimensionComponent.Exponents.Temperature = 0;
                DimensionComponent.Exponents.Amount = 0;
                
                DefaultUnit = RotationalAccelerationUnit.RadianPerSecondSquared;
                
                Symbols.Add(RotationalAccelerationUnit.DegreePerSecondSquared, "°/s²");
                Symbols.Add(RotationalAccelerationUnit.RevolutionPerMinutePerSecond, "rpm/s");
                Symbols.Add(RotationalAccelerationUnit.RevolutionPerSecondSquared, "r/s²");
                Symbols.Add(RotationalAccelerationUnit.Yottaradianpersecondsquared, "Yrad/s²");
                Symbols.Add(RotationalAccelerationUnit.Zettaradianpersecondsquared, "Zrad/s²");
                Symbols.Add(RotationalAccelerationUnit.Exaradianpersecondsquared, "Erad/s²");
                Symbols.Add(RotationalAccelerationUnit.Petaradianpersecondsquared, "Prad/s²");
                Symbols.Add(RotationalAccelerationUnit.Teraradianpersecondsquared, "Trad/s²");
                Symbols.Add(RotationalAccelerationUnit.Gigaradianpersecondsquared, "Grad/s²");
                Symbols.Add(RotationalAccelerationUnit.Megaradianpersecondsquared, "Mrad/s²");
                Symbols.Add(RotationalAccelerationUnit.Kiloradianpersecondsquared, "krad/s²");
                Symbols.Add(RotationalAccelerationUnit.Hectoradianpersecondsquared, "hrad/s²");
                Symbols.Add(RotationalAccelerationUnit.Dekaradianpersecondsquared, "darad/s²");
                Symbols.Add(RotationalAccelerationUnit.RadianPerSecondSquared, "rad/s²");
                Symbols.Add(RotationalAccelerationUnit.Deciradianpersecondsquared, "drad/s²");
                Symbols.Add(RotationalAccelerationUnit.Centiradianpersecondsquared, "crad/s²");
                Symbols.Add(RotationalAccelerationUnit.Milliradianpersecondsquared, "mrad/s²");
                Symbols.Add(RotationalAccelerationUnit.Microradianpersecondsquared, "µrad/s²");
                Symbols.Add(RotationalAccelerationUnit.Nanoradianpersecondsquared, "nrad/s²");
                Symbols.Add(RotationalAccelerationUnit.Picoradianpersecondsquared, "prad/s²");
                Symbols.Add(RotationalAccelerationUnit.Femtoradianpersecondsquared, "frad/s²");
                Symbols.Add(RotationalAccelerationUnit.Attoradianpersecondsquared, "arad/s²");
                Symbols.Add(RotationalAccelerationUnit.Zeptoradianpersecondsquared, "zrad/s²");
                Symbols.Add(RotationalAccelerationUnit.Yoctoradianpersecondsquared, "yrad/s²");
                
                PluralSymbols.Add(RotationalAccelerationUnit.DegreePerSecondSquared, "deg/s²");
                
                ConversionFunctions.Add(RotationalAccelerationUnit.DegreePerSecondSquared, "(Math.PI / 180) * x");
                ConversionFunctions.Add(RotationalAccelerationUnit.RevolutionPerMinutePerSecond, "((2 * Math.PI) / 60) * x");
                ConversionFunctions.Add(RotationalAccelerationUnit.RevolutionPerSecondSquared, "(2 * Math.PI) * x");
                ConversionFunctions.Add(RotationalAccelerationUnit.Yottaradianpersecondsquared, "x * 1e24");
                ConversionFunctions.Add(RotationalAccelerationUnit.Zettaradianpersecondsquared, "x * 1e21");
                ConversionFunctions.Add(RotationalAccelerationUnit.Exaradianpersecondsquared, "x * 1e18");
                ConversionFunctions.Add(RotationalAccelerationUnit.Petaradianpersecondsquared, "x * 1e15");
                ConversionFunctions.Add(RotationalAccelerationUnit.Teraradianpersecondsquared, "x * 1e12");
                ConversionFunctions.Add(RotationalAccelerationUnit.Gigaradianpersecondsquared, "x * 1e9");
                ConversionFunctions.Add(RotationalAccelerationUnit.Megaradianpersecondsquared, "x * 1e6");
                ConversionFunctions.Add(RotationalAccelerationUnit.Kiloradianpersecondsquared, "x * 1e3");
                ConversionFunctions.Add(RotationalAccelerationUnit.Hectoradianpersecondsquared, "x * 1e2");
                ConversionFunctions.Add(RotationalAccelerationUnit.Dekaradianpersecondsquared, "x * 1e1");
                ConversionFunctions.Add(RotationalAccelerationUnit.RadianPerSecondSquared, "x * 1e0");
                ConversionFunctions.Add(RotationalAccelerationUnit.Deciradianpersecondsquared, "x * 1e-1");
                ConversionFunctions.Add(RotationalAccelerationUnit.Centiradianpersecondsquared, "x * 1e-2");
                ConversionFunctions.Add(RotationalAccelerationUnit.Milliradianpersecondsquared, "x * 1e-3");
                ConversionFunctions.Add(RotationalAccelerationUnit.Microradianpersecondsquared, "x * 1e-6");
                ConversionFunctions.Add(RotationalAccelerationUnit.Nanoradianpersecondsquared, "x * 1e-9");
                ConversionFunctions.Add(RotationalAccelerationUnit.Picoradianpersecondsquared, "x * 1e-12");
                ConversionFunctions.Add(RotationalAccelerationUnit.Femtoradianpersecondsquared, "x * 1e-15");
                ConversionFunctions.Add(RotationalAccelerationUnit.Attoradianpersecondsquared, "x * 1e-18");
                ConversionFunctions.Add(RotationalAccelerationUnit.Zeptoradianpersecondsquared, "x * 1e-21");
                ConversionFunctions.Add(RotationalAccelerationUnit.Yoctoradianpersecondsquared, "x * 1e-24");
            }
        }
    }
