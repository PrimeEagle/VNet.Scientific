using System.Numerics;

namespace VNet.Scientific.Measurement;

public abstract class DimensionBase<TUnit, TVal> : IDimension<TUnit, TVal> where TUnit : notnull, Enum where TVal : notnull, INumber<TVal>
{
    public abstract string IdTag { get; }
    public DimensionExponents Exponents { get; init; }
    public TUnit DefaultUnit { get; set; }
    public Dictionary<TUnit, string> Symbols => _symbols;
    public Dictionary<TUnit, string> PluralSymbols => _pluralSymbols;
    public Dictionary<TUnit, string> ConversionFunctions => _conversionFunctions;

    private readonly Dictionary<TUnit, string> _symbols;
    private readonly Dictionary<TUnit, string> _pluralSymbols; 
    private readonly Dictionary<TUnit, string> _conversionFunctions;


    public DimensionBase()
    {
        Exponents = new DimensionExponents();
        _symbols = new Dictionary<TUnit, string>();
        _pluralSymbols = new Dictionary<TUnit, string>(); 
        _conversionFunctions = new Dictionary<TUnit, string>();
    }

    public string GetConversionFactor(TUnit unit)
    {
        if (_conversionFunctions == null || !_conversionFunctions.TryGetValue(unit, out var exp)) throw new ArgumentOutOfRangeException();

        return exp;
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
        //if (!_conversionFunctions.ContainsKey(fromUnit) || !_conversionFunctions.ContainsKey(toUnit))
        //{
        //    throw new ArgumentException("Invalid unit specified");
        //}

        //var func = value * GenericNumber<TVal>.FromDouble(_conversionFunctions[(TUnit)fromUnit]);
        //var valueInDefaultUnits = InlineFunctionEvaluator.Evaluate(func, new Dictionary<string, object>() { { "x", value } });
        //var convertedValue = valueInDefaultUnits / GenericNumber<TVal>.FromDouble(InlineFunctionEvaluator.Evaluate(func, new Dictionary<string, object>() { { "x", valueInDefaultUnits } }));

        //return convertedValue;
        return value;
     }
}