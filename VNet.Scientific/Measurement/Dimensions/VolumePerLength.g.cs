
    // Auto-generated for VNet on 2023-07-05 10:35:43
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
                
                Symbols.Add(VolumePerLengthUnit.LiterPerMeter, "l/m");
                Symbols.Add(VolumePerLengthUnit.LiterPerKilometer, "l/km");
                Symbols.Add(VolumePerLengthUnit.LiterPerMillimeter, "l/mm");
                Symbols.Add(VolumePerLengthUnit.OilBarrelPerFoot, "bbl/ft");
                Symbols.Add(VolumePerLengthUnit.CubicYardPerFoot, "yd³/ft");
                Symbols.Add(VolumePerLengthUnit.CubicYardPerUsSurveyFoot, "yd³/ftUS");
                Symbols.Add(VolumePerLengthUnit.UsGallonPerMile, "gal (U.S.)/mi");
                Symbols.Add(VolumePerLengthUnit.ImperialGallonPerMile, "gal (imp.)/mi");
                Symbols.Add(VolumePerLengthUnit.CubicYottameterpermeter, "Ym³/m");
                Symbols.Add(VolumePerLengthUnit.CubicZettameterpermeter, "Zm³/m");
                Symbols.Add(VolumePerLengthUnit.CubicExameterpermeter, "Em³/m");
                Symbols.Add(VolumePerLengthUnit.CubicPetameterpermeter, "Pm³/m");
                Symbols.Add(VolumePerLengthUnit.CubicTerameterpermeter, "Tm³/m");
                Symbols.Add(VolumePerLengthUnit.CubicGigameterpermeter, "Gm³/m");
                Symbols.Add(VolumePerLengthUnit.CubicMegameterpermeter, "Mm³/m");
                Symbols.Add(VolumePerLengthUnit.CubicKilometerpermeter, "km³/m");
                Symbols.Add(VolumePerLengthUnit.CubicHectometerpermeter, "hm³/m");
                Symbols.Add(VolumePerLengthUnit.CubicDekameterpermeter, "dam³/m");
                Symbols.Add(VolumePerLengthUnit.CubicMeterPerMeter, "m³/m");
                Symbols.Add(VolumePerLengthUnit.CubicDecimeterpermeter, "dm³/m");
                Symbols.Add(VolumePerLengthUnit.CubicCentimeterpermeter, "cm³/m");
                Symbols.Add(VolumePerLengthUnit.CubicMillimeterpermeter, "mm³/m");
                Symbols.Add(VolumePerLengthUnit.CubicMicrometerpermeter, "µm³/m");
                Symbols.Add(VolumePerLengthUnit.CubicNanometerpermeter, "nm³/m");
                Symbols.Add(VolumePerLengthUnit.CubicPicometerpermeter, "pm³/m");
                Symbols.Add(VolumePerLengthUnit.CubicFemtometerpermeter, "fm³/m");
                Symbols.Add(VolumePerLengthUnit.CubicAttometerpermeter, "am³/m");
                Symbols.Add(VolumePerLengthUnit.CubicZeptometerpermeter, "zm³/m");
                Symbols.Add(VolumePerLengthUnit.CubicYoctometerpermeter, "ym³/m");
                
                
                ConversionFunctions.Add(VolumePerLengthUnit.LiterPerMeter, "x / 1000");
                ConversionFunctions.Add(VolumePerLengthUnit.LiterPerKilometer, "x / 1e6");
                ConversionFunctions.Add(VolumePerLengthUnit.LiterPerMillimeter, "x");
                ConversionFunctions.Add(VolumePerLengthUnit.OilBarrelPerFoot, "x / 1.91713408");
                ConversionFunctions.Add(VolumePerLengthUnit.CubicYardPerFoot, "x * 2.50838208");
                ConversionFunctions.Add(VolumePerLengthUnit.CubicYardPerUsSurveyFoot, "x * 2.50837706323584");
                ConversionFunctions.Add(VolumePerLengthUnit.UsGallonPerMile, "x / (1000 * 1609.344 / 3.785411784)");
                ConversionFunctions.Add(VolumePerLengthUnit.ImperialGallonPerMile, "x / (1000 * 1609.344 / 4.54609)");
                ConversionFunctions.Add(VolumePerLengthUnit.CubicYottameterpermeter, "x * 1e72");
                ConversionFunctions.Add(VolumePerLengthUnit.CubicZettameterpermeter, "x * 1e63");
                ConversionFunctions.Add(VolumePerLengthUnit.CubicExameterpermeter, "x * 1e54");
                ConversionFunctions.Add(VolumePerLengthUnit.CubicPetameterpermeter, "x * 1e45");
                ConversionFunctions.Add(VolumePerLengthUnit.CubicTerameterpermeter, "x * 1e36");
                ConversionFunctions.Add(VolumePerLengthUnit.CubicGigameterpermeter, "x * 1e27");
                ConversionFunctions.Add(VolumePerLengthUnit.CubicMegameterpermeter, "x * 1e18");
                ConversionFunctions.Add(VolumePerLengthUnit.CubicKilometerpermeter, "x * 1e9");
                ConversionFunctions.Add(VolumePerLengthUnit.CubicHectometerpermeter, "x * 1e6");
                ConversionFunctions.Add(VolumePerLengthUnit.CubicDekameterpermeter, "x * 1e3");
                ConversionFunctions.Add(VolumePerLengthUnit.CubicMeterPerMeter, "x * 1e0");
                ConversionFunctions.Add(VolumePerLengthUnit.CubicDecimeterpermeter, "x * 1e-3");
                ConversionFunctions.Add(VolumePerLengthUnit.CubicCentimeterpermeter, "x * 1e-6");
                ConversionFunctions.Add(VolumePerLengthUnit.CubicMillimeterpermeter, "x * 1e-9");
                ConversionFunctions.Add(VolumePerLengthUnit.CubicMicrometerpermeter, "x * 1e-18");
                ConversionFunctions.Add(VolumePerLengthUnit.CubicNanometerpermeter, "x * 1e-27");
                ConversionFunctions.Add(VolumePerLengthUnit.CubicPicometerpermeter, "x * 1e-36");
                ConversionFunctions.Add(VolumePerLengthUnit.CubicFemtometerpermeter, "x * 1e-45");
                ConversionFunctions.Add(VolumePerLengthUnit.CubicAttometerpermeter, "x * 1e-54");
                ConversionFunctions.Add(VolumePerLengthUnit.CubicZeptometerpermeter, "x * 1e-63");
                ConversionFunctions.Add(VolumePerLengthUnit.CubicYoctometerpermeter, "x * 1e-72");
            }
        }
    }
