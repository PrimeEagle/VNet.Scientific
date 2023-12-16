namespace VNet.Scientific.Measurement.UnitsNet;

public class Root
{
    public string Name { get; set; }
    public string BaseUnit { get; set; }
    public string XmlDocSummary { get; set; }
    public BaseDimensions BaseDimensions { get; set; }
    public List<Unit> Units { get; set; }
}