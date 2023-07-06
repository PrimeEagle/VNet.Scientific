
    // Auto-generated for VNet on 2023-07-05 10:35:43
    using System.Numerics;
    
    
    namespace VNet.Scientific.Measurement.Dimensions
    {
        public sealed class SolidAngle<TVal> : DimensionBase<SolidAngleUnit, TVal> where TVal : notnull, INumber<TVal>
        {
            public override string IdTag => nameof(SolidAngle<TVal>);
            
            public SolidAngle() : base()
            {
                DimensionComponent.Exponents.Length = 0;
                DimensionComponent.Exponents.Mass = 0;
                DimensionComponent.Exponents.Time = 0;
                DimensionComponent.Exponents.ElectricalCurrent = 0;
                DimensionComponent.Exponents.LuminousIntensity = 0;
                DimensionComponent.Exponents.Temperature = 0;
                DimensionComponent.Exponents.Amount = 0;
                
                DefaultUnit = SolidAngleUnit.Steradian;
                
                Symbols.Add(SolidAngleUnit.Yottasteradian, "Ysr");
                Symbols.Add(SolidAngleUnit.Zettasteradian, "Zsr");
                Symbols.Add(SolidAngleUnit.Exasteradian, "Esr");
                Symbols.Add(SolidAngleUnit.Petasteradian, "Psr");
                Symbols.Add(SolidAngleUnit.Terasteradian, "Tsr");
                Symbols.Add(SolidAngleUnit.Gigasteradian, "Gsr");
                Symbols.Add(SolidAngleUnit.Megasteradian, "Msr");
                Symbols.Add(SolidAngleUnit.Kilosteradian, "ksr");
                Symbols.Add(SolidAngleUnit.Hectosteradian, "hsr");
                Symbols.Add(SolidAngleUnit.Dekasteradian, "dasr");
                Symbols.Add(SolidAngleUnit.Steradian, "sr");
                Symbols.Add(SolidAngleUnit.Decisteradian, "dsr");
                Symbols.Add(SolidAngleUnit.Centisteradian, "csr");
                Symbols.Add(SolidAngleUnit.Millisteradian, "msr");
                Symbols.Add(SolidAngleUnit.Microsteradian, "µsr");
                Symbols.Add(SolidAngleUnit.Nanosteradian, "nsr");
                Symbols.Add(SolidAngleUnit.Picosteradian, "psr");
                Symbols.Add(SolidAngleUnit.Femtosteradian, "fsr");
                Symbols.Add(SolidAngleUnit.Attosteradian, "asr");
                Symbols.Add(SolidAngleUnit.Zeptosteradian, "zsr");
                Symbols.Add(SolidAngleUnit.Yoctosteradian, "ysr");
                
                
                ConversionFunctions.Add(SolidAngleUnit.Yottasteradian, "x * 1e24");
                ConversionFunctions.Add(SolidAngleUnit.Zettasteradian, "x * 1e21");
                ConversionFunctions.Add(SolidAngleUnit.Exasteradian, "x * 1e18");
                ConversionFunctions.Add(SolidAngleUnit.Petasteradian, "x * 1e15");
                ConversionFunctions.Add(SolidAngleUnit.Terasteradian, "x * 1e12");
                ConversionFunctions.Add(SolidAngleUnit.Gigasteradian, "x * 1e9");
                ConversionFunctions.Add(SolidAngleUnit.Megasteradian, "x * 1e6");
                ConversionFunctions.Add(SolidAngleUnit.Kilosteradian, "x * 1e3");
                ConversionFunctions.Add(SolidAngleUnit.Hectosteradian, "x * 1e2");
                ConversionFunctions.Add(SolidAngleUnit.Dekasteradian, "x * 1e1");
                ConversionFunctions.Add(SolidAngleUnit.Steradian, "x * 1e0");
                ConversionFunctions.Add(SolidAngleUnit.Decisteradian, "x * 1e-1");
                ConversionFunctions.Add(SolidAngleUnit.Centisteradian, "x * 1e-2");
                ConversionFunctions.Add(SolidAngleUnit.Millisteradian, "x * 1e-3");
                ConversionFunctions.Add(SolidAngleUnit.Microsteradian, "x * 1e-6");
                ConversionFunctions.Add(SolidAngleUnit.Nanosteradian, "x * 1e-9");
                ConversionFunctions.Add(SolidAngleUnit.Picosteradian, "x * 1e-12");
                ConversionFunctions.Add(SolidAngleUnit.Femtosteradian, "x * 1e-15");
                ConversionFunctions.Add(SolidAngleUnit.Attosteradian, "x * 1e-18");
                ConversionFunctions.Add(SolidAngleUnit.Zeptosteradian, "x * 1e-21");
                ConversionFunctions.Add(SolidAngleUnit.Yoctosteradian, "x * 1e-24");
            }
        }
    }
