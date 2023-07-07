
    // Auto-generated for VNet on 2023-07-06 12:42:23
    using System.Numerics;
    
    
    namespace VNet.Scientific.Measurement.Dimensions
    {
        public sealed class Level<TVal> : DimensionBase<LevelUnit, TVal> where TVal : notnull, INumber<TVal>
        {
            public override string IdTag => nameof(Level<TVal>);
            
            public Level() : base()
            {
                Exponents.Length = 0;
                Exponents.Mass = 0;
                Exponents.Time = 0;
                Exponents.ElectricalCurrent = 0;
                Exponents.LuminousIntensity = 0;
                Exponents.Temperature = 0;
                Exponents.Amount = 0;
                
                DefaultUnit = LevelUnit.Decibel;
                
                Symbols.Add(LevelUnit.Decibel, "dB");
                Symbols.Add(LevelUnit.Neper, "Np");
                
                
                ConversionFunctions.Add(LevelUnit.Decibel, "x");
                ConversionFunctions.Add(LevelUnit.Neper, "(1 / 0.115129254) * x");
            }
        }
    }
