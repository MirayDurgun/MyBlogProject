using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace MyBlogProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdminPortfolioController : Controller
    {
        PortfolioManager pm = new PortfolioManager(new EfPortfolioRepository());
        
        public IActionResult Index()
        {
            var values = pm.GetList();
            return View(values);
        }

    }
}
