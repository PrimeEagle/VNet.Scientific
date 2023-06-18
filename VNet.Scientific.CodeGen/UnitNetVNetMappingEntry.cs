// ReSharper disable ClassNeverInstantiated.Global
using VNet.CodeGeneration.Json;


namespace VNet.Scientific.CodeGen
{
    public class UnitNetVNetMappingEntry
    {
        [VNetJsonProperty("unitNetName")]
        public string UnitNetName { get; set; }

        [VNetJsonProperty("vNetName")]
        public string VNetName { get; set; }
    }
}