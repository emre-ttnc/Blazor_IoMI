using System.ComponentModel.DataAnnotations;

namespace Inspection_of_Measuring_Instruments.Shared.Models.UserModels;

public class InspectorModel : BaseUserModel
{
    [Required]
    [StringLength(4, ErrorMessage = "Registry code must be 4 characters.", MinimumLength = 4)]
    public string? RegistryCode { get; set; }
}