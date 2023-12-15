using Microsoft.AspNetCore.Mvc;

namespace MyBlogProject.Controllers
{
    public class PortfolioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
