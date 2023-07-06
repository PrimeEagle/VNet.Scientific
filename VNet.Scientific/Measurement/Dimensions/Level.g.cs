
    // Auto-generated for VNet on 2023-07-05 10:35:43
    using System.Numerics;
    
    
    namespace VNet.Scientific.Measurement.Dimensions
    {
        public sealed class Level<TVal> : DimensionBase<LevelUnit, TVal> where TVal : notnull, INumber<TVal>
        {
            public override string IdTag => nameof(Level<TVal>);
            
            public Level() : base()
            {
                DimensionComponent.Exponents.Length = 0;
                DimensionComponent.Exponents.Mass = 0;
                DimensionComponent.Exponents.Time = 0;
                DimensionComponent.Exponents.ElectricalCurrent = 0;
                DimensionComponent.Exponents.LuminousIntensity = 0;
                DimensionComponent.Exponents.Temperature = 0;
                DimensionComponent.Exponents.Amount = 0;
                
                DefaultUnit = LevelUnit.Decibel;
                
                Symbols.Add(LevelUnit.Decibel, "dB");
                Symbols.Add(LevelUnit.Neper, "Np");
                
                
                ConversionFunctions.Add(LevelUnit.Decibel, "x");
                ConversionFunctions.Add(LevelUnit.Neper, "(1 / 0.115129254) * x");
            }
        }
    }
