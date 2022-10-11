using Inspection_of_Measuring_Instruments.Shared.Models.UserModels;

namespace Inspection_of_Measuring_Instruments.Shared.Models.InspectionModels;

public class ServiceInspectionModel : BaseInspectionModel
{
    public ServicePersonModel? Service { get; set; }
}