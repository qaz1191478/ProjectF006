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

        public IActionResult CustomPage()  // ����˹�� CustomPage
        {
            return View();  // ������§�Ѻ CustomPage.cshtml
        }

        public IActionResult Knowledge()
        {
            return View(); // ������§�Ѻ Knowledge.cshtml
        }

        // �ʴ������Һ����� 1-9
        public IActionResult ArticleDetail(int id)
        {
            if (id < 1 || id > 9)
            {
                return NotFound(); // ��ͧ�ѹ�����Ҷ֧��������������
            }

            ViewData["ArticleId"] = id;
            return View($"ArticleDetail{id}");
        }

        public IActionResult ContactPage()
        {
            return View("_ContactPage");  // ���������س���ҧ
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
