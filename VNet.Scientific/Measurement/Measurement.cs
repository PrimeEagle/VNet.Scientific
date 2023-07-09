using System.Numerics;

// ReSharper disable CompareOfFloatsByEqualityOperator
// ReSharper disable UnusedVariable

namespace VNet.Scientific.Measurement;

public class Measurement<TDim, TUnit, TVal> where TDim : notnull, IDimensionBase<TUnit, TVal>
    where TUnit : notnull, Enum    
    where TVal : notnull, INumber<TVal>
{
    private TDim Dimension { get; set; }
    private TVal Value { get; set; }


    public Measurement(TVal value)
    {
        Value = value;
    }

    public Measurement(TVal value, TUnit unit)
    {
        SetValue(value, unit);
    }

    public void SetValue(TVal value, TUnit unit)
    {
        Dimension.ValidateUnit(unit);
        Value = Dimension.ConvertToDefaultUnit(value, unit);
    }

    public TVal GetValue(TUnit unit)
    {
        Dimension.ValidateUnit(unit);
        return Dimension.ConvertFromDefaultUnit(Value, unit);
    }

    private static bool AreDimensionsCompatible(Measurement<TDim, TUnit, TVal> a, Measurement<TDim, TUnit, TVal> b)
    {
        return a.Dimension.Exponents == b.Dimension.Exponents;
    }

    public static Measurement<TDim, TUnit, TVal> operator +(Measurement<TDim, TUnit, TVal> a, Measurement<TDim, TUnit, TVal> b)
    {
        if (!AreDimensionsCompatible(a, b)) throw new InvalidOperationException("Dimensions are incompatible for this operation.");


        var value = a.Value + b.Value;

        return new Measurement<TDim, TUnit, TVal>(value);
    }

    public static Measurement<TDim, TUnit, TVal> operator -(Measurement<TDim, TUnit, TVal> a, Measurement<TDim, TUnit, TVal> b)
    {
        if (!AreDimensionsCompatible(a, b)) throw new InvalidOperationException("Dimensions are incompatible for this operation.");

        var value = a.Value - b.Value;

        return new Measurement<TDim, TUnit, TVal>(value);
    }

    public static dynamic operator *(Measurement<TDim, TUnit, TVal> a, Measurement<TDim, TUnit, TVal> b)
    {
        var value = a.Value * b.Value;
        var tempDimensionComponent = a.Dimension.Exponents + b.Dimension.Exponents;
        var measurement = tempDimensionComponent.FindMatch();

        return measurement;
    }

    public static dynamic operator /(Measurement<TDim, TUnit, TVal> a, Measurement<TDim, TUnit, TVal> b)
    {
        var value = a.Value / b.Value;

        var tempDimensionComponent = a.Dimension.Exponents - b.Dimension.Exponents;
        var measurement = tempDimensionComponent.FindMatch();

        return measurement;
    }

    public static Measurement<TDim, TUnit, TVal> operator -(Measurement<TDim, TUnit, TVal> a)
    {
        return new Measurement<TDim, TUnit, TVal>(-a.Value);
    }
}