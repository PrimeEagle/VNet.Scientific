
    // Auto-generated for VNet on 2023-07-06 12:42:23
    using System.Numerics;
    
    
    namespace VNet.Scientific.Measurement.Dimensions
    {
        public sealed class Scalar<TVal> : DimensionBase<ScalarUnit, TVal> where TVal : notnull, INumber<TVal>
        {
            public override string IdTag => nameof(Scalar<TVal>);
            
            public Scalar() : base()
            {
                Exponents.Length = 0;
                Exponents.Mass = 0;
                Exponents.Time = 0;
                Exponents.ElectricalCurrent = 0;
                Exponents.LuminousIntensity = 0;
                Exponents.Temperature = 0;
                Exponents.Amount = 0;
                
                DefaultUnit = ScalarUnit.Amount;
                
                
                
                ConversionFunctions.Add(ScalarUnit.Amount, "x");
            }
        }
    }
