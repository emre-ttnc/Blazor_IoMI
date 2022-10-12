using Inspection_of_Measuring_Instruments.Application.Repositories.InspectionRepositories;
using Inspection_of_Measuring_Instruments.Domain.Entities.InspectionEntities;

namespace Inspection_of_Measuring_Instruments.Persistence.Repositories.InspectionRespositories;

public class ScaleInspectionWriteRepository : WriteRepository<ScaleInspection>, IScaleInspectionWriteRepository
{
    public ScaleInspectionWriteRepository(IoMIDbContext context) : base(context)
    {
    }
}