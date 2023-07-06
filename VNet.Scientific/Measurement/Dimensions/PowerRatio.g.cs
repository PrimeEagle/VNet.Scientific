
    // Auto-generated for VNet on 2023-07-05 10:35:43
    using System.Numerics;
    
    
    namespace VNet.Scientific.Measurement.Dimensions
    {
        public sealed class PowerRatio<TVal> : DimensionBase<PowerRatioUnit, TVal> where TVal : notnull, INumber<TVal>
        {
            public override string IdTag => nameof(PowerRatio<TVal>);
            
            public PowerRatio() : base()
            {
                DimensionComponent.Exponents.Length = 0;
                DimensionComponent.Exponents.Mass = 0;
                DimensionComponent.Exponents.Time = 0;
                DimensionComponent.Exponents.ElectricalCurrent = 0;
                DimensionComponent.Exponents.LuminousIntensity = 0;
                DimensionComponent.Exponents.Temperature = 0;
                DimensionComponent.Exponents.Amount = 0;
                
                DefaultUnit = PowerRatioUnit.DecibelWatt;
                
                Symbols.Add(PowerRatioUnit.DecibelWatt, "dBW");
                Symbols.Add(PowerRatioUnit.DecibelMilliwatt, "dBmW");
                
                PluralSymbols.Add(PowerRatioUnit.DecibelMilliwatt, "dBm");
                
                ConversionFunctions.Add(PowerRatioUnit.DecibelWatt, "x");
                ConversionFunctions.Add(PowerRatioUnit.DecibelMilliwatt, "x - 30");
            }
        }
    }
