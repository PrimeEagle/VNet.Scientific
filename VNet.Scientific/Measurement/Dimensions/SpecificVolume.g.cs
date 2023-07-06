
    // Auto-generated for VNet on 2023-07-05 10:35:43
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
                
                Symbols.Add(SpecificVolumeUnit.CubicFootPerPound, "ft³/lb");
                Symbols.Add(SpecificVolumeUnit.CubicYottameterperkilogram, "Ym³/kg");
                Symbols.Add(SpecificVolumeUnit.CubicZettameterperkilogram, "Zm³/kg");
                Symbols.Add(SpecificVolumeUnit.CubicExameterperkilogram, "Em³/kg");
                Symbols.Add(SpecificVolumeUnit.CubicPetameterperkilogram, "Pm³/kg");
                Symbols.Add(SpecificVolumeUnit.CubicTerameterperkilogram, "Tm³/kg");
                Symbols.Add(SpecificVolumeUnit.CubicGigameterperkilogram, "Gm³/kg");
                Symbols.Add(SpecificVolumeUnit.CubicMegameterperkilogram, "Mm³/kg");
                Symbols.Add(SpecificVolumeUnit.CubicKilometerperkilogram, "km³/kg");
                Symbols.Add(SpecificVolumeUnit.CubicHectometerperkilogram, "hm³/kg");
                Symbols.Add(SpecificVolumeUnit.CubicDekameterperkilogram, "dam³/kg");
                Symbols.Add(SpecificVolumeUnit.CubicMeterPerKilogram, "m³/kg");
                Symbols.Add(SpecificVolumeUnit.CubicDecimeterperkilogram, "dm³/kg");
                Symbols.Add(SpecificVolumeUnit.CubicCentimeterperkilogram, "cm³/kg");
                Symbols.Add(SpecificVolumeUnit.CubicMillimeterperkilogram, "mm³/kg");
                Symbols.Add(SpecificVolumeUnit.CubicMicrometerperkilogram, "µm³/kg");
                Symbols.Add(SpecificVolumeUnit.CubicNanometerperkilogram, "nm³/kg");
                Symbols.Add(SpecificVolumeUnit.CubicPicometerperkilogram, "pm³/kg");
                Symbols.Add(SpecificVolumeUnit.CubicFemtometerperkilogram, "fm³/kg");
                Symbols.Add(SpecificVolumeUnit.CubicAttometerperkilogram, "am³/kg");
                Symbols.Add(SpecificVolumeUnit.CubicZeptometerperkilogram, "zm³/kg");
                Symbols.Add(SpecificVolumeUnit.CubicYoctometerperkilogram, "ym³/kg");
                
                
                ConversionFunctions.Add(SpecificVolumeUnit.CubicFootPerPound, "x / 16.01846353");
                ConversionFunctions.Add(SpecificVolumeUnit.CubicYottameterperkilogram, "x * 1e72");
                ConversionFunctions.Add(SpecificVolumeUnit.CubicZettameterperkilogram, "x * 1e63");
                ConversionFunctions.Add(SpecificVolumeUnit.CubicExameterperkilogram, "x * 1e54");
                ConversionFunctions.Add(SpecificVolumeUnit.CubicPetameterperkilogram, "x * 1e45");
                ConversionFunctions.Add(SpecificVolumeUnit.CubicTerameterperkilogram, "x * 1e36");
                ConversionFunctions.Add(SpecificVolumeUnit.CubicGigameterperkilogram, "x * 1e27");
                ConversionFunctions.Add(SpecificVolumeUnit.CubicMegameterperkilogram, "x * 1e18");
                ConversionFunctions.Add(SpecificVolumeUnit.CubicKilometerperkilogram, "x * 1e9");
                ConversionFunctions.Add(SpecificVolumeUnit.CubicHectometerperkilogram, "x * 1e6");
                ConversionFunctions.Add(SpecificVolumeUnit.CubicDekameterperkilogram, "x * 1e3");
                ConversionFunctions.Add(SpecificVolumeUnit.CubicMeterPerKilogram, "x * 1e0");
                ConversionFunctions.Add(SpecificVolumeUnit.CubicDecimeterperkilogram, "x * 1e-3");
                ConversionFunctions.Add(SpecificVolumeUnit.CubicCentimeterperkilogram, "x * 1e-6");
                ConversionFunctions.Add(SpecificVolumeUnit.CubicMillimeterperkilogram, "x * 1e-9");
                ConversionFunctions.Add(SpecificVolumeUnit.CubicMicrometerperkilogram, "x * 1e-18");
                ConversionFunctions.Add(SpecificVolumeUnit.CubicNanometerperkilogram, "x * 1e-27");
                ConversionFunctions.Add(SpecificVolumeUnit.CubicPicometerperkilogram, "x * 1e-36");
                ConversionFunctions.Add(SpecificVolumeUnit.CubicFemtometerperkilogram, "x * 1e-45");
                ConversionFunctions.Add(SpecificVolumeUnit.CubicAttometerperkilogram, "x * 1e-54");
                ConversionFunctions.Add(SpecificVolumeUnit.CubicZeptometerperkilogram, "x * 1e-63");
                ConversionFunctions.Add(SpecificVolumeUnit.CubicYoctometerperkilogram, "x * 1e-72");
            }
        }
    }
