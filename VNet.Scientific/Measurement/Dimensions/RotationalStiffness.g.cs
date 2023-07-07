
    // Auto-generated for VNet on 2023-07-06 12:42:23
    using System.Numerics;
    
    
    namespace VNet.Scientific.Measurement.Dimensions
    {
        public sealed class RotationalStiffness<TVal> : DimensionBase<RotationalStiffnessUnit, TVal> where TVal : notnull, INumber<TVal>
        {
            public override string IdTag => nameof(RotationalStiffness<TVal>);
            
            public RotationalStiffness() : base()
            {
                Exponents.Length = 2;
                Exponents.Mass = 1;
                Exponents.Time = -2;
                Exponents.ElectricalCurrent = 0;
                Exponents.LuminousIntensity = 0;
                Exponents.Temperature = 0;
                Exponents.Amount = 0;
                
                DefaultUnit = RotationalStiffnessUnit.NewtonMeterPerRadian;
                
                Symbols.Add(RotationalStiffnessUnit.PoundForceFootPerDegrees, "lbf·ft/deg");
                Symbols.Add(RotationalStiffnessUnit.KilopoundForceFootPerDegrees, "kipf·ft/°");
                Symbols.Add(RotationalStiffnessUnit.NewtonMillimeterPerDegree, "N·mm/deg");
                Symbols.Add(RotationalStiffnessUnit.NewtonMeterPerDegree, "N·m/deg");
                Symbols.Add(RotationalStiffnessUnit.NewtonMillimeterPerRadian, "N·mm/rad");
                Symbols.Add(RotationalStiffnessUnit.PoundForceFeetPerRadian, "lbf·ft/rad");
                Symbols.Add(RotationalStiffnessUnit.Yottanewtonmeterperradian, "YN·m/rad");
                Symbols.Add(RotationalStiffnessUnit.Zettanewtonmeterperradian, "ZN·m/rad");
                Symbols.Add(RotationalStiffnessUnit.Exanewtonmeterperradian, "EN·m/rad");
                Symbols.Add(RotationalStiffnessUnit.Petanewtonmeterperradian, "PN·m/rad");
                Symbols.Add(RotationalStiffnessUnit.Teranewtonmeterperradian, "TN·m/rad");
                Symbols.Add(RotationalStiffnessUnit.Giganewtonmeterperradian, "GN·m/rad");
                Symbols.Add(RotationalStiffnessUnit.Meganewtonmeterperradian, "MN·m/rad");
                Symbols.Add(RotationalStiffnessUnit.Kilonewtonmeterperradian, "kN·m/rad");
                Symbols.Add(RotationalStiffnessUnit.Hectonewtonmeterperradian, "hN·m/rad");
                Symbols.Add(RotationalStiffnessUnit.Dekanewtonmeterperradian, "daN·m/rad");
                Symbols.Add(RotationalStiffnessUnit.NewtonMeterPerRadian, "N·m/rad");
                Symbols.Add(RotationalStiffnessUnit.Decinewtonmeterperradian, "dN·m/rad");
                Symbols.Add(RotationalStiffnessUnit.Centinewtonmeterperradian, "cN·m/rad");
                Symbols.Add(RotationalStiffnessUnit.Millinewtonmeterperradian, "mN·m/rad");
                Symbols.Add(RotationalStiffnessUnit.Micronewtonmeterperradian, "µN·m/rad");
                Symbols.Add(RotationalStiffnessUnit.Nanonewtonmeterperradian, "nN·m/rad");
                Symbols.Add(RotationalStiffnessUnit.Piconewtonmeterperradian, "pN·m/rad");
                Symbols.Add(RotationalStiffnessUnit.Femtonewtonmeterperradian, "fN·m/rad");
                Symbols.Add(RotationalStiffnessUnit.Attonewtonmeterperradian, "aN·m/rad");
                Symbols.Add(RotationalStiffnessUnit.Zeptonewtonmeterperradian, "zN·m/rad");
                Symbols.Add(RotationalStiffnessUnit.Yoctonewtonmeterperradian, "yN·m/rad");
                
                PluralSymbols.Add(RotationalStiffnessUnit.KilopoundForceFootPerDegrees, "kip·ft/°g");
                PluralSymbols.Add(RotationalStiffnessUnit.NewtonMillimeterPerDegree, "Nmm/deg");
                PluralSymbols.Add(RotationalStiffnessUnit.NewtonMeterPerDegree, "Nm/deg");
                PluralSymbols.Add(RotationalStiffnessUnit.NewtonMillimeterPerRadian, "Nmm/rad");
                PluralSymbols.Add(RotationalStiffnessUnit.Yottanewtonmeterperradian, "YNm/rad");
                PluralSymbols.Add(RotationalStiffnessUnit.Zettanewtonmeterperradian, "ZNm/rad");
                PluralSymbols.Add(RotationalStiffnessUnit.Exanewtonmeterperradian, "ENm/rad");
                PluralSymbols.Add(RotationalStiffnessUnit.Petanewtonmeterperradian, "PNm/rad");
                PluralSymbols.Add(RotationalStiffnessUnit.Teranewtonmeterperradian, "TNm/rad");
                PluralSymbols.Add(RotationalStiffnessUnit.Giganewtonmeterperradian, "GNm/rad");
                PluralSymbols.Add(RotationalStiffnessUnit.Meganewtonmeterperradian, "MNm/rad");
                PluralSymbols.Add(RotationalStiffnessUnit.Kilonewtonmeterperradian, "kNm/rad");
                PluralSymbols.Add(RotationalStiffnessUnit.Hectonewtonmeterperradian, "hNm/rad");
                PluralSymbols.Add(RotationalStiffnessUnit.Dekanewtonmeterperradian, "daNm/rad");
                PluralSymbols.Add(RotationalStiffnessUnit.NewtonMeterPerRadian, "Nm/rad");
                PluralSymbols.Add(RotationalStiffnessUnit.Decinewtonmeterperradian, "dNm/rad");
                PluralSymbols.Add(RotationalStiffnessUnit.Centinewtonmeterperradian, "cNm/rad");
                PluralSymbols.Add(RotationalStiffnessUnit.Millinewtonmeterperradian, "mNm/rad");
                PluralSymbols.Add(RotationalStiffnessUnit.Micronewtonmeterperradian, "µNm/rad");
                PluralSymbols.Add(RotationalStiffnessUnit.Nanonewtonmeterperradian, "nNm/rad");
                PluralSymbols.Add(RotationalStiffnessUnit.Piconewtonmeterperradian, "pNm/rad");
                PluralSymbols.Add(RotationalStiffnessUnit.Femtonewtonmeterperradian, "fNm/rad");
                PluralSymbols.Add(RotationalStiffnessUnit.Attonewtonmeterperradian, "aNm/rad");
                PluralSymbols.Add(RotationalStiffnessUnit.Zeptonewtonmeterperradian, "zNm/rad");
                PluralSymbols.Add(RotationalStiffnessUnit.Yoctonewtonmeterperradian, "yNm/rad");
                
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
