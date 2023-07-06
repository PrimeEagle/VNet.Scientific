
    // Auto-generated for VNet on 2023-07-05 10:35:43
    using System.Numerics;
    
    
    namespace VNet.Scientific.Measurement.Dimensions
    {
        public sealed class ThermalResistance<TVal> : DimensionBase<ThermalResistanceUnit, TVal> where TVal : notnull, INumber<TVal>
        {
            public override string IdTag => nameof(ThermalResistance<TVal>);
            
            public ThermalResistance() : base()
            {
                DimensionComponent.Exponents.Length = 0;
                DimensionComponent.Exponents.Mass = -1;
                DimensionComponent.Exponents.Time = 3;
                DimensionComponent.Exponents.ElectricalCurrent = 0;
                DimensionComponent.Exponents.LuminousIntensity = 0;
                DimensionComponent.Exponents.Temperature = 1;
                DimensionComponent.Exponents.Amount = 0;
                
                DefaultUnit = ThermalResistanceUnit.SquareMeterKelvinPerKilowatt;
                
                Symbols.Add(ThermalResistanceUnit.SquareMeterKelvinPerWatt, "m²K/W");
                Symbols.Add(ThermalResistanceUnit.SquareMeterDegreeCelsiusPerWatt, "m²°C/W");
                Symbols.Add(ThermalResistanceUnit.SquareCentimeterKelvinPerWatt, "cm²K/W");
                Symbols.Add(ThermalResistanceUnit.SquareCentimeterHourDegreeCelsiusPerKilocalorie, "cm²Hr°C/kcal");
                Symbols.Add(ThermalResistanceUnit.HourSquareFeetDegreeFahrenheitPerBtu, "Hrft²°F/Btu");
                Symbols.Add(ThermalResistanceUnit.SquareYottameterkelvinperkilowatt, "Ym²K/kW");
                Symbols.Add(ThermalResistanceUnit.SquareZettameterkelvinperkilowatt, "Zm²K/kW");
                Symbols.Add(ThermalResistanceUnit.SquareExameterkelvinperkilowatt, "Em²K/kW");
                Symbols.Add(ThermalResistanceUnit.SquarePetameterkelvinperkilowatt, "Pm²K/kW");
                Symbols.Add(ThermalResistanceUnit.SquareTerameterkelvinperkilowatt, "Tm²K/kW");
                Symbols.Add(ThermalResistanceUnit.SquareGigameterkelvinperkilowatt, "Gm²K/kW");
                Symbols.Add(ThermalResistanceUnit.SquareMegameterkelvinperkilowatt, "Mm²K/kW");
                Symbols.Add(ThermalResistanceUnit.SquareKilometerkelvinperkilowatt, "km²K/kW");
                Symbols.Add(ThermalResistanceUnit.SquareHectometerkelvinperkilowatt, "hm²K/kW");
                Symbols.Add(ThermalResistanceUnit.SquareDekameterkelvinperkilowatt, "dam²K/kW");
                Symbols.Add(ThermalResistanceUnit.SquareMeterKelvinPerKilowatt, "m²K/kW");
                Symbols.Add(ThermalResistanceUnit.SquareDecimeterkelvinperkilowatt, "dm²K/kW");
                Symbols.Add(ThermalResistanceUnit.SquareCentimeterkelvinperkilowatt, "cm²K/kW");
                Symbols.Add(ThermalResistanceUnit.SquareMillimeterkelvinperkilowatt, "mm²K/kW");
                Symbols.Add(ThermalResistanceUnit.SquareMicrometerkelvinperkilowatt, "µm²K/kW");
                Symbols.Add(ThermalResistanceUnit.SquareNanometerkelvinperkilowatt, "nm²K/kW");
                Symbols.Add(ThermalResistanceUnit.SquarePicometerkelvinperkilowatt, "pm²K/kW");
                Symbols.Add(ThermalResistanceUnit.SquareFemtometerkelvinperkilowatt, "fm²K/kW");
                Symbols.Add(ThermalResistanceUnit.SquareAttometerkelvinperkilowatt, "am²K/kW");
                Symbols.Add(ThermalResistanceUnit.SquareZeptometerkelvinperkilowatt, "zm²K/kW");
                Symbols.Add(ThermalResistanceUnit.SquareYoctometerkelvinperkilowatt, "ym²K/kW");
                
                
                ConversionFunctions.Add(ThermalResistanceUnit.SquareMeterKelvinPerWatt, "x * 1000");
                ConversionFunctions.Add(ThermalResistanceUnit.SquareMeterDegreeCelsiusPerWatt, "x * 1000.0");
                ConversionFunctions.Add(ThermalResistanceUnit.SquareCentimeterKelvinPerWatt, "x * 0.1");
                ConversionFunctions.Add(ThermalResistanceUnit.SquareCentimeterHourDegreeCelsiusPerKilocalorie, "x * 0.0859779507590433");
                ConversionFunctions.Add(ThermalResistanceUnit.HourSquareFeetDegreeFahrenheitPerBtu, "x * 176.1121482159839");
                ConversionFunctions.Add(ThermalResistanceUnit.SquareYottameterkelvinperkilowatt, "x * 1e48");
                ConversionFunctions.Add(ThermalResistanceUnit.SquareZettameterkelvinperkilowatt, "x * 1e42");
                ConversionFunctions.Add(ThermalResistanceUnit.SquareExameterkelvinperkilowatt, "x * 1e36");
                ConversionFunctions.Add(ThermalResistanceUnit.SquarePetameterkelvinperkilowatt, "x * 1e30");
                ConversionFunctions.Add(ThermalResistanceUnit.SquareTerameterkelvinperkilowatt, "x * 1e24");
                ConversionFunctions.Add(ThermalResistanceUnit.SquareGigameterkelvinperkilowatt, "x * 1e18");
                ConversionFunctions.Add(ThermalResistanceUnit.SquareMegameterkelvinperkilowatt, "x * 1e12");
                ConversionFunctions.Add(ThermalResistanceUnit.SquareKilometerkelvinperkilowatt, "x * 1e6");
                ConversionFunctions.Add(ThermalResistanceUnit.SquareHectometerkelvinperkilowatt, "x * 1e4");
                ConversionFunctions.Add(ThermalResistanceUnit.SquareDekameterkelvinperkilowatt, "x * 1e2");
                ConversionFunctions.Add(ThermalResistanceUnit.SquareMeterKelvinPerKilowatt, "x * 1e0");
                ConversionFunctions.Add(ThermalResistanceUnit.SquareDecimeterkelvinperkilowatt, "x * 1e-2");
                ConversionFunctions.Add(ThermalResistanceUnit.SquareCentimeterkelvinperkilowatt, "x * 1e-4");
                ConversionFunctions.Add(ThermalResistanceUnit.SquareMillimeterkelvinperkilowatt, "x * 1e-6");
                ConversionFunctions.Add(ThermalResistanceUnit.SquareMicrometerkelvinperkilowatt, "x * 1e-12");
                ConversionFunctions.Add(ThermalResistanceUnit.SquareNanometerkelvinperkilowatt, "x * 1e-18");
                ConversionFunctions.Add(ThermalResistanceUnit.SquarePicometerkelvinperkilowatt, "x * 1e-24");
                ConversionFunctions.Add(ThermalResistanceUnit.SquareFemtometerkelvinperkilowatt, "x * 1e-30");
                ConversionFunctions.Add(ThermalResistanceUnit.SquareAttometerkelvinperkilowatt, "x * 1e-36");
                ConversionFunctions.Add(ThermalResistanceUnit.SquareZeptometerkelvinperkilowatt, "x * 1e-42");
                ConversionFunctions.Add(ThermalResistanceUnit.SquareYoctometerkelvinperkilowatt, "x * 1e-48");
            }
        }
    }
