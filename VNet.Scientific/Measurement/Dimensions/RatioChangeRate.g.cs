
    // Auto-generated for VNet on 2023-07-06 12:42:23
    using System.Numerics;
    
    
    namespace VNet.Scientific.Measurement.Dimensions
    {
        public sealed class RatioChangeRate<TVal> : DimensionBase<RatioChangeRateUnit, TVal> where TVal : notnull, INumber<TVal>
        {
            public override string IdTag => nameof(RatioChangeRate<TVal>);
            
            public RatioChangeRate() : base()
            {
                Exponents.Length = 0;
                Exponents.Mass = 0;
                Exponents.Time = -1;
                Exponents.ElectricalCurrent = 0;
                Exponents.LuminousIntensity = 0;
                Exponents.Temperature = 0;
                Exponents.Amount = 0;
                
                DefaultUnit = RatioChangeRateUnit.DecimalFractionPerSecond;
                
                Symbols.Add(RatioChangeRateUnit.PercentPerSecond, "%/s");
                Symbols.Add(RatioChangeRateUnit.DecimalFractionPerSecond, "/s");
                
                
                ConversionFunctions.Add(RatioChangeRateUnit.PercentPerSecond, "x / 1e2");
                ConversionFunctions.Add(RatioChangeRateUnit.DecimalFractionPerSecond, "x");
            }
        }
    }
