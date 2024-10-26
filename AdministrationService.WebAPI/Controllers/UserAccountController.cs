using Microsoft.AspNetCore.Mvc;

namespace AdministrationService.WebAPI.Controllers
{
    public class UserAccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
