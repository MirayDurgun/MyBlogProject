using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace MyBlogProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdminController : Controller
    {
        AdminManager adm = new AdminManager(new EfAdminRepositoy());
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Profile()
        {
            var values = adm.GetList();
            return View(values);
        }
    }
}
