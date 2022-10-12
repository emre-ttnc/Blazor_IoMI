using Inspection_of_Measuring_Instruments.Domain.Entities.InstrumentEntities;

namespace Inspection_of_Measuring_Instruments.Domain.Entities.InspectionEntities;

public class ScaleInspection : BaseInspectionEntity
{
    public ICollection<Scale>? Scales { get; set; }
}