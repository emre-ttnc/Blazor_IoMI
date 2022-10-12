using Inspection_of_Measuring_Instruments.Application.Repositories.InspectionRepositories;
using Inspection_of_Measuring_Instruments.Application.Repositories.InstrumentRepositories;
using Inspection_of_Measuring_Instruments.Application.Services;
using Inspection_of_Measuring_Instruments.Domain.Entities.UserEntities;
using Inspection_of_Measuring_Instruments.Persistence.Repositories.InspectionRespositories;
using Inspection_of_Measuring_Instruments.Persistence.Repositories.InstrumentRepositories;
using Inspection_of_Measuring_Instruments.Persistence.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Inspection_of_Measuring_Instruments.Persistence;

public static class ServiceRegistrations
{
    public static void AddPersistenceServices(this IServiceCollection services)
    {
        services.AddDbContext<IoMIDbContext>(options => options.UseNpgsql("User ID=postgres;Password=123456;Host=localhost;Port=5432;Database=IoMIDb;"));

        services.AddIdentity<BaseUserEntity, UserRole>().AddEntityFrameworkStores<IoMIDbContext>();

        services.AddScoped<IUserService, UserService>();

        services.AddScoped<IScaleReadRepository, ScaleReadRepository>();
        services.AddScoped<IScaleWriteRepository, ScaleWriteRepository>();
        services.AddScoped<IGasMeterReadRepository, GasMeterReadRepository>();
        services.AddScoped<IGasMeterWriteRepository, GasMeterWriteRepository>();

        services.AddScoped<IScaleInspectionReadRepository, ScaleInspectionReadRepository>();
        services.AddScoped<IScaleInspectionWriteRepository, ScaleInspectionWriteRepository>();
        services.AddScoped<IGasMeterInspectionReadRepository, GasMeterInspectionReadRepository>();
        services.AddScoped<IGasMeterInspectionWriteRepository, GasMeterInspectionWriteRepository>();
    }
}