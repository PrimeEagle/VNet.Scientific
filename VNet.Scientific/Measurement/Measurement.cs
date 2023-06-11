using System.Numerics;

// ReSharper disable CompareOfFloatsByEqualityOperator
// ReSharper disable UnusedVariable

namespace VNet.Scientific.Measurement;

public class Measurement<TDim, TVal> where TDim : notnull, IDimensionBase<TVal>
    where TVal : notnull, INumber<TVal>
{
    private TDim Dimension { get; set; }
    private TVal Value { get; set; }


    public Measurement(TVal value)
    {
        Value = value;
    }

    public Measurement(TVal value, Enum unit)
    {
        SetValue(value, unit);
    }

    public void SetValue(TVal value, Enum unit)
    {
        Dimension.ValidateUnit(unit);
        Value = Dimension.ConvertToDefaultUnit(value, unit);
    }

    public TVal GetValue(Enum unit)
    {
        Dimension.ValidateUnit(unit);
        return Dimension.ConvertFromDefaultUnit(Value, unit);
    }

    private static bool AreDimensionsCompatible(Measurement<TDim, TVal> a, Measurement<TDim, TVal> b)
    {
        return a.Dimension.DimensionComponent == b.Dimension.DimensionComponent;
    }

    public static Measurement<TDim, TVal> operator +(Measurement<TDim, TVal> a, Measurement<TDim, TVal> b)
    {
        if (!AreDimensionsCompatible(a, b)) throw new InvalidOperationException("Dimensions are incompatible for this operation.");


        var value = a.Value + b.Value;

        return new Measurement<TDim, TVal>(value);
    }

    public static Measurement<TDim, TVal> operator -(Measurement<TDim, TVal> a, Measurement<TDim, TVal> b)
    {
        if (!AreDimensionsCompatible(a, b)) throw new InvalidOperationException("Dimensions are incompatible for this operation.");

        var value = a.Value - b.Value;

        return new Measurement<TDim, TVal>(value);
    }

    public static Measurement<TDim, TVal> operator *(Measurement<TDim, TVal> a, Measurement<TDim, TVal> b)
    {
        var value = a.Value * b.Value;

        var tempDimensionComponent = a.Dimension.DimensionComponent + b.Dimension.DimensionComponent;
        var matchedDimension = tempDimensionComponent.FindMatch();

        var genericClass = typeof(Measurement<,>);
        var constructedClass = genericClass.MakeGenericType(matchedDimension.GetType(), typeof(TVal));

        var result = (Measurement<TDim,TVal>)Activator.CreateInstance(constructedClass, value)!;
        if (result == null) throw new ArgumentNullException(nameof(result));

        return result;
    }

    public static Measurement<TDim, TVal> operator /(Measurement<TDim, TVal> a, Measurement<TDim, TVal> b)
    {
        var value = a.Value / b.Value;

        var tempDimensionComponent = a.Dimension.DimensionComponent - b.Dimension.DimensionComponent;
        var matchedDimension = tempDimensionComponent.FindMatch();

        var genericClass = typeof(Measurement<,>);
        var constructedClass = genericClass.MakeGenericType(matchedDimension.GetType(), typeof(TVal));

        var result = (Measurement<TDim, TVal>)Activator.CreateInstance(constructedClass, value)!;
        if (result == null) throw new ArgumentNullException(nameof(result));

        return result;
    }

    public static Measurement<TDim, TVal> operator -(Measurement<TDim, TVal> a)
    {
        return new Measurement<TDim, TVal>(-a.Value);
    }
}