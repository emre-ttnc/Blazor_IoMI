using Inspection_of_Measuring_Instruments.Domain.Entities.InspectionEntities;
using Inspection_of_Measuring_Instruments.Domain.Entities.InstrumentEntities;
using Inspection_of_Measuring_Instruments.Domain.Entities.UserEntities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Inspection_of_Measuring_Instruments.Persistence;

public class IoMIDbContext : IdentityDbContext<BaseUserEntity, UserRole, string>
{
	public IoMIDbContext(DbContextOptions options):base(options){}

	public DbSet<GasMeter> GasMeters { get; set; }
	public DbSet<Scale> Scales { get; set; }
	public DbSet<GasMeterInspection> GasMeterInspections { get; set; }
	public DbSet<ScaleInspection> ScaleInspections { get; set; }

}