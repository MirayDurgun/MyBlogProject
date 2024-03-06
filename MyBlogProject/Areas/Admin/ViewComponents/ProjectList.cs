using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace MyProjectProject.Areas.Admin.ViewComponents
{
    public class ProjectList : ViewComponent
    {
        ProjectManager pm=new ProjectManager(new EfProjectRepository());
        public IViewComponentResult Invoke(int id)
        {
           var values= pm.GetLast8Project();
            return View(values);
        }
    }
}

