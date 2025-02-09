using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using project.Models;

namespace project.Controllers
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

        public IActionResult Map()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult CustomPage()  // เพิ่มหน้า CustomPage
        {
            return View();  // เชื่อมโยงกับ CustomPage.cshtml
        }

        public IActionResult Knowledge()
        {
            return View(); // เชื่อมโยงกับ Knowledge.cshtml
        }

        // แสดงเนื้อหาบทความ 1-9
        public IActionResult ArticleDetail(int id)
        {
            if (id < 1 || id > 9)
            {
                return NotFound(); // ป้องกันการเข้าถึงบทความที่ไม่มี
            }

            ViewData["ArticleId"] = id;
            return View($"ArticleDetail{id}");
        }

        public IActionResult ContactPage()
        {
            return View("_ContactPage");  // ชื่อไฟล์ที่คุณสร้าง
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
