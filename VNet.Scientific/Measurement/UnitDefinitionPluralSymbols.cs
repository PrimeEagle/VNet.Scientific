namespace VNet.Scientific.Measurement;

public static partial class UnitDefinition
{
    public static readonly Dictionary<string, Dictionary<Enum, string>> PluralSymbols = new()
    {
        { "Length", new Dictionary<Enum, string>() },
        { "Mass", new Dictionary<Enum, string>() },
        { "Time", new Dictionary<Enum, string>() },
        { "ElectricalCurrent", new Dictionary<Enum, string>() },
        { "LuminousIntensity", new Dictionary<Enum, string>() },
        { "Temperature", new Dictionary<Enum, string>() },
        { "Amount", new Dictionary<Enum, string>() }
    };
}