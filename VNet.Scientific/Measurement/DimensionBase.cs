using System.Numerics;
using VNet.System.Conversion;
using VNet.Expressions;

namespace VNet.Scientific.Measurement;

public abstract class DimensionBase<TUnit, TVal> : IDimension<TUnit, TVal> where TUnit : notnull, Enum 
                                                                            where TVal : notnull, INumber<TVal>
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

    public virtual void ValidateUnit(TUnit unit)
    {
        if (unit.GetType() != typeof(TUnit))
        {
            throw new ArgumentException($"Units must be of type {nameof(TUnit)}.");
        }
    }
        
    public TVal ConvertToDefaultUnit(TVal value, TUnit fromUnit)
    {
        ValidateUnit(fromUnit);
        return Convert(value, fromUnit, DefaultUnit);
    }

    public TVal ConvertFromDefaultUnit(TVal value, TUnit toUnit)
    {
        ValidateUnit(toUnit);
        return Convert(value, DefaultUnit, toUnit);
    }

    protected virtual TVal Convert(TVal value, TUnit fromUnit, TUnit toUnit)
    {
        if (!_conversionFunctions.ContainsKey(fromUnit) || !_conversionFunctions.ContainsKey(toUnit))
        {
            throw new ArgumentException("Invalid unit specified");
        }

        var func = _conversionFunctions[(TUnit)fromUnit];
        Dictionary<string, object> parameters = new Dictionary<string, object>
        {
            { "x", (object)value }
        };
        var valueInDefaultUnits = InlineFunctionEvaluator.Evaluate<double>(func, parameters);

        parameters.Clear();
        parameters.Add("x", valueInDefaultUnits);
        var convertedValue = valueInDefaultUnits / InlineFunctionEvaluator.Evaluate<double>(func, parameters);

        return GenericNumber<TVal>.FromDouble(convertedValue);
     }
}