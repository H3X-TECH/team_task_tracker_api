using AdministrationService.Application.Model.UserCredential;
using AdministrationService.Application.Model.UserInfo;
using AdministrationService.Application.Model.UserRegistration;
using AdministrationService.Application.Services.Interfaces;
using AdministrationService.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using T3.Shared;
using T3.Shared.Helper;

namespace AdministrationService.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserInfoService _userInfoService;
        private readonly IUserCredentialService _userCredentialService;
        public UserController(IUserInfoService userInfoService,
                              IUserCredentialService userCredentialService)
        {
            _userInfoService = userInfoService;
            _userCredentialService = userCredentialService;
        }

        [HttpPost]
        [Route("SignUp")]
        public async Task<ActionResult<ApiResponse<UserInfo>>> SignUp(UserSignUpRequest request)
        {

            CreateUserInfo userInfo = new CreateUserInfo
            {
                UserName = request.UserName,
                Email = request.Email
            };
            var data2 = await _userInfoService.Create(userInfo);

            CreateUserCredential userCredential = new CreateUserCredential
            {
                UserId = data2.UserId,
                Password = request.Password,
            };
            var result = await _userCredentialService.Create(userCredential);

           

            var createdResponse = ApiResponse<UserInfo>.Created(data2);
            return ApiResponseHelper<UserInfo>.GenerateResponse(createdResponse);

            //return ApiResponse<string>.Created(data);
        }
    }
}
