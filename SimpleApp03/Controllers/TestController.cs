using Microsoft.AspNetCore.Mvc;

namespace SimpleApp03.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Message()
        {
            return View();
        }
    }
}
