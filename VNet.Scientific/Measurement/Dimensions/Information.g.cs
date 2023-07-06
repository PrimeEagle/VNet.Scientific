
    // Auto-generated for VNet on 2023-07-05 10:35:43
    using System.Numerics;
    
    
    namespace VNet.Scientific.Measurement.Dimensions
    {
        public sealed class Information<TVal> : DimensionBase<InformationUnit, TVal> where TVal : notnull, INumber<TVal>
        {
            public override string IdTag => nameof(Information<TVal>);
            
            public Information() : base()
            {
                DimensionComponent.Exponents.Length = 0;
                DimensionComponent.Exponents.Mass = 0;
                DimensionComponent.Exponents.Time = 0;
                DimensionComponent.Exponents.ElectricalCurrent = 0;
                DimensionComponent.Exponents.LuminousIntensity = 0;
                DimensionComponent.Exponents.Temperature = 0;
                DimensionComponent.Exponents.Amount = 0;
                
                DefaultUnit = InformationUnit.Bit;
                
                Symbols.Add(InformationUnit.Byte, "B");
                Symbols.Add(InformationUnit.Bit, "b");
                
                
                ConversionFunctions.Add(InformationUnit.Byte, "x * 8m");
                ConversionFunctions.Add(InformationUnit.Bit, "x");
            }
        }
    }
