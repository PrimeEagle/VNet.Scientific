namespace VNet.Scientific.Measurement;

public class FractionalDimensionComponent
{
    public SingleDimensionComponent Length { get; init; }
    public SingleDimensionComponent Mass { get; init; }
    public SingleDimensionComponent Time { get; init; }
    public SingleDimensionComponent ElectricalCurrent { get; init; }
    public SingleDimensionComponent LuminousIntensity { get; init; }
    public SingleDimensionComponent Temperature { get; init; }
    public SingleDimensionComponent Amount { get; init; }


    public FractionalDimensionComponent()
    {
        Length = new SingleDimensionComponent();
        Mass = new SingleDimensionComponent();
        Time = new SingleDimensionComponent();
        ElectricalCurrent = new SingleDimensionComponent();
        LuminousIntensity = new SingleDimensionComponent();
        Temperature = new SingleDimensionComponent();
        Amount = new SingleDimensionComponent();
    }
}