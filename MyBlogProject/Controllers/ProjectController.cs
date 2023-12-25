using Microsoft.AspNetCore.Mvc;

namespace MyBlogProject.Controllers
{
    public class ProjectController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
