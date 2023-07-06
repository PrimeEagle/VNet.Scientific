
    // Auto-generated for VNet on 2023-07-05 10:35:43
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
                
                Symbols.Add(TorqueUnit.NewtonMillimeter, "N·mm");
                Symbols.Add(TorqueUnit.NewtonCentimeter, "N·cm");
                Symbols.Add(TorqueUnit.PoundalFoot, "pdl·ft");
                Symbols.Add(TorqueUnit.PoundForceInch, "lbf·in");
                Symbols.Add(TorqueUnit.PoundForceFoot, "lbf·ft");
                Symbols.Add(TorqueUnit.GramForceMillimeter, "gf·mm");
                Symbols.Add(TorqueUnit.GramForceCentimeter, "gf·cm");
                Symbols.Add(TorqueUnit.GramForceMeter, "gf·m");
                Symbols.Add(TorqueUnit.KilogramForceMillimeter, "kgf·mm");
                Symbols.Add(TorqueUnit.KilogramForceCentimeter, "kgf·cm");
                Symbols.Add(TorqueUnit.KilogramForceMeter, "kgf·m");
                Symbols.Add(TorqueUnit.TonneForceMillimeter, "tf·mm");
                Symbols.Add(TorqueUnit.TonneForceCentimeter, "tf·cm");
                Symbols.Add(TorqueUnit.TonneForceMeter, "tf·m");
                Symbols.Add(TorqueUnit.Yottanewtonmeter, "YN·m");
                Symbols.Add(TorqueUnit.Zettanewtonmeter, "ZN·m");
                Symbols.Add(TorqueUnit.Exanewtonmeter, "EN·m");
                Symbols.Add(TorqueUnit.Petanewtonmeter, "PN·m");
                Symbols.Add(TorqueUnit.Teranewtonmeter, "TN·m");
                Symbols.Add(TorqueUnit.Giganewtonmeter, "GN·m");
                Symbols.Add(TorqueUnit.Meganewtonmeter, "MN·m");
                Symbols.Add(TorqueUnit.Kilonewtonmeter, "kN·m");
                Symbols.Add(TorqueUnit.Hectonewtonmeter, "hN·m");
                Symbols.Add(TorqueUnit.Dekanewtonmeter, "daN·m");
                Symbols.Add(TorqueUnit.NewtonMeter, "N·m");
                Symbols.Add(TorqueUnit.Decinewtonmeter, "dN·m");
                Symbols.Add(TorqueUnit.Centinewtonmeter, "cN·m");
                Symbols.Add(TorqueUnit.Millinewtonmeter, "mN·m");
                Symbols.Add(TorqueUnit.Micronewtonmeter, "µN·m");
                Symbols.Add(TorqueUnit.Nanonewtonmeter, "nN·m");
                Symbols.Add(TorqueUnit.Piconewtonmeter, "pN·m");
                Symbols.Add(TorqueUnit.Femtonewtonmeter, "fN·m");
                Symbols.Add(TorqueUnit.Attonewtonmeter, "aN·m");
                Symbols.Add(TorqueUnit.Zeptonewtonmeter, "zN·m");
                Symbols.Add(TorqueUnit.Yoctonewtonmeter, "yN·m");
                
                
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
