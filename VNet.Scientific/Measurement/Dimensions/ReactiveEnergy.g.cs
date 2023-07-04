
    // Auto-generated for VNet on 2023-07-03 11:25:32
    using System.Numerics;
    
    
    namespace VNet.Scientific.Measurement.Dimensions
    {
        public sealed class ReactiveEnergy<TVal> : DimensionBase<ReactiveEnergyUnit, TVal> where TVal : notnull, INumber<TVal>
        {
            public override string IdTag => nameof(ReactiveEnergy<TVal>);
            
            public ReactiveEnergy() : base()
            {
                DimensionComponent.Exponents.Length = 2;
                DimensionComponent.Exponents.Mass = 1;
                DimensionComponent.Exponents.Time = -1;
                DimensionComponent.Exponents.ElectricalCurrent = 0;
                DimensionComponent.Exponents.LuminousIntensity = 0;
                DimensionComponent.Exponents.Temperature = 0;
                DimensionComponent.Exponents.Amount = 0;
                
                DefaultUnit = ReactiveEnergyUnit.VoltampereReactiveHour;
                
                
                _conversionFunctions.Add("YottaVoltampereReactiveHour", "x * 1e24");
                _conversionFunctions.Add("ZettaVoltampereReactiveHour", "x * 1e21");
                _conversionFunctions.Add("ExaVoltampereReactiveHour", "x * 1e18");
                _conversionFunctions.Add("PetaVoltampereReactiveHour", "x * 1e15");
                _conversionFunctions.Add("TeraVoltampereReactiveHour", "x * 1e12");
                _conversionFunctions.Add("GigaVoltampereReactiveHour", "x * 1e9");
                _conversionFunctions.Add("MegaVoltampereReactiveHour", "x * 1e6");
                _conversionFunctions.Add("KiloVoltampereReactiveHour", "x * 1e3");
                _conversionFunctions.Add("HectoVoltampereReactiveHour", "x * 1e2");
                _conversionFunctions.Add("DekaVoltampereReactiveHour", "x * 1e1");
                _conversionFunctions.Add("VoltampereReactiveHour", "x * 1e0");
                _conversionFunctions.Add("DeciVoltampereReactiveHour", "x * 1e-1");
                _conversionFunctions.Add("CentiVoltampereReactiveHour", "x * 1e-2");
                _conversionFunctions.Add("MilliVoltampereReactiveHour", "x * 1e-3");
                _conversionFunctions.Add("MicroVoltampereReactiveHour", "x * 1e-6");
                _conversionFunctions.Add("NanoVoltampereReactiveHour", "x * 1e-9");
                _conversionFunctions.Add("PicoVoltampereReactiveHour", "x * 1e-12");
                _conversionFunctions.Add("FemtoVoltampereReactiveHour", "x * 1e-15");
                _conversionFunctions.Add("AttoVoltampereReactiveHour", "x * 1e-18");
                _conversionFunctions.Add("ZeptoVoltampereReactiveHour", "x * 1e-21");
                _conversionFunctions.Add("YoctoVoltampereReactiveHour", "x * 1e-24");
            }
        }
    }
