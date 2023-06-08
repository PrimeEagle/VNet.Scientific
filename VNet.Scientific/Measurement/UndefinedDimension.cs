using System.Numerics;
// ReSharper disable UnusedMember.Global
// ReSharper disable ClassNeverInstantiated.Global
// ReSharper disable StaticMemberInGenericType
// ReSharper disable ConvertToConstant.Local

namespace VNet.Scientific.Measurement;

public sealed class UndefinedDimension<TVal> : DimensionBase<LengthUnit, TVal> where TVal : notnull, INumber<TVal>
{
    public override string IdTag => nameof(UndefinedDimension<TVal>);

    public UndefinedDimension() : base()
    {

    }
}