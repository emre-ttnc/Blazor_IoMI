using Inspection_of_Measuring_Instruments.Shared.Models.InspectionModels;

namespace Inspection_of_Measuring_Instruments.Shared.Models.InstrumentModels;

public class GasMeterModel : BaseInstrumentModel
{
    public string? MaxFlowRate { get; set; }
    public ICollection<GasMeterInspectionModel>? PastInspections { get; set; }
}