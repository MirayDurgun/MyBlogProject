using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MyBlogProject.Controllers
{
    public class AdminController : Controller
    {
        AdminManager adm=new AdminManager(new EfAdminRepositoy());
        public IActionResult Index()
        {
            return View();
        }

        [AllowAnonymous]
        public IActionResult About()
        {
            var values = adm.GetList();
            return View(values);
        }
    }
}
