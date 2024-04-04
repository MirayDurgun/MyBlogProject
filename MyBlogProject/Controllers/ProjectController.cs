using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MyBlogProject.Controllers
{
    [AllowAnonymous]
    public class ProjectController : Controller
    {
        ProjectManager pm = new ProjectManager(new EfProjectRepository());



        public IActionResult Index()
        {
            var values = pm.GetList();
            return View(values);
        }

        public IActionResult ProjectSingle(int id)
        {
            //idye göre detayları getirecek
            var values = pm.GetProjectById(id);
            return View(values);

        }

    }
}
