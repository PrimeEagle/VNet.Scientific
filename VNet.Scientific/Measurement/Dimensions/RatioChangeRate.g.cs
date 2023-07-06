
    // Auto-generated for VNet on 2023-07-05 10:35:43
    using System.Numerics;
    
    
    namespace VNet.Scientific.Measurement.Dimensions
    {
        public sealed class RatioChangeRate<TVal> : DimensionBase<RatioChangeRateUnit, TVal> where TVal : notnull, INumber<TVal>
        {
            public override string IdTag => nameof(RatioChangeRate<TVal>);
            
            public RatioChangeRate() : base()
            {
                DimensionComponent.Exponents.Length = 0;
                DimensionComponent.Exponents.Mass = 0;
                DimensionComponent.Exponents.Time = -1;
                DimensionComponent.Exponents.ElectricalCurrent = 0;
                DimensionComponent.Exponents.LuminousIntensity = 0;
                DimensionComponent.Exponents.Temperature = 0;
                DimensionComponent.Exponents.Amount = 0;
                
                DefaultUnit = RatioChangeRateUnit.DecimalFractionPerSecond;
                
                Symbols.Add(RatioChangeRateUnit.PercentPerSecond, "%/s");
                Symbols.Add(RatioChangeRateUnit.DecimalFractionPerSecond, "/s");
                
                
                ConversionFunctions.Add(RatioChangeRateUnit.PercentPerSecond, "x / 1e2");
                ConversionFunctions.Add(RatioChangeRateUnit.DecimalFractionPerSecond, "x");
            }
        }
    }
