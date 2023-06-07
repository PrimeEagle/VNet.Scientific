using System.Numerics;
// ReSharper disable UnusedMember.Global
// ReSharper disable StaticMemberInGenericType
#pragma warning disable CA2211

namespace VNet.Scientific.Measurement;

public interface IDimensionBase<TVal> where TVal : notnull, INumber<TVal>
{
    public void ValidateUnit(Enum unit);
    public TVal ConvertToDefaultUnit(TVal value, Enum fromUnit);
    public TVal ConvertFromDefaultUnit(TVal value, Enum toUnit);
    public float LengthNumeratorExponent { get; }
    public float MassNumeratorExponent { get; }
    public float TimeNumeratorExponent { get; }
    public float ElectricalCurrentNumeratorExponent { get; }
    public float LuminousIntensityNumeratorExponent { get; }
    public float AmountNumeratorExponent { get; }
    public float TemperatureNumeratorExponent { get; }

    public float LengthDenominatorExponent { get; }
    public float MassDenominatorExponent { get; }
    public float TimeDenominatorExponent { get; }
    public float ElectricalCurrentDenominatorExponent { get; }
    public float LuminousIntensityDenominatorExponent { get; }
    public float AmountDenominatorExponent { get; }
    public float TemperatureDenominatorExponent { get; }
}