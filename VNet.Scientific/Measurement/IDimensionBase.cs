using System.Numerics;

// ReSharper disable UnusedMember.Global
// ReSharper disable StaticMemberInGenericType

namespace VNet.Scientific.Measurement;

public interface IDimensionBase<TUnit, TVal> where TUnit : notnull, Enum
                                             where TVal : notnull, INumber<TVal>
    
{
    public string IdTag { get; }
    public DimensionExponents Exponents { get; init; }



    public void ValidateUnit(TUnit unit);
    public TVal ConvertToDefaultUnit(TVal value, TUnit fromUnit);
    public TVal ConvertFromDefaultUnit(TVal value, TUnit toUnit);
}