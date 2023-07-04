
    // Auto-generated for VNet on 2023-07-03 11:25:32
    using System.Numerics;
    
    
    namespace VNet.Scientific.Measurement.Dimensions
    {
        public sealed class VolumeFlow<TVal> : DimensionBase<VolumeFlowUnit, TVal> where TVal : notnull, INumber<TVal>
        {
            public override string IdTag => nameof(VolumeFlow<TVal>);
            
            public VolumeFlow() : base()
            {
                DimensionComponent.Exponents.Length = 3;
                DimensionComponent.Exponents.Mass = 0;
                DimensionComponent.Exponents.Time = -1;
                DimensionComponent.Exponents.ElectricalCurrent = 0;
                DimensionComponent.Exponents.LuminousIntensity = 0;
                DimensionComponent.Exponents.Temperature = 0;
                DimensionComponent.Exponents.Amount = 0;
                
                DefaultUnit = VolumeFlowUnit.CubicMeterPerSecond;
                
                
                _conversionFunctions.Add("CubicMeterPerMinute", "x / 60");
                _conversionFunctions.Add("CubicMeterPerHour", "x / 3600");
                _conversionFunctions.Add("CubicMeterPerDay", "x / 86400");
                _conversionFunctions.Add("CubicFootPerSecond", "x / 35.314666721");
                _conversionFunctions.Add("CubicFootPerMinute", "x / 2118.88000326");
                _conversionFunctions.Add("CubicFootPerHour", "x * 7.8657907199999087346816086183876e-6");
                _conversionFunctions.Add("CubicYardPerSecond", "x * 0.764554857984");
                _conversionFunctions.Add("CubicYardPerMinute", "x * 0.0127425809664");
                _conversionFunctions.Add("CubicYardPerHour", "x * 2.1237634944E-4");
                _conversionFunctions.Add("CubicYardPerDay", "x / 113007");
                _conversionFunctions.Add("MillionUsGallonPerDay", "x / 22.824465227");
                _conversionFunctions.Add("UsGallonPerDay", "x / 22824465.227");
                _conversionFunctions.Add("LiterPerSecond", "x / 1000");
                _conversionFunctions.Add("LiterPerMinute", "x / 60000.00000");
                _conversionFunctions.Add("LiterPerHour", "x / 3600000.000");
                _conversionFunctions.Add("LiterPerDay", "x / 86400000");
                _conversionFunctions.Add("UsGallonPerSecond", "x / 264.1720523581484");
                _conversionFunctions.Add("UsGallonPerMinute", "x / 15850.323141489");
                _conversionFunctions.Add("UkGallonPerDay", "x / 19005304");
                _conversionFunctions.Add("UkGallonPerHour", "x / 791887.667");
                _conversionFunctions.Add("UkGallonPerMinute", "x / 13198.2");
                _conversionFunctions.Add("UkGallonPerSecond", "x / 219.969");
                _conversionFunctions.Add("KilousGallonPerMinute", "x / 15.850323141489");
                _conversionFunctions.Add("UsGallonPerHour", "x / 951019.38848933424");
                _conversionFunctions.Add("CubicDecimeterPerMinute", "x / 60000.00000");
                _conversionFunctions.Add("OilBarrelPerDay", "x * 1.8401307283333333333333333333333e-6");
                _conversionFunctions.Add("OilBarrelPerMinute", "x * 2.64978825e-3");
                _conversionFunctions.Add("OilBarrelPerHour", "x * 4.41631375e-5");
                _conversionFunctions.Add("OilBarrelPerSecond", "x / 6.28981");
                _conversionFunctions.Add("AcreFootPerSecond", "x / 0.000810713194");
                _conversionFunctions.Add("AcreFootPerMinute", "x / 0.0486427916");
                _conversionFunctions.Add("AcreFootPerHour", "x / 2.91857");
                _conversionFunctions.Add("AcreFootPerDay", "x / 70.0457");
                _conversionFunctions.Add("CubicCentimeterPerMinute", "x * 1.6666666666667e-8");
                _conversionFunctions.Add("CubicYottaMeterPerSecond", "x * 1e72");
                _conversionFunctions.Add("CubicZettaMeterPerSecond", "x * 1e63");
                _conversionFunctions.Add("CubicExaMeterPerSecond", "x * 1e54");
                _conversionFunctions.Add("CubicPetaMeterPerSecond", "x * 1e45");
                _conversionFunctions.Add("CubicTeraMeterPerSecond", "x * 1e36");
                _conversionFunctions.Add("CubicGigaMeterPerSecond", "x * 1e27");
                _conversionFunctions.Add("CubicMegaMeterPerSecond", "x * 1e18");
                _conversionFunctions.Add("CubicKiloMeterPerSecond", "x * 1e9");
                _conversionFunctions.Add("CubicHectoMeterPerSecond", "x * 1e6");
                _conversionFunctions.Add("CubicDekaMeterPerSecond", "x * 1e3");
                _conversionFunctions.Add("CubicMeterPerSecond", "x * 1e0");
                _conversionFunctions.Add("CubicDeciMeterPerSecond", "x * 1e-3");
                _conversionFunctions.Add("CubicCentiMeterPerSecond", "x * 1e-6");
                _conversionFunctions.Add("CubicMilliMeterPerSecond", "x * 1e-9");
                _conversionFunctions.Add("CubicMicroMeterPerSecond", "x * 1e-18");
                _conversionFunctions.Add("CubicNanoMeterPerSecond", "x * 1e-27");
                _conversionFunctions.Add("CubicPicoMeterPerSecond", "x * 1e-36");
                _conversionFunctions.Add("CubicFemtoMeterPerSecond", "x * 1e-45");
                _conversionFunctions.Add("CubicAttoMeterPerSecond", "x * 1e-54");
                _conversionFunctions.Add("CubicZeptoMeterPerSecond", "x * 1e-63");
                _conversionFunctions.Add("CubicYoctoMeterPerSecond", "x * 1e-72");
            }
        }
    }
