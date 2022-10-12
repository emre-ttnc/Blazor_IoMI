using Inspection_of_Measuring_Instruments.Shared.Models.InstrumentModels;

namespace Inspection_of_Measuring_Instruments.Shared.Models.InspectionModels;

public class GasMeterInspectionModel : BaseInspectionModel
{
    public ICollection<GasMeterModel>? GasMeter { get; set; }
}