using Inspection_of_Measuring_Instruments.Shared.Models.UserModels;

namespace Inspection_of_Measuring_Instruments.Shared.Models.InspectionModels;

public class BaseInspectionModel
{
    public DateOnly? InspectionDate { get; set; }
    public BaseUserModel? Inspector { get; set; }
    public bool IsValid { get; set; }
}