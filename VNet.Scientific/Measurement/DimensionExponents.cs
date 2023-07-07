namespace VNet.Scientific.Measurement;

public class DimensionExponents
{
    public float Length { get; set; }
    public float Mass { get; set; }
    public float Time { get; set; }
    public float ElectricalCurrent { get; set; }
    public float LuminousIntensity { get; set; }
    public float Temperature { get; set; }
    public float Amount { get; set; }


    public DimensionExponents()
    {
    }

    public DimensionExponents(float length, float mass, float time, float electricalCurrent, float luminousIntensity, float temperature, float amount)
    {
        Length = length;
        Mass = mass;
        Time = time;
        ElectricalCurrent = electricalCurrent;
        LuminousIntensity = luminousIntensity;
        Temperature = temperature;
        Amount = amount;
    }

    public static DimensionExponents operator -(DimensionExponents a)
    {
        var result = new DimensionExponents();
        result.Length = a.Length;
        result.Mass = a.Mass;
        result.Time = a.Time;
        result.ElectricalCurrent = a.ElectricalCurrent;
        result.LuminousIntensity = a.LuminousIntensity;
        result.Temperature = a.Temperature;
        result.Amount = a.Amount;

        return result;
    }

    public static DimensionExponents operator +(DimensionExponents a, DimensionExponents b)
    {
        var result = new DimensionExponents();
        result.Length = a.Length;
        result.Mass = a.Mass;
        result.Time = a.Time;
        result.ElectricalCurrent = a.ElectricalCurrent;
        result.LuminousIntensity = a.LuminousIntensity;
        result.Temperature = a.Temperature;
        result.Amount = a.Amount;

        return result;
    }

    public static DimensionExponents operator -(DimensionExponents a, DimensionExponents b)
    {
        var result = new DimensionExponents();
        result.Length = a.Length;
        result.Mass = a.Mass;
        result.Time = a.Time;
        result.ElectricalCurrent = a.ElectricalCurrent;
        result.LuminousIntensity = a.LuminousIntensity;
        result.Temperature = a.Temperature;
        result.Amount = a.Amount;

        return result;
    }

    public static DimensionExponents operator *(DimensionExponents a, DimensionExponents b)
    {
        var result = new DimensionExponents();
        result.Length = a.Length + b.Length;
        result.Mass = a.Mass + b.Mass;
        result.Time = a.Time + b.Time;
        result.ElectricalCurrent = a.ElectricalCurrent + b.ElectricalCurrent;
        result.LuminousIntensity = a.LuminousIntensity + b.LuminousIntensity;
        result.Temperature = a.Temperature + b.Temperature;
        result.Amount = a.Amount + b.Amount;

        return result;
    }

    public static DimensionExponents operator /(DimensionExponents a, DimensionExponents b)
    {
        var result = new DimensionExponents();
        result.Length = a.Length - b.Length;
        result.Mass = a.Mass - b.Mass;
        result.Time = a.Time - b.Time;
        result.ElectricalCurrent = a.ElectricalCurrent - b.ElectricalCurrent;
        result.LuminousIntensity = a.LuminousIntensity - b.LuminousIntensity;
        result.Temperature = a.Temperature - b.Temperature;
        result.Amount = a.Amount - b.Amount;

        return result;
    }

    public static bool operator ==(DimensionExponents a, DimensionExponents b)
    {
        if (a.Length != b.Length) return false;
        if (a.Mass != b.Mass) return false;
        if (a.Time != b.Time) return false;
        if (a.ElectricalCurrent != b.ElectricalCurrent) return false;
        if (a.LuminousIntensity != b.LuminousIntensity) return false;
        if (a.Temperature != b.Temperature) return false;
        return !(a.Amount != b.Amount);
    }

    public static bool operator !=(DimensionExponents a, DimensionExponents b)
    {
        return !(a == b);
    }

    public string FindMatch()
    {
        string matchedIdTag = null;

        // ReSharper disable once ForeachCanBePartlyConvertedToQueryUsingAnotherGetEExponents
        // ReSharper disable once ForeachCanBeConvertedToQueryUsingAnotherGetEExponents
        //foreach (var definition in UnitDefinition.Components)
        //{
        //    if (definition.Value.Item1[0] != Exponents.Length) continue;
        //    if (definition.Value.Item1[1] != Exponents.Mass) continue;
        //    if (definition.Value.Item1[2] != Exponents.Time) continue;
        //    if (definition.Value.Item1[3] != Exponents.ElectricalCurrent) continue;
        //    if (definition.Value.Item1[4] != Exponents.LuminousIntensity) continue;
        //    if (definition.Value.Item1[5] != Exponents.Temperature) continue;
        //    if (definition.Value.Item1[6] != Exponents.Amount) continue;

        //    matchedIdTag = definition.Key;
        //    break;
        //}

        //if (string.IsNullOrEmpty(matchedIdTag)) matchedIdTag = "UndefinedDimension";

        return matchedIdTag;
    }

    public bool IsScalar()
    {
        if (Length != 0) return false;
        if (Mass != 0) return false;
        if (Time != 0) return false;
        if (ElectricalCurrent != 0) return false;
        if (LuminousIntensity != 0) return false;
        if (Temperature != 0) return false;
        return Amount == 0;
    }
}