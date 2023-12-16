namespace VNet.Scientific.Measurement.UnitsNet;

public class Unit
{
    public string SingularName { get; set; }
    public string PluralName { get; set; }
    public BaseUnits BaseUnits { get; set; }
    public string FromUnitToBaseFunc { get; set; }
    public string FromBaseToUnitFunc { get; set; }
    public string XmlDocSummary { get; set; }
    public string XmlDocRemarks { get; set; }
    public List<string> Prefixes { get; set; }
    public List<Localization> Localization { get; set; }
}