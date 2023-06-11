using System.Numerics;

// ReSharper disable UnusedMember.Global
// ReSharper disable ClassNeverInstantiated.Global
// ReSharper disable StaticMemberInGenericType
// ReSharper disable ConvertToConstant.Local

namespace VNet.Scientific.Measurement;

public sealed class Length<TVal> : DimensionBase<LengthUnit, TVal> where TVal : notnull, INumber<TVal>
{
    public override string IdTag => nameof(Length<TVal>);

    public Length() : base()
    {
        Initialize(IdTag);
    }
}