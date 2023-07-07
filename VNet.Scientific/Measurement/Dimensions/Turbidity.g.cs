
    // Auto-generated for VNet on 2023-07-06 12:42:23
    using System.Numerics;
    
    
    namespace VNet.Scientific.Measurement.Dimensions
    {
        public sealed class Turbidity<TVal> : DimensionBase<TurbidityUnit, TVal> where TVal : notnull, INumber<TVal>
        {
            public override string IdTag => nameof(Turbidity<TVal>);
            
            public Turbidity() : base()
            {
                Exponents.Length = 0;
                Exponents.Mass = 0;
                Exponents.Time = 0;
                Exponents.ElectricalCurrent = 0;
                Exponents.LuminousIntensity = 0;
                Exponents.Temperature = 0;
                Exponents.Amount = 0;
                
                DefaultUnit = TurbidityUnit.NTU;
                
                Symbols.Add(TurbidityUnit.NTU, "NTU");
                
                
                ConversionFunctions.Add(TurbidityUnit.NTU, "x");
            }
        }
    }
