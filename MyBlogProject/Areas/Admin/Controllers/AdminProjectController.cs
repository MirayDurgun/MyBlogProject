using Microsoft.AspNetCore.Mvc;

namespace MyBlogProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdminProjectController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
