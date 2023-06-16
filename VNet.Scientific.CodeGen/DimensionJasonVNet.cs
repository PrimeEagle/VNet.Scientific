using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text.Json.Serialization;
using VNet.CodeGeneration.Expressions;
using VNet.CodeGeneration.Log;

// ReSharper disable UseObjectOrCollectionInitializer

namespace VNet.Scientific.CodeGen
{
    public class DimensionJasonVNet
    {
        [JsonPropertyName("name")]
        public string Name { get; private set; }

        [JsonPropertyName("exponents")]
        public List<float> Exponents { get; private set; }

        [JsonPropertyName("default unit")]
        public string DefaultUnit { get; private set; }

        [JsonPropertyName("units")]
        public List<string> Units { get; private set; }

        [JsonPropertyName("conversion functions")]
        public Dictionary<string, string> ConversionFunctions { get; private set; }

        [JsonPropertyName("symbols")]
        public Dictionary<string, string> Symbols { get; private set; }

        [JsonPropertyName("plural symbols")]
        public Dictionary<string, string> PluralSymbols { get; private set; }


        public DimensionJasonVNet()
        {
            Exponents = new List<float>();
            Units = new List<string>();
            ConversionFunctions = new Dictionary<string, string>();
            Symbols = new Dictionary<string, string>();
            PluralSymbols = new Dictionary<string, string>();
        }

        public static DimensionJasonVNet ConvertFrom(DimensionJsonUnitNet dimUnitNet)
        {
            var dimVNet = new DimensionJasonVNet();
            dimVNet.Name = dimUnitNet.Name;
            dimVNet.DefaultUnit = dimUnitNet.BaseUnit;

            //Log.WriteLine("exponents");
            // Exponents
            dimVNet.Exponents.Add(dimUnitNet.BaseDimensions?.L ?? 0);
            dimVNet.Exponents.Add(dimUnitNet.BaseDimensions?.M ?? 0);
            dimVNet.Exponents.Add(dimUnitNet.BaseDimensions?.T ?? 0);
            dimVNet.Exponents.Add(dimUnitNet.BaseDimensions?.I ?? 0);
            dimVNet.Exponents.Add(dimUnitNet.BaseDimensions?.J ?? 0);
            dimVNet.Exponents.Add(dimUnitNet.BaseDimensions?.Θ ?? 0);
            dimVNet.Exponents.Add(dimUnitNet.BaseDimensions?.N ?? 0);

            //Log.WriteLine($"num units = {dimUnitNet.Units.Count}");
            foreach (var unit in dimUnitNet.Units)
            {
                //Log.WriteLine($"name = {unit.SingularName}");
                // Name
                if (!dimVNet.Units.Contains(unit.SingularName)) dimVNet.Units.Add(unit.SingularName);

                //Log.WriteLine($"conversion functions, {unit.FromUnitToBaseFunc}");
                // Conversion Functions
                if(!dimVNet.ConversionFunctions.ContainsKey(unit.SingularName)) dimVNet.ConversionFunctions.Add(unit.SingularName, unit.FromUnitToBaseFunc.Replace("{x}", "x"));

                //Log.WriteLine("symbols");
                // Symbols
                var abbreviation = unit.Localization.FirstOrDefault(l => l.Culture == "en-US");
                if (abbreviation?.Abbreviations != null && abbreviation.Abbreviations.Count > 0)
                {
                    if (!dimVNet.Symbols.ContainsKey(unit.SingularName)) dimVNet.Symbols.Add(unit.SingularName, abbreviation.Abbreviations[0]);
                }

                //Log.WriteLine("plural symbols");
                // Plural Symbols
                if (abbreviation?.Abbreviations != null && abbreviation.Abbreviations.Count > 1)
                {
                    if (!dimVNet.PluralSymbols.ContainsKey(unit.SingularName)) dimVNet.PluralSymbols.Add(unit.SingularName, abbreviation.Abbreviations[1]);
                }
            }

            return dimVNet;
        }
    }
}