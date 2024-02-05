using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

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

        [HttpGet]
        public IActionResult ProjectAdd()
        {
            return View();

        }

        [HttpPost]
        public IActionResult ProjectAdd(Project p)
        {


            p.ProjectStatus = true;
            pm.TAdd(p);
            return RedirectToAction("Index", "AdminProject");
        }

        public IActionResult ProjectDelete(int id)
        {
            var projectvalue = pm.GetById(id);

            pm.TDelete(projectvalue);
            return RedirectToAction("Index", "AdminProject");

        }

        [HttpGet]
        public IActionResult ProjectUpdate(int id)
        {
            var projectvalue = pm.GetById(id);
            return View(projectvalue);
        }

        [HttpPost]
        public IActionResult ProjectUpdate(Project p)
        {
            var projectvalue = pm.GetById(p.ProjectId);
            p.ProjectStatus = true;
            pm.TUpdate(p);
            return RedirectToAction("Index", "AdminProject");
        }

    }
}

