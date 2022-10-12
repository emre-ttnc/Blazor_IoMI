using Inspection_of_Measuring_Instruments.Domain.Entities.InstrumentEntities;

namespace Inspection_of_Measuring_Instruments.Domain.Entities.InspectionEntities;

public class GasMeterInspection : BaseInspectionEntity
{
    public ICollection<GasMeter>? GasMeter { get; set; }
}