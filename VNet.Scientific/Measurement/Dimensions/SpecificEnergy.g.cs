
    // Auto-generated for VNet on 2023-07-03 11:25:32
    using System.Numerics;
    
    
    namespace VNet.Scientific.Measurement.Dimensions
    {
        public sealed class SpecificEnergy<TVal> : DimensionBase<SpecificEnergyUnit, TVal> where TVal : notnull, INumber<TVal>
        {
            public override string IdTag => nameof(SpecificEnergy<TVal>);
            
            public SpecificEnergy() : base()
            {
                DimensionComponent.Exponents.Length = 2;
                DimensionComponent.Exponents.Mass = 0;
                DimensionComponent.Exponents.Time = -2;
                DimensionComponent.Exponents.ElectricalCurrent = 0;
                DimensionComponent.Exponents.LuminousIntensity = 0;
                DimensionComponent.Exponents.Temperature = 0;
                DimensionComponent.Exponents.Amount = 0;
                
                DefaultUnit = SpecificEnergyUnit.JoulePerKilogram;
                
                
                _conversionFunctions.Add("MegaJoulePerTonne", "x * 1e3");
                _conversionFunctions.Add("CaloriePerGram", "x * 4.184e3");
                _conversionFunctions.Add("WattHourPerKilogram", "x * 3.6e3");
                _conversionFunctions.Add("WattDayPerKilogram", "x * (24 * 3.6e3)");
                _conversionFunctions.Add("WattDayPerTonne", "x * ((24 * 3.6e3) / 1e3)");
                _conversionFunctions.Add("WattDayPerShortTon", "x * ((24 * 3.6e3) / 9.0718474e2)");
                _conversionFunctions.Add("WattHourPerPound", "x * 7.93664e3");
                _conversionFunctions.Add("BtuPerPound", "x * 2326.000075362");
                _conversionFunctions.Add("YottaJoulePerKilogram", "x * 1e24");
                _conversionFunctions.Add("ZettaJoulePerKilogram", "x * 1e21");
                _conversionFunctions.Add("ExaJoulePerKilogram", "x * 1e18");
                _conversionFunctions.Add("PetaJoulePerKilogram", "x * 1e15");
                _conversionFunctions.Add("TeraJoulePerKilogram", "x * 1e12");
                _conversionFunctions.Add("GigaJoulePerKilogram", "x * 1e9");
                _conversionFunctions.Add("MegaJoulePerKilogram", "x * 1e6");
                _conversionFunctions.Add("KiloJoulePerKilogram", "x * 1e3");
                _conversionFunctions.Add("HectoJoulePerKilogram", "x * 1e2");
                _conversionFunctions.Add("DekaJoulePerKilogram", "x * 1e1");
                _conversionFunctions.Add("JoulePerKilogram", "x * 1e0");
                _conversionFunctions.Add("DeciJoulePerKilogram", "x * 1e-1");
                _conversionFunctions.Add("CentiJoulePerKilogram", "x * 1e-2");
                _conversionFunctions.Add("MilliJoulePerKilogram", "x * 1e-3");
                _conversionFunctions.Add("MicroJoulePerKilogram", "x * 1e-6");
                _conversionFunctions.Add("NanoJoulePerKilogram", "x * 1e-9");
                _conversionFunctions.Add("PicoJoulePerKilogram", "x * 1e-12");
                _conversionFunctions.Add("FemtoJoulePerKilogram", "x * 1e-15");
                _conversionFunctions.Add("AttoJoulePerKilogram", "x * 1e-18");
                _conversionFunctions.Add("ZeptoJoulePerKilogram", "x * 1e-21");
                _conversionFunctions.Add("YoctoJoulePerKilogram", "x * 1e-24");
            }
        }
    }
