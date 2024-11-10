using AdministrationService.Application.Model.UserInfo;
using AdministrationService.Application.Model.UserRegistration;
using AdministrationService.Application.Services.Interfaces;
using AdministrationService.Domain.Entities;
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
                CreateUserInfo userInfo = new CreateUserInfo
                {
                    UserName = request.UserName,
                    Email = request.Email
                };
                var data2 = _userInfoService.Create(userInfo);
            }
            catch
            {

            }
            return ApiResponse<string>.Created(data);
        }
    }
}
