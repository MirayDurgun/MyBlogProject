using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace MyBlogProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdminPortfolioController : Controller
    {
        AdminManager pm = new AdminManager(new EfAdminRepositoy());
        
        public IActionResult Index()
        {
            var values = pm.GetList();
            return View(values);
        }

    }
}
