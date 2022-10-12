namespace Inspection_of_Measuring_Instruments.Domain.Entities.InstrumentEntities;

public class Scale : BaseInstrumentEntity
{
    public string? MaximumCapacity { get; set; }
    public string? AccuracyClass { get; set; }
}