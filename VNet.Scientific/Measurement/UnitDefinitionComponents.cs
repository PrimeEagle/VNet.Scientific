// ReSharper disable UnusedMember.Global
#pragma warning disable CA2211

namespace VNet.Scientific.Measurement;

public static partial class UnitDefinition
{
    public static readonly Dictionary<string, Tuple<float[], float[], Enum>> Components = new()
    {
        {"Scalar", new Tuple<float[], float[], Enum>
        (
            new float[]{0, 0, 0, 0, 0, 0, 0},
            new float[]{0, 0, 0, 0, 0, 0, 0},
            ScalarUnit.None
        )},
        {"Length", new Tuple<float[], float[], Enum>
        (
            new float[]{1, 0, 0, 0, 0, 0, 0},
            new float[]{0, 0, 0, 0, 0, 0, 0},
            LengthUnit.Meter
        )}
    };
}