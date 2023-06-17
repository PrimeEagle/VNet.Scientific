using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;
using VNet.CodeGeneration.Log;

// ReSharper disable CollectionNeverQueried.Global
// ReSharper disable UseObjectOrCollectionInitializer

namespace VNet.Scientific.CodeGen
{
    public class VNetDimension
    {
        [JsonPropertyName("name")] 
        public string Name { get; set; }

        [JsonPropertyName("exponents")] 
        public List<float> Exponents { get; set; }

        [JsonPropertyName("default unit")] 
        public string DefaultUnit { get; set; }

        [JsonPropertyName("units")] 
        public List<string> Units { get; set; }

        [JsonPropertyName("conversion functions")]
        public Dictionary<string, string> ConversionFunctions { get; set; }

        [JsonPropertyName("symbols")] 
        public Dictionary<string, string> Symbols { get; set; }

        [JsonPropertyName("plural symbols")] 
        public Dictionary<string, string> PluralSymbols { get; set; }


        public VNetDimension()
        {
            Exponents = new List<float>();
            Units = new List<string>();
            ConversionFunctions = new Dictionary<string, string>();
            Symbols = new Dictionary<string, string>();
            PluralSymbols = new Dictionary<string, string>();
        }

        public static VNetDimension ConvertFrom(IVNetConvertible source, IEnumerable<UnitNetVNetMappingEntry> mapping = null)
        {
            var dimVNet = new VNetDimension();

            UnitNetVNetMappingEntry mappingEntry = null;
            if (mapping != null)
            {
                mappingEntry = mapping.FirstOrDefault(m => m.UnitNetName == source.Name);
            }

            dimVNet.Name = mappingEntry == null ? source.Name : mappingEntry.VNetName;
            dimVNet.DefaultUnit = source.BaseUnit;

            dimVNet.Exponents.Add(source.BaseDimensionLength);
            dimVNet.Exponents.Add(source.BaseDimensionMass);
            dimVNet.Exponents.Add(source.BaseDimensionTime);
            dimVNet.Exponents.Add(source.BaseDimensionElectricalCurrent);
            dimVNet.Exponents.Add(source.BaseDimensionLuminousIntensity);
            dimVNet.Exponents.Add(source.BaseDimensionTemperature);
            dimVNet.Exponents.Add(source.BaseDimensionAmount);

            foreach (var unitName in source.UnitNames)
            {
                if (!dimVNet.Units.Contains(unitName)) dimVNet.Units.Add(unitName);
                dimVNet.ConversionFunctions = new Dictionary<string, string>(source.ConversionFunctions);
                dimVNet.Symbols = new Dictionary<string, string>(source.Symbols);
                dimVNet.PluralSymbols = new Dictionary<string, string>(source.PluralSymbols);
            }

            return dimVNet;
        }

        public static void ConversionPostProcess(VNetDimension dimVNet)
        {
            AddOrUpdateMetricPrefixes(dimVNet);
        }

        private static void AddOrUpdateMetricPrefixes(VNetDimension dimVNet)
        {
            var log = new Logger();
            log.Initialize(@"D:\generator_add.log");
            log.Clear();
            log.WriteLine($"  AddOrUpdate for {dimVNet.Name}");

            var metricPrefixes = new Dictionary<string, Tuple<string, string>>
            {
                { "yotta", new Tuple<string, string>("Y", "10e24") },
                { "zetta", new Tuple<string, string>("Z", "10e21") },
                { "exa", new Tuple<string, string>("E", "10e18") },
                { "peta", new Tuple<string, string>("P", "10e15") },
                { "tera", new Tuple<string, string>("T", "10e12") },
                { "giga", new Tuple<string, string>("G", "10e9") },
                { "mega", new Tuple<string, string>("M", "10e6") },
                { "kilo", new Tuple<string, string>("k", "10e3") },
                { "hecto", new Tuple<string, string>("h", "10e2") },
                { "deka", new Tuple<string, string>("da", "10e1") },
                { "_", new Tuple<string, string>("", "10e0") },
                { "deci", new Tuple<string, string>("d", "10e-1") },
                { "centi", new Tuple<string, string>("c", "10e-2") },
                { "milli", new Tuple<string, string>("m", "10e-3") },
                { "micro", new Tuple<string, string>("µ", "10e-6") },
                { "nano", new Tuple<string, string>("n", "10e-9") },
                { "pico", new Tuple<string, string>("p", "10e-12") },
                { "femto", new Tuple<string, string>("f", "10e-15") },
                { "atto", new Tuple<string, string>("a", "10e-18") },
                { "zepto", new Tuple<string, string>("z", "10e-21") },
                { "yocto", new Tuple<string, string>("y", "10e-24") }
            };

            var ignoreList = new List<string>()
            {
                "degree",
                "inversekelvin",
                "bit",
                "internationalunit",
                "decibel",
                "decimalfraction",
                "decibelwatt",
                "decimalfractionpersecond",
                "percent",
                "amount",
                "kelvin",
                "kelvinpermeter",
                "ntu"
            };

            string defaultSymbol = null;
            string defaultPluralSymbol = null;
            log.WriteLine($"  default unit = {dimVNet.DefaultUnit}");

            var lowerDefaultUnit = dimVNet.DefaultUnit.ToLower();
            dimVNet.Symbols?.TryGetValue(dimVNet.DefaultUnit, out defaultSymbol);
            dimVNet.PluralSymbols?.TryGetValue(dimVNet.DefaultUnit, out defaultPluralSymbol);

            if (ignoreList.Contains(lowerDefaultUnit)) return;

            // special cases
            var isSpecialCase = true;
            var scalingFactor = 1.0d;
            var isSquare = false;
            var isCubic = false;
            var isInverse = false;
            var isInverseSquare = false;
            var isStandardCubic = false;
            var prePrefix = string.Empty;

            switch (lowerDefaultUnit)
            {
                case "kilogrampercubicmeter":
                case "kilogrampermeter":
                case "kilogram":
                case "kilogrampersecondpersquaremeter":
                case "kilogramsquaremeter":
                case "kilogrampermole":
                case "kilogrammeterpersecondsquare":
                    lowerDefaultUnit = lowerDefaultUnit.Replace("kilogram", "gram");
                    if(defaultSymbol !=null)
                        defaultSymbol = defaultSymbol.Replace("kg", "g");
                    scalingFactor = 1000d;
                    break;
                case "squaremeter":
                case "squaremeterkelvinperkilowatt":
                    prePrefix = "square";
                    lowerDefaultUnit = lowerDefaultUnit.Replace(prePrefix, "");
                    isSquare = true;
                    break;
                case "inversemeter":
                case "inversepascal":
                    prePrefix = "inverse";
                    lowerDefaultUnit = lowerDefaultUnit.Replace(prePrefix, "");
                    isInverse = true;
                    break;
                case "inversesquaremeter":
                    prePrefix = "inversesquare";
                    lowerDefaultUnit = lowerDefaultUnit.Replace(prePrefix, "");
                    isInverseSquare = true;
                    break;
                case "standardcubicmeterpersecond":
                    prePrefix = "standardcubic";
                    lowerDefaultUnit = lowerDefaultUnit.Replace(prePrefix, "");
                    isStandardCubic = true;
                    break;
                case "cubicmeter":
                case "cubicmeterperkilogram":
                case "cubicmeterpersecond":
                case "cubicmeterpersecondpersquaremeter":
                case "cubicmeterpermeter":
                    prePrefix = "cubic";
                    lowerDefaultUnit = lowerDefaultUnit.Replace(prePrefix, "");
                    isCubic = true;
                    break;
                default:
                    isSpecialCase = false;
                    break;
            }

            if (isSpecialCase) return;


            // remove any existing metric prefixes for default unit, for unit names
            dimVNet.Units.RemoveAll(u => u.ToLower() == lowerDefaultUnit);
            dimVNet.Units.RemoveAll(u => metricPrefixes.Keys.Any(prefix => u.ToLower() == prePrefix.ToLower() + prefix.ToLower() + lowerDefaultUnit));
            foreach (var u in dimVNet.Units)
            {
                log.WriteLine($"   remaining unit = {u}");
            }
            // remove any existing metric prefixes for default unit, for conversion functions
            dimVNet.ConversionFunctions = dimVNet.ConversionFunctions.Where(kv => dimVNet.Units.Contains(kv.Key)).ToDictionary(kv => kv.Key, kv => kv.Value);
            //dimVNet.ConversionFunctions = dimVNet.ConversionFunctions
            //    .Where(kv => !kv.Key.ToLower().EndsWith(lowerDefaultUnit) &&
            //                 !metricPrefixes.Keys.Any(prefix => kv.Key.ToLower().StartsWith(prePrefix.ToLower() + prefix)))
            //    .ToDictionary(kv => kv.Key, kv => kv.Value);
            //dimVNet.ConversionFunctions.Remove(dimVNet.DefaultUnit);

            // remove any existing metric prefixes for default unit, for symbols
            dimVNet.Symbols = dimVNet.Symbols.Where(kv => dimVNet.Units.Contains(kv.Key)).ToDictionary(kv => kv.Key, kv => kv.Value);
            //dimVNet.Symbols = dimVNet.Symbols
            //    .Where(kv => !kv.Key.ToLower().EndsWith(lowerDefaultUnit) &&
            //                 !metricPrefixes.Keys.Any(prefix => kv.Key.ToLower().StartsWith(prePrefix.ToLower() + prefix)))
            //    .ToDictionary(kv => kv.Key, kv => kv.Value);
            //dimVNet.Symbols.Remove(dimVNet.DefaultUnit);

            // remove any existing metric prefixes for default unit, for plural symbols
            dimVNet.PluralSymbols = dimVNet.PluralSymbols.Where(kv => dimVNet.Units.Contains(kv.Key)).ToDictionary(kv => kv.Key, kv => kv.Value);
            //dimVNet.PluralSymbols = dimVNet.PluralSymbols
            //    .Where(kv => !kv.Key.ToLower().EndsWith(lowerDefaultUnit) &&
            //                 !metricPrefixes.Keys.Any(prefix =>  kv.Key.ToLower().StartsWith(prePrefix.ToLower() + prefix)))
            //    .ToDictionary(kv => kv.Key, kv => kv.Value);
            //dimVNet.PluralSymbols.Remove(dimVNet.DefaultUnit);


            // add all metric prefixes for unit names
            foreach (var prefix in metricPrefixes.Keys)
            {
                log.WriteLine($"  prefix before = {prefix}");
                var pre = char.ToUpper(prefix[0]) + prefix.Substring(1);
                if(prefix == "_") pre = string.Empty;
                log.WriteLine($"  prefix after = {pre}");

                var unitName = prePrefix  + pre + (string.IsNullOrEmpty(pre) ? dimVNet.DefaultUnit : char.ToLower(dimVNet.DefaultUnit[0]) + dimVNet.DefaultUnit.Substring(1));
                log.WriteLine($"  unitName = {unitName}");
                dimVNet.Units.Add(unitName);

                dimVNet.ConversionFunctions.Add(unitName, $"x * {metricPrefixes[prefix].Item2}");
                log.WriteLine($"  added conversion function");

                if (!string.IsNullOrEmpty(defaultSymbol))
                {
                    dimVNet.Symbols.Add(unitName, $"{metricPrefixes[prefix].Item1}{defaultSymbol}");
                    log.WriteLine($"  added symbol");
                }

                if (!string.IsNullOrEmpty(defaultPluralSymbol))
                {
                    dimVNet.PluralSymbols.Add(unitName, $"{metricPrefixes[prefix].Item1}{defaultPluralSymbol}");
                    log.WriteLine($"  added plural symbol");
                }
            }

            if (scalingFactor != 1.0d)
            {
                foreach (var cfk in dimVNet.ConversionFunctions.Keys)
                {
                    dimVNet.ConversionFunctions[cfk] =  $"{scalingFactor} * ({dimVNet.ConversionFunctions[cfk]})";
                }
            }
        }

        public void Save(string fileName)
        {
            var jsonOptions = new JsonSerializerOptions
            {
                WriteIndented = true
            };

            var json = JsonSerializer.Serialize(this, jsonOptions);
            json = Regex.Unescape(json);

            File.WriteAllText(fileName, json);
        }
    }
}