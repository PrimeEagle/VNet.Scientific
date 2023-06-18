using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using VNet.CodeGeneration.Json;
//using VNet.CodeGeneration.Log;

// ReSharper disable CollectionNeverQueried.Global
// ReSharper disable UseObjectOrCollectionInitializer

namespace VNet.Scientific.CodeGen
{
    public class VNetDimension
    {
        [VNetJsonProperty("name")] 
        public string Name { get; set; }

        [VNetJsonProperty("exponents")] 
        public List<float> Exponents { get; set; }

        [VNetJsonProperty("default unit")] 
        public string DefaultUnit { get; set; }

        [VNetJsonProperty("units")] 
        public List<string> Units { get; set; }

        [VNetJsonProperty("conversion functions")]
        public Dictionary<string, string> ConversionFunctions { get; set; }

        [VNetJsonProperty("symbols")] 
        public Dictionary<string, string> Symbols { get; set; }

        [VNetJsonProperty("plural symbols")] 
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
           //var log = new Logger();
            //log.Initialize(@"D:\generator_add.log");
            //log.WriteLine($"AddOrUpdate for {dimVNet.Name}");

            var metricPrefixes = new Dictionary<string, Tuple<string, string>>
            {
                { "yotta", new Tuple<string, string>("Y", "1e24") },
                { "zetta", new Tuple<string, string>("Z", "1e21") },
                { "exa", new Tuple<string, string>("E", "1e18") },
                { "peta", new Tuple<string, string>("P", "1e15") },
                { "tera", new Tuple<string, string>("T", "1e12") },
                { "giga", new Tuple<string, string>("G", "1e9") },
                { "mega", new Tuple<string, string>("M", "1e6") },
                { "kilo", new Tuple<string, string>("k", "1e3") },
                { "hecto", new Tuple<string, string>("h", "1e2") },
                { "deka", new Tuple<string, string>("da", "1e1") },
                { "_", new Tuple<string, string>("", "1e0") },
                { "deci", new Tuple<string, string>("d", "1e-1") },
                { "centi", new Tuple<string, string>("c", "1e-2") },
                { "milli", new Tuple<string, string>("m", "1e-3") },
                { "micro", new Tuple<string, string>("µ", "1e-6") },
                { "nano", new Tuple<string, string>("n", "1e-9") },
                { "pico", new Tuple<string, string>("p", "1e-12") },
                { "femto", new Tuple<string, string>("f", "1e-15") },
                { "atto", new Tuple<string, string>("a", "1e-18") },
                { "zepto", new Tuple<string, string>("z", "1e-21") },
                { "yocto", new Tuple<string, string>("y", "1e-24") }
            };

            var ignoreList = new List<string>()
            {
                "degree",
                "inversekelvin",
                "bit",
                "internationalunit",
                "decibel",
                "decimalfraction",
                "decibelvolt",
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
            //log.WriteLine($"  default unit = {dimVNet.DefaultUnit}");

            var baseDefaultUnit = dimVNet.DefaultUnit;
            var lowerDefaultUnit = baseDefaultUnit.ToLower();

            dimVNet.Symbols?.TryGetValue(dimVNet.DefaultUnit, out defaultSymbol);
            dimVNet.PluralSymbols?.TryGetValue(dimVNet.DefaultUnit, out defaultPluralSymbol);

            if (ignoreList.Contains(lowerDefaultUnit)) return;

            // special cases
            var scalingFactor = 1.0d;
            var prePrefix = string.Empty;
            var exponentFactor = 1;
            var calcOperator = "*";
            var suffix = string.Empty;


            switch (lowerDefaultUnit)
            {
                case "kilogrampercubicmeter":
                case "kilogrampermeter":
                case "kilogram":
                case "kilogrampersecondpersquaremeter":
                case "kilogramsquaremeter":
                case "kilogrampermole":
                case "kilogrammeterpersecondsquare":
                    baseDefaultUnit = "Gram";
                    //log.WriteLine("1");
                    lowerDefaultUnit = "gram";
                    //log.WriteLine("2");
                    suffix = baseDefaultUnit.Substring(8);
                    //log.WriteLine("3");
                    defaultSymbol = "g";
                    //log.WriteLine("4");
                    scalingFactor = 1000d;
                   //log.WriteLine("5");
                    break;
                case "squaremeter":
                case "squaremeterkelvinperkilowatt":
                    prePrefix = "square";
                    exponentFactor = 2;
                    break;
                case "inversemeter":
                case "inversepascal":
                    prePrefix = "inverse";
                    calcOperator = "/";
                    break;
                case "inversesquaremeter":
                    prePrefix = "inversesquare";
                    calcOperator = "/";
                    exponentFactor = 2;
                    break;
                case "standardcubicmeterpersecond":
                    prePrefix = "standardcubic";
                    exponentFactor = 3;
                    break;
                case "cubicmeter":
                case "cubicmeterperkilogram":
                case "cubicmeterpersecond":
                case "cubicmeterpersecondpersquaremeter":
                case "cubicmeterpermeter":
                    prePrefix = "cubic";
                    exponentFactor = 3;
                    break;
                default:
                    break;
            }

            //log.WriteLine("6");
            if (prePrefix.Length > 0)
            {
                //log.WriteLine("7");
                baseDefaultUnit = baseDefaultUnit.Substring(prePrefix.Length);
                //log.WriteLine("8");
                lowerDefaultUnit = baseDefaultUnit.ToLower();
                //log.WriteLine("9");
            }

           // log.WriteLine($"   baseDefaultUnit = {baseDefaultUnit}");
           //log.WriteLine($"   lowerDefaultUnit = {lowerDefaultUnit}");

            // remove any existing metric prefixes for default unit, for unit names
            dimVNet.Units.RemoveAll(u => u.ToLower() == prePrefix + lowerDefaultUnit);
            dimVNet.Units.RemoveAll(u => metricPrefixes.Keys.Any(prefix => u.ToLower() == prePrefix + prefix.ToLower() + lowerDefaultUnit));
            foreach (var u in dimVNet.Units)
            {
                //log.WriteLine($"   remaining unit = {u}");
            }
            dimVNet.ConversionFunctions = dimVNet.ConversionFunctions.Where(kv => dimVNet.Units.Contains(kv.Key)).ToDictionary(kv => kv.Key, kv => kv.Value);
            dimVNet.Symbols = dimVNet.Symbols.Where(kv => dimVNet.Units.Contains(kv.Key)).ToDictionary(kv => kv.Key, kv => kv.Value);
            dimVNet.PluralSymbols = dimVNet.PluralSymbols.Where(kv => dimVNet.Units.Contains(kv.Key)).ToDictionary(kv => kv.Key, kv => kv.Value);

            // add all metric prefixes for unit names
            foreach (var prefix in metricPrefixes.Keys)
            {
                var unitName = Capitalize(prePrefix)  + Capitalize(prefix) + (string.IsNullOrEmpty(prefix) ? dimVNet.DefaultUnit : Capitalize(baseDefaultUnit) + Capitalize(suffix));
               // log.WriteLine($"  unitName = {unitName}");
                //log.WriteLine($"   prePrefix = {prePrefix}");
                //log.WriteLine($"   prefix = {prefix}");
                //log.WriteLine($"   Capitalize(prefix) = {Capitalize(prefix)}");
                dimVNet.Units.Add(unitName);

                //log.WriteLine($"   metricPrefix value = {metricPrefixes[prefix].Item2}");
                //log.WriteLine($"   exponentFactor = {exponentFactor}");
                //log.WriteLine($"   calc = x {calcOperator} { AdjustExponent(metricPrefixes[prefix].Item2, exponentFactor) }");
                dimVNet.ConversionFunctions.Add(unitName, $"x {calcOperator} {AdjustExponent(metricPrefixes[prefix].Item2, exponentFactor)}");

                if (!string.IsNullOrEmpty(defaultSymbol))
                {
                    dimVNet.Symbols.Add(unitName, $"{metricPrefixes[prefix].Item1}{defaultSymbol}");
                }

                if (!string.IsNullOrEmpty(defaultPluralSymbol))
                {
                    dimVNet.PluralSymbols.Add(unitName, $"{metricPrefixes[prefix].Item1}{defaultPluralSymbol}");
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
            var json = VNetJsonSerializer.Serialize(this, true);
            json = Regex.Unescape(json);

            File.WriteAllText(fileName, json);
        }

        private static string Capitalize(string value)
        {
            return string.IsNullOrEmpty(value) || value == "_" ? string.Empty : char.ToUpper(value[0]) + value.Substring(1);
        }

        private static string AdjustExponent(string value, int factor)
        {
            if (!value.StartsWith("1e") || string.IsNullOrEmpty(value)) return value;

            var exponent = int.Parse(value.Substring(2));

            return $"1e{exponent * factor}";
        }

        public static List<UnitNetVNetMappingEntry> Do(string mappingJson)
        {
            return VNetJsonSerializer.Deserialize<List<UnitNetVNetMappingEntry>>(mappingJson.Trim());
        }
    }
}