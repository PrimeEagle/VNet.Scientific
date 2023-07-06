
    // Auto-generated for VNet on 2023-07-05 10:24:46
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
