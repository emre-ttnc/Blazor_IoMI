using Inspection_of_Measuring_Instruments.Application.Repositories.InstrumentRepositories;
using Inspection_of_Measuring_Instruments.Domain.Entities.InstrumentEntities;

namespace Inspection_of_Measuring_Instruments.Persistence.Repositories.InstrumentRepositories;

public class GasMeterWriteRepository : WriteRepository<GasMeter>, IGasMeterWriteRepository
{
    public GasMeterWriteRepository(IoMIDbContext context) : base(context)
    {
    }
}