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

    public Type FindMatchingDimensions()
    {
        Type matchedType = null;

        // ReSharper disable once ForeachCanBeConvertedToQueryUsingAnotherGetEnumerator
        foreach (var unitType in UnitLookup.ConversionFactors.Keys)
        {
            var dimensionTypeName = unitType?.GetType().Name.Replace("Unit", "");
            var dimensionType = Type.GetType(dimensionTypeName ?? throw new InvalidOperationException());


            
            var lengthNumerator = (float)(dimensionType?.GetProperty("LengthNumeratorExponent")?.GetValue(null, null) ?? throw new InvalidOperationException());
            if (lengthNumerator != Dimension.LengthNumeratorExponent) continue;

            var massNumerator = (float)(dimensionType?.GetProperty("MassNumeratorExponent")?.GetValue(null, null) ?? throw new InvalidOperationException());
            if (massNumerator != Dimension.MassNumeratorExponent) continue;

            var timeNumerator = (float)(dimensionType?.GetProperty("TimeNumeratorExponent")?.GetValue(null, null) ?? throw new InvalidOperationException());
            if (timeNumerator != Dimension.TimeNumeratorExponent) continue;

            var electricalCurrentNumerator = (float)(dimensionType?.GetProperty("ElectricalCurrentNumeratorExponent")?.GetValue(null, null) ?? throw new InvalidOperationException());
            if (electricalCurrentNumerator != Dimension.ElectricalCurrentNumeratorExponent) continue;

            var luminousIntensityNumerator = (float)(dimensionType?.GetProperty("LuminousIntensityNumeratorExponent")?.GetValue(null, null) ?? throw new InvalidOperationException());
            if (luminousIntensityNumerator != Dimension.LuminousIntensityNumeratorExponent) continue;

            var temperatureNumerator = (float)(dimensionType?.GetProperty("TemperatureNumeratorExponent")?.GetValue(null, null) ?? throw new InvalidOperationException());
            if (temperatureNumerator != Dimension.TemperatureNumeratorExponent) continue;

            var amountNumerator = (float)(dimensionType?.GetProperty("AmountNumeratorExponent")?.GetValue(null, null) ?? throw new InvalidOperationException());
            if (amountNumerator != Dimension.AmountNumeratorExponent) continue;


            var lengthDenominator = (float)(dimensionType?.GetProperty("LengthDenominatorExponent")?.GetValue(null, null) ?? throw new InvalidOperationException());
            if (lengthDenominator != Dimension.LengthDenominatorExponent) continue;

            var massDenominator = (float)(dimensionType?.GetProperty("MassDenominatorExponent")?.GetValue(null, null) ?? throw new InvalidOperationException());
            if (massDenominator != Dimension.MassDenominatorExponent) continue;

            var timeDenominator = (float)(dimensionType?.GetProperty("TimeDenominatorExponent")?.GetValue(null, null) ?? throw new InvalidOperationException());
            if (timeDenominator != Dimension.TimeDenominatorExponent) continue;

            var electricalCurrentDenominator = (float)(dimensionType?.GetProperty("ElectricalCurrentDenominatorExponent")?.GetValue(null, null) ?? throw new InvalidOperationException());
            if (electricalCurrentDenominator != Dimension.ElectricalCurrentDenominatorExponent) continue;

            var luminousIntensityDenominator = (float)(dimensionType?.GetProperty("LuminousIntensityDenominatorExponent")?.GetValue(null, null) ?? throw new InvalidOperationException());
            if (luminousIntensityDenominator != Dimension.LuminousIntensityDenominatorExponent) continue;

            var temperatureDenominator = (float)(dimensionType?.GetProperty("TemperatureDenominatorExponent")?.GetValue(null, null) ?? throw new InvalidOperationException());
            if (temperatureDenominator != Dimension.TemperatureDenominatorExponent) continue;

            var amountDenominator = (float)(dimensionType?.GetProperty("AmountDenominatorExponent")?.GetValue(null, null) ?? throw new InvalidOperationException());
            if (amountDenominator != Dimension.AmountDenominatorExponent) continue;

            matchedType = dimensionType;
            break;
        }

        matchedType ??= typeof(UniversalDimension);

        return matchedType;
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

    public static Measurement<TDim, TVal> operator -(Measurement<TDim, TVal> a)
    {
        return new Measurement<TDim, TVal>(-a.Value);
    }
}