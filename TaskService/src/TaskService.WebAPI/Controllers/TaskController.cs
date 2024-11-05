using Microsoft.AspNetCore.Mvc;

namespace TaskService.WebAPI.Controllers
{
    public class TaskController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
