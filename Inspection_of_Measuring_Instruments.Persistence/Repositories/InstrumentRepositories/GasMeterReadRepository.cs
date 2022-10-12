using Inspection_of_Measuring_Instruments.Application.Repositories.InstrumentRepositories;
using Inspection_of_Measuring_Instruments.Domain.Entities.InstrumentEntities;

namespace Inspection_of_Measuring_Instruments.Persistence.Repositories.InstrumentRepositories;

public class GasMeterReadRepository : ReadRepository<GasMeter>, IGasMeterReadRepository
{
    public GasMeterReadRepository(IoMIDbContext context) : base(context)
    {
    }
}