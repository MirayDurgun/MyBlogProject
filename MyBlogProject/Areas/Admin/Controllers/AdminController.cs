
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

        [HttpGet]
        public IActionResult AdminUpdate(int id)
        {
            var adminnvalue = adm.GetById(id);
            return View(adminnvalue);
        }

        [HttpPost]
        public IActionResult AdminUpdate(EntityLayer.Concrete.Admin a)
        {
            if (!ModelState.IsValid)
            {
                return View(a);
            }
            var adminnvalue = adm.GetById(a.AdminID);
            adm.TUpdate(a);
            return RedirectToAction("Profile", "Admin");

        }
    }
}
