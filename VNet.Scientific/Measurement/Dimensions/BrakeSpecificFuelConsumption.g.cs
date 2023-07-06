
    // Auto-generated for VNet on 2023-07-05 10:35:43
    using System.Numerics;
    
    
    namespace VNet.Scientific.Measurement.Dimensions
    {
        public sealed class BrakeSpecificFuelConsumption<TVal> : DimensionBase<BrakeSpecificFuelConsumptionUnit, TVal> where TVal : notnull, INumber<TVal>
        {
            public override string IdTag => nameof(BrakeSpecificFuelConsumption<TVal>);
            
            public BrakeSpecificFuelConsumption() : base()
            {
                DimensionComponent.Exponents.Length = -2;
                DimensionComponent.Exponents.Mass = 0;
                DimensionComponent.Exponents.Time = 2;
                DimensionComponent.Exponents.ElectricalCurrent = 0;
                DimensionComponent.Exponents.LuminousIntensity = 0;
                DimensionComponent.Exponents.Temperature = 0;
                DimensionComponent.Exponents.Amount = 0;
                
                DefaultUnit = BrakeSpecificFuelConsumptionUnit.KilogramPerJoule;
                
                Symbols.Add(BrakeSpecificFuelConsumptionUnit.GramPerKiloWattHour, "g/kWh");
                Symbols.Add(BrakeSpecificFuelConsumptionUnit.PoundPerMechanicalHorsepowerHour, "lb/hph");
                Symbols.Add(BrakeSpecificFuelConsumptionUnit.Yottakilogramperjoule, "Ykg/J");
                Symbols.Add(BrakeSpecificFuelConsumptionUnit.Zettakilogramperjoule, "Zkg/J");
                Symbols.Add(BrakeSpecificFuelConsumptionUnit.Exakilogramperjoule, "Ekg/J");
                Symbols.Add(BrakeSpecificFuelConsumptionUnit.Petakilogramperjoule, "Pkg/J");
                Symbols.Add(BrakeSpecificFuelConsumptionUnit.Terakilogramperjoule, "Tkg/J");
                Symbols.Add(BrakeSpecificFuelConsumptionUnit.Gigakilogramperjoule, "Gkg/J");
                Symbols.Add(BrakeSpecificFuelConsumptionUnit.Megakilogramperjoule, "Mkg/J");
                Symbols.Add(BrakeSpecificFuelConsumptionUnit.Kilokilogramperjoule, "kkg/J");
                Symbols.Add(BrakeSpecificFuelConsumptionUnit.Hectokilogramperjoule, "hkg/J");
                Symbols.Add(BrakeSpecificFuelConsumptionUnit.Dekakilogramperjoule, "dakg/J");
                Symbols.Add(BrakeSpecificFuelConsumptionUnit.KilogramPerJoule, "kg/J");
                Symbols.Add(BrakeSpecificFuelConsumptionUnit.Decikilogramperjoule, "dkg/J");
                Symbols.Add(BrakeSpecificFuelConsumptionUnit.Centikilogramperjoule, "ckg/J");
                Symbols.Add(BrakeSpecificFuelConsumptionUnit.Millikilogramperjoule, "mkg/J");
                Symbols.Add(BrakeSpecificFuelConsumptionUnit.Microkilogramperjoule, "µkg/J");
                Symbols.Add(BrakeSpecificFuelConsumptionUnit.Nanokilogramperjoule, "nkg/J");
                Symbols.Add(BrakeSpecificFuelConsumptionUnit.Picokilogramperjoule, "pkg/J");
                Symbols.Add(BrakeSpecificFuelConsumptionUnit.Femtokilogramperjoule, "fkg/J");
                Symbols.Add(BrakeSpecificFuelConsumptionUnit.Attokilogramperjoule, "akg/J");
                Symbols.Add(BrakeSpecificFuelConsumptionUnit.Zeptokilogramperjoule, "zkg/J");
                Symbols.Add(BrakeSpecificFuelConsumptionUnit.Yoctokilogramperjoule, "ykg/J");
                
                
                ConversionFunctions.Add(BrakeSpecificFuelConsumptionUnit.GramPerKiloWattHour, "x / 3.6e9");
                ConversionFunctions.Add(BrakeSpecificFuelConsumptionUnit.PoundPerMechanicalHorsepowerHour, "x * 1.689659410672e-7");
                ConversionFunctions.Add(BrakeSpecificFuelConsumptionUnit.Yottakilogramperjoule, "x * 1e24");
                ConversionFunctions.Add(BrakeSpecificFuelConsumptionUnit.Zettakilogramperjoule, "x * 1e21");
                ConversionFunctions.Add(BrakeSpecificFuelConsumptionUnit.Exakilogramperjoule, "x * 1e18");
                ConversionFunctions.Add(BrakeSpecificFuelConsumptionUnit.Petakilogramperjoule, "x * 1e15");
                ConversionFunctions.Add(BrakeSpecificFuelConsumptionUnit.Terakilogramperjoule, "x * 1e12");
                ConversionFunctions.Add(BrakeSpecificFuelConsumptionUnit.Gigakilogramperjoule, "x * 1e9");
                ConversionFunctions.Add(BrakeSpecificFuelConsumptionUnit.Megakilogramperjoule, "x * 1e6");
                ConversionFunctions.Add(BrakeSpecificFuelConsumptionUnit.Kilokilogramperjoule, "x * 1e3");
                ConversionFunctions.Add(BrakeSpecificFuelConsumptionUnit.Hectokilogramperjoule, "x * 1e2");
                ConversionFunctions.Add(BrakeSpecificFuelConsumptionUnit.Dekakilogramperjoule, "x * 1e1");
                ConversionFunctions.Add(BrakeSpecificFuelConsumptionUnit.KilogramPerJoule, "x * 1e0");
                ConversionFunctions.Add(BrakeSpecificFuelConsumptionUnit.Decikilogramperjoule, "x * 1e-1");
                ConversionFunctions.Add(BrakeSpecificFuelConsumptionUnit.Centikilogramperjoule, "x * 1e-2");
                ConversionFunctions.Add(BrakeSpecificFuelConsumptionUnit.Millikilogramperjoule, "x * 1e-3");
                ConversionFunctions.Add(BrakeSpecificFuelConsumptionUnit.Microkilogramperjoule, "x * 1e-6");
                ConversionFunctions.Add(BrakeSpecificFuelConsumptionUnit.Nanokilogramperjoule, "x * 1e-9");
                ConversionFunctions.Add(BrakeSpecificFuelConsumptionUnit.Picokilogramperjoule, "x * 1e-12");
                ConversionFunctions.Add(BrakeSpecificFuelConsumptionUnit.Femtokilogramperjoule, "x * 1e-15");
                ConversionFunctions.Add(BrakeSpecificFuelConsumptionUnit.Attokilogramperjoule, "x * 1e-18");
                ConversionFunctions.Add(BrakeSpecificFuelConsumptionUnit.Zeptokilogramperjoule, "x * 1e-21");
                ConversionFunctions.Add(BrakeSpecificFuelConsumptionUnit.Yoctokilogramperjoule, "x * 1e-24");
            }
        }
    }
