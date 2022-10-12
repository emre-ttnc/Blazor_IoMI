using Inspection_of_Measuring_Instruments.Application.Repositories.InstrumentRepositories;
using Inspection_of_Measuring_Instruments.Domain.Entities.InstrumentEntities;

namespace Inspection_of_Measuring_Instruments.Persistence.Repositories.InstrumentRepositories;

public class ScaleReadRepository : ReadRepository<Scale>, IScaleReadRepository
{
    public ScaleReadRepository(IoMIDbContext context) : base(context)
    {
    }
}