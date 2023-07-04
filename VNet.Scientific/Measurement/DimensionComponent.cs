namespace VNet.Scientific.Measurement
{
    public class DimensionComponent
    {
        public FractionalDimensionComponent Exponents { get; init; }


        public DimensionComponent()
        {
            Exponents = new FractionalDimensionComponent();
        }

        public static DimensionComponent operator -(DimensionComponent a)
        {
            var result = new DimensionComponent();
            result.Exponents.Length = a.Exponents.Length;
            result.Exponents.Mass = a.Exponents.Mass;
            result.Exponents.Time = a.Exponents.Time;
            result.Exponents.ElectricalCurrent = a.Exponents.ElectricalCurrent;
            result.Exponents.LuminousIntensity = a.Exponents.LuminousIntensity;
            result.Exponents.Temperature = a.Exponents.Temperature;
            result.Exponents.Amount = a.Exponents.Amount;

            return result;
        }

        public static DimensionComponent operator +(DimensionComponent a, DimensionComponent b)
        {
            var result = new DimensionComponent();
            result.Exponents.Length = a.Exponents.Length;
            result.Exponents.Mass = a.Exponents.Mass;
            result.Exponents.Time = a.Exponents.Time;
            result.Exponents.ElectricalCurrent = a.Exponents.ElectricalCurrent;
            result.Exponents.LuminousIntensity = a.Exponents.LuminousIntensity;
            result.Exponents.Temperature = a.Exponents.Temperature;
            result.Exponents.Amount = a.Exponents.Amount;

            return result;
        }

        public static DimensionComponent operator -(DimensionComponent a, DimensionComponent b)
        {
            var result = new DimensionComponent();
            result.Exponents.Length = a.Exponents.Length;
            result.Exponents.Mass = a.Exponents.Mass;
            result.Exponents.Time = a.Exponents.Time;
            result.Exponents.ElectricalCurrent = a.Exponents.ElectricalCurrent;
            result.Exponents.LuminousIntensity = a.Exponents.LuminousIntensity;
            result.Exponents.Temperature = a.Exponents.Temperature;
            result.Exponents.Amount = a.Exponents.Amount;

            return result;
        }

        public static DimensionComponent operator *(DimensionComponent a, DimensionComponent b)
        {
            var result = new DimensionComponent();
            result.Exponents.Length = a.Exponents.Length + b.Exponents.Length;
            result.Exponents.Mass = a.Exponents.Mass + b.Exponents.Mass;
            result.Exponents.Time = a.Exponents.Time + b.Exponents.Time;
            result.Exponents.ElectricalCurrent = a.Exponents.ElectricalCurrent + b.Exponents.ElectricalCurrent;
            result.Exponents.LuminousIntensity = a.Exponents.LuminousIntensity + b.Exponents.LuminousIntensity;
            result.Exponents.Temperature = a.Exponents.Temperature + b.Exponents.Temperature;
            result.Exponents.Amount = a.Exponents.Amount + b.Exponents.Amount;

            return result;
        }

        public static DimensionComponent operator /(DimensionComponent a, DimensionComponent b)
        {
            var result = new DimensionComponent();
            result.Exponents.Length = a.Exponents.Length - b.Exponents.Length;
            result.Exponents.Mass = a.Exponents.Mass - b.Exponents.Mass;
            result.Exponents.Time = a.Exponents.Time - b.Exponents.Time;
            result.Exponents.ElectricalCurrent = a.Exponents.ElectricalCurrent - b.Exponents.ElectricalCurrent;
            result.Exponents.LuminousIntensity = a.Exponents.LuminousIntensity - b.Exponents.LuminousIntensity;
            result.Exponents.Temperature = a.Exponents.Temperature - b.Exponents.Temperature;
            result.Exponents.Amount = a.Exponents.Amount - b.Exponents.Amount;

            return result;
        }

        public static bool operator ==(DimensionComponent a, DimensionComponent b)
        {
            if (a.Exponents.Length != b.Exponents.Length) return false;
            if (a.Exponents.Mass != b.Exponents.Mass) return false;
            if (a.Exponents.Time != b.Exponents.Time) return false;
            if (a.Exponents.ElectricalCurrent != b.Exponents.ElectricalCurrent) return false;
            if (a.Exponents.LuminousIntensity != b.Exponents.LuminousIntensity) return false;
            if (a.Exponents.Temperature != b.Exponents.Temperature) return false;
            return !(a.Exponents.Amount != b.Exponents.Amount);
        }

        public static bool operator !=(DimensionComponent a, DimensionComponent b)
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
            if (Exponents.Length != 0) return false;
            if (Exponents.Mass != 0) return false;
            if (Exponents.Time != 0) return false;
            if (Exponents.ElectricalCurrent != 0) return false;
            if (Exponents.LuminousIntensity != 0) return false;
            if (Exponents.Temperature != 0) return false;
            return Exponents.Amount == 0;
        }
    }
}