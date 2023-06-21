// ReSharper disable ClassNeverInstantiated.Global
using VNet.CodeGeneration.ZeroDepJson;


namespace VNet.Scientific.CodeGen
{
    public class UnitNetVNetMappingEntry
    {
        [Json("unitNetName")]
        public string UnitNetName { get; set; }

        [Json("vNetName")]
        public string VNetName { get; set; }
    }
}