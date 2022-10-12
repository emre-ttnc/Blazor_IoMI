using Inspection_of_Measuring_Instruments.Application.Services;
using Inspection_of_Measuring_Instruments.Shared.Models.ServerResponseModels;
using Inspection_of_Measuring_Instruments.Shared.Models.UserModels;
using Microsoft.AspNetCore.Mvc;

namespace Inspection_of_Measuring_Instruments.Server.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost("register")]
        public async Task<ServerResponse<bool>> CreateUserAsync([FromBody] UserOfInstrumentModel request)
        {
            if (request == null)
                return new ServerResponse<bool>() { ErrorMessage = "Something went wrong!", Success = false, Value = false };
            bool result = await _userService.CreateUserAsync(new()
            {
                Id = request.Id,
                Username = request.Username,
                Password = request.Password,
                Name = request.Name,
                Surname = request.Surname,
                Email = request.Email,
                Address = request.Address,
                CompanyName = request.CompanyName,
                IsActive = request.IsActive
            });
            return new ServerResponse<bool>() { Success = result, Value = result };
        }
    }
}
