using System.Numerics;

// ReSharper disable UnusedMember.Global
// ReSharper disable ClassNeverInstantiated.Global
// ReSharper disable StaticMemberInGenericType
// ReSharper disable ConvertToConstant.Local

namespace VNet.Scientific.Measurement;

public sealed class Scalar<TVal> : DimensionBase<LengthUnit, TVal> where TVal : notnull, INumber<TVal>
{
    public override string IdTag => nameof(Scalar<TVal>);

    public Scalar() : base()
    {

    }
}