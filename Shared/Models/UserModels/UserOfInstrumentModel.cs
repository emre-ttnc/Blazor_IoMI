namespace Inspection_of_Measuring_Instruments.Shared.Models.UserModels;

public class UserOfInstrumentModel : BaseUserModel
{
    public string? CompanyName { get; set; }
    public string? Address { get; set; }
}