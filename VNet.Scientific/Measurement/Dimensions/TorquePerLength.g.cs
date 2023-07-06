
    // Auto-generated for VNet on 2023-07-05 10:35:43
    using System.Numerics;
    
    
    namespace VNet.Scientific.Measurement.Dimensions
    {
        public sealed class TorquePerLength<TVal> : DimensionBase<TorquePerLengthUnit, TVal> where TVal : notnull, INumber<TVal>
        {
            public override string IdTag => nameof(TorquePerLength<TVal>);
            
            public TorquePerLength() : base()
            {
                DimensionComponent.Exponents.Length = 1;
                DimensionComponent.Exponents.Mass = 1;
                DimensionComponent.Exponents.Time = -2;
                DimensionComponent.Exponents.ElectricalCurrent = 0;
                DimensionComponent.Exponents.LuminousIntensity = 0;
                DimensionComponent.Exponents.Temperature = 0;
                DimensionComponent.Exponents.Amount = 0;
                
                DefaultUnit = TorquePerLengthUnit.NewtonMeterPerMeter;
                
                Symbols.Add(TorquePerLengthUnit.NewtonMillimeterPerMeter, "N·mm/m");
                Symbols.Add(TorquePerLengthUnit.NewtonCentimeterPerMeter, "N·cm/m");
                Symbols.Add(TorquePerLengthUnit.PoundForceInchPerFoot, "lbf·in/ft");
                Symbols.Add(TorquePerLengthUnit.PoundForceFootPerFoot, "lbf·ft/ft");
                Symbols.Add(TorquePerLengthUnit.KilogramForceMillimeterPerMeter, "kgf·mm/m");
                Symbols.Add(TorquePerLengthUnit.KilogramForceCentimeterPerMeter, "kgf·cm/m");
                Symbols.Add(TorquePerLengthUnit.KilogramForceMeterPerMeter, "kgf·m/m");
                Symbols.Add(TorquePerLengthUnit.TonneForceMillimeterPerMeter, "tf·mm/m");
                Symbols.Add(TorquePerLengthUnit.TonneForceCentimeterPerMeter, "tf·cm/m");
                Symbols.Add(TorquePerLengthUnit.TonneForceMeterPerMeter, "tf·m/m");
                Symbols.Add(TorquePerLengthUnit.Yottanewtonmeterpermeter, "YN·m/m");
                Symbols.Add(TorquePerLengthUnit.Zettanewtonmeterpermeter, "ZN·m/m");
                Symbols.Add(TorquePerLengthUnit.Exanewtonmeterpermeter, "EN·m/m");
                Symbols.Add(TorquePerLengthUnit.Petanewtonmeterpermeter, "PN·m/m");
                Symbols.Add(TorquePerLengthUnit.Teranewtonmeterpermeter, "TN·m/m");
                Symbols.Add(TorquePerLengthUnit.Giganewtonmeterpermeter, "GN·m/m");
                Symbols.Add(TorquePerLengthUnit.Meganewtonmeterpermeter, "MN·m/m");
                Symbols.Add(TorquePerLengthUnit.Kilonewtonmeterpermeter, "kN·m/m");
                Symbols.Add(TorquePerLengthUnit.Hectonewtonmeterpermeter, "hN·m/m");
                Symbols.Add(TorquePerLengthUnit.Dekanewtonmeterpermeter, "daN·m/m");
                Symbols.Add(TorquePerLengthUnit.NewtonMeterPerMeter, "N·m/m");
                Symbols.Add(TorquePerLengthUnit.Decinewtonmeterpermeter, "dN·m/m");
                Symbols.Add(TorquePerLengthUnit.Centinewtonmeterpermeter, "cN·m/m");
                Symbols.Add(TorquePerLengthUnit.Millinewtonmeterpermeter, "mN·m/m");
                Symbols.Add(TorquePerLengthUnit.Micronewtonmeterpermeter, "µN·m/m");
                Symbols.Add(TorquePerLengthUnit.Nanonewtonmeterpermeter, "nN·m/m");
                Symbols.Add(TorquePerLengthUnit.Piconewtonmeterpermeter, "pN·m/m");
                Symbols.Add(TorquePerLengthUnit.Femtonewtonmeterpermeter, "fN·m/m");
                Symbols.Add(TorquePerLengthUnit.Attonewtonmeterpermeter, "aN·m/m");
                Symbols.Add(TorquePerLengthUnit.Zeptonewtonmeterpermeter, "zN·m/m");
                Symbols.Add(TorquePerLengthUnit.Yoctonewtonmeterpermeter, "yN·m/m");
                
                
                ConversionFunctions.Add(TorquePerLengthUnit.NewtonMillimeterPerMeter, "x * 0.001");
                ConversionFunctions.Add(TorquePerLengthUnit.NewtonCentimeterPerMeter, "x * 0.01");
                ConversionFunctions.Add(TorquePerLengthUnit.PoundForceInchPerFoot, "x * 0.370685147638");
                ConversionFunctions.Add(TorquePerLengthUnit.PoundForceFootPerFoot, "x * 4.44822161526");
                ConversionFunctions.Add(TorquePerLengthUnit.KilogramForceMillimeterPerMeter, "x * 0.00980665019960652");
                ConversionFunctions.Add(TorquePerLengthUnit.KilogramForceCentimeterPerMeter, "x * 0.0980665019960652");
                ConversionFunctions.Add(TorquePerLengthUnit.KilogramForceMeterPerMeter, "x * 9.80665019960652");
                ConversionFunctions.Add(TorquePerLengthUnit.TonneForceMillimeterPerMeter, "x * 9.80665019960652");
                ConversionFunctions.Add(TorquePerLengthUnit.TonneForceCentimeterPerMeter, "x * 98.0665019960652");
                ConversionFunctions.Add(TorquePerLengthUnit.TonneForceMeterPerMeter, "x * 9806.65019960653");
                ConversionFunctions.Add(TorquePerLengthUnit.Yottanewtonmeterpermeter, "x * 1e24");
                ConversionFunctions.Add(TorquePerLengthUnit.Zettanewtonmeterpermeter, "x * 1e21");
                ConversionFunctions.Add(TorquePerLengthUnit.Exanewtonmeterpermeter, "x * 1e18");
                ConversionFunctions.Add(TorquePerLengthUnit.Petanewtonmeterpermeter, "x * 1e15");
                ConversionFunctions.Add(TorquePerLengthUnit.Teranewtonmeterpermeter, "x * 1e12");
                ConversionFunctions.Add(TorquePerLengthUnit.Giganewtonmeterpermeter, "x * 1e9");
                ConversionFunctions.Add(TorquePerLengthUnit.Meganewtonmeterpermeter, "x * 1e6");
                ConversionFunctions.Add(TorquePerLengthUnit.Kilonewtonmeterpermeter, "x * 1e3");
                ConversionFunctions.Add(TorquePerLengthUnit.Hectonewtonmeterpermeter, "x * 1e2");
                ConversionFunctions.Add(TorquePerLengthUnit.Dekanewtonmeterpermeter, "x * 1e1");
                ConversionFunctions.Add(TorquePerLengthUnit.NewtonMeterPerMeter, "x * 1e0");
                ConversionFunctions.Add(TorquePerLengthUnit.Decinewtonmeterpermeter, "x * 1e-1");
                ConversionFunctions.Add(TorquePerLengthUnit.Centinewtonmeterpermeter, "x * 1e-2");
                ConversionFunctions.Add(TorquePerLengthUnit.Millinewtonmeterpermeter, "x * 1e-3");
                ConversionFunctions.Add(TorquePerLengthUnit.Micronewtonmeterpermeter, "x * 1e-6");
                ConversionFunctions.Add(TorquePerLengthUnit.Nanonewtonmeterpermeter, "x * 1e-9");
                ConversionFunctions.Add(TorquePerLengthUnit.Piconewtonmeterpermeter, "x * 1e-12");
                ConversionFunctions.Add(TorquePerLengthUnit.Femtonewtonmeterpermeter, "x * 1e-15");
                ConversionFunctions.Add(TorquePerLengthUnit.Attonewtonmeterpermeter, "x * 1e-18");
                ConversionFunctions.Add(TorquePerLengthUnit.Zeptonewtonmeterpermeter, "x * 1e-21");
                ConversionFunctions.Add(TorquePerLengthUnit.Yoctonewtonmeterpermeter, "x * 1e-24");
            }
        }
    }
