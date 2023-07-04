
    // Auto-generated for VNet on 2023-07-03 11:25:32
    using System.Numerics;
    
    
    namespace VNet.Scientific.Measurement.Dimensions
    {
        public sealed class VolumePerLength<TVal> : DimensionBase<VolumePerLengthUnit, TVal> where TVal : notnull, INumber<TVal>
        {
            public override string IdTag => nameof(VolumePerLength<TVal>);
            
            public VolumePerLength() : base()
            {
                DimensionComponent.Exponents.Length = 2;
                DimensionComponent.Exponents.Mass = 0;
                DimensionComponent.Exponents.Time = 0;
                DimensionComponent.Exponents.ElectricalCurrent = 0;
                DimensionComponent.Exponents.LuminousIntensity = 0;
                DimensionComponent.Exponents.Temperature = 0;
                DimensionComponent.Exponents.Amount = 0;
                
                DefaultUnit = VolumePerLengthUnit.CubicMeterPerMeter;
                
                
                _conversionFunctions.Add("LiterPerMeter", "x / 1000");
                _conversionFunctions.Add("LiterPerKilometer", "x / 1e6");
                _conversionFunctions.Add("LiterPerMillimeter", "x");
                _conversionFunctions.Add("OilBarrelPerFoot", "x / 1.91713408");
                _conversionFunctions.Add("CubicYardPerFoot", "x * 2.50838208");
                _conversionFunctions.Add("CubicYardPerUsSurveyFoot", "x * 2.50837706323584");
                _conversionFunctions.Add("UsGallonPerMile", "x / (1000 * 1609.344 / 3.785411784)");
                _conversionFunctions.Add("ImperialGallonPerMile", "x / (1000 * 1609.344 / 4.54609)");
                _conversionFunctions.Add("CubicYottaMeterPerMeter", "x * 1e72");
                _conversionFunctions.Add("CubicZettaMeterPerMeter", "x * 1e63");
                _conversionFunctions.Add("CubicExaMeterPerMeter", "x * 1e54");
                _conversionFunctions.Add("CubicPetaMeterPerMeter", "x * 1e45");
                _conversionFunctions.Add("CubicTeraMeterPerMeter", "x * 1e36");
                _conversionFunctions.Add("CubicGigaMeterPerMeter", "x * 1e27");
                _conversionFunctions.Add("CubicMegaMeterPerMeter", "x * 1e18");
                _conversionFunctions.Add("CubicKiloMeterPerMeter", "x * 1e9");
                _conversionFunctions.Add("CubicHectoMeterPerMeter", "x * 1e6");
                _conversionFunctions.Add("CubicDekaMeterPerMeter", "x * 1e3");
                _conversionFunctions.Add("CubicMeterPerMeter", "x * 1e0");
                _conversionFunctions.Add("CubicDeciMeterPerMeter", "x * 1e-3");
                _conversionFunctions.Add("CubicCentiMeterPerMeter", "x * 1e-6");
                _conversionFunctions.Add("CubicMilliMeterPerMeter", "x * 1e-9");
                _conversionFunctions.Add("CubicMicroMeterPerMeter", "x * 1e-18");
                _conversionFunctions.Add("CubicNanoMeterPerMeter", "x * 1e-27");
                _conversionFunctions.Add("CubicPicoMeterPerMeter", "x * 1e-36");
                _conversionFunctions.Add("CubicFemtoMeterPerMeter", "x * 1e-45");
                _conversionFunctions.Add("CubicAttoMeterPerMeter", "x * 1e-54");
                _conversionFunctions.Add("CubicZeptoMeterPerMeter", "x * 1e-63");
                _conversionFunctions.Add("CubicYoctoMeterPerMeter", "x * 1e-72");
            }
        }
    }
