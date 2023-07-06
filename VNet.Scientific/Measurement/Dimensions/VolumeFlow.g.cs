
    // Auto-generated for VNet on 2023-07-05 10:35:43
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
                
                Symbols.Add(VolumeFlowUnit.CubicMeterPerMinute, "m³/min");
                Symbols.Add(VolumeFlowUnit.CubicMeterPerHour, "m³/h");
                Symbols.Add(VolumeFlowUnit.CubicMeterPerDay, "m³/d");
                Symbols.Add(VolumeFlowUnit.CubicFootPerSecond, "ft³/s");
                Symbols.Add(VolumeFlowUnit.CubicFootPerMinute, "ft³/min");
                Symbols.Add(VolumeFlowUnit.CubicFootPerHour, "ft³/h");
                Symbols.Add(VolumeFlowUnit.CubicYardPerSecond, "yd³/s");
                Symbols.Add(VolumeFlowUnit.CubicYardPerMinute, "yd³/min");
                Symbols.Add(VolumeFlowUnit.CubicYardPerHour, "yd³/h");
                Symbols.Add(VolumeFlowUnit.CubicYardPerDay, "cy/day");
                Symbols.Add(VolumeFlowUnit.MillionUsGallonPerDay, "MGD");
                Symbols.Add(VolumeFlowUnit.UsGallonPerDay, "gpd");
                Symbols.Add(VolumeFlowUnit.LiterPerSecond, "L/s");
                Symbols.Add(VolumeFlowUnit.LiterPerMinute, "L/min");
                Symbols.Add(VolumeFlowUnit.LiterPerHour, "L/h");
                Symbols.Add(VolumeFlowUnit.LiterPerDay, "l/day");
                Symbols.Add(VolumeFlowUnit.UsGallonPerSecond, "gal (U.S.)/s");
                Symbols.Add(VolumeFlowUnit.UsGallonPerMinute, "gal (U.S.)/min");
                Symbols.Add(VolumeFlowUnit.UkGallonPerDay, "gal (U. K.)/d");
                Symbols.Add(VolumeFlowUnit.UkGallonPerHour, "gal (imp.)/h");
                Symbols.Add(VolumeFlowUnit.UkGallonPerMinute, "gal (imp.)/min");
                Symbols.Add(VolumeFlowUnit.UkGallonPerSecond, "gal (imp.)/s");
                Symbols.Add(VolumeFlowUnit.KilousGallonPerMinute, "kgal (U.S.)/min");
                Symbols.Add(VolumeFlowUnit.UsGallonPerHour, "gal (U.S.)/h");
                Symbols.Add(VolumeFlowUnit.CubicDecimeterPerMinute, "dm³/min");
                Symbols.Add(VolumeFlowUnit.OilBarrelPerDay, "bbl/d");
                Symbols.Add(VolumeFlowUnit.OilBarrelPerMinute, "bbl/min");
                Symbols.Add(VolumeFlowUnit.OilBarrelPerHour, "bbl/hr");
                Symbols.Add(VolumeFlowUnit.OilBarrelPerSecond, "bbl/s");
                Symbols.Add(VolumeFlowUnit.AcreFootPerSecond, "af/s");
                Symbols.Add(VolumeFlowUnit.AcreFootPerMinute, "af/m");
                Symbols.Add(VolumeFlowUnit.AcreFootPerHour, "af/h");
                Symbols.Add(VolumeFlowUnit.AcreFootPerDay, "af/d");
                Symbols.Add(VolumeFlowUnit.CubicCentimeterPerMinute, "cm³/min");
                Symbols.Add(VolumeFlowUnit.CubicYottameterpersecond, "Ym³/s");
                Symbols.Add(VolumeFlowUnit.CubicZettameterpersecond, "Zm³/s");
                Symbols.Add(VolumeFlowUnit.CubicExameterpersecond, "Em³/s");
                Symbols.Add(VolumeFlowUnit.CubicPetameterpersecond, "Pm³/s");
                Symbols.Add(VolumeFlowUnit.CubicTerameterpersecond, "Tm³/s");
                Symbols.Add(VolumeFlowUnit.CubicGigameterpersecond, "Gm³/s");
                Symbols.Add(VolumeFlowUnit.CubicMegameterpersecond, "Mm³/s");
                Symbols.Add(VolumeFlowUnit.CubicKilometerpersecond, "km³/s");
                Symbols.Add(VolumeFlowUnit.CubicHectometerpersecond, "hm³/s");
                Symbols.Add(VolumeFlowUnit.CubicDekameterpersecond, "dam³/s");
                Symbols.Add(VolumeFlowUnit.CubicMeterPerSecond, "m³/s");
                Symbols.Add(VolumeFlowUnit.CubicDecimeterpersecond, "dm³/s");
                Symbols.Add(VolumeFlowUnit.CubicCentimeterpersecond, "cm³/s");
                Symbols.Add(VolumeFlowUnit.CubicMillimeterpersecond, "mm³/s");
                Symbols.Add(VolumeFlowUnit.CubicMicrometerpersecond, "µm³/s");
                Symbols.Add(VolumeFlowUnit.CubicNanometerpersecond, "nm³/s");
                Symbols.Add(VolumeFlowUnit.CubicPicometerpersecond, "pm³/s");
                Symbols.Add(VolumeFlowUnit.CubicFemtometerpersecond, "fm³/s");
                Symbols.Add(VolumeFlowUnit.CubicAttometerpersecond, "am³/s");
                Symbols.Add(VolumeFlowUnit.CubicZeptometerpersecond, "zm³/s");
                Symbols.Add(VolumeFlowUnit.CubicYoctometerpersecond, "ym³/s");
                
                PluralSymbols.Add(VolumeFlowUnit.CubicFootPerMinute, "CFM");
                PluralSymbols.Add(VolumeFlowUnit.CubicFootPerHour, "cf/hr");
                PluralSymbols.Add(VolumeFlowUnit.UsGallonPerDay, "gal/d");
                PluralSymbols.Add(VolumeFlowUnit.LiterPerSecond, "LPS");
                PluralSymbols.Add(VolumeFlowUnit.LiterPerMinute, "LPM");
                PluralSymbols.Add(VolumeFlowUnit.LiterPerHour, "LPH");
                PluralSymbols.Add(VolumeFlowUnit.LiterPerDay, "L/d");
                PluralSymbols.Add(VolumeFlowUnit.UsGallonPerMinute, "GPM");
                PluralSymbols.Add(VolumeFlowUnit.KilousGallonPerMinute, "KGPM");
                PluralSymbols.Add(VolumeFlowUnit.OilBarrelPerDay, "BOPD");
                PluralSymbols.Add(VolumeFlowUnit.OilBarrelPerMinute, "bpm");
                PluralSymbols.Add(VolumeFlowUnit.OilBarrelPerHour, "bph");
                
                ConversionFunctions.Add(VolumeFlowUnit.CubicMeterPerMinute, "x / 60");
                ConversionFunctions.Add(VolumeFlowUnit.CubicMeterPerHour, "x / 3600");
                ConversionFunctions.Add(VolumeFlowUnit.CubicMeterPerDay, "x / 86400");
                ConversionFunctions.Add(VolumeFlowUnit.CubicFootPerSecond, "x / 35.314666721");
                ConversionFunctions.Add(VolumeFlowUnit.CubicFootPerMinute, "x / 2118.88000326");
                ConversionFunctions.Add(VolumeFlowUnit.CubicFootPerHour, "x * 7.8657907199999087346816086183876e-6");
                ConversionFunctions.Add(VolumeFlowUnit.CubicYardPerSecond, "x * 0.764554857984");
                ConversionFunctions.Add(VolumeFlowUnit.CubicYardPerMinute, "x * 0.0127425809664");
                ConversionFunctions.Add(VolumeFlowUnit.CubicYardPerHour, "x * 2.1237634944E-4");
                ConversionFunctions.Add(VolumeFlowUnit.CubicYardPerDay, "x / 113007");
                ConversionFunctions.Add(VolumeFlowUnit.MillionUsGallonPerDay, "x / 22.824465227");
                ConversionFunctions.Add(VolumeFlowUnit.UsGallonPerDay, "x / 22824465.227");
                ConversionFunctions.Add(VolumeFlowUnit.LiterPerSecond, "x / 1000");
                ConversionFunctions.Add(VolumeFlowUnit.LiterPerMinute, "x / 60000.00000");
                ConversionFunctions.Add(VolumeFlowUnit.LiterPerHour, "x / 3600000.000");
                ConversionFunctions.Add(VolumeFlowUnit.LiterPerDay, "x / 86400000");
                ConversionFunctions.Add(VolumeFlowUnit.UsGallonPerSecond, "x / 264.1720523581484");
                ConversionFunctions.Add(VolumeFlowUnit.UsGallonPerMinute, "x / 15850.323141489");
                ConversionFunctions.Add(VolumeFlowUnit.UkGallonPerDay, "x / 19005304");
                ConversionFunctions.Add(VolumeFlowUnit.UkGallonPerHour, "x / 791887.667");
                ConversionFunctions.Add(VolumeFlowUnit.UkGallonPerMinute, "x / 13198.2");
                ConversionFunctions.Add(VolumeFlowUnit.UkGallonPerSecond, "x / 219.969");
                ConversionFunctions.Add(VolumeFlowUnit.KilousGallonPerMinute, "x / 15.850323141489");
                ConversionFunctions.Add(VolumeFlowUnit.UsGallonPerHour, "x / 951019.38848933424");
                ConversionFunctions.Add(VolumeFlowUnit.CubicDecimeterPerMinute, "x / 60000.00000");
                ConversionFunctions.Add(VolumeFlowUnit.OilBarrelPerDay, "x * 1.8401307283333333333333333333333e-6");
                ConversionFunctions.Add(VolumeFlowUnit.OilBarrelPerMinute, "x * 2.64978825e-3");
                ConversionFunctions.Add(VolumeFlowUnit.OilBarrelPerHour, "x * 4.41631375e-5");
                ConversionFunctions.Add(VolumeFlowUnit.OilBarrelPerSecond, "x / 6.28981");
                ConversionFunctions.Add(VolumeFlowUnit.AcreFootPerSecond, "x / 0.000810713194");
                ConversionFunctions.Add(VolumeFlowUnit.AcreFootPerMinute, "x / 0.0486427916");
                ConversionFunctions.Add(VolumeFlowUnit.AcreFootPerHour, "x / 2.91857");
                ConversionFunctions.Add(VolumeFlowUnit.AcreFootPerDay, "x / 70.0457");
                ConversionFunctions.Add(VolumeFlowUnit.CubicCentimeterPerMinute, "x * 1.6666666666667e-8");
                ConversionFunctions.Add(VolumeFlowUnit.CubicYottameterpersecond, "x * 1e72");
                ConversionFunctions.Add(VolumeFlowUnit.CubicZettameterpersecond, "x * 1e63");
                ConversionFunctions.Add(VolumeFlowUnit.CubicExameterpersecond, "x * 1e54");
                ConversionFunctions.Add(VolumeFlowUnit.CubicPetameterpersecond, "x * 1e45");
                ConversionFunctions.Add(VolumeFlowUnit.CubicTerameterpersecond, "x * 1e36");
                ConversionFunctions.Add(VolumeFlowUnit.CubicGigameterpersecond, "x * 1e27");
                ConversionFunctions.Add(VolumeFlowUnit.CubicMegameterpersecond, "x * 1e18");
                ConversionFunctions.Add(VolumeFlowUnit.CubicKilometerpersecond, "x * 1e9");
                ConversionFunctions.Add(VolumeFlowUnit.CubicHectometerpersecond, "x * 1e6");
                ConversionFunctions.Add(VolumeFlowUnit.CubicDekameterpersecond, "x * 1e3");
                ConversionFunctions.Add(VolumeFlowUnit.CubicMeterPerSecond, "x * 1e0");
                ConversionFunctions.Add(VolumeFlowUnit.CubicDecimeterpersecond, "x * 1e-3");
                ConversionFunctions.Add(VolumeFlowUnit.CubicCentimeterpersecond, "x * 1e-6");
                ConversionFunctions.Add(VolumeFlowUnit.CubicMillimeterpersecond, "x * 1e-9");
                ConversionFunctions.Add(VolumeFlowUnit.CubicMicrometerpersecond, "x * 1e-18");
                ConversionFunctions.Add(VolumeFlowUnit.CubicNanometerpersecond, "x * 1e-27");
                ConversionFunctions.Add(VolumeFlowUnit.CubicPicometerpersecond, "x * 1e-36");
                ConversionFunctions.Add(VolumeFlowUnit.CubicFemtometerpersecond, "x * 1e-45");
                ConversionFunctions.Add(VolumeFlowUnit.CubicAttometerpersecond, "x * 1e-54");
                ConversionFunctions.Add(VolumeFlowUnit.CubicZeptometerpersecond, "x * 1e-63");
                ConversionFunctions.Add(VolumeFlowUnit.CubicYoctometerpersecond, "x * 1e-72");
            }
        }
    }
