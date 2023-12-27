using Microsoft.AspNetCore.Mvc;

namespace MyBlogProject.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
