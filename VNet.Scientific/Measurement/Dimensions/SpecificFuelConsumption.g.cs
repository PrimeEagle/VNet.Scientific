
    // Auto-generated for VNet on 2023-07-05 10:24:46
    using System.Numerics;
    
    
    namespace VNet.Scientific.Measurement.Dimensions
    {
        public sealed class SpecificFuelConsumption<TVal> : DimensionBase<SpecificFuelConsumptionUnit, TVal> where TVal : notnull, INumber<TVal>
        {
            public override string IdTag => nameof(SpecificFuelConsumption<TVal>);
            
            public SpecificFuelConsumption() : base()
            {
                DimensionComponent.Exponents.Length = 0;
                DimensionComponent.Exponents.Mass = 0;
                DimensionComponent.Exponents.Time = 0;
                DimensionComponent.Exponents.ElectricalCurrent = 0;
                DimensionComponent.Exponents.LuminousIntensity = 0;
                DimensionComponent.Exponents.Temperature = 0;
                DimensionComponent.Exponents.Amount = 0;
                
                DefaultUnit = SpecificFuelConsumptionUnit.GramPerKiloNewtonSecond;
                
                
                ConversionFunctions.Add(SpecificFuelConsumptionUnit.PoundMassPerPoundForceHour, "x * 28.33");
                ConversionFunctions.Add(SpecificFuelConsumptionUnit.KilogramPerKilogramForceHour, "x * 28.33");
                ConversionFunctions.Add(SpecificFuelConsumptionUnit.Yottagramperkilonewtonsecond, "x * 1e24");
                ConversionFunctions.Add(SpecificFuelConsumptionUnit.Zettagramperkilonewtonsecond, "x * 1e21");
                ConversionFunctions.Add(SpecificFuelConsumptionUnit.Exagramperkilonewtonsecond, "x * 1e18");
                ConversionFunctions.Add(SpecificFuelConsumptionUnit.Petagramperkilonewtonsecond, "x * 1e15");
                ConversionFunctions.Add(SpecificFuelConsumptionUnit.Teragramperkilonewtonsecond, "x * 1e12");
                ConversionFunctions.Add(SpecificFuelConsumptionUnit.Gigagramperkilonewtonsecond, "x * 1e9");
                ConversionFunctions.Add(SpecificFuelConsumptionUnit.Megagramperkilonewtonsecond, "x * 1e6");
                ConversionFunctions.Add(SpecificFuelConsumptionUnit.Kilogramperkilonewtonsecond, "x * 1e3");
                ConversionFunctions.Add(SpecificFuelConsumptionUnit.Hectogramperkilonewtonsecond, "x * 1e2");
                ConversionFunctions.Add(SpecificFuelConsumptionUnit.Dekagramperkilonewtonsecond, "x * 1e1");
                ConversionFunctions.Add(SpecificFuelConsumptionUnit.GramPerKiloNewtonSecond, "x * 1e0");
                ConversionFunctions.Add(SpecificFuelConsumptionUnit.Decigramperkilonewtonsecond, "x * 1e-1");
                ConversionFunctions.Add(SpecificFuelConsumptionUnit.Centigramperkilonewtonsecond, "x * 1e-2");
                ConversionFunctions.Add(SpecificFuelConsumptionUnit.Milligramperkilonewtonsecond, "x * 1e-3");
                ConversionFunctions.Add(SpecificFuelConsumptionUnit.Microgramperkilonewtonsecond, "x * 1e-6");
                ConversionFunctions.Add(SpecificFuelConsumptionUnit.Nanogramperkilonewtonsecond, "x * 1e-9");
                ConversionFunctions.Add(SpecificFuelConsumptionUnit.Picogramperkilonewtonsecond, "x * 1e-12");
                ConversionFunctions.Add(SpecificFuelConsumptionUnit.Femtogramperkilonewtonsecond, "x * 1e-15");
                ConversionFunctions.Add(SpecificFuelConsumptionUnit.Attogramperkilonewtonsecond, "x * 1e-18");
                ConversionFunctions.Add(SpecificFuelConsumptionUnit.Zeptogramperkilonewtonsecond, "x * 1e-21");
                ConversionFunctions.Add(SpecificFuelConsumptionUnit.Yoctogramperkilonewtonsecond, "x * 1e-24");
            }
        }
    }
