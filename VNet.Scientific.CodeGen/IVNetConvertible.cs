using System.Collections.Generic;

namespace VNet.Scientific.CodeGen
{
    public interface IVNetConvertible
    {
        string Name { get; }
        string BaseUnit { get; }
        float BaseDimensionLength { get; }
        float BaseDimensionMass { get; }
        float BaseDimensionTime { get; }
        float BaseDimensionElectricalCurrent { get; }
        float BaseDimensionLuminousIntensity { get; }
        float BaseDimensionTemperature { get; }
        float BaseDimensionAmount { get; }
        List<string> UnitNames { get; }
        Dictionary<string, string> ConversionFunctions {get; }
        Dictionary<string, string> Symbols { get; }
        Dictionary<string, string> PluralSymbols { get; }
    }
}