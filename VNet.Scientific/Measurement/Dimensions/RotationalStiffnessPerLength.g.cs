
    // Auto-generated for VNet on 2023-07-05 10:35:43
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
                
                Symbols.Add(RotationalStiffnessPerLengthUnit.PoundForceFootPerDegreesPerFoot, "lbf·ft/deg/ft");
                Symbols.Add(RotationalStiffnessPerLengthUnit.KilopoundForceFootPerDegreesPerFoot, "kipf·ft/°/ft");
                Symbols.Add(RotationalStiffnessPerLengthUnit.Yottanewtonmeterperradianpermeter, "YN·m/rad/m");
                Symbols.Add(RotationalStiffnessPerLengthUnit.Zettanewtonmeterperradianpermeter, "ZN·m/rad/m");
                Symbols.Add(RotationalStiffnessPerLengthUnit.Exanewtonmeterperradianpermeter, "EN·m/rad/m");
                Symbols.Add(RotationalStiffnessPerLengthUnit.Petanewtonmeterperradianpermeter, "PN·m/rad/m");
                Symbols.Add(RotationalStiffnessPerLengthUnit.Teranewtonmeterperradianpermeter, "TN·m/rad/m");
                Symbols.Add(RotationalStiffnessPerLengthUnit.Giganewtonmeterperradianpermeter, "GN·m/rad/m");
                Symbols.Add(RotationalStiffnessPerLengthUnit.Meganewtonmeterperradianpermeter, "MN·m/rad/m");
                Symbols.Add(RotationalStiffnessPerLengthUnit.Kilonewtonmeterperradianpermeter, "kN·m/rad/m");
                Symbols.Add(RotationalStiffnessPerLengthUnit.Hectonewtonmeterperradianpermeter, "hN·m/rad/m");
                Symbols.Add(RotationalStiffnessPerLengthUnit.Dekanewtonmeterperradianpermeter, "daN·m/rad/m");
                Symbols.Add(RotationalStiffnessPerLengthUnit.NewtonMeterPerRadianPerMeter, "N·m/rad/m");
                Symbols.Add(RotationalStiffnessPerLengthUnit.Decinewtonmeterperradianpermeter, "dN·m/rad/m");
                Symbols.Add(RotationalStiffnessPerLengthUnit.Centinewtonmeterperradianpermeter, "cN·m/rad/m");
                Symbols.Add(RotationalStiffnessPerLengthUnit.Millinewtonmeterperradianpermeter, "mN·m/rad/m");
                Symbols.Add(RotationalStiffnessPerLengthUnit.Micronewtonmeterperradianpermeter, "µN·m/rad/m");
                Symbols.Add(RotationalStiffnessPerLengthUnit.Nanonewtonmeterperradianpermeter, "nN·m/rad/m");
                Symbols.Add(RotationalStiffnessPerLengthUnit.Piconewtonmeterperradianpermeter, "pN·m/rad/m");
                Symbols.Add(RotationalStiffnessPerLengthUnit.Femtonewtonmeterperradianpermeter, "fN·m/rad/m");
                Symbols.Add(RotationalStiffnessPerLengthUnit.Attonewtonmeterperradianpermeter, "aN·m/rad/m");
                Symbols.Add(RotationalStiffnessPerLengthUnit.Zeptonewtonmeterperradianpermeter, "zN·m/rad/m");
                Symbols.Add(RotationalStiffnessPerLengthUnit.Yoctonewtonmeterperradianpermeter, "yN·m/rad/m");
                
                PluralSymbols.Add(RotationalStiffnessPerLengthUnit.KilopoundForceFootPerDegreesPerFoot, "kip·ft/°/ft");
                PluralSymbols.Add(RotationalStiffnessPerLengthUnit.Yottanewtonmeterperradianpermeter, "YNm/rad/m");
                PluralSymbols.Add(RotationalStiffnessPerLengthUnit.Zettanewtonmeterperradianpermeter, "ZNm/rad/m");
                PluralSymbols.Add(RotationalStiffnessPerLengthUnit.Exanewtonmeterperradianpermeter, "ENm/rad/m");
                PluralSymbols.Add(RotationalStiffnessPerLengthUnit.Petanewtonmeterperradianpermeter, "PNm/rad/m");
                PluralSymbols.Add(RotationalStiffnessPerLengthUnit.Teranewtonmeterperradianpermeter, "TNm/rad/m");
                PluralSymbols.Add(RotationalStiffnessPerLengthUnit.Giganewtonmeterperradianpermeter, "GNm/rad/m");
                PluralSymbols.Add(RotationalStiffnessPerLengthUnit.Meganewtonmeterperradianpermeter, "MNm/rad/m");
                PluralSymbols.Add(RotationalStiffnessPerLengthUnit.Kilonewtonmeterperradianpermeter, "kNm/rad/m");
                PluralSymbols.Add(RotationalStiffnessPerLengthUnit.Hectonewtonmeterperradianpermeter, "hNm/rad/m");
                PluralSymbols.Add(RotationalStiffnessPerLengthUnit.Dekanewtonmeterperradianpermeter, "daNm/rad/m");
                PluralSymbols.Add(RotationalStiffnessPerLengthUnit.NewtonMeterPerRadianPerMeter, "Nm/rad/m");
                PluralSymbols.Add(RotationalStiffnessPerLengthUnit.Decinewtonmeterperradianpermeter, "dNm/rad/m");
                PluralSymbols.Add(RotationalStiffnessPerLengthUnit.Centinewtonmeterperradianpermeter, "cNm/rad/m");
                PluralSymbols.Add(RotationalStiffnessPerLengthUnit.Millinewtonmeterperradianpermeter, "mNm/rad/m");
                PluralSymbols.Add(RotationalStiffnessPerLengthUnit.Micronewtonmeterperradianpermeter, "µNm/rad/m");
                PluralSymbols.Add(RotationalStiffnessPerLengthUnit.Nanonewtonmeterperradianpermeter, "nNm/rad/m");
                PluralSymbols.Add(RotationalStiffnessPerLengthUnit.Piconewtonmeterperradianpermeter, "pNm/rad/m");
                PluralSymbols.Add(RotationalStiffnessPerLengthUnit.Femtonewtonmeterperradianpermeter, "fNm/rad/m");
                PluralSymbols.Add(RotationalStiffnessPerLengthUnit.Attonewtonmeterperradianpermeter, "aNm/rad/m");
                PluralSymbols.Add(RotationalStiffnessPerLengthUnit.Zeptonewtonmeterperradianpermeter, "zNm/rad/m");
                PluralSymbols.Add(RotationalStiffnessPerLengthUnit.Yoctonewtonmeterperradianpermeter, "yNm/rad/m");
                
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
