using Inspection_of_Measuring_Instruments.Application.Repositories.InstrumentRepositories;
using Inspection_of_Measuring_Instruments.Domain.Entities.InstrumentEntities;

namespace Inspection_of_Measuring_Instruments.Persistence.Repositories.InstrumentRepositories;

public class ScaleWriteRepository : WriteRepository<Scale>, IScaleWriteRepository
{
    public ScaleWriteRepository(IoMIDbContext context) : base(context)
    {
    }
}