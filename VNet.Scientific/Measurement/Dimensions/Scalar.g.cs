
    // Auto-generated for VNet on 2023-07-05 10:35:43
    using System.Numerics;
    
    
    namespace VNet.Scientific.Measurement.Dimensions
    {
        public sealed class Scalar<TVal> : DimensionBase<ScalarUnit, TVal> where TVal : notnull, INumber<TVal>
        {
            public override string IdTag => nameof(Scalar<TVal>);
            
            public Scalar() : base()
            {
                DimensionComponent.Exponents.Length = 0;
                DimensionComponent.Exponents.Mass = 0;
                DimensionComponent.Exponents.Time = 0;
                DimensionComponent.Exponents.ElectricalCurrent = 0;
                DimensionComponent.Exponents.LuminousIntensity = 0;
                DimensionComponent.Exponents.Temperature = 0;
                DimensionComponent.Exponents.Amount = 0;
                
                DefaultUnit = ScalarUnit.Amount;
                
                
                
                ConversionFunctions.Add(ScalarUnit.Amount, "x");
            }
        }
    }
