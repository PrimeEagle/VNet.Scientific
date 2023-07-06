
    // Auto-generated for VNet on 2023-07-05 10:24:46
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
