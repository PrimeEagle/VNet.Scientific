using System.Collections.Generic;
using System.Linq;
// ReSharper disable CollectionNeverUpdated.Local
// ReSharper disable UnusedMember.Local

namespace VNet.Scientific.CodeGen.UnitNet
{
    public class UnitNetDimension : IVNetConvertible
    {
        public string Name { get; set; }
        public string BaseUnit { get; set; }
        public string XmlDocSummary { get; set; }
        public UnitNetBaseDimensions BaseDimensions { get; set; }
        public List<UnitNetUnit> Units { get; set; }




        public float BaseDimensionLength => BaseDimensions?.L ?? 0;
        public float BaseDimensionMass => BaseDimensions?.M ?? 0;
        public float BaseDimensionTime => BaseDimensions?.T ?? 0;
        public float BaseDimensionElectricalCurrent => BaseDimensions?.I ?? 0;
        public float BaseDimensionLuminousIntensity => BaseDimensions?.J ?? 0;
        public float BaseDimensionTemperature => BaseDimensions?.Θ ?? 0;
        public float BaseDimensionAmount => BaseDimensions?.N ?? 0;


        public List<string> UnitNames => Units?.Select(u => u.SingularName).ToList();

        public Dictionary<string, string> ConversionFunctions =>
                                                                Units.Select(u => new
                                                                {
                                                                    Key = u.SingularName,
                                                                    Value = u.FromUnitToBaseFunc.Replace("{x}", "x")
                                                                }).ToDictionary(u => u.Key, u => u.Value);

        public Dictionary<string, string> Symbols
        {
            get
            {
                var result = new Dictionary<string, string>();

                foreach (var unit in Units)
                {
                    foreach (var loc in unit.Localization)
                    {
                        if (loc.Culture == "en-US" && loc.Abbreviations != null && loc.Abbreviations.Count > 0)
                        {
                            var val = loc.Abbreviations[0].Replace("\\'", "").Replace("\\\"", "").Replace("'", "").Replace("\"", "").Trim();
                            if (!string.IsNullOrEmpty(val))
                            {
                                result.Add(unit.SingularName, val);
                            }
                        }
                    }
                }

                return result;
            }
        }


        public Dictionary<string, string> PluralSymbols
        {
            get
            {
                var result = new Dictionary<string, string>();

                foreach (var unit in Units)
                {
                    foreach (var loc in unit.Localization)
                    {
                        if (loc.Culture == "en-US" && loc.Abbreviations != null && loc.Abbreviations.Count > 1)
                        {
                            var val = loc.Abbreviations[1].Replace("\\'", "").Replace("\\\"", "").Replace("'", "").Replace("\"", "").Trim();
                            if (!string.IsNullOrEmpty(val))
                            {
                                result.Add(unit.SingularName, val);
                            }
                        }
                    }
                }

                return result;
            }
        }
    }
}