
    // Auto-generated for VNet on 2023-07-06 12:42:23
    using System.Numerics;
    
    
    namespace VNet.Scientific.Measurement.Dimensions
    {
        public sealed class SpecificFuelConsumption<TVal> : DimensionBase<SpecificFuelConsumptionUnit, TVal> where TVal : notnull, INumber<TVal>
        {
            public override string IdTag => nameof(SpecificFuelConsumption<TVal>);
            
            public SpecificFuelConsumption() : base()
            {
                Exponents.Length = 0;
                Exponents.Mass = 0;
                Exponents.Time = 0;
                Exponents.ElectricalCurrent = 0;
                Exponents.LuminousIntensity = 0;
                Exponents.Temperature = 0;
                Exponents.Amount = 0;
                
                DefaultUnit = SpecificFuelConsumptionUnit.GramPerKiloNewtonSecond;
                
                Symbols.Add(SpecificFuelConsumptionUnit.PoundMassPerPoundForceHour, "lb/(lbf·h)");
                Symbols.Add(SpecificFuelConsumptionUnit.KilogramPerKilogramForceHour, "kg/(kgf�h)");
                Symbols.Add(SpecificFuelConsumptionUnit.Yottagramperkilonewtonsecond, "Yg/(kN�s)");
                Symbols.Add(SpecificFuelConsumptionUnit.Zettagramperkilonewtonsecond, "Zg/(kN�s)");
                Symbols.Add(SpecificFuelConsumptionUnit.Exagramperkilonewtonsecond, "Eg/(kN�s)");
                Symbols.Add(SpecificFuelConsumptionUnit.Petagramperkilonewtonsecond, "Pg/(kN�s)");
                Symbols.Add(SpecificFuelConsumptionUnit.Teragramperkilonewtonsecond, "Tg/(kN�s)");
                Symbols.Add(SpecificFuelConsumptionUnit.Gigagramperkilonewtonsecond, "Gg/(kN�s)");
                Symbols.Add(SpecificFuelConsumptionUnit.Megagramperkilonewtonsecond, "Mg/(kN�s)");
                Symbols.Add(SpecificFuelConsumptionUnit.Kilogramperkilonewtonsecond, "kg/(kN�s)");
                Symbols.Add(SpecificFuelConsumptionUnit.Hectogramperkilonewtonsecond, "hg/(kN�s)");
                Symbols.Add(SpecificFuelConsumptionUnit.Dekagramperkilonewtonsecond, "dag/(kN�s)");
                Symbols.Add(SpecificFuelConsumptionUnit.GramPerKiloNewtonSecond, "g/(kN�s)");
                Symbols.Add(SpecificFuelConsumptionUnit.Decigramperkilonewtonsecond, "dg/(kN�s)");
                Symbols.Add(SpecificFuelConsumptionUnit.Centigramperkilonewtonsecond, "cg/(kN�s)");
                Symbols.Add(SpecificFuelConsumptionUnit.Milligramperkilonewtonsecond, "mg/(kN�s)");
                Symbols.Add(SpecificFuelConsumptionUnit.Microgramperkilonewtonsecond, "µg/(kN�s)");
                Symbols.Add(SpecificFuelConsumptionUnit.Nanogramperkilonewtonsecond, "ng/(kN�s)");
                Symbols.Add(SpecificFuelConsumptionUnit.Picogramperkilonewtonsecond, "pg/(kN�s)");
                Symbols.Add(SpecificFuelConsumptionUnit.Femtogramperkilonewtonsecond, "fg/(kN�s)");
                Symbols.Add(SpecificFuelConsumptionUnit.Attogramperkilonewtonsecond, "ag/(kN�s)");
                Symbols.Add(SpecificFuelConsumptionUnit.Zeptogramperkilonewtonsecond, "zg/(kN�s)");
                Symbols.Add(SpecificFuelConsumptionUnit.Yoctogramperkilonewtonsecond, "yg/(kN�s)");
                
                
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
