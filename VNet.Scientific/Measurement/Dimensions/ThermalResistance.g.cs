
    // Auto-generated for VNet on 2023-07-03 11:25:32
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
                
                
                _conversionFunctions.Add("SquareMeterKelvinPerWatt", "x * 1000");
                _conversionFunctions.Add("SquareMeterDegreeCelsiusPerWatt", "x * 1000.0");
                _conversionFunctions.Add("SquareCentimeterKelvinPerWatt", "x * 0.1");
                _conversionFunctions.Add("SquareCentimeterHourDegreeCelsiusPerKilocalorie", "x * 0.0859779507590433");
                _conversionFunctions.Add("HourSquareFeetDegreeFahrenheitPerBtu", "x * 176.1121482159839");
                _conversionFunctions.Add("SquareYottaMeterKelvinPerKilowatt", "x * 1e48");
                _conversionFunctions.Add("SquareZettaMeterKelvinPerKilowatt", "x * 1e42");
                _conversionFunctions.Add("SquareExaMeterKelvinPerKilowatt", "x * 1e36");
                _conversionFunctions.Add("SquarePetaMeterKelvinPerKilowatt", "x * 1e30");
                _conversionFunctions.Add("SquareTeraMeterKelvinPerKilowatt", "x * 1e24");
                _conversionFunctions.Add("SquareGigaMeterKelvinPerKilowatt", "x * 1e18");
                _conversionFunctions.Add("SquareMegaMeterKelvinPerKilowatt", "x * 1e12");
                _conversionFunctions.Add("SquareKiloMeterKelvinPerKilowatt", "x * 1e6");
                _conversionFunctions.Add("SquareHectoMeterKelvinPerKilowatt", "x * 1e4");
                _conversionFunctions.Add("SquareDekaMeterKelvinPerKilowatt", "x * 1e2");
                _conversionFunctions.Add("SquareMeterKelvinPerKilowatt", "x * 1e0");
                _conversionFunctions.Add("SquareDeciMeterKelvinPerKilowatt", "x * 1e-2");
                _conversionFunctions.Add("SquareCentiMeterKelvinPerKilowatt", "x * 1e-4");
                _conversionFunctions.Add("SquareMilliMeterKelvinPerKilowatt", "x * 1e-6");
                _conversionFunctions.Add("SquareMicroMeterKelvinPerKilowatt", "x * 1e-12");
                _conversionFunctions.Add("SquareNanoMeterKelvinPerKilowatt", "x * 1e-18");
                _conversionFunctions.Add("SquarePicoMeterKelvinPerKilowatt", "x * 1e-24");
                _conversionFunctions.Add("SquareFemtoMeterKelvinPerKilowatt", "x * 1e-30");
                _conversionFunctions.Add("SquareAttoMeterKelvinPerKilowatt", "x * 1e-36");
                _conversionFunctions.Add("SquareZeptoMeterKelvinPerKilowatt", "x * 1e-42");
                _conversionFunctions.Add("SquareYoctoMeterKelvinPerKilowatt", "x * 1e-48");
            }
        }
    }
