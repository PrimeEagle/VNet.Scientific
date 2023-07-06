
    // Auto-generated for VNet on 2023-07-05 10:24:46
    using System.Numerics;
    
    
    namespace VNet.Scientific.Measurement.Dimensions
    {
        public sealed class RotationalStiffnessPerLength<TVal> : DimensionBase<RotationalStiffnessPerLengthUnit, TVal> where TVal : notnull, INumber<TVal>
        {
            public override string IdTag => nameof(RotationalStiffnessPerLength<TVal>);
            
            public RotationalStiffnessPerLength() : base()
            {
                DimensionComponent.Exponents.Length = 1;
                DimensionComponent.Exponents.Mass = 1;
                DimensionComponent.Exponents.Time = -2;
                DimensionComponent.Exponents.ElectricalCurrent = 0;
                DimensionComponent.Exponents.LuminousIntensity = 0;
                DimensionComponent.Exponents.Temperature = 0;
                DimensionComponent.Exponents.Amount = 0;
                
                DefaultUnit = RotationalStiffnessPerLengthUnit.NewtonMeterPerRadianPerMeter;
                
                
                ConversionFunctions.Add(RotationalStiffnessPerLengthUnit.PoundForceFootPerDegreesPerFoot, "x * 254.864324570");
                ConversionFunctions.Add(RotationalStiffnessPerLengthUnit.KilopoundForceFootPerDegreesPerFoot, "x * 254864.324570");
                ConversionFunctions.Add(RotationalStiffnessPerLengthUnit.Yottanewtonmeterperradianpermeter, "x * 1e24");
                ConversionFunctions.Add(RotationalStiffnessPerLengthUnit.Zettanewtonmeterperradianpermeter, "x * 1e21");
                ConversionFunctions.Add(RotationalStiffnessPerLengthUnit.Exanewtonmeterperradianpermeter, "x * 1e18");
                ConversionFunctions.Add(RotationalStiffnessPerLengthUnit.Petanewtonmeterperradianpermeter, "x * 1e15");
                ConversionFunctions.Add(RotationalStiffnessPerLengthUnit.Teranewtonmeterperradianpermeter, "x * 1e12");
                ConversionFunctions.Add(RotationalStiffnessPerLengthUnit.Giganewtonmeterperradianpermeter, "x * 1e9");
                ConversionFunctions.Add(RotationalStiffnessPerLengthUnit.Meganewtonmeterperradianpermeter, "x * 1e6");
                ConversionFunctions.Add(RotationalStiffnessPerLengthUnit.Kilonewtonmeterperradianpermeter, "x * 1e3");
                ConversionFunctions.Add(RotationalStiffnessPerLengthUnit.Hectonewtonmeterperradianpermeter, "x * 1e2");
                ConversionFunctions.Add(RotationalStiffnessPerLengthUnit.Dekanewtonmeterperradianpermeter, "x * 1e1");
                ConversionFunctions.Add(RotationalStiffnessPerLengthUnit.NewtonMeterPerRadianPerMeter, "x * 1e0");
                ConversionFunctions.Add(RotationalStiffnessPerLengthUnit.Decinewtonmeterperradianpermeter, "x * 1e-1");
                ConversionFunctions.Add(RotationalStiffnessPerLengthUnit.Centinewtonmeterperradianpermeter, "x * 1e-2");
                ConversionFunctions.Add(RotationalStiffnessPerLengthUnit.Millinewtonmeterperradianpermeter, "x * 1e-3");
                ConversionFunctions.Add(RotationalStiffnessPerLengthUnit.Micronewtonmeterperradianpermeter, "x * 1e-6");
                ConversionFunctions.Add(RotationalStiffnessPerLengthUnit.Nanonewtonmeterperradianpermeter, "x * 1e-9");
                ConversionFunctions.Add(RotationalStiffnessPerLengthUnit.Piconewtonmeterperradianpermeter, "x * 1e-12");
                ConversionFunctions.Add(RotationalStiffnessPerLengthUnit.Femtonewtonmeterperradianpermeter, "x * 1e-15");
                ConversionFunctions.Add(RotationalStiffnessPerLengthUnit.Attonewtonmeterperradianpermeter, "x * 1e-18");
                ConversionFunctions.Add(RotationalStiffnessPerLengthUnit.Zeptonewtonmeterperradianpermeter, "x * 1e-21");
                ConversionFunctions.Add(RotationalStiffnessPerLengthUnit.Yoctonewtonmeterperradianpermeter, "x * 1e-24");
            }
        }
    }
