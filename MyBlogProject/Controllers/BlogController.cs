using Microsoft.AspNetCore.Mvc;

namespace MyBlogProject.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
