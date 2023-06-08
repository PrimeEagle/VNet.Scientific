namespace VNet.Scientific.Measurement
{
    public class DimensionComponent
    {
        public FractionalDimensionComponent Numerator { get; init; }
        public FractionalDimensionComponent Denominator { get; init; }


        public DimensionComponent()
        {
            Numerator = new FractionalDimensionComponent();
            Denominator = new FractionalDimensionComponent();
        }

        public static DimensionComponent operator -(DimensionComponent a)
        {
            var result = new DimensionComponent();
            result.Numerator.Length.Exponent = -a.Numerator.Length.Exponent;
            result.Numerator.Mass.Exponent = -a.Numerator.Mass.Exponent;
            result.Numerator.Time.Exponent = -a.Numerator.Time.Exponent;
            result.Numerator.ElectricalCurrent.Exponent = -a.Numerator.ElectricalCurrent.Exponent;
            result.Numerator.LuminousIntensity.Exponent = -a.Numerator.LuminousIntensity.Exponent;
            result.Numerator.Temperature.Exponent = -a.Numerator.Temperature.Exponent;
            result.Numerator.Amount.Exponent = -a.Numerator.Amount.Exponent;

            result.Denominator.Length.Exponent = -a.Denominator.Length.Exponent;
            result.Denominator.Mass.Exponent = -a.Denominator.Mass.Exponent;
            result.Denominator.Time.Exponent = -a.Denominator.Time.Exponent;
            result.Denominator.ElectricalCurrent.Exponent = -a.Denominator.ElectricalCurrent.Exponent;
            result.Denominator.LuminousIntensity.Exponent = -a.Denominator.LuminousIntensity.Exponent;
            result.Denominator.Temperature.Exponent = -a.Denominator.Temperature.Exponent;
            result.Denominator.Amount.Exponent = -a.Denominator.Amount.Exponent;

            return result;
        }

        public static DimensionComponent operator +(DimensionComponent a, DimensionComponent b)
        {
            var result = new DimensionComponent();
            result.Numerator.Length.Exponent = a.Numerator.Length.Exponent + b.Numerator.Length.Exponent;
            result.Numerator.Mass.Exponent = a.Numerator.Mass.Exponent + b.Numerator.Mass.Exponent;
            result.Numerator.Time.Exponent = a.Numerator.Time.Exponent + b.Numerator.Time.Exponent;
            result.Numerator.ElectricalCurrent.Exponent = a.Numerator.ElectricalCurrent.Exponent + b.Numerator.ElectricalCurrent.Exponent;
            result.Numerator.LuminousIntensity.Exponent = a.Numerator.LuminousIntensity.Exponent + b.Numerator.LuminousIntensity.Exponent;
            result.Numerator.Temperature.Exponent = a.Numerator.Temperature.Exponent + b.Numerator.Temperature.Exponent;
            result.Numerator.Amount.Exponent = a.Numerator.Amount.Exponent + b.Numerator.Amount.Exponent;

            result.Denominator.Length.Exponent = a.Denominator.Length.Exponent + b.Denominator.Length.Exponent;
            result.Denominator.Mass.Exponent = a.Denominator.Mass.Exponent + b.Denominator.Mass.Exponent;
            result.Denominator.Time.Exponent = a.Denominator.Time.Exponent + b.Denominator.Time.Exponent;
            result.Denominator.ElectricalCurrent.Exponent = a.Denominator.ElectricalCurrent.Exponent + b.Denominator.ElectricalCurrent.Exponent;
            result.Denominator.LuminousIntensity.Exponent = a.Denominator.LuminousIntensity.Exponent + b.Denominator.LuminousIntensity.Exponent;
            result.Denominator.Temperature.Exponent = a.Denominator.Temperature.Exponent + b.Denominator.Temperature.Exponent;
            result.Denominator.Amount.Exponent = a.Denominator.Amount.Exponent + b.Denominator.Amount.Exponent;

            return result;
        }

        public static DimensionComponent operator -(DimensionComponent a, DimensionComponent b)
        {
            var result = new DimensionComponent();
            result.Numerator.Length.Exponent = a.Numerator.Length.Exponent - b.Numerator.Length.Exponent;
            result.Numerator.Mass.Exponent = a.Numerator.Mass.Exponent - b.Numerator.Mass.Exponent;
            result.Numerator.Time.Exponent = a.Numerator.Time.Exponent - b.Numerator.Time.Exponent;
            result.Numerator.ElectricalCurrent.Exponent = a.Numerator.ElectricalCurrent.Exponent - b.Numerator.ElectricalCurrent.Exponent;
            result.Numerator.LuminousIntensity.Exponent = a.Numerator.LuminousIntensity.Exponent - b.Numerator.LuminousIntensity.Exponent;
            result.Numerator.Temperature.Exponent = a.Numerator.Temperature.Exponent - b.Numerator.Temperature.Exponent;
            result.Numerator.Amount.Exponent = a.Numerator.Amount.Exponent - b.Numerator.Amount.Exponent;

            result.Denominator.Length.Exponent = a.Denominator.Length.Exponent - b.Denominator.Length.Exponent;
            result.Denominator.Mass.Exponent = a.Denominator.Mass.Exponent - b.Denominator.Mass.Exponent;
            result.Denominator.Time.Exponent = a.Denominator.Time.Exponent - b.Denominator.Time.Exponent;
            result.Denominator.ElectricalCurrent.Exponent = a.Denominator.ElectricalCurrent.Exponent - b.Denominator.ElectricalCurrent.Exponent;
            result.Denominator.LuminousIntensity.Exponent = a.Denominator.LuminousIntensity.Exponent - b.Denominator.LuminousIntensity.Exponent;
            result.Denominator.Temperature.Exponent = a.Denominator.Temperature.Exponent - b.Denominator.Temperature.Exponent;
            result.Denominator.Amount.Exponent = a.Denominator.Amount.Exponent - b.Denominator.Amount.Exponent;

            return result;
        }

        public static DimensionComponent operator *(DimensionComponent a, DimensionComponent b)
        {
            var result = new DimensionComponent();
            result.Numerator.Length.Exponent = a.Numerator.Length.Exponent * b.Numerator.Length.Exponent;
            result.Numerator.Mass.Exponent = a.Numerator.Mass.Exponent * b.Numerator.Mass.Exponent;
            result.Numerator.Time.Exponent = a.Numerator.Time.Exponent * b.Numerator.Time.Exponent;
            result.Numerator.ElectricalCurrent.Exponent = a.Numerator.ElectricalCurrent.Exponent * b.Numerator.ElectricalCurrent.Exponent;
            result.Numerator.LuminousIntensity.Exponent = a.Numerator.LuminousIntensity.Exponent * b.Numerator.LuminousIntensity.Exponent;
            result.Numerator.Temperature.Exponent = a.Numerator.Temperature.Exponent * b.Numerator.Temperature.Exponent;
            result.Numerator.Amount.Exponent = a.Numerator.Amount.Exponent * b.Numerator.Amount.Exponent;

            result.Denominator.Length.Exponent = a.Denominator.Length.Exponent * b.Denominator.Length.Exponent;
            result.Denominator.Mass.Exponent = a.Denominator.Mass.Exponent * b.Denominator.Mass.Exponent;
            result.Denominator.Time.Exponent = a.Denominator.Time.Exponent * b.Denominator.Time.Exponent;
            result.Denominator.ElectricalCurrent.Exponent = a.Denominator.ElectricalCurrent.Exponent * b.Denominator.ElectricalCurrent.Exponent;
            result.Denominator.LuminousIntensity.Exponent = a.Denominator.LuminousIntensity.Exponent * b.Denominator.LuminousIntensity.Exponent;
            result.Denominator.Temperature.Exponent = a.Denominator.Temperature.Exponent * b.Denominator.Temperature.Exponent;
            result.Denominator.Amount.Exponent = a.Denominator.Amount.Exponent * b.Denominator.Amount.Exponent;

            return result;
        }

        public static DimensionComponent operator /(DimensionComponent a, DimensionComponent b)
        {
            var result = new DimensionComponent();
            result.Numerator.Length.Exponent = a.Numerator.Length.Exponent / b.Numerator.Length.Exponent;
            result.Numerator.Mass.Exponent = a.Numerator.Mass.Exponent / b.Numerator.Mass.Exponent;
            result.Numerator.Time.Exponent = a.Numerator.Time.Exponent / b.Numerator.Time.Exponent;
            result.Numerator.ElectricalCurrent.Exponent = a.Numerator.ElectricalCurrent.Exponent / b.Numerator.ElectricalCurrent.Exponent;
            result.Numerator.LuminousIntensity.Exponent = a.Numerator.LuminousIntensity.Exponent / b.Numerator.LuminousIntensity.Exponent;
            result.Numerator.Temperature.Exponent = a.Numerator.Temperature.Exponent / b.Numerator.Temperature.Exponent;
            result.Numerator.Amount.Exponent = a.Numerator.Amount.Exponent / b.Numerator.Amount.Exponent;

            result.Denominator.Length.Exponent = a.Denominator.Length.Exponent / b.Denominator.Length.Exponent;
            result.Denominator.Mass.Exponent = a.Denominator.Mass.Exponent / b.Denominator.Mass.Exponent;
            result.Denominator.Time.Exponent = a.Denominator.Time.Exponent / b.Denominator.Time.Exponent;
            result.Denominator.ElectricalCurrent.Exponent = a.Denominator.ElectricalCurrent.Exponent / b.Denominator.ElectricalCurrent.Exponent;
            result.Denominator.LuminousIntensity.Exponent = a.Denominator.LuminousIntensity.Exponent / b.Denominator.LuminousIntensity.Exponent;
            result.Denominator.Temperature.Exponent = a.Denominator.Temperature.Exponent / b.Denominator.Temperature.Exponent;
            result.Denominator.Amount.Exponent = a.Denominator.Amount.Exponent / b.Denominator.Amount.Exponent;

            return result;
        }

        public static bool operator ==(DimensionComponent a, DimensionComponent b)
        {
            if (a.Numerator.Length.Exponent != b.Numerator.Length.Exponent) return false;
            if (a.Numerator.Mass.Exponent != b.Numerator.Mass.Exponent) return false;
            if (a.Numerator.Time.Exponent != b.Numerator.Time.Exponent) return false;
            if (a.Numerator.ElectricalCurrent.Exponent != b.Numerator.ElectricalCurrent.Exponent) return false;
            if (a.Numerator.LuminousIntensity.Exponent != b.Numerator.LuminousIntensity.Exponent) return false;
            if (a.Numerator.Temperature.Exponent != b.Numerator.Temperature.Exponent) return false;
            if (a.Numerator.Amount.Exponent != b.Numerator.Amount.Exponent) return false;

            if (a.Denominator.Length.Exponent != b.Denominator.Length.Exponent) return false;
            if (a.Denominator.Mass.Exponent != b.Denominator.Mass.Exponent) return false;
            if (a.Denominator.Time.Exponent != b.Denominator.Time.Exponent) return false;
            if (a.Denominator.ElectricalCurrent.Exponent != b.Denominator.ElectricalCurrent.Exponent) return false;
            if (a.Denominator.LuminousIntensity.Exponent != b.Denominator.LuminousIntensity.Exponent) return false;
            if (a.Denominator.Temperature.Exponent != b.Denominator.Temperature.Exponent) return false;
            if (a.Denominator.Amount.Exponent != b.Denominator.Amount.Exponent) return false;

            return true;
        }

        public static bool operator !=(DimensionComponent a, DimensionComponent b)
        {
            return !(a == b);
        }

        public void Reduce()
        {
            var n = Numerator.Length.Exponent;
            var d = Denominator.Length.Exponent;
            var result = ReduceSingleDimension(n, d);
            Numerator.Length.Exponent = result.Item1;
            Denominator.Length.Exponent = result.Item2;

            n = Numerator.Mass.Exponent;
            d = Denominator.Mass.Exponent;
            result = ReduceSingleDimension(n, d);
            Numerator.Mass.Exponent = result.Item1;
            Denominator.Mass.Exponent = result.Item2;

            n = Numerator.Time.Exponent;
            d = Denominator.Time.Exponent;
            result = ReduceSingleDimension(n, d);
            Numerator.Time.Exponent = result.Item1;
            Denominator.Time.Exponent = result.Item2;

            n = Numerator.ElectricalCurrent.Exponent;
            d = Denominator.ElectricalCurrent.Exponent;
            result = ReduceSingleDimension(n, d);
            Numerator.ElectricalCurrent.Exponent = result.Item1;
            Denominator.ElectricalCurrent.Exponent = result.Item2;

            n = Numerator.LuminousIntensity.Exponent;
            d = Denominator.LuminousIntensity.Exponent;
            result = ReduceSingleDimension(n, d);
            Numerator.LuminousIntensity.Exponent = result.Item1;
            Denominator.LuminousIntensity.Exponent = result.Item2;

            n = Numerator.Temperature.Exponent;
            d = Denominator.Temperature.Exponent;
            result = ReduceSingleDimension(n, d);
            Numerator.Temperature.Exponent = result.Item1;
            Denominator.Temperature.Exponent = result.Item2;

            n = Numerator.Amount.Exponent;
            d = Denominator.Amount.Exponent;
            result = ReduceSingleDimension(n, d);
            Numerator.Amount.Exponent = result.Item1;
            Denominator.Amount.Exponent = result.Item2;
        }

        private static Tuple<float, float> ReduceSingleDimension(float a, float b)
        {
            if (a == b) return new Tuple<float, float>(0, 0);
            if (a == 0 || b == 0) return new Tuple<float, float>(a, b);

            if (a < b)
            {
                a = 0;
                b -= a;
            }
            else
            {
                b = 0;
                a -= b;
            }

            return new Tuple<float, float>(a, b);
        }

        public string FindMatch()
        {
            Reduce();
            string matchedIdTag = null;

            // ReSharper disable once ForeachCanBePartlyConvertedToQueryUsingAnotherGetEnumerator
            // ReSharper disable once ForeachCanBeConvertedToQueryUsingAnotherGetEnumerator
            foreach (var definition in UnitDefinition.Components)
            {
                if (definition.Value.Item1[0] != Numerator.Length.Exponent) continue;
                if (definition.Value.Item1[1] != Numerator.Mass.Exponent) continue;
                if (definition.Value.Item1[2] != Numerator.Time.Exponent) continue;
                if (definition.Value.Item1[3] != Numerator.ElectricalCurrent.Exponent) continue;
                if (definition.Value.Item1[4] != Numerator.LuminousIntensity.Exponent) continue;
                if (definition.Value.Item1[5] != Numerator.Temperature.Exponent) continue;
                if (definition.Value.Item1[6] != Numerator.Amount.Exponent) continue;

                if (definition.Value.Item2[0] != Denominator.Length.Exponent) continue;
                if (definition.Value.Item2[1] != Denominator.Mass.Exponent) continue;
                if (definition.Value.Item2[2] != Denominator.Time.Exponent) continue;
                if (definition.Value.Item2[3] != Denominator.ElectricalCurrent.Exponent) continue;
                if (definition.Value.Item2[4] != Denominator.LuminousIntensity.Exponent) continue;
                if (definition.Value.Item2[5] != Denominator.Temperature.Exponent) continue;
                if (definition.Value.Item2[6] != Denominator.Amount.Exponent) continue;

                matchedIdTag = definition.Key;
                break;
            }

            if (string.IsNullOrEmpty(matchedIdTag)) matchedIdTag = "UndefinedDimension";

            return matchedIdTag;
        }

        public bool IsScalar()
        {
            if (Numerator.Length.Exponent != 0) return false;
            if (Numerator.Mass.Exponent != 0) return false;
            if (Numerator.Time.Exponent != 0) return false;
            if (Numerator.ElectricalCurrent.Exponent != 0) return false;
            if (Numerator.LuminousIntensity.Exponent != 0) return false;
            if (Numerator.Temperature.Exponent != 0) return false;
            if (Numerator.Amount.Exponent != 0) return false;

            if (Denominator.Length.Exponent != 0) return false;
            if (Denominator.Mass.Exponent != 0) return false;
            if (Denominator.Time.Exponent != 0) return false;
            if (Denominator.ElectricalCurrent.Exponent != 0) return false;
            if (Denominator.LuminousIntensity.Exponent != 0) return false;
            if (Denominator.Temperature.Exponent != 0) return false;
            if (Denominator.Amount.Exponent != 0) return false;

            return true;
        }
    }
}