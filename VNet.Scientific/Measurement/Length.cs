using System.Numerics;
// ReSharper disable UnusedMember.Global
// ReSharper disable ClassNeverInstantiated.Global
// ReSharper disable StaticMemberInGenericType
// ReSharper disable ConvertToConstant.Local

namespace VNet.Scientific.Measurement;

public sealed class Length<TVal> : DimensionBase<LengthUnit, TVal> where TVal : notnull, INumber<TVal>
{
    private static readonly float SLengthNumeratorExponent = 1;
    private static readonly float SMassNumeratorExponent = 0;
    private static readonly float STimeNumeratorExponent = 0;
    private static readonly float SElectricalCurrentNumeratorExponent = 0;
    private static readonly float SLuminousIntensityNumeratorExponent = 0;
    private static readonly float SAmountNumeratorExponent = 0;
    private static readonly float STemperatureNumeratorExponent = 0;

    private static readonly float SLengthDenominatorExponent = 0;
    private static readonly float SMassDenominatorExponent = 0;
    private static readonly float STimeDenominatorExponent = 0;
    private static readonly float SElectricalCurrentDenominatorExponent = 0;
    private static readonly float SLuminousIntensityDenominatorExponent = 0;
    private static readonly float SAmountDenominatorExponent = 0;
    private static readonly float STemperatureDenominatorExponent = 0;

    public override float LengthNumeratorExponent => SLengthNumeratorExponent;
    public override float MassNumeratorExponent => SMassNumeratorExponent;
    public override float TimeNumeratorExponent => STimeNumeratorExponent;
    public override float ElectricalCurrentNumeratorExponent => SElectricalCurrentNumeratorExponent;
    public override float LuminousIntensityNumeratorExponent => SLuminousIntensityNumeratorExponent;
    public override float AmountNumeratorExponent => SAmountNumeratorExponent;
    public override float TemperatureNumeratorExponent => STemperatureNumeratorExponent;

    public override float LengthDenominatorExponent => SLengthDenominatorExponent;
    public override float MassDenominatorExponent => SMassDenominatorExponent;
    public override float TimeDenominatorExponent => STimeDenominatorExponent;
    public override float ElectricalCurrentDenominatorExponent => SElectricalCurrentDenominatorExponent;
    public override float LuminousIntensityDenominatorExponent => SLuminousIntensityDenominatorExponent;
    public override float AmountDenominatorExponent => SAmountDenominatorExponent;
    public override float TemperatureDenominatorExponent => STemperatureDenominatorExponent;


    public Length():base(LengthUnit.Meter)
    {
    }
}