using System.Collections.Generic;
// ReSharper disable ClassNeverInstantiated.Global

namespace VNet.Scientific.CodeGen.UnitNet
{
    public class UnitNetUnit
    {
        public string SingularName { get; set; }
        public string PluralName { get; set; }
        public UnitNetBaseUnits BaseUnits { get; set; }
        public string FromUnitToBaseFunc { get; set; }
        public string FromBaseToUnitFunc { get; set; }
        public string XmlDocSummary { get; set; }
        public string XmlDocRemarks { get; set; }
        public List<string> Prefixes { get; set; }
        public List<UnitNetLocalization> Localization { get; set; }
    }
}