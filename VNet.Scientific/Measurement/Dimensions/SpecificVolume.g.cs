
    // Auto-generated for VNet on 2023-07-03 11:25:32
    using System.Numerics;
    
    
    namespace VNet.Scientific.Measurement.Dimensions
    {
        public sealed class SpecificVolume<TVal> : DimensionBase<SpecificVolumeUnit, TVal> where TVal : notnull, INumber<TVal>
        {
            public override string IdTag => nameof(SpecificVolume<TVal>);
            
            public SpecificVolume() : base()
            {
                DimensionComponent.Exponents.Length = 3;
                DimensionComponent.Exponents.Mass = -1;
                DimensionComponent.Exponents.Time = 0;
                DimensionComponent.Exponents.ElectricalCurrent = 0;
                DimensionComponent.Exponents.LuminousIntensity = 0;
                DimensionComponent.Exponents.Temperature = 0;
                DimensionComponent.Exponents.Amount = 0;
                
                DefaultUnit = SpecificVolumeUnit.CubicMeterPerKilogram;
                
                
                _conversionFunctions.Add("CubicFootPerPound", "x / 16.01846353");
                _conversionFunctions.Add("CubicYottaMeterPerKilogram", "x * 1e72");
                _conversionFunctions.Add("CubicZettaMeterPerKilogram", "x * 1e63");
                _conversionFunctions.Add("CubicExaMeterPerKilogram", "x * 1e54");
                _conversionFunctions.Add("CubicPetaMeterPerKilogram", "x * 1e45");
                _conversionFunctions.Add("CubicTeraMeterPerKilogram", "x * 1e36");
                _conversionFunctions.Add("CubicGigaMeterPerKilogram", "x * 1e27");
                _conversionFunctions.Add("CubicMegaMeterPerKilogram", "x * 1e18");
                _conversionFunctions.Add("CubicKiloMeterPerKilogram", "x * 1e9");
                _conversionFunctions.Add("CubicHectoMeterPerKilogram", "x * 1e6");
                _conversionFunctions.Add("CubicDekaMeterPerKilogram", "x * 1e3");
                _conversionFunctions.Add("CubicMeterPerKilogram", "x * 1e0");
                _conversionFunctions.Add("CubicDeciMeterPerKilogram", "x * 1e-3");
                _conversionFunctions.Add("CubicCentiMeterPerKilogram", "x * 1e-6");
                _conversionFunctions.Add("CubicMilliMeterPerKilogram", "x * 1e-9");
                _conversionFunctions.Add("CubicMicroMeterPerKilogram", "x * 1e-18");
                _conversionFunctions.Add("CubicNanoMeterPerKilogram", "x * 1e-27");
                _conversionFunctions.Add("CubicPicoMeterPerKilogram", "x * 1e-36");
                _conversionFunctions.Add("CubicFemtoMeterPerKilogram", "x * 1e-45");
                _conversionFunctions.Add("CubicAttoMeterPerKilogram", "x * 1e-54");
                _conversionFunctions.Add("CubicZeptoMeterPerKilogram", "x * 1e-63");
                _conversionFunctions.Add("CubicYoctoMeterPerKilogram", "x * 1e-72");
            }
        }
    }
