﻿using System.Collections.Generic;
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
                                                                })
                                                                    .ToDictionary(u => u.Key, u => u.Value);

        public Dictionary<string, string> Symbols
        {
            get
            {
                var localizations = Units.Select(u => new
                {
                    Key = u.SingularName,
                    Value = u.Localization.FirstOrDefault(l => l.Culture == "en-US")
                }
                ).Where(u => u.Value != null);

                if (localizations != null)
                {


                    var a = localizations.Select(l => new
                    {
                        Key = l.Key,
                        Value = l.Value.Abbreviations == null ? null : l.Value.Abbreviations.FirstOrDefault()
                    }).Where(u => u.Value != null);
                    
                    if(a != null && a.First().Key != null && a.First().Value != null) return a.ToDictionary(u => u.Key, u => u.Value);

                }

                return new Dictionary<string, string>();
            }
        }


        public Dictionary<string, string> PluralSymbols
        {
            get
            {
                var localizations = Units.Select(u => new
                {
                    Key = u.SingularName,
                    Value = u.Localization.FirstOrDefault(l => l.Culture == "en-US")
                }
                ).Where(u => u.Value != null);

                if (localizations != null)
                {

                    return localizations.Select(l => new
                    {
                        Key = l.Key,
                        Value = l.Value.Abbreviations == null ? null : l.Value.Abbreviations.Skip(1).FirstOrDefault()
                    }).Where(u => u.Value != null).ToDictionary(u => u.Key, u => u.Value);

                }

                return new Dictionary<string, string>();
            }
        }
    }
}