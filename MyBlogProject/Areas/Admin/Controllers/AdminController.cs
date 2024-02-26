
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
            var educationvalue = adm.GetById(id);
            return View(educationvalue);
        }

        [HttpPost]
        public IActionResult AdminUpdate(EntityLayer.Concrete.Admin a)
        {

            var educationvalue = adm.GetById(a.AdminID);
            adm.TUpdate(a);
            return RedirectToAction("Profile", "Admin");

        }
    }
}
