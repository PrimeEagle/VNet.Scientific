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
        return a.Dimension.LengthNumeratorExponent == b.Dimension.LengthNumeratorExponent &&
               a.Dimension.MassNumeratorExponent == b.Dimension.MassNumeratorExponent &&
               a.Dimension.TimeNumeratorExponent == b.Dimension.TimeNumeratorExponent &&
               a.Dimension.ElectricalCurrentNumeratorExponent == b.Dimension.ElectricalCurrentNumeratorExponent &&
               a.Dimension.LuminousIntensityNumeratorExponent == b.Dimension.LuminousIntensityNumeratorExponent &&
               a.Dimension.TimeNumeratorExponent == b.Dimension.TimeNumeratorExponent &&
               a.Dimension.AmountNumeratorExponent == b.Dimension.AmountNumeratorExponent &&
               a.Dimension.LengthDenominatorExponent == b.Dimension.LengthDenominatorExponent &&
               a.Dimension.MassDenominatorExponent == b.Dimension.MassDenominatorExponent &&
               a.Dimension.TimeDenominatorExponent == b.Dimension.TimeDenominatorExponent &&
               a.Dimension.ElectricalCurrentDenominatorExponent == b.Dimension.ElectricalCurrentDenominatorExponent &&
               a.Dimension.LuminousIntensityDenominatorExponent == b.Dimension.LuminousIntensityDenominatorExponent &&
               a.Dimension.TimeDenominatorExponent == b.Dimension.TimeDenominatorExponent &&
               a.Dimension.AmountDenominatorExponent == b.Dimension.AmountDenominatorExponent;
    }

    private static Type FindMatchingDimensions(Measurement<TDim, TVal> a)
    {
        Type matchedType = null;

        // ReSharper disable once ForeachCanBeConvertedToQueryUsingAnotherGetEnumerator
        foreach (var unitType in UnitLookup.ConversionFactors.Keys)
        {
            var dimensionTypeName = unitType?.GetType().Name.Replace("Unit", "");
            var dimensionType = Type.GetType(dimensionTypeName ?? throw new InvalidOperationException());


            
            var lengthNumerator = (float)(dimensionType?.GetProperty("LengthNumeratorExponent")?.GetValue(null, null) ?? throw new InvalidOperationException());
            if (lengthNumerator != a.Dimension.LengthNumeratorExponent) continue;

            var massNumerator = (float)(dimensionType?.GetProperty("MassNumeratorExponent")?.GetValue(null, null) ?? throw new InvalidOperationException());
            if (massNumerator != a.Dimension.MassNumeratorExponent) continue;

            var timeNumerator = (float)(dimensionType?.GetProperty("TimeNumeratorExponent")?.GetValue(null, null) ?? throw new InvalidOperationException());
            if (timeNumerator != a.Dimension.TimeNumeratorExponent) continue;

            var electricalCurrentNumerator = (float)(dimensionType?.GetProperty("ElectricalCurrentNumeratorExponent")?.GetValue(null, null) ?? throw new InvalidOperationException());
            if (electricalCurrentNumerator != a.Dimension.ElectricalCurrentNumeratorExponent) continue;

            var luminousIntensityNumerator = (float)(dimensionType?.GetProperty("LuminousIntensityNumeratorExponent")?.GetValue(null, null) ?? throw new InvalidOperationException());
            if (luminousIntensityNumerator != a.Dimension.LuminousIntensityNumeratorExponent) continue;

            var temperatureNumerator = (float)(dimensionType?.GetProperty("TemperatureNumeratorExponent")?.GetValue(null, null) ?? throw new InvalidOperationException());
            if (temperatureNumerator != a.Dimension.TemperatureNumeratorExponent) continue;

            var amountNumerator = (float)(dimensionType?.GetProperty("AmountNumeratorExponent")?.GetValue(null, null) ?? throw new InvalidOperationException());
            if (amountNumerator != a.Dimension.AmountNumeratorExponent) continue;


            var lengthDenominator = (float)(dimensionType?.GetProperty("LengthDenominatorExponent")?.GetValue(null, null) ?? throw new InvalidOperationException());
            if (lengthDenominator != a.Dimension.LengthDenominatorExponent) continue;

            var massDenominator = (float)(dimensionType?.GetProperty("MassDenominatorExponent")?.GetValue(null, null) ?? throw new InvalidOperationException());
            if (massDenominator != a.Dimension.MassDenominatorExponent) continue;

            var timeDenominator = (float)(dimensionType?.GetProperty("TimeDenominatorExponent")?.GetValue(null, null) ?? throw new InvalidOperationException());
            if (timeDenominator != a.Dimension.TimeDenominatorExponent) continue;

            var electricalCurrentDenominator = (float)(dimensionType?.GetProperty("ElectricalCurrentDenominatorExponent")?.GetValue(null, null) ?? throw new InvalidOperationException());
            if (electricalCurrentDenominator != a.Dimension.ElectricalCurrentDenominatorExponent) continue;

            var luminousIntensityDenominator = (float)(dimensionType?.GetProperty("LuminousIntensityDenominatorExponent")?.GetValue(null, null) ?? throw new InvalidOperationException());
            if (luminousIntensityDenominator != a.Dimension.LuminousIntensityDenominatorExponent) continue;

            var temperatureDenominator = (float)(dimensionType?.GetProperty("TemperatureDenominatorExponent")?.GetValue(null, null) ?? throw new InvalidOperationException());
            if (temperatureDenominator != a.Dimension.TemperatureDenominatorExponent) continue;

            var amountDenominator = (float)(dimensionType?.GetProperty("AmountDenominatorExponent")?.GetValue(null, null) ?? throw new InvalidOperationException());
            if (amountDenominator != a.Dimension.AmountDenominatorExponent) continue;

            matchedType = dimensionType;
            break;
        }

        // TODO
        matchedType ??= typeof(UniversalDimension);

        return matchedType;
    }

    private static void ReduceDimensions(Measurement<TDim, TVal> a)
    {
        // TODO
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

        var result = new Measurement<TDim, TVal>(value);
        result.Dimension.LengthNumeratorExponent = a.Dimension.LengthNumeratorExponent + b.Dimension.LengthNumeratorExponent;
        result.Dimension.MassNumeratorExponent = a.Dimension.MassNumeratorExponent + b.Dimension.MassNumeratorExponent;
        result.Dimension.TimeNumeratorExponent = a.Dimension.TimeNumeratorExponent + b.Dimension.TimeNumeratorExponent;
        result.Dimension.ElectricalCurrentNumeratorExponent = a.Dimension.ElectricalCurrentNumeratorExponent + b.Dimension.ElectricalCurrentNumeratorExponent;
        result.Dimension.LuminousIntensityNumeratorExponent = a.Dimension.LuminousIntensityNumeratorExponent + b.Dimension.LuminousIntensityNumeratorExponent;
        result.Dimension.TemperatureNumeratorExponent = a.Dimension.TemperatureNumeratorExponent + b.Dimension.TemperatureNumeratorExponent;
        result.Dimension.AmountNumeratorExponent = a.Dimension.AmountNumeratorExponent + b.Dimension.AmountNumeratorExponent;

        result.Dimension.LengthDenominatorExponent = a.Dimension.LengthDenominatorExponent + b.Dimension.LengthDenominatorExponent;
        result.Dimension.MassDenominatorExponent = a.Dimension.MassDenominatorExponent + b.Dimension.MassDenominatorExponent;
        result.Dimension.TimeDenominatorExponent = a.Dimension.TimeDenominatorExponent + b.Dimension.TimeDenominatorExponent;
        result.Dimension.ElectricalCurrentDenominatorExponent = a.Dimension.ElectricalCurrentDenominatorExponent + b.Dimension.ElectricalCurrentDenominatorExponent;
        result.Dimension.LuminousIntensityDenominatorExponent = a.Dimension.LuminousIntensityDenominatorExponent + b.Dimension.LuminousIntensityDenominatorExponent;
        result.Dimension.TemperatureDenominatorExponent = a.Dimension.TemperatureDenominatorExponent + b.Dimension.TemperatureDenominatorExponent;
        result.Dimension.AmountDenominatorExponent = a.Dimension.AmountDenominatorExponent + b.Dimension.AmountDenominatorExponent;

        ReduceDimensions(result);
        var matchedType = FindMatchingDimensions(result);
        // TODO

        return result;
    }

    public static Measurement<TDim, TVal> operator -(Measurement<TDim, TVal> a)
    {
        return new Measurement<TDim, TVal>(-a.Value);
    }
}