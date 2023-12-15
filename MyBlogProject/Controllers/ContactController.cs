using Microsoft.AspNetCore.Mvc;

namespace MyBlogProject.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
