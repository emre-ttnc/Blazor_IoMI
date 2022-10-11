using Inspection_of_Measuring_Instruments.Domain.Entities.UserEntities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Inspection_of_Measuring_Instruments.Persistence;

public static class ServiceRegistrations
{
    public static void AddPersistenceServices(this IServiceCollection services)
    {
        services.AddDbContext<IoMIDbContext>(options => options.UseNpgsql("User ID=postgres;Password=123456;Host=localhost;Port=5432;Database=IoMIDb;"));

        services.AddIdentity<BaseUserEntity, UserRole>().AddEntityFrameworkStores<IoMIDbContext>();
    }
}