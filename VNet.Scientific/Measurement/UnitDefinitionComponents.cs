// ReSharper disable UnusedMember.Global

namespace VNet.Scientific.Measurement;

public static partial class UnitDefinition
{
    public static readonly Dictionary<string, Tuple<float[], float[], Enum>> Components = new()
    {
        {"Scalar", new Tuple<float[], float[], Enum>
        (
            new float[]{ 0, 0, 0, 0, 0, 0, 0 },
            new float[]{ 0, 0, 0, 0, 0, 0, 0 },
            ScalarUnit.None
        )},
        {"Length", new Tuple<float[], float[], Enum>
        (
            new float[]{ 1, 0, 0, 0, 0, 0, 0 },
            new float[]{ 0, 0, 0, 0, 0, 0, 0 },
            LengthUnit.Meter
        )},
        {"Mass", new Tuple<float[], float[], Enum>
        (
            new float[]{ 0, 1, 0, 0, 0, 0, 0 },
            new float[]{ 0, 0, 0, 0, 0, 0, 0 },
            LengthUnit.Meter
        )},
        {"Time", new Tuple<float[], float[], Enum>
        (
            new float[]{ 0, 0, 1, 0, 0, 0, 0 },
            new float[]{ 0, 0, 0, 0, 0, 0, 0 },
            LengthUnit.Meter
        )},
        {"ElectricalCurrent", new Tuple<float[], float[], Enum>
        (
            new float[]{ 0, 0, 0, 1, 0, 0, 0 },
            new float[]{ 0, 0, 0, 0, 0, 0, 0 },
            LengthUnit.Meter
        )},
        {"LuminousIntensity", new Tuple<float[], float[], Enum>
        (
            new float[]{ 0, 0, 0, 0, 1, 0, 0 },
            new float[]{ 0, 0, 0, 0, 0, 0, 0 },
            LengthUnit.Meter
        )},
        {"Temperature", new Tuple<float[], float[], Enum>
        (
            new float[]{ 0, 0, 0, 0, 0, 1, 0 },
            new float[]{ 0, 0, 0, 0, 0, 0, 0 },
            LengthUnit.Meter
        )},
        {"Amount", new Tuple<float[], float[], Enum>
        (
            new float[]{ 0, 0, 0, 0, 0, 0, 1 },
            new float[]{ 0, 0, 0, 0, 0, 0, 0 },
            LengthUnit.Meter
        )}
    };
}