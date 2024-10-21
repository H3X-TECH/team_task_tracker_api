using AdministrationService.Application.Model;
using AdministrationService.Application.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace AdministrationService.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : Controller
    {
        private readonly ITokenService _tokenService;
        public AuthController(ITokenService tokenService)
        {
            _tokenService = tokenService;
        }

        [HttpPost("login")]
        public async Task<ActionResult<AuthTokenResponse>> Login(LoginRequest loginRequest)
        {
            AuthTokenResponse response = new AuthTokenResponse();
            if (IsValidUser(loginRequest.Username, loginRequest.Password))
            {
                var token = _tokenService.GenerateToken(userId: "123", userRole: "Admin");
                response.AccessToken = token;
                return Ok(response);
            }

            return Unauthorized();
        }

        private bool IsValidUser(string username, string password)
        {
            return username == "testUser" && password == "password";
        }
    }
}
