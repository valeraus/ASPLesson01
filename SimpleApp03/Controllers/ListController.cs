using Microsoft.AspNetCore.Mvc;

namespace SimpleApp03.Controllers
{
    public class ListController : Controller
    {
        public IActionResult Info()
        {
            return View();
        }
    }
}
