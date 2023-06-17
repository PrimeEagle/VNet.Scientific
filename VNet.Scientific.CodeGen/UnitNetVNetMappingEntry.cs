using System.Text.Json.Serialization;
// ReSharper disable ClassNeverInstantiated.Global


namespace VNet.Scientific.CodeGen
{
    public class UnitNetVNetMappingEntry
    {
        [JsonPropertyName("unitNetName")]
        public string UnitNetName { get; set; }

        [JsonPropertyName("vNetName")]
        public string VNetName { get; set; }
    }
}