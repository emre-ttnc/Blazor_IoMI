namespace Inspection_of_Measuring_Instruments.Application.DTOs.UserDTOs;

public class BaseUserDTO
{
    public Guid? Id { get; set; }
    public string? Name { get; set; }
    public string? Surname { get; set; }
    public string? Username { get; set; }
    public string? Email { get; set; }
    public bool IsActive { get; set; }
}