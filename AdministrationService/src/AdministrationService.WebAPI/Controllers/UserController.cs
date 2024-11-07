using AdministrationService.Application.Model.UserRegistration;
using AdministrationService.Application.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using T3.Shared;

namespace AdministrationService.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserInfoService _userInfoService;
        public UserController(IUserInfoService userInfoService)
        {
            _userInfoService = userInfoService;
        }

        [HttpPost]
        [Route("SignUp")]
        public async Task<ActionResult<ApiResponse<string>>> SignUp(UserSignUpRequest request)
        {
            var data = "";
            try
            {
                
            }
            catch
            {

            }
            return ApiResponse<string>.Created(data);
        }
    }
}
