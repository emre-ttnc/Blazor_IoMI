using Inspection_of_Measuring_Instruments.Application.DTOs.UserDTOs;
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
            if (request is null)
                return new ServerResponse<bool>() { ErrorMessage = "Something went wrong!", Success = false, Value = false };
            CreateUserResponseDTO result = await _userService.CreateUserAsync(request);
            return new ServerResponse<bool> { ErrorMessage = result.ErrorMessage, Success = result.IsSuccess, Value = result.IsSuccess };
        }
    }
}
