using System.Numerics;
using VNet.System.Conversion;

namespace VNet.Scientific.Measurement;

public abstract class DimensionBase<TUnit, TVal> : IDimension<TUnit, TVal> where TUnit : notnull, Enum where TVal : notnull, INumber<TVal>
{
    public abstract float LengthNumeratorExponent { get; }
    public abstract float MassNumeratorExponent { get; }
    public abstract float TimeNumeratorExponent { get; }
    public abstract float ElectricalCurrentNumeratorExponent { get; }
    public abstract float LuminousIntensityNumeratorExponent { get; }
    public abstract float AmountNumeratorExponent { get; }
    public abstract float TemperatureNumeratorExponent { get; }
            
    public abstract float LengthDenominatorExponent { get; }
    public abstract float MassDenominatorExponent { get; }
    public abstract float TimeDenominatorExponent { get; }
    public abstract float ElectricalCurrentDenominatorExponent { get; }
    public abstract float LuminousIntensityDenominatorExponent { get; }
    public abstract float AmountDenominatorExponent { get; }
    public abstract float TemperatureDenominatorExponent { get; }

    public TUnit DefaultUnit { get; init; }


    protected DimensionBase(TUnit defaultUnit)
    {
        DefaultUnit = defaultUnit;
    }

    public virtual void ValidateUnit(Enum unit)
    {
        if (unit.GetType() != typeof(TUnit))
        {
            throw new ArgumentException($"Units must be of type {nameof(TUnit)}.");
        }

        var hasAttribute = typeof(TUnit).GetCustomAttributes(typeof(UnitEnumAttribute), false).Length > 0;

        if (!hasAttribute)
        {
            throw new ArgumentException($"The provided unit type does not have the [UnitEnum] attribute");
        }
    }
        
    public TVal ConvertToDefaultUnit(TVal value, Enum fromUnit)
    {
        ValidateUnit(fromUnit);
        return Convert(value, fromUnit, DefaultUnit);
    }

    public TVal ConvertFromDefaultUnit(TVal value, Enum toUnit)
    {
        ValidateUnit(toUnit);
        return Convert(value, DefaultUnit, toUnit);
    }

    protected virtual TVal Convert(TVal value, Enum fromUnit, Enum toUnit)
    {
        var unitType = typeof(TUnit);

        if (!UnitLookup.ConversionFactors.ContainsKey(unitType) || !UnitLookup.ConversionFactors[unitType].ContainsKey(fromUnit) || 
            !UnitLookup.ConversionFactors[unitType].ContainsKey(toUnit))
        {
            throw new ArgumentException("Invalid unit specified");
        }

        var valueInMeters = value * GenericNumber<TVal>.FromDouble(UnitLookup.ConversionFactors[unitType][(TUnit)fromUnit]);
        var convertedValue = valueInMeters / GenericNumber<TVal>.FromDouble(UnitLookup.ConversionFactors[unitType][(TUnit)toUnit]);

        return convertedValue;
    }
}