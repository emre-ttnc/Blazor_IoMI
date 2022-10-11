using Microsoft.AspNetCore.Identity;

namespace Inspection_of_Measuring_Instruments.Domain.Entities.UserEntities;

public class BaseUserEntity : IdentityUser<string>
{
    public string? Name { get; set; }
    public string? Surname { get; set; }
    public string? RegistryCode { get; set; }
    public bool IsActive { get; set; }
}