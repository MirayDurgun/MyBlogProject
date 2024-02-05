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

            if (projectvalue != null)
            {
                pm.TDelete(projectvalue);
                return RedirectToAction("Index", "AdminProject");
            }
            else
            {
                // Handle the case where the project is not found
                // For example, show an error message or redirect to an error page
                return NotFound("Project not found");
            }
        }

    }
}

