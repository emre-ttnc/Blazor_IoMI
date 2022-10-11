using Inspection_of_Measuring_Instruments.Domain.Entities.UserEntities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Inspection_of_Measuring_Instruments.Persistence;

public class IoMIDbContext : IdentityDbContext<BaseUserEntity, UserRole, string>
{
	public IoMIDbContext(DbContextOptions options):base(options){}


}