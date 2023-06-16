using System.Collections.Generic;

namespace VNet.Scientific.CodeGen
{
    public class DimensionJsonUnitNetUnit
    {
        public string SingularName { get; set; }
        public string PluralName { get; set; }
        public DimensionJsonUnitNetBaseUnits BaseUnits { get; set; }
        public string FromUnitToBaseFunc { get; set; }
        public string FromBaseToUnitFunc { get; set; }
        public string XmlDocSummary { get; set; }
        public string XmlDocRemarks { get; set; }
        public List<string> Prefixes { get; set; }
        public List<DimensionJsonUnitNetLocalization> Localization { get; set; }
    }
}