
    // Auto-generated for VNet on 2023-07-06 12:42:23
    using System.Numerics;
    
    
    namespace VNet.Scientific.Measurement.Dimensions
    {
        public sealed class RelativeHumidity<TVal> : DimensionBase<RelativeHumidityUnit, TVal> where TVal : notnull, INumber<TVal>
        {
            public override string IdTag => nameof(RelativeHumidity<TVal>);
            
            public RelativeHumidity() : base()
            {
                Exponents.Length = 0;
                Exponents.Mass = 0;
                Exponents.Time = 0;
                Exponents.ElectricalCurrent = 0;
                Exponents.LuminousIntensity = 0;
                Exponents.Temperature = 0;
                Exponents.Amount = 0;
                
                DefaultUnit = RelativeHumidityUnit.Percent;
                
                Symbols.Add(RelativeHumidityUnit.Percent, "%RH");
                
                
                ConversionFunctions.Add(RelativeHumidityUnit.Percent, "x");
            }
        }
    }
