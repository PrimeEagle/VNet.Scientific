namespace VNet.Scientific.Measurement;

public static partial class UnitDefinition
{
    public static readonly Dictionary<string, Dictionary<Enum, string>> Symbols = new()
    {
        { "Length", new Dictionary<Enum, string>()
            {
                { LengthUnit.Angstrom, "Å" },
                { LengthUnit.AstronomicalUnit, "au" },
                { LengthUnit.Attometer, "am" },
                { LengthUnit.Cana, "cana" },
                { LengthUnit.Centimeter, "cm" },
                { LengthUnit.Chain, "ch" },
                { LengthUnit.Chi, "尺" },
                { LengthUnit.Cubit, "cubit" },
                { LengthUnit.Decameter, "dam" },
                { LengthUnit.Decimeter, "dm" },
                { LengthUnit.Femtometer, "fm" },
                { LengthUnit.Fathom, "ftm" },
                { LengthUnit.Foot, "ft" },
                { LengthUnit.Furlong, "fur" },
                { LengthUnit.Hectometer, "hm" },
                { LengthUnit.HubbleLength, "Hubble length" },
                { LengthUnit.Inch, "in" },
                { LengthUnit.Kilometer, "km" },
                { LengthUnit.League, "lea" },
                { LengthUnit.Li, "里" },
                { LengthUnit.LightYear, "ly" },
                { LengthUnit.Megameter, "Mm" },
                { LengthUnit.Meter, "m" },
                { LengthUnit.Micrometer, "µm" },
                { LengthUnit.Micron, "µ" },
                { LengthUnit.Mile, "mi" },
                { LengthUnit.Millimeter, "mm" },
                { LengthUnit.Nanometer, "nm" },
                { LengthUnit.NauticalMile, "nmi" },
                { LengthUnit.Pace, "pace" },
                { LengthUnit.Parsec, "pc" },
                { LengthUnit.Picometer, "pm" },
                { LengthUnit.PlanckLength, "Planck" },
                { LengthUnit.Rod, "rd" },
                { LengthUnit.Rope, "rope" },
                { LengthUnit.Thou, "th" },
                { LengthUnit.Verst, "Verst" },
                { LengthUnit.Yard, "yd" }
            }
        }
    };
}