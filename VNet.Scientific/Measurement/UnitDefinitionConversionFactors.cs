namespace VNet.Scientific.Measurement;

public static partial class UnitDefinition
{
    public static readonly Dictionary<string, Dictionary<Enum, double>> ConversionFactors = new()
    {
        { "Length", new Dictionary<Enum, double>()
            {
                { LengthUnit.Angstrom, 1e-10 },
                { LengthUnit.AstronomicalUnit, 1.495978707e11 },
                { LengthUnit.Attometer, 1e-18 },
                { LengthUnit.Cana, 0.45 },
                { LengthUnit.Centimeter, 0.01 },
                { LengthUnit.Chain, 20.1168 },
                { LengthUnit.Chi, 0.333 },
                { LengthUnit.Cubit, 0.5 },
                { LengthUnit.Decameter, 10 },
                { LengthUnit.Decimeter, 0.1 },
                { LengthUnit.Femtometer, 1e-15 },
                { LengthUnit.Fathom, 1.8288 },
                { LengthUnit.Foot, 0.3048 },
                { LengthUnit.Furlong, 201.168 },
                { LengthUnit.Hectometer, 100 },
                { LengthUnit.HubbleLength, 4.4e26 },
                { LengthUnit.Inch, 0.0254 },
                { LengthUnit.Kilometer, 1000 },
                { LengthUnit.League, 4828.032 },
                { LengthUnit.Li, 500 },
                { LengthUnit.LightYear, 9.461e15 },
                { LengthUnit.Megameter, 1e6 },
                { LengthUnit.Meter, 1 },
                { LengthUnit.Micrometer, 1e-6 },
                { LengthUnit.Micron, 1e-6 },
                { LengthUnit.Mile, 1609.344 },
                { LengthUnit.Millimeter, 0.001 },
                { LengthUnit.Nanometer, 1e-9 },
                { LengthUnit.NauticalMile, 1852 },
                { LengthUnit.Pace, 0.762 },
                { LengthUnit.Parsec, 3.086e16 },
                { LengthUnit.Picometer, 1e-12 },
                { LengthUnit.PlanckLength, 1.616255e-35 },
                { LengthUnit.Rod, 5.0292 },
                { LengthUnit.Rope, 6.096 },
                { LengthUnit.Thou, 2.54e-5 },
                { LengthUnit.Verst, 1066.8 },
                { LengthUnit.Yard, 0.9144 }
            }
        }
    };
}