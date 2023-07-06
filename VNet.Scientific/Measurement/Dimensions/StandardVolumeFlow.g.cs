
    // Auto-generated for VNet on 2023-07-05 10:35:43
    using System.Numerics;
    
    
    namespace VNet.Scientific.Measurement.Dimensions
    {
        public sealed class StandardVolumeFlow<TVal> : DimensionBase<StandardVolumeFlowUnit, TVal> where TVal : notnull, INumber<TVal>
        {
            public override string IdTag => nameof(StandardVolumeFlow<TVal>);
            
            public StandardVolumeFlow() : base()
            {
                DimensionComponent.Exponents.Length = 0;
                DimensionComponent.Exponents.Mass = 1;
                DimensionComponent.Exponents.Time = -1;
                DimensionComponent.Exponents.ElectricalCurrent = 0;
                DimensionComponent.Exponents.LuminousIntensity = 0;
                DimensionComponent.Exponents.Temperature = 0;
                DimensionComponent.Exponents.Amount = 0;
                
                DefaultUnit = StandardVolumeFlowUnit.StandardCubicMeterPerSecond;
                
                Symbols.Add(StandardVolumeFlowUnit.StandardCubicMeterPerMinute, "Sm³/min");
                Symbols.Add(StandardVolumeFlowUnit.StandardCubicMeterPerHour, "Sm³/h");
                Symbols.Add(StandardVolumeFlowUnit.StandardCubicMeterPerDay, "Sm³/d");
                Symbols.Add(StandardVolumeFlowUnit.StandardCubicCentimeterPerMinute, "sccm");
                Symbols.Add(StandardVolumeFlowUnit.StandardLiterPerMinute, "slm");
                Symbols.Add(StandardVolumeFlowUnit.StandardCubicFootPerSecond, "Sft³/s");
                Symbols.Add(StandardVolumeFlowUnit.StandardCubicFootPerMinute, "scfm");
                Symbols.Add(StandardVolumeFlowUnit.StandardCubicFootPerHour, "scfh");
                Symbols.Add(StandardVolumeFlowUnit.StandardcubicYottameterpersecond, "YSm³/s");
                Symbols.Add(StandardVolumeFlowUnit.StandardcubicZettameterpersecond, "ZSm³/s");
                Symbols.Add(StandardVolumeFlowUnit.StandardcubicExameterpersecond, "ESm³/s");
                Symbols.Add(StandardVolumeFlowUnit.StandardcubicPetameterpersecond, "PSm³/s");
                Symbols.Add(StandardVolumeFlowUnit.StandardcubicTerameterpersecond, "TSm³/s");
                Symbols.Add(StandardVolumeFlowUnit.StandardcubicGigameterpersecond, "GSm³/s");
                Symbols.Add(StandardVolumeFlowUnit.StandardcubicMegameterpersecond, "MSm³/s");
                Symbols.Add(StandardVolumeFlowUnit.StandardcubicKilometerpersecond, "kSm³/s");
                Symbols.Add(StandardVolumeFlowUnit.StandardcubicHectometerpersecond, "hSm³/s");
                Symbols.Add(StandardVolumeFlowUnit.StandardcubicDekameterpersecond, "daSm³/s");
                Symbols.Add(StandardVolumeFlowUnit.StandardCubicMeterPerSecond, "Sm³/s");
                Symbols.Add(StandardVolumeFlowUnit.StandardcubicDecimeterpersecond, "dSm³/s");
                Symbols.Add(StandardVolumeFlowUnit.StandardcubicCentimeterpersecond, "cSm³/s");
                Symbols.Add(StandardVolumeFlowUnit.StandardcubicMillimeterpersecond, "mSm³/s");
                Symbols.Add(StandardVolumeFlowUnit.StandardcubicMicrometerpersecond, "µSm³/s");
                Symbols.Add(StandardVolumeFlowUnit.StandardcubicNanometerpersecond, "nSm³/s");
                Symbols.Add(StandardVolumeFlowUnit.StandardcubicPicometerpersecond, "pSm³/s");
                Symbols.Add(StandardVolumeFlowUnit.StandardcubicFemtometerpersecond, "fSm³/s");
                Symbols.Add(StandardVolumeFlowUnit.StandardcubicAttometerpersecond, "aSm³/s");
                Symbols.Add(StandardVolumeFlowUnit.StandardcubicZeptometerpersecond, "zSm³/s");
                Symbols.Add(StandardVolumeFlowUnit.StandardcubicYoctometerpersecond, "ySm³/s");
                
                
                ConversionFunctions.Add(StandardVolumeFlowUnit.StandardCubicMeterPerMinute, "x / 60");
                ConversionFunctions.Add(StandardVolumeFlowUnit.StandardCubicMeterPerHour, "x / 3600");
                ConversionFunctions.Add(StandardVolumeFlowUnit.StandardCubicMeterPerDay, "x / 86400");
                ConversionFunctions.Add(StandardVolumeFlowUnit.StandardCubicCentimeterPerMinute, "x / 6e7");
                ConversionFunctions.Add(StandardVolumeFlowUnit.StandardLiterPerMinute, "x / 60000");
                ConversionFunctions.Add(StandardVolumeFlowUnit.StandardCubicFootPerSecond, "x / 35.314666721");
                ConversionFunctions.Add(StandardVolumeFlowUnit.StandardCubicFootPerMinute, "x / 2118.88000326");
                ConversionFunctions.Add(StandardVolumeFlowUnit.StandardCubicFootPerHour, "x * 7.8657907199999087346816086183876e-6");
                ConversionFunctions.Add(StandardVolumeFlowUnit.StandardcubicYottameterpersecond, "x * 1e72");
                ConversionFunctions.Add(StandardVolumeFlowUnit.StandardcubicZettameterpersecond, "x * 1e63");
                ConversionFunctions.Add(StandardVolumeFlowUnit.StandardcubicExameterpersecond, "x * 1e54");
                ConversionFunctions.Add(StandardVolumeFlowUnit.StandardcubicPetameterpersecond, "x * 1e45");
                ConversionFunctions.Add(StandardVolumeFlowUnit.StandardcubicTerameterpersecond, "x * 1e36");
                ConversionFunctions.Add(StandardVolumeFlowUnit.StandardcubicGigameterpersecond, "x * 1e27");
                ConversionFunctions.Add(StandardVolumeFlowUnit.StandardcubicMegameterpersecond, "x * 1e18");
                ConversionFunctions.Add(StandardVolumeFlowUnit.StandardcubicKilometerpersecond, "x * 1e9");
                ConversionFunctions.Add(StandardVolumeFlowUnit.StandardcubicHectometerpersecond, "x * 1e6");
                ConversionFunctions.Add(StandardVolumeFlowUnit.StandardcubicDekameterpersecond, "x * 1e3");
                ConversionFunctions.Add(StandardVolumeFlowUnit.StandardCubicMeterPerSecond, "x * 1e0");
                ConversionFunctions.Add(StandardVolumeFlowUnit.StandardcubicDecimeterpersecond, "x * 1e-3");
                ConversionFunctions.Add(StandardVolumeFlowUnit.StandardcubicCentimeterpersecond, "x * 1e-6");
                ConversionFunctions.Add(StandardVolumeFlowUnit.StandardcubicMillimeterpersecond, "x * 1e-9");
                ConversionFunctions.Add(StandardVolumeFlowUnit.StandardcubicMicrometerpersecond, "x * 1e-18");
                ConversionFunctions.Add(StandardVolumeFlowUnit.StandardcubicNanometerpersecond, "x * 1e-27");
                ConversionFunctions.Add(StandardVolumeFlowUnit.StandardcubicPicometerpersecond, "x * 1e-36");
                ConversionFunctions.Add(StandardVolumeFlowUnit.StandardcubicFemtometerpersecond, "x * 1e-45");
                ConversionFunctions.Add(StandardVolumeFlowUnit.StandardcubicAttometerpersecond, "x * 1e-54");
                ConversionFunctions.Add(StandardVolumeFlowUnit.StandardcubicZeptometerpersecond, "x * 1e-63");
                ConversionFunctions.Add(StandardVolumeFlowUnit.StandardcubicYoctometerpersecond, "x * 1e-72");
            }
        }
    }
