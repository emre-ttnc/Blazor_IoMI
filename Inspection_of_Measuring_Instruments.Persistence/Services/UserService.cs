using Inspection_of_Measuring_Instruments.Application.DTOs.UserDTOs;
using Inspection_of_Measuring_Instruments.Application.Services;
using Inspection_of_Measuring_Instruments.Domain.Entities.UserEntities;
using Inspection_of_Measuring_Instruments.Shared.Models.UserModels;
using Microsoft.AspNetCore.Identity;

namespace Inspection_of_Measuring_Instruments.Persistence.Services;

public class UserService : IUserService
{
    private readonly UserManager<BaseUserEntity> _userManager;

    public UserService(UserManager<BaseUserEntity> userManager)
    {
        _userManager = userManager;
    }

    public Task<bool> CreateInspectorAsync(InspectorModel inspector)
    {
        throw new NotImplementedException();
    }

    public async Task<CreateUserResponseDTO> CreateUserAsync(UserOfInstrumentModel user)
    {
        BaseUserEntity? duplicateEmailUser = await _userManager.FindByEmailAsync(user.Email);
        if (duplicateEmailUser is not null)
            return new CreateUserResponseDTO() { ErrorMessage = "An account with this email already exists.", IsSuccess = false };

        IdentityResult result = await _userManager.CreateAsync(new BaseUserEntity()
        {
            Id = user.Id.ToString() ?? Guid.NewGuid().ToString(),
            UserName = user.Username,
            Name = user.Name,
            Surname = user.Surname,
            Email = user.Email,
            IsActive = user.IsActive,
            Address = user.Address,
            CompanyName = user.CompanyName

        }, user.Password);
        if (!result.Succeeded && result.Errors.Any())
            return new CreateUserResponseDTO() { ErrorMessage = result.Errors?.FirstOrDefault()?.Code, IsSuccess = false };
        return new CreateUserResponseDTO() { IsSuccess = true };
    }

    public bool DeleteInspector(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<bool> DeleteInspectorAsync(InspectorModel inspector)
    {
        throw new NotImplementedException();
    }

    public bool DeleteUser(UserOfInstrumentModel user)
    {
        throw new NotImplementedException();
    }

    public Task<bool> DeleteUserAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<bool> UpdateInspectorAsync(InspectorModel inspector)
    {
        throw new NotImplementedException();
    }

    public Task<bool> UpdatePasswordAsync(Guid id, string password, string resetToken)
    {
        throw new NotImplementedException();
    }

    public Task<bool> UpdateUserAsync(UserOfInstrumentModel user)
    {
        throw new NotImplementedException();
    }
}