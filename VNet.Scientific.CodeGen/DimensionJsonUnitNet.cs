using System.Collections.Generic;

namespace VNet.Scientific.CodeGen
{
    public class DimensionJsonUnitNet
    {
        public string Name { get; set; }
        public string BaseUnit { get; set; }
        public string XmlDocSummary { get; set; }
        public DimensionJsonUnitNetBaseDimensions BaseDimensions { get; set; }
        public List<DimensionJsonUnitNetUnit> Units { get; set; }
    }
}