
    // Auto-generated for VNet on 2023-07-05 10:24:46
    using System.Numerics;
    
    
    namespace VNet.Scientific.Measurement.Dimensions
    {
        public sealed class PowerDensity<TVal> : DimensionBase<PowerDensityUnit, TVal> where TVal : notnull, INumber<TVal>
        {
            public override string IdTag => nameof(PowerDensity<TVal>);
            
            public PowerDensity() : base()
            {
                DimensionComponent.Exponents.Length = -1;
                DimensionComponent.Exponents.Mass = 1;
                DimensionComponent.Exponents.Time = -3;
                DimensionComponent.Exponents.ElectricalCurrent = 0;
                DimensionComponent.Exponents.LuminousIntensity = 0;
                DimensionComponent.Exponents.Temperature = 0;
                DimensionComponent.Exponents.Amount = 0;
                
                DefaultUnit = PowerDensityUnit.WattPerCubicMeter;
                
                
                ConversionFunctions.Add(PowerDensityUnit.WattPerCubicInch, "x * 6.102374409473228e4");
                ConversionFunctions.Add(PowerDensityUnit.WattPerCubicFoot, "x * 3.531466672148859e1");
                ConversionFunctions.Add(PowerDensityUnit.WattPerLiter, "x * 1.0e3");
                ConversionFunctions.Add(PowerDensityUnit.Yottawattpercubicmeter, "x * 1e24");
                ConversionFunctions.Add(PowerDensityUnit.Zettawattpercubicmeter, "x * 1e21");
                ConversionFunctions.Add(PowerDensityUnit.Exawattpercubicmeter, "x * 1e18");
                ConversionFunctions.Add(PowerDensityUnit.Petawattpercubicmeter, "x * 1e15");
                ConversionFunctions.Add(PowerDensityUnit.Terawattpercubicmeter, "x * 1e12");
                ConversionFunctions.Add(PowerDensityUnit.Gigawattpercubicmeter, "x * 1e9");
                ConversionFunctions.Add(PowerDensityUnit.Megawattpercubicmeter, "x * 1e6");
                ConversionFunctions.Add(PowerDensityUnit.Kilowattpercubicmeter, "x * 1e3");
                ConversionFunctions.Add(PowerDensityUnit.Hectowattpercubicmeter, "x * 1e2");
                ConversionFunctions.Add(PowerDensityUnit.Dekawattpercubicmeter, "x * 1e1");
                ConversionFunctions.Add(PowerDensityUnit.WattPerCubicMeter, "x * 1e0");
                ConversionFunctions.Add(PowerDensityUnit.Deciwattpercubicmeter, "x * 1e-1");
                ConversionFunctions.Add(PowerDensityUnit.Centiwattpercubicmeter, "x * 1e-2");
                ConversionFunctions.Add(PowerDensityUnit.Milliwattpercubicmeter, "x * 1e-3");
                ConversionFunctions.Add(PowerDensityUnit.Microwattpercubicmeter, "x * 1e-6");
                ConversionFunctions.Add(PowerDensityUnit.Nanowattpercubicmeter, "x * 1e-9");
                ConversionFunctions.Add(PowerDensityUnit.Picowattpercubicmeter, "x * 1e-12");
                ConversionFunctions.Add(PowerDensityUnit.Femtowattpercubicmeter, "x * 1e-15");
                ConversionFunctions.Add(PowerDensityUnit.Attowattpercubicmeter, "x * 1e-18");
                ConversionFunctions.Add(PowerDensityUnit.Zeptowattpercubicmeter, "x * 1e-21");
                ConversionFunctions.Add(PowerDensityUnit.Yoctowattpercubicmeter, "x * 1e-24");
            }
        }
    }
