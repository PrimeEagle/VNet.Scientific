using System.Numerics;
using VNet.System.Conversion;

namespace VNet.Scientific.Measurement;

public abstract class DimensionBase<TUnit, TVal> : IDimension<TUnit, TVal> where TUnit : notnull, Enum where TVal : notnull, INumber<TVal>
{
    public abstract string IdTag { get; }
    public DimensionComponent DimensionComponent { get; init; }
    public TUnit DefaultUnit { get; set; }



    public DimensionBase()
    {
        DimensionComponent = new DimensionComponent();
    }

    protected void Initialize(string idTag)
    {
        if (!UnitDefinition.Components.ContainsKey(idTag)) throw new InvalidOperationException($"Value '{idTag}' was not found in UnitDefinition.Components");

        var definition = UnitDefinition.Components[idTag];

        DimensionComponent.Exponents.Length = definition.Item1[0];
        DimensionComponent.Exponents.Mass = definition.Item1[1];
        DimensionComponent.Exponents.Time = definition.Item1[2];
        DimensionComponent.Exponents.ElectricalCurrent = definition.Item1[3];
        DimensionComponent.Exponents.LuminousIntensity = definition.Item1[4];
        DimensionComponent.Exponents.Temperature = definition.Item1[5];
        DimensionComponent.Exponents.Amount = definition.Item1[6];


        DefaultUnit = (TUnit)definition.Item2;
    }

    public virtual void ValidateUnit(Enum unit)
    {
        if (unit.GetType() != typeof(TUnit))
        {
            throw new ArgumentException($"Units must be of type {nameof(TUnit)}.");
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
        if (!UnitDefinition.ConversionFactors.ContainsKey(IdTag) || !UnitDefinition.ConversionFactors[IdTag].ContainsKey(fromUnit) || 
            !UnitDefinition.ConversionFactors[IdTag].ContainsKey(toUnit))
        {
            throw new ArgumentException("Invalid unit specified");
        }

        var valueInMeters = value * GenericNumber<TVal>.FromDouble(UnitDefinition.ConversionFactors[IdTag][(TUnit)fromUnit]);
        var convertedValue = valueInMeters / GenericNumber<TVal>.FromDouble(UnitDefinition.ConversionFactors[IdTag][(TUnit)toUnit]);

        return convertedValue;
    }
}