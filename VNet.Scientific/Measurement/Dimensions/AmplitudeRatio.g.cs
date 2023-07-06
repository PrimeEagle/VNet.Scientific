
    // Auto-generated for VNet on 2023-07-05 10:35:43
    using System.Numerics;
    
    
    namespace VNet.Scientific.Measurement.Dimensions
    {
        public sealed class AmplitudeRatio<TVal> : DimensionBase<AmplitudeRatioUnit, TVal> where TVal : notnull, INumber<TVal>
        {
            public override string IdTag => nameof(AmplitudeRatio<TVal>);
            
            public AmplitudeRatio() : base()
            {
                DimensionComponent.Exponents.Length = 0;
                DimensionComponent.Exponents.Mass = 0;
                DimensionComponent.Exponents.Time = 0;
                DimensionComponent.Exponents.ElectricalCurrent = 0;
                DimensionComponent.Exponents.LuminousIntensity = 0;
                DimensionComponent.Exponents.Temperature = 0;
                DimensionComponent.Exponents.Amount = 0;
                
                DefaultUnit = AmplitudeRatioUnit.DecibelVolt;
                
                Symbols.Add(AmplitudeRatioUnit.DecibelVolt, "dBV");
                Symbols.Add(AmplitudeRatioUnit.DecibelMicrovolt, "dBµV");
                Symbols.Add(AmplitudeRatioUnit.DecibelMillivolt, "dBmV");
                Symbols.Add(AmplitudeRatioUnit.DecibelUnloaded, "dBu");
                
                
                ConversionFunctions.Add(AmplitudeRatioUnit.DecibelVolt, "x");
                ConversionFunctions.Add(AmplitudeRatioUnit.DecibelMicrovolt, "x - 120");
                ConversionFunctions.Add(AmplitudeRatioUnit.DecibelMillivolt, "x - 60");
                ConversionFunctions.Add(AmplitudeRatioUnit.DecibelUnloaded, "x - 2.218487499");
            }
        }
    }
