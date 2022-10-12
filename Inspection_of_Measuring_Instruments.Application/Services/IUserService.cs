using Inspection_of_Measuring_Instruments.Shared.Models.UserModels;

namespace Inspection_of_Measuring_Instruments.Application.Services;

public interface IUserService
{
    Task<bool> CreateUserAsync(UserOfInstrumentModel user);
    Task<bool> UpdateUserAsync(UserOfInstrumentModel user);
    bool DeleteUser(UserOfInstrumentModel user);
    Task<bool> DeleteUserAsync(Guid id);
    Task<bool> UpdatePasswordAsync(Guid id, string password, string resetToken);

    Task<bool> CreateInspectorAsync(InspectorModel inspector);
    Task<bool> UpdateInspectorAsync(InspectorModel inspector);
    Task<bool> DeleteInspectorAsync(InspectorModel inspector);
    bool DeleteInspector(Guid id);
}