
    // Auto-generated for VNet on 2023-07-05 10:24:46
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
