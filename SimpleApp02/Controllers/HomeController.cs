using Microsoft.AspNetCore.Mvc;
using SimpleApp02.Models;
using System.Diagnostics;

namespace SimpleApp02.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        //public IActionResult DownloadLesson()
        //{
        //    string filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "lesson_description.txt");
        //    byte[] fileBytes = System.IO.File.ReadAllBytes(filePath);
        //    return File(fileBytes, "text/plain");
        //}
        public IActionResult DownloadLesson()
        {
            var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Lesson.pdf");
            var fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            var mimeType = "application/pdf"; // MIME тип файла PDF
            return File(fileStream, mimeType, Path.GetFileName(filePath));
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}