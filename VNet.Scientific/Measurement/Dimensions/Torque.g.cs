
    // Auto-generated for VNet on 2023-07-05 10:24:46
    using System.Numerics;
    
    
    namespace VNet.Scientific.Measurement.Dimensions
    {
        public sealed class Torque<TVal> : DimensionBase<TorqueUnit, TVal> where TVal : notnull, INumber<TVal>
        {
            public override string IdTag => nameof(Torque<TVal>);
            
            public Torque() : base()
            {
                DimensionComponent.Exponents.Length = 2;
                DimensionComponent.Exponents.Mass = 1;
                DimensionComponent.Exponents.Time = -2;
                DimensionComponent.Exponents.ElectricalCurrent = 0;
                DimensionComponent.Exponents.LuminousIntensity = 0;
                DimensionComponent.Exponents.Temperature = 0;
                DimensionComponent.Exponents.Amount = 0;
                
                DefaultUnit = TorqueUnit.NewtonMeter;
                
                
                ConversionFunctions.Add(TorqueUnit.NewtonMillimeter, "x * 0.001");
                ConversionFunctions.Add(TorqueUnit.NewtonCentimeter, "x * 0.01");
                ConversionFunctions.Add(TorqueUnit.PoundalFoot, "x * 4.21401100938048e-2");
                ConversionFunctions.Add(TorqueUnit.PoundForceInch, "x * 1.129848290276167e-1");
                ConversionFunctions.Add(TorqueUnit.PoundForceFoot, "x * 1.3558179483314");
                ConversionFunctions.Add(TorqueUnit.GramForceMillimeter, "x * 9.80665e-6");
                ConversionFunctions.Add(TorqueUnit.GramForceCentimeter, "x * 9.80665e-5");
                ConversionFunctions.Add(TorqueUnit.GramForceMeter, "x * 9.80665e-3");
                ConversionFunctions.Add(TorqueUnit.KilogramForceMillimeter, "x * 9.80665e-3");
                ConversionFunctions.Add(TorqueUnit.KilogramForceCentimeter, "x * 9.80665e-2");
                ConversionFunctions.Add(TorqueUnit.KilogramForceMeter, "x * 9.80665");
                ConversionFunctions.Add(TorqueUnit.TonneForceMillimeter, "x * 9.80665");
                ConversionFunctions.Add(TorqueUnit.TonneForceCentimeter, "x * 9.80665e1");
                ConversionFunctions.Add(TorqueUnit.TonneForceMeter, "x * 9.80665e3");
                ConversionFunctions.Add(TorqueUnit.Yottanewtonmeter, "x * 1e24");
                ConversionFunctions.Add(TorqueUnit.Zettanewtonmeter, "x * 1e21");
                ConversionFunctions.Add(TorqueUnit.Exanewtonmeter, "x * 1e18");
                ConversionFunctions.Add(TorqueUnit.Petanewtonmeter, "x * 1e15");
                ConversionFunctions.Add(TorqueUnit.Teranewtonmeter, "x * 1e12");
                ConversionFunctions.Add(TorqueUnit.Giganewtonmeter, "x * 1e9");
                ConversionFunctions.Add(TorqueUnit.Meganewtonmeter, "x * 1e6");
                ConversionFunctions.Add(TorqueUnit.Kilonewtonmeter, "x * 1e3");
                ConversionFunctions.Add(TorqueUnit.Hectonewtonmeter, "x * 1e2");
                ConversionFunctions.Add(TorqueUnit.Dekanewtonmeter, "x * 1e1");
                ConversionFunctions.Add(TorqueUnit.NewtonMeter, "x * 1e0");
                ConversionFunctions.Add(TorqueUnit.Decinewtonmeter, "x * 1e-1");
                ConversionFunctions.Add(TorqueUnit.Centinewtonmeter, "x * 1e-2");
                ConversionFunctions.Add(TorqueUnit.Millinewtonmeter, "x * 1e-3");
                ConversionFunctions.Add(TorqueUnit.Micronewtonmeter, "x * 1e-6");
                ConversionFunctions.Add(TorqueUnit.Nanonewtonmeter, "x * 1e-9");
                ConversionFunctions.Add(TorqueUnit.Piconewtonmeter, "x * 1e-12");
                ConversionFunctions.Add(TorqueUnit.Femtonewtonmeter, "x * 1e-15");
                ConversionFunctions.Add(TorqueUnit.Attonewtonmeter, "x * 1e-18");
                ConversionFunctions.Add(TorqueUnit.Zeptonewtonmeter, "x * 1e-21");
                ConversionFunctions.Add(TorqueUnit.Yoctonewtonmeter, "x * 1e-24");
            }
        }
    }
