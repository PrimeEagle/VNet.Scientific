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

    public dynamic FindMatch()
    {
        var matches = DimensionDef.Exponents.Keys.Where(e =>
            DimensionDef.Exponents[e].Length == Length &&
            DimensionDef.Exponents[e].Mass == Mass &&
            DimensionDef.Exponents[e].Time == Time &&
            DimensionDef.Exponents[e].ElectricalCurrent == ElectricalCurrent &&
            DimensionDef.Exponents[e].LuminousIntensity == LuminousIntensity &&
            DimensionDef.Exponents[e].Temperature == Temperature &&
            DimensionDef.Exponents[e].Amount == Amount).ToList<string>();

        if (matches is null || matches.Count == 0) return null;

        var dimTypeName = $"VNet.Scientific.Measurement.Dimensions.{matches.First()}";
        var unitTypeName = $"{dimTypeName}Unit";

        var dimType = Type.GetType(dimTypeName);
        var unitType = Type.GetType(unitTypeName);
        var valType = typeof(double);

        var genericType = typeof(Measurement<,,>);
        var specificType = genericType.MakeGenericType(new Type[] { dimType, unitType, valType });
        var measurement = Activator.CreateInstance(specificType);

        return measurement;
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