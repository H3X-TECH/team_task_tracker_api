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
        public async Task<ActionResult<AuthTokenResponse>> Login()
        {
            AuthTokenResponse response = new AuthTokenResponse();

            return response;
        }
    }
}
