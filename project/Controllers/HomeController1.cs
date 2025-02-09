using Microsoft.AspNetCore.Mvc;

namespace project.Controllers
{
    public class DepartmentController : Controller
    {
        public IActionResult TeacherInfo()
        {
            return View();
        }
    }
}
