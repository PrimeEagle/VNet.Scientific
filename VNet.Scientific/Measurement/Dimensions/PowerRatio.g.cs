
    // Auto-generated for VNet on 2023-07-06 12:42:23
    using System.Numerics;
    
    
    namespace VNet.Scientific.Measurement.Dimensions
    {
        public sealed class PowerRatio<TVal> : DimensionBase<PowerRatioUnit, TVal> where TVal : notnull, INumber<TVal>
        {
            public override string IdTag => nameof(PowerRatio<TVal>);
            
            public PowerRatio() : base()
            {
                Exponents.Length = 0;
                Exponents.Mass = 0;
                Exponents.Time = 0;
                Exponents.ElectricalCurrent = 0;
                Exponents.LuminousIntensity = 0;
                Exponents.Temperature = 0;
                Exponents.Amount = 0;
                
                DefaultUnit = PowerRatioUnit.DecibelWatt;
                
                Symbols.Add(PowerRatioUnit.DecibelWatt, "dBW");
                Symbols.Add(PowerRatioUnit.DecibelMilliwatt, "dBmW");
                
                PluralSymbols.Add(PowerRatioUnit.DecibelMilliwatt, "dBm");
                
                ConversionFunctions.Add(PowerRatioUnit.DecibelWatt, "x");
                ConversionFunctions.Add(PowerRatioUnit.DecibelMilliwatt, "x - 30");
            }
        }
    }
