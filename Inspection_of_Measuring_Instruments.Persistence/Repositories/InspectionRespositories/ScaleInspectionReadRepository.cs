using Inspection_of_Measuring_Instruments.Application.Repositories.InspectionRepositories;
using Inspection_of_Measuring_Instruments.Domain.Entities.InspectionEntities;

namespace Inspection_of_Measuring_Instruments.Persistence.Repositories.InspectionRespositories;

public class ScaleInspectionReadRepository : ReadRepository<ScaleInspection>, IScaleInspectionReadRepository
{
    public ScaleInspectionReadRepository(IoMIDbContext context) : base(context)
    {
    }
}