using Inspection_of_Measuring_Instruments.Domain.Entities.UserEntities;

namespace Inspection_of_Measuring_Instruments.Domain.Entities.InspectionEntities;

public class BaseInspectionEntity : BaseEntity
{
    public DateOnly? InspectionDate { get; set; }
    public BaseUserEntity? Inspector { get; set; }
    public bool IsValid { get; set; }
}