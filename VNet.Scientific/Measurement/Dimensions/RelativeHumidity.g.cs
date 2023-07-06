
    // Auto-generated for VNet on 2023-07-05 10:35:43
    using System.Numerics;
    
    
    namespace VNet.Scientific.Measurement.Dimensions
    {
        public sealed class RelativeHumidity<TVal> : DimensionBase<RelativeHumidityUnit, TVal> where TVal : notnull, INumber<TVal>
        {
            public override string IdTag => nameof(RelativeHumidity<TVal>);
            
            public RelativeHumidity() : base()
            {
                DimensionComponent.Exponents.Length = 0;
                DimensionComponent.Exponents.Mass = 0;
                DimensionComponent.Exponents.Time = 0;
                DimensionComponent.Exponents.ElectricalCurrent = 0;
                DimensionComponent.Exponents.LuminousIntensity = 0;
                DimensionComponent.Exponents.Temperature = 0;
                DimensionComponent.Exponents.Amount = 0;
                
                DefaultUnit = RelativeHumidityUnit.Percent;
                
                Symbols.Add(RelativeHumidityUnit.Percent, "%RH");
                
                
                ConversionFunctions.Add(RelativeHumidityUnit.Percent, "x");
            }
        }
    }
