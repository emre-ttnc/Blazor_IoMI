namespace Inspection_of_Measuring_Instruments.Shared.Models.UserModels;

public class BaseUserModel
{
    public Guid? Id { get; set; }
    public string? Name { get; set; }
    public string? Surname { get; set; }
    public int RegistryCode { get; set; }
    public bool IsActive { get; set; }
}