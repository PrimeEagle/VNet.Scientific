using System.Numerics;

namespace VNet.Scientific.Measurement;

public interface IDimension<TUnit, TVal> : IDimensionBase<TUnit, TVal> where TUnit : notnull, Enum 
                                                                       where TVal : notnull, INumber<TVal>
{
    public new TUnit DefaultUnit { get; set; }
}