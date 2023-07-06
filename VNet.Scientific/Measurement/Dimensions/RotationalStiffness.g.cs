
    // Auto-generated for VNet on 2023-07-05 10:24:46
    using System.Numerics;
    
    
    namespace VNet.Scientific.Measurement.Dimensions
    {
        public sealed class RotationalStiffness<TVal> : DimensionBase<RotationalStiffnessUnit, TVal> where TVal : notnull, INumber<TVal>
        {
            public override string IdTag => nameof(RotationalStiffness<TVal>);
            
            public RotationalStiffness() : base()
            {
                DimensionComponent.Exponents.Length = 2;
                DimensionComponent.Exponents.Mass = 1;
                DimensionComponent.Exponents.Time = -2;
                DimensionComponent.Exponents.ElectricalCurrent = 0;
                DimensionComponent.Exponents.LuminousIntensity = 0;
                DimensionComponent.Exponents.Temperature = 0;
                DimensionComponent.Exponents.Amount = 0;
                
                DefaultUnit = RotationalStiffnessUnit.NewtonMeterPerRadian;
                
                
                ConversionFunctions.Add(RotationalStiffnessUnit.PoundForceFootPerDegrees, "x * 77.6826");
                ConversionFunctions.Add(RotationalStiffnessUnit.KilopoundForceFootPerDegrees, "x * 77682.6");
                ConversionFunctions.Add(RotationalStiffnessUnit.NewtonMillimeterPerDegree, "x * 180 / Math.PI * 0.001");
                ConversionFunctions.Add(RotationalStiffnessUnit.NewtonMeterPerDegree, "x * (180 / Math.PI)");
                ConversionFunctions.Add(RotationalStiffnessUnit.NewtonMillimeterPerRadian, "x * 0.001");
                ConversionFunctions.Add(RotationalStiffnessUnit.PoundForceFeetPerRadian, "x * 1.3558179483314");
                ConversionFunctions.Add(RotationalStiffnessUnit.Yottanewtonmeterperradian, "x * 1e24");
                ConversionFunctions.Add(RotationalStiffnessUnit.Zettanewtonmeterperradian, "x * 1e21");
                ConversionFunctions.Add(RotationalStiffnessUnit.Exanewtonmeterperradian, "x * 1e18");
                ConversionFunctions.Add(RotationalStiffnessUnit.Petanewtonmeterperradian, "x * 1e15");
                ConversionFunctions.Add(RotationalStiffnessUnit.Teranewtonmeterperradian, "x * 1e12");
                ConversionFunctions.Add(RotationalStiffnessUnit.Giganewtonmeterperradian, "x * 1e9");
                ConversionFunctions.Add(RotationalStiffnessUnit.Meganewtonmeterperradian, "x * 1e6");
                ConversionFunctions.Add(RotationalStiffnessUnit.Kilonewtonmeterperradian, "x * 1e3");
                ConversionFunctions.Add(RotationalStiffnessUnit.Hectonewtonmeterperradian, "x * 1e2");
                ConversionFunctions.Add(RotationalStiffnessUnit.Dekanewtonmeterperradian, "x * 1e1");
                ConversionFunctions.Add(RotationalStiffnessUnit.NewtonMeterPerRadian, "x * 1e0");
                ConversionFunctions.Add(RotationalStiffnessUnit.Decinewtonmeterperradian, "x * 1e-1");
                ConversionFunctions.Add(RotationalStiffnessUnit.Centinewtonmeterperradian, "x * 1e-2");
                ConversionFunctions.Add(RotationalStiffnessUnit.Millinewtonmeterperradian, "x * 1e-3");
                ConversionFunctions.Add(RotationalStiffnessUnit.Micronewtonmeterperradian, "x * 1e-6");
                ConversionFunctions.Add(RotationalStiffnessUnit.Nanonewtonmeterperradian, "x * 1e-9");
                ConversionFunctions.Add(RotationalStiffnessUnit.Piconewtonmeterperradian, "x * 1e-12");
                ConversionFunctions.Add(RotationalStiffnessUnit.Femtonewtonmeterperradian, "x * 1e-15");
                ConversionFunctions.Add(RotationalStiffnessUnit.Attonewtonmeterperradian, "x * 1e-18");
                ConversionFunctions.Add(RotationalStiffnessUnit.Zeptonewtonmeterperradian, "x * 1e-21");
                ConversionFunctions.Add(RotationalStiffnessUnit.Yoctonewtonmeterperradian, "x * 1e-24");
            }
        }
    }
