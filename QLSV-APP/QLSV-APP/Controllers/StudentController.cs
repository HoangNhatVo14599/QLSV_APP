using Microsoft.AspNetCore.Mvc;

namespace QLSV_APP.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }
    }
}
