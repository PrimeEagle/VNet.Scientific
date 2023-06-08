using System.Numerics;
// ReSharper disable UnusedMember.Global
// ReSharper disable StaticMemberInGenericType
#pragma warning disable CA2211

namespace VNet.Scientific.Measurement;

public interface IDimensionBase<TVal> where TVal : notnull, INumber<TVal>
{
    public string IdTag { get; }
    public DimensionComponent DimensionComponent { get; init; }



    public void ValidateUnit(Enum unit);
    public TVal ConvertToDefaultUnit(TVal value, Enum fromUnit);
    public TVal ConvertFromDefaultUnit(TVal value, Enum toUnit);
}