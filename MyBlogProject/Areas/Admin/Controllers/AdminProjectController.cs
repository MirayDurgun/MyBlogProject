using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace MyBlogProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdminProjectController : Controller
    {
        ProjectManager pm = new ProjectManager(new EfProjectRepository());
        public IActionResult Index()
        {
            var values = pm.GetList();
            return View(values);
        }
    }
}
