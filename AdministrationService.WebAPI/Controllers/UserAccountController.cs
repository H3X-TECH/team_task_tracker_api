using Microsoft.AspNetCore.Mvc;

namespace AdministrationService.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserAccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
