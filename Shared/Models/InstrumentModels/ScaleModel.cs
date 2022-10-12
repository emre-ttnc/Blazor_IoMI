using Inspection_of_Measuring_Instruments.Shared.Models.InspectionModels;

namespace Inspection_of_Measuring_Instruments.Shared.Models.InstrumentModels;

public class ScaleModel : BaseInstrumentModel
{
    public string? MaximumCapacity { get; set; }
    public string? AccuracyClass { get; set; }
    public ICollection<ScaleInspectionModel>? PastInspections { get; set; }
}