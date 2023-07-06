
    // Auto-generated for VNet on 2023-07-05 10:35:43
    using System.Numerics;
    
    
    namespace VNet.Scientific.Measurement.Dimensions
    {
        public sealed class Turbidity<TVal> : DimensionBase<TurbidityUnit, TVal> where TVal : notnull, INumber<TVal>
        {
            public override string IdTag => nameof(Turbidity<TVal>);
            
            public Turbidity() : base()
            {
                DimensionComponent.Exponents.Length = 0;
                DimensionComponent.Exponents.Mass = 0;
                DimensionComponent.Exponents.Time = 0;
                DimensionComponent.Exponents.ElectricalCurrent = 0;
                DimensionComponent.Exponents.LuminousIntensity = 0;
                DimensionComponent.Exponents.Temperature = 0;
                DimensionComponent.Exponents.Amount = 0;
                
                DefaultUnit = TurbidityUnit.NTU;
                
                Symbols.Add(TurbidityUnit.NTU, "NTU");
                
                
                ConversionFunctions.Add(TurbidityUnit.NTU, "x");
            }
        }
    }
