﻿using System.ComponentModel.DataAnnotations;

namespace Inspection_of_Measuring_Instruments.Shared.Models.UserModels;

public class LoginUserModel
{
    [Required]
    [StringLength(16, ErrorMessage = "Username can be up to 16 and at least 6 characters.", MinimumLength = 6)]
    [RegularExpression(@"^[a-z]+$", ErrorMessage = "Username must be in English lowercase letters only.")]
    public string? Username { get; set; }
    [Required]
    [StringLength(16, ErrorMessage = "Password can be up to 16 and at least 6 characters.", MinimumLength = 6)]
    public string? Password { get; set; }
}